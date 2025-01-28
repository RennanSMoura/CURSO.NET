 select * from clientes;
+----+---------+------------+------------------------------+--------------------------------------+---------------------+
| Id | Nome    | Sobrenome  | Email                        | AceitaComunicados                    | DataCadastro        |
+----+---------+------------+------------------------------+--------------------------------------+---------------------+
|  1 | Ken     | Sánchez    | ken.sanchez@email.com        | 0x00                                 | 2009-01-07 00:00:00 |
|  2 | Rob     | Walters    | rob.walters@email.com        | 0x00                                 | 2007-11-28 00:00:00 |
|  3 | Gail    | Erickson   | gail.erickson@email.com      | 0x00                                 | 2007-12-30 00:00:00 |
|  4 | Jossef  | Goldberg   | jossef.goldberg@email.com    | 0x00                                 | 2013-12-16 00:00:00 |
|  5 | Diane   | Margheim   | diane.margheim@email.com     | 0x00                                 | 2008-12-22 00:00:00 |
|  6 | Gigi    | Matthew    | gigi.matthew@email.com       | 0x00                                 | 2009-01-09 00:00:00 |
|  7 | Ken     | Sánchez    | ken.sanchez@email.com        | 0x00                                 | 2009-01-07 00:00:00 |
|  8 | Terri   | Duffy      | terri.duffy@email.com        | 0x01                                 | 2008-01-24 00:00:00 |
|  9 | Roberto | Tamburello | roberto.tamburello@email.com | 0x00                                 | 2007-11-04 00:00:00 |
| 10 | Rob     | Walters    | rob.walters@email.com        | 0x00                                 | 2007-11-28 00:00:00 |
| 11 | Gail    | Erickson   | gail.erickson@email.com      | 0x00                                 | 2007-12-30 00:00:00 |
| 12 | Jossef  | Goldberg   | jossef.goldberg@email.com    | 0x00                                 | 2013-12-16 00:00:00 |
| 13 | Dylan   | Miller     | dylan.miller@email.com       | 0x01                                 | 2009-02-01 00:00:00 |
| 14 | Diane   | Margheim   | diane.margheim@email.com     | 0x00                                 | 2008-12-22 00:00:00 |
| 15 | Gigi    | Matthew    | gigi.matthew@email.com       | 0x00                                 | 2009-01-09 00:00:00 |
| 16 | Michael | Raheem     | michael.raheem@email.com     | 0x00                                 | 2009-04-26 00:00:00 |
+----+---------+------------+------------------------------+--------------------------------------+---------------------+
-- 16 rows in set (0.00 sec)

 select * from cliente order by nome;
-- ERROR 1146 (42S02): Table 'teste.cliente' doesn't exist
 select * from clientes order by nome;
+----+---------+------------+------------------------------+--------------------------------------+---------------------+
| Id | Nome    | Sobrenome  | Email                        | AceitaComunicados                    | DataCadastro        |
+----+---------+------------+------------------------------+--------------------------------------+---------------------+
|  5 | Diane   | Margheim   | diane.margheim@email.com     | 0x00                                 | 2008-12-22 00:00:00 |
| 14 | Diane   | Margheim   | diane.margheim@email.com     | 0x00                                 | 2008-12-22 00:00:00 |
| 13 | Dylan   | Miller     | dylan.miller@email.com       | 0x01                                 | 2009-02-01 00:00:00 |
|  3 | Gail    | Erickson   | gail.erickson@email.com      | 0x00                                 | 2007-12-30 00:00:00 |
| 11 | Gail    | Erickson   | gail.erickson@email.com      | 0x00                                 | 2007-12-30 00:00:00 |
|  6 | Gigi    | Matthew    | gigi.matthew@email.com       | 0x00                                 | 2009-01-09 00:00:00 |
| 15 | Gigi    | Matthew    | gigi.matthew@email.com       | 0x00                                 | 2009-01-09 00:00:00 |
|  4 | Jossef  | Goldberg   | jossef.goldberg@email.com    | 0x00                                 | 2013-12-16 00:00:00 |
| 12 | Jossef  | Goldberg   | jossef.goldberg@email.com    | 0x00                                 | 2013-12-16 00:00:00 |
|  1 | Ken     | Sánchez    | ken.sanchez@email.com        | 0x00                                 | 2009-01-07 00:00:00 |
|  7 | Ken     | Sánchez    | ken.sanchez@email.com        | 0x00                                 | 2009-01-07 00:00:00 |
| 16 | Michael | Raheem     | michael.raheem@email.com     | 0x00                                 | 2009-04-26 00:00:00 |
|  2 | Rob     | Walters    | rob.walters@email.com        | 0x00                                 | 2007-11-28 00:00:00 |
| 10 | Rob     | Walters    | rob.walters@email.com        | 0x00                                 | 2007-11-28 00:00:00 |
|  9 | Roberto | Tamburello | roberto.tamburello@email.com | 0x00                                 | 2007-11-04 00:00:00 |
|  8 | Terri   | Duffy      | terri.duffy@email.com        | 0x01                                 | 2008-01-24 00:00:00 |
+----+---------+------------+------------------------------+--------------------------------------+---------------------+
-- 16 rows in set (0.00 sec)

 select nome from clientes;
+---------+
| nome    |
+---------+
| Ken     |
| Rob     |
| Gail    |
| Jossef  |
| Diane   |
| Gigi    |
| Ken     |
| Terri   |
| Roberto |
| Rob     |
| Gail    |
| Jossef  |
| Dylan   |
| Diane   |
| Gigi    |
| Michael |
+---------+
-- 16 rows in set (0.00 sec)

 select nome from clientes where nome = 'ken';
+------+
| nome |
+------+
| Ken  |
| Ken  |
+------+
-- 2 rows in set (0.00 sec)

 select * from clientes where nome = 'ken';
+----+------+-----------+-----------------------+--------------------------------------+---------------------+
| Id | Nome | Sobrenome | Email                 | AceitaComunicados                    | DataCadastro        |
+----+------+-----------+-----------------------+--------------------------------------+---------------------+
|  1 | Ken  | Sánchez   | ken.sanchez@email.com | 0x00                                 | 2009-01-07 00:00:00 |
|  7 | Ken  | Sánchez   | ken.sanchez@email.com | 0x00                                 | 2009-01-07 00:00:00 |
+----+------+-----------+-----------------------+--------------------------------------+---------------------+
-- 2 rows in set (0.00 sec)

 select * from clientes where nome like 'A%';
Empty set (0.00 sec)

 select * from clientes where nome like 'B%';
Empty set (0.00 sec)

 select * from clientes where nome like 'K%';
+----+------+-----------+-----------------------+--------------------------------------+---------------------+
| Id | Nome | Sobrenome | Email                 | AceitaComunicados                    | DataCadastro        |
+----+------+-----------+-----------------------+--------------------------------------+---------------------+
|  1 | Ken  | Sánchez   | ken.sanchez@email.com | 0x00                                 | 2009-01-07 00:00:00 |
|  7 | Ken  | Sánchez   | ken.sanchez@email.com | 0x00                                 | 2009-01-07 00:00:00 |
+----+------+-----------+-----------------------+--------------------------------------+---------------------+
-- 2 rows in set (0.00 sec)

 update clientes set email = novo@novo.com where id = 1;
-- ERROR 1064 (42000): You have an -- error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near '@novo.com where id = 1' at line 1
 update clientes set email = 'novo@novo.com' where id = 1;
-- Query OK, 1 row affected (0.01 sec)
-- Rows matched: 1  Changed: 1  Warnings: 0

delete clientes qhere id = 2;
-- ERROR 1064 (42000): You have an -- error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near 'qhere id = 2' at line 1
 delete from clientes where id = 2;
-- Query OK, 1 row affected (0.00 sec)

 
create table produtos (
-> id int primary key auto_increment,
-> Nome varchar(255),
-> Cor varchar (50),
-> Preco decimal(13,2),
-> Tamanho varchar(5),
-> Genero char(1)
);


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
