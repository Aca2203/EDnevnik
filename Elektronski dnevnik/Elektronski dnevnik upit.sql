CREATE DATABASE Elektronski_dnevnik;
USE Elektronski_dnevnik;
USE Proba;
DROP DATABASE Elektronski_dnevnik;

CREATE TABLE Osoba(
  id INT PRIMARY KEY IDENTITY(1, 1),
  ime NVARCHAR(20) NOT NULL,
  prezime NVARCHAR(20) NOT NULL,
  adresa NVARCHAR(50),
  jmbg CHAR(13) NOT NULL,
  email NVARCHAR(30) NOT NULL,
  pass NVARCHAR(20) NOT NULL,
  uloga NVARCHAR(20) NOT NULL
);

CREATE TABLE Smer(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(50) NOT NULL
);

CREATE TABLE Predmet(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(40) NOT NULL,
  razred INT NOT NULL
);

CREATE TABLE Skolska_godina(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(10) NOT NULL
);

CREATE TABLE Odeljenje(
  id INT PRIMARY KEY IDENTITY(1, 1),
  razred INT NOT NULL,
  indeks CHAR(2) NOT NULL,
  smer_id INT FOREIGN KEY REFERENCES Smer(id),
  razredni_id INT FOREIGN KEY REFERENCES Osoba(id), -- ON DELETE CASCADE
  godina_id INT FOREIGN KEY REFERENCES Skolska_godina(id)
);

CREATE TABLE Upisnica(
  id INT PRIMARY KEY IDENTITY(1, 1),
  osoba_id INT FOREIGN KEY REFERENCES Osoba(id),
  odeljenje_id INT FOREIGN KEY REFERENCES Odeljenje(id)
);

CREATE TABLE Raspodela(
  id INT PRIMARY KEY IDENTITY(1, 1),
  nastavnik_id INT FOREIGN KEY REFERENCES Osoba(id),
  godina_id INT FOREIGN KEY REFERENCES Skolska_godina(id),
  predmet_id INT FOREIGN KEY REFERENCES Predmet(id),
  odeljenje_id INT FOREIGN KEY REFERENCES Odeljenje(id)
);

CREATE TABLE Ocena(
  id INT PRIMARY KEY IDENTITY(1, 1),
  datum DATE,
  raspodela_id INT FOREIGN KEY REFERENCES Raspodela(id),
  ocena INT NOT NULL,
  ucenik_id INT FOREIGN KEY REFERENCES Osoba(id)
);

INSERT INTO Osoba(ime, prezime, adresa, jmbg, email, pass, uloga) VALUES('Aleksandar', 'Stefanović', 'Marijane Gregoran 85', '2210003710256', 'aleksandar.stefanovic@prva.rs', 'coamafija1312', 'ucenik');
INSERT INTO Osoba(ime, prezime, jmbg, email, pass, uloga) VALUES('Jovan', 'Savić', '2108003524715', 'jovanzsavic@gmail.com', 'Savkela25', 'ucenik');
INSERT INTO Osoba(ime, prezime, adresa, jmbg, email, pass, uloga) VALUES('Milan', 'Marić', 'Paunova 57', '0703004225794', 'maricmilan314@gmail.com', 'Ricma57', 'ucenik');
INSERT INTO Osoba(ime, prezime, jmbg, email, pass, uloga) VALUES('Miloš', 'Pušić', '0101070956018', 'smoki77@yahoo.com', 'milospusic12', 'profesor');
INSERT INTO Osoba(ime, prezime, adresa, jmbg, email, pass, uloga) VALUES('Valentina', 'Popović', 'Cara Dušana 1', '1009080132564', 'valentina.popovic@gmail.com', 'valerijo15', 'profesor');
INSERT INTO Osoba(ime, prezime, jmbg, email, pass, uloga) VALUES('Miloš', 'Marković', '1212110485836', 'losmiM@gmail.com', 'losmi1312', 'ucenik');

INSERT INTO Smer VALUES('Prirodno-matematicki');
INSERT INTO Smer VALUES('Drustveno-jezicki');
INSERT INTO Smer VALUES('IT smer');

INSERT INTO Skolska_godina VALUES('2018/19');
INSERT INTO Skolska_godina VALUES('2019/20');
INSERT INTO Skolska_godina VALUES('2020/21');

INSERT INTO Odeljenje VALUES(4, '9', 3, 110, 5);
INSERT INTO Odeljenje VALUES(4, 'R', 3, 109, 3);
INSERT INTO Odeljenje VALUES(3, '7', 2, 112, 5);

INSERT INTO Raspodela VALUES(109, 5, 3, 6);
INSERT INTO Raspodela VALUES(110, 5, 4, 5);

INSERT INTO Upisnica VALUES(106, 5);
INSERT INTO Upisnica VALUES(107, 5);
INSERT INTO Upisnica VALUES(108, 5);
INSERT INTO Upisnica VALUES(111, 6);
INSERT INTO Upisnica VALUES(113, 6);

SELECT *
FROM Osoba;

DELETE FROM Raspodela;

SELECT *
FROM Smer;

SELECT *
FROM Osoba;

SELECT *
FROM Predmet;

SELECT *
FROM Skolska_godina;

SELECT *
FROM Odeljenje;

SELECT *
FROM Upisnica;

SELECT *
FROM Raspodela;

SELECT *
FROM Ocena;

UPDATE Osoba
SET ime = 'Aleksandar'
WHERE id = 1;