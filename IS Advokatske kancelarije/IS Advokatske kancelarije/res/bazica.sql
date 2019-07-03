--
-- File generated with SQLiteStudio v3.2.1 on Wed Jun 12 21:28:56 2019
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: stranke
CREATE TABLE stranke (id INT PRIMARY KEY, ime STRING, prezime STRING, jmbg CHAR (13) UNIQUE, datum STRING, predmet STRING, broj INT);
INSERT INTO stranke (id, ime, prezime, jmbg, datum, predmet, broj) VALUES (1, 'pera', 'peric', '021', '01-01-1991', 'krivica', 212);

-- Table: zaduzenja
CREATE TABLE zaduzenja (id INT NOT NULL PRIMARY KEY, idStranke INT REFERENCES stranke (id), datumZaduzenja STRING, zaduzenje DOUBLE, razduzenje DOUBLE);
INSERT INTO zaduzenja (id, idStranke, datumZaduzenja, zaduzenje, razduzenje) VALUES (1, 1, '01-01-2001', 100.0, 30.0);

-- View: Pogled_Zaduzenje
CREATE VIEW Pogled_Zaduzenje AS SELECT zaduzenja.id AS id,
       stranke.ime AS ime,
       stranke.prezime AS prezime,
       zaduzenja.zaduzenje AS duguje,
       zaduzenja.datumZaduzenja AS datum,
       zaduzenja.razduzenje AS uplaceno
  FROM stranke
       INNER JOIN
       zaduzenja ON zaduzenja.idStranke = stranke.id;

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
