create database desafio;
use desafio;

CREATE TABLE atores(
    Id int primary key auto_increment,
    PrimeiroNome varchar(45),
    UltimoNome varchar(45),
    Genero char(1)
);

INSERT INTO Atores (PrimeiroNome, UltimoNome, Genero) VALUES
('James', 'Stewart', 'M'),
('Deborah', 'Kerr', 'F'),
('Peter', 'OToole', 'M'),
('Robert', 'DeNiro', 'M'),
('Harrison', 'Ford', 'M'),
('Stephen', 'Baldwin', 'M'),
('Jack', 'Nicholson', 'M'),
('Mark', 'Wahlberg', 'M'),
('Woody', 'Allen', 'M'),
('Claire', 'Danes', 'F'),
('Tim', 'Robbins', 'M'),
('Kevin', 'Spacey', 'M'),
('Kate', 'Winslet', 'F'),
('Robin', 'Williams', 'M'),
('Jon', 'Voight', 'M'),
('Ewan', 'McGregor', 'M'),
('Christian', 'Bale', 'M'),
('Maggie', 'Gyllenhaal', 'F'),
('Dev', 'Patel', 'M'),
('Sigourney', 'Weaver', 'F'),
('David', 'Aston', 'M'),
('Ali', 'Astin', 'F');



CREATE TABLE filmes(
    Id int primary key auto_increment,
    Nome varchar(45),
    Ano int,
    Duracao int
);

INSERT INTO Filmes (Nome, Ano, Duracao) VALUES
('Um Corpo que Cai', 1958, 128),
('Os Inocentes', 1961, 100),
('Lawrence da Arábia', 1962, 216),
('O Franco Atirador', 1978, 183),
('Amadeus', 1984, 160),
('Blade Runner', 1982, 117),
('De Olhos Bem Fechados', 1999, 159),
('Os Suspeitos', 1995, 106),
('Chinatown', 1974, 130),
('Boogie Nights - Prazer Sem Limites', 1997, 155),
('Noivo Neurótico, Noiva Nervosa', 1977, 93),
('Princesa Mononoke', 1997, 134),
('Um Sonho de Liberdade', 1994, 142),
('Beleza Americana', 1999, 122),
('Titanic', 1997, 194),
('Gênio Indomável', 1997, 126),
('Amargo pesadelo', 1972, 109),
('Trainspotting - Sem Limites', 1996, 94),
('O Grande Truque', 2006, 130),
('Donnie Darko', 2001, 113),
('Quem Quer Ser um Milionário?', 2008, 120),
('Aliens, O Resgate', 1986, 137),
('Uma Vida sem Limites', 2004, 118),
('Avatar', 2009, 162),
('Coração Valente', 1995, 178),
('Os Sete Samurais', 1954, 207),
('A Viagem de Chihiro', 2001, 125),
('De Volta para o Futuro', 1985, 116);


CREATE TABLE elencoFilme(
    Id int primary key auto_increment,
    IdAutor int,
    IdFilme int,
    Papel varchar(30),
    Constraint FkElencoAutor
        Foreign Key (IdAutor)
            References atores(ID),
    Constraint FkElencoFilme
        Foreign Key(IdFilme)
            References filmes(Id)
);

alter table elencofilme rename column idAutor to idAtor;


INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (1, 1, 1, 'John Scottie Ferguson');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (2, 2, 2, 'Miss Giddens');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (3, 3, 3, 'T.E. Lawrence');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (4, 4, 4, 'Michael');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (5, 6, 6, 'Rick Deckard');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (6, 7, 8, 'McManus');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (7, 9, 10, 'Eddie Adams');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (8, 10, 11, 'Alvy Singer');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (9, 11, 12, 'San');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (10, 12, 13, 'Andy Dufresne');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (11, 13, 14, 'Lester Burnham');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (12, 14, 15, 'Rose DeWitt Bukater');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (13, 15, 16, 'Sean Maguire');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (14, 16, 17, 'Ed');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (15, 17, 18, 'Renton');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (16, 19, 20, 'Elizabeth Darko');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (17, 20, 21, 'Older Jamal');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (18, 21, 22, 'Ripley');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (19, 13, 23, 'Bobby Darin');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (20, 8, 9, 'J.J. Gittes');
INSERT INTO elencoFilme (Id, IdAtor, IdFilme, Papel) VALUES (21, 18, 19, 'Alfred Borden');



CREATE TABLE genero(
    Id int primary key auto_increment,
    Genero varchar(20)
);

INSERT INTO Genero (Genero) VALUES
('Ação'),
('Aventura'),
('Animação'),
('Biografia'),
('Comédia'),
('Crime'),
('Drama'),
('Horror'),
('Musical'),
('Mistério'),
('Romance'),
('Suspense'),
('Guerra');

CREATE TABLE filmesGenero(
    Id int primary key auto_increment,
    idGenero int,
    idFilme int,
    Constraint FkFilmeGenero
        Foreign key (idGenero)
            References genero(id),
    Constraint fkFilme
        Foreign key (idFilme)
            References filmes(id)
);

INSERT INTO FilmesGenero (IdGenero, IdFilme) VALUES
(1, 22),
(2, 17),
(2, 3),
(3, 12),
(5, 11),
(6, 8),
(6, 13),
(7, 26),
(7, 28),
(7, 18),
(7, 21),
(8, 2),
(9, 23),
(10, 7),
(10, 27),
(10, 1),
(11, 14),
(12, 6),
(13, 4);


-- 1 - Buscar o nome e ano dos filmes

SELECT NOME, ANO FROM FILMES;

-- 2 - Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano

SELECT  NOME,
        ANO
            FROM FILMES
                ORDER BY ANO;

-- 3 - Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a duração

SELECT  NOME,
        ANO,
        DURACAO
            FROM FILMES
                WHERE FILMES.NOME = 'De volta para o futuro';


-- 4 - Buscar os filmes lançados em 1997

SELECT  NOME,
        ANO,
        DURACAO
            FROM FILMES
                WHERE FILMES.ANO = 1997;


-- 5 - Buscar os filmes lançados APÓS o ano 2000


SELECT  NOME,
        ANO,
        DURACAO
            FROM FILMES
                WHERE FILMES.ANO > 2000;


-- 6 - Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente

SELECT  NOME,
        ANO,
        DURACAO
            FROM FILMES
                WHERE DURACAO > 100 AND DURACAO < 150
                    ORDER BY DURACAO;

-- 7 - Buscar a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela duracao em ordem decrescente

SELECT  ANO,
        COUNT(nome) AS Quantidade
            FROM filmes
                GROUP BY ano
                    ORDER BY Quantidade DESC;

-- 8 - Buscar os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome

SELECT 
    PrimeiroNome,
    UltimoNome,
    Genero
        from atores
            where genero = 'M';

-- 9 - Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome

SELECT 
    PrimeiroNome,
    UltimoNome,
    Genero
        from atores
            where genero = 'F'
                order by PrimeiroNome;

-- 10 - Buscar o nome do filme e o gênero

SELECT 
    FILMES.NOME,
    GENERO.GENERO
        FROM FilmesGenero
            JOIN genero 
                ON FilmesGenero.IdGenero = genero.id
                    JOIN FILMES
                        ON FilmesGenero.IdFilme = filmes.id; 


-- 11 - Buscar o nome do filme e o gênero do tipo "Mistério"

SELECT 
    FILMES.NOME,
    GENERO.GENERO
        FROM FilmesGenero
            JOIN genero 
                ON FilmesGenero.IdGenero = genero.id
                    JOIN FILMES
                        ON FilmesGenero.IdFilme = filmes.id
                            Where genero.genero = 'Mistério'; 


-- 12 - Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel

SELECT 
    FILMES.NOME,
    ATORES.PrimeiroNome,
    ATORES.UltimoNome,
    ElencoFilme.Papel
        FROM ElencoFilme
            JOIN ATORES 
                ON ElencoFilme.IdAtor = Atores.Id
                    JOIN FILMES
                        ON ElencoFilme.IdFilme = FILMES.Id;