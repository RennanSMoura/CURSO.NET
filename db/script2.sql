desc produtos;
+---------+---------------+------+-----+---------+----------------+
| Field   | Type          | Null | Key | Default | Extra          |
+---------+---------------+------+-----+---------+----------------+
| id      | int           | NO   | PRI | NULL    | auto_increment |
| Nome    | varchar(255)  | YES  |     | NULL    |                |
| Cor     | varchar(50)   | YES  |     | NULL    |                |
| Preco   | decimal(13,2) | YES  |     | NULL    |                |
| Tamanho | varchar(5)    | YES  |     | NULL    |                |
| Genero  | char(1)       | YES  |     | NULL    |                |
+---------+---------------+------+-----+---------+----------------+
-- 6 rows in set (0.00 sec)

INSERT INTO Produtos VALUES ('Mountain Bike Socks, M','Branco','9.50','M','U')
    -> INSERT INTO Produtos VALUES ('Mountain Bike Socks, L','Branco','9.50','G','U')
    -> INSERT INTO Produtos VALUES ('AWC Logo Cap','Colorido','8.99','','U')
    -> INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, S','Colorido','49.99','P','U')
    -> INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, M','Colorido','49.99','M','U')
    -> INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, L','Colorido','49.99','G','U')
    -> INSERT INTO Produtos VALUES ('Mountain Bike Socks, M','Branco','9.50','M','U');

INSERT INTO Produtos (Nome,Cor,Preco,Tamanho,Genero) VALUES ('Mountain Bike Socks, M','Branco','9.50','M','U');
-- Query OK, 1 row affected (0.01 sec)

INSERT INTO Produtos  (Nome,Cor,Preco,Tamanho,Genero) VALUES ('AWC Logo Cap','Colorido','8.99','','U');
-- Query OK, 1 row affected (0.01 sec)

INSERT INTO Produtos (Nome,Cor,Preco,Tamanho,Genero) VALUES ('Long-Sleeve Logo Jersey, M','Colorido','49.99','M','U');
-- Query OK, 1 row affected (0.01 sec)

select count(*) from produtos;
+----------+
| count(*) |
+----------+
|        3 |
+----------+
1 row in set (0.01 sec)

select count(*) from produtos where tamanho = 'm';
+----------+
| count(*) |
+----------+
|        2 |
+----------+
1 row in set (0.00 sec)

select sum(preco) from produtos;
+------------+
| sum(preco) |
+------------+
|      68.48 |
+------------+
1 row in set (0.00 sec)

select min(preco) from produtos;
+------------+
| min(preco) |
+------------+
|       8.99 |
+------------+
1 row in set (0.00 sec)

select max(preco) from produtos;
+------------+
| max(preco) |
+------------+
|      49.99 |
+------------+
1 row in set (0.00 sec)

select avg(preco) from produtos;
+------------+
| avg(preco) |
+------------+
|  22.826667 |
+------------+
1 row in set (0.00 sec)

select nome + ' - ' + cor from produtos;
+--------------------+
| nome + ' - ' + cor |
+--------------------+
|                  0 |
|                  0 |
|                  0 |
+--------------------+
-- 3 rows in set, 9 warnings (0.00 sec)

select Upper(nome) Nome,Lower(cor) Cor from produtos;
+----------------------------+----------+
| Nome                       | Cor      |
+----------------------------+----------+
| MOUNTAIN BIKE SOCKS, M     | branco   |
| AWC LOGO CAP               | colorido |
| LONG-SLEEVE LOGO JERSEY, M | colorido |
+----------------------------+----------+
-- 3 rows in set (0.00 sec)

alter table produtos add ColunaTeste varchar(255);
-- -- Query OK, 0 rows affected (0.01 sec)


select Tamanho,count(*) Quantidade from produtos group by tamanho;
+---------+------------+
| Tamanho | Quantidade |
+---------+------------+
| M       |          2 |
|         |          1 |
+---------+------------+

CREATE TABLE enderecos (
    idEndereco INT PRIMARY KEY AUTO_INCREMENT,
    IdCliente INT,
    Rua VARCHAR(255),
    Bairro VARCHAR(255),
    Cidade VARCHAR(255),
    Estado CHAR(2),
    CONSTRAINT fkEnderecoCliente FOREIGN KEY (IdCliente) REFERENCES Clientes(id)
                        );
-- Query OK, 0 rows affected (0.08 sec)

insert into enderecos (idCliente,rua,bairro,cidade,estado) values (4, 'rua teste', 'bairro teste', 'cidade teste', 'SP');

-- Query OK, 1 row affected (0.04 sec)

select * from clientes where id = 4;
+----+--------+-----------+---------------------------+--------------------------------------+---------------------+
| Id | Nome   | Sobrenome | Email                     | AceitaComunicados                    | DataCadastro        |
+----+--------+-----------+---------------------------+--------------------------------------+---------------------+
|  4 | Jossef | Goldberg  | jossef.goldberg@email.com | 0x00                                 | 2013-12-16 00:00:00 |
+----+--------+-----------+---------------------------+--------------------------------------+---------------------+

select clientes.nome, enderecos.rua
         from clientes as clientes
            join enderecos as enderecos
                on enderecos.idCliente = Clientes.id;

+--------+-----------+
| nome   | rua       |
+--------+-----------+
| Jossef | rua teste |
+--------+-----------+

 alter table produtos add constraint chkGenero check (Genero = 'U' or Genero = 'M' or Genero = 'F');

insert into produtos (genero) values ('a');
-- ERROR 3819 (HY000): Check constraint 'chkGenero' is violated.

alter table produtos drop constraint chkGenero;
-- Query OK, 0 rows affected (0.04 sec)

CREATE PROCEDURE InserirNovoProduto
    @Nome VARCHAR(255),
    @Cor VARCHAR(50),
    @Preco DECIMAL,
    @Tamanho VARCHAR(5),
    @Genero CHAR(1)
AS
BEGIN
    INSERT INTO produtos (nome, cor, preco, tamanho, genero)
    VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero);
END;

EXEC InserirNovoProduto
  'NOVO PRODUTO PROCEDURE', 
  'COLORIDO',
  50,
  'G',
  'M';

-- EXEC InserirNovoProduto
--     @Nome = 'NOVO PRODUTO PROCEDURE', 
--     @Cor =  'COLORIDO',
--     @Preco =  50,
--     @Tamanho =  'G',
--     @Genero =  'M';


Create Procedure ObterProdutoTamaho
    @TamanhoProduto varchar(5)
        as
            Select * from produto
                where Tamanho = @TamanhoProduto;
                    Exec ObterProdutoTamaho 'G';

SELECT
    Nome,
    Preco,
    FORMAT(Preco - (Preco / 100 * 10), 'C', 'pt-BR') AS PrecoDesconto
        FROM produtos where tamanho = 'm';

+----------------------------+-------+---------------+
| Nome                       | Preco | PrecoDesconto |
+----------------------------+-------+---------------+
| Mountain Bike Socks, M     |  9.50 | 9             |
| AWC Logo Cap               |  8.99 | 8             |
| Long-Sleeve Logo Jersey, M | 49.99 | 45            |
+----------------------------+-------+---------------+

DELIMITER //

CREATE FUNCTION calcularDesconto(Preco DECIMAL(13,2), Porcentagem INT)
RETURNS DECIMAL(13,2)
DETERMINISTIC
BEGIN
    RETURN Preco - (Preco / 100 * Porcentagem);
END //

DELIMITER ;
-- Query OK, 0 rows affected (0.04 sec)

SELECT
    Nome,
    Preco,
    calcularDesconto(Preco,10) AS PrecoDesconto
        FROM produtos where tamanho = 'm';

+----------------------------+-------+---------------+
| Nome                       | Preco | PrecoDesconto |
+----------------------------+-------+---------------+
| Mountain Bike Socks, M     |  9.50 |          8.55 |
| Long-Sleeve Logo Jersey, M | 49.99 |         44.99 |
+----------------------------+-------+---------------+
-- 2 rows in set, 1 warning (0.00 sec)