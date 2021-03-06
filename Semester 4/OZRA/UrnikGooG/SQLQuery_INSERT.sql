UPDATE [dbo].[Bolniška]
SET FK_Urnik = NULL
WHERE Id = 1

DELETE FROM [dbo].[TipOpravila]
DELETE FROM [dbo].[Opravilo]
DELETE FROM [dbo].[Izmena]
DELETE FROM [dbo].[MesečniUrnik]
DELETE FROM [dbo].[Zaposleni]
DELETE FROM [dbo].[Bolniška]
DELETE FROM [dbo].[Dopust]
DELETE FROM [dbo].[ProstiDan]





INSERT INTO Zaposleni(Id, Ime, Priimek, Emšo, DavčnaŠtevilka, UrnaPostavka) VALUES (1,'Jan','Ban','EMŠO12345',123456789,5);
INSERT INTO Zaposleni(Id, Ime, Priimek, Emšo, DavčnaŠtevilka, UrnaPostavka) VALUES (2,'Miha','Piha','EMŠO12345',123456789,5);
INSERT INTO Zaposleni(Id, Ime, Priimek, Emšo, DavčnaŠtevilka, UrnaPostavka) VALUES (3,'Nina','Kina','EMŠO12345',123456789,5);
INSERT INTO Zaposleni(Id, Ime, Priimek, Emšo, DavčnaŠtevilka, UrnaPostavka) VALUES (4,'Mojca','Pojca','EMŠO12345',123456789,5);
INSERT INTO Zaposleni(Id, Ime, Priimek, Emšo, DavčnaŠtevilka, UrnaPostavka) VALUES (5,'Nik','Cik','EMŠO12345',123456789,5);



INSERT INTO MesečniUrnik(Id, Leto, Mesec, Id_Zaposleni) VALUES (1,2017,5,1);
INSERT INTO MesečniUrnik(Id, Leto, Mesec, Id_Zaposleni) VALUES (2,2017,5,2);
INSERT INTO MesečniUrnik(Id, Leto, Mesec, Id_Zaposleni) VALUES (3,2017,5,3);
INSERT INTO MesečniUrnik(Id, Leto, Mesec, Id_Zaposleni) VALUES (4,2017,5,4);
INSERT INTO MesečniUrnik(Id, Leto, Mesec, Id_Zaposleni) VALUES (5,2017,4,4);
INSERT INTO MesečniUrnik(Id, Leto, Mesec, Id_Zaposleni) VALUES (6,2017,5,5);
INSERT INTO MesečniUrnik(Id, Leto, Mesec, Id_Zaposleni) VALUES (7,2017,4,5);


set dateformat dmy
INSERT INTO ProstiDan (Id, Datum, Opis, Id_Urnik) VALUES(1,'01/5/2017','Rojstni dan', 1)
INSERT INTO ProstiDan (Id, Datum, Opis, Id_Urnik) VALUES(2,'01/6/2017','Prošnja za prost dan', 1)
INSERT INTO ProstiDan (Id, Datum, Opis, Id_Urnik) VALUES(3,'01/6/2017','Prošnja za prost dan', 2)
INSERT INTO ProstiDan (Id, Datum, Opis, Id_Urnik) VALUES(4,'01/6/2017','Prošnja za prost dan', 6)
INSERT INTO ProstiDan (Id, Datum, Opis, Id_Urnik) VALUES(5,'01/6/2017','Prošnja za prost dan', 7)


INSERT INTO Bolniška ( Id, DatumZačetka, DatumKonca, Razlog, Id_Urnik)VALUES(1,'01/5/2017','13/5/2017','Gripa',1)
INSERT INTO Bolniška ( Id, DatumZačetka, DatumKonca, Razlog, Id_Urnik)VALUES(2,'01/5/2017','13/5/2017','Operacija žolča',2)
INSERT INTO Bolniška ( Id, DatumZačetka, DatumKonca, Razlog, Id_Urnik)VALUES(3,'01/5/2017','7/5/2017','Prehlad',3)
INSERT INTO Bolniška ( Id, DatumZačetka, DatumKonca, Razlog, Id_Urnik)VALUES(4,'01/5/2017','5/5/2017','Na glavo padu',4)
INSERT INTO Bolniška ( Id, DatumZačetka, DatumKonca, Razlog, Id_Urnik)VALUES(5,'01/5/2017','3/5/2017','Obisk zdravnika',5)


INSERT INTO Dopust(Id, DatumZačetka, DatumKonca, Redni, Id_Urnik)VALUES(1,'01/5/2017','10/5/2017',1,1)
INSERT INTO Dopust(Id, DatumZačetka, DatumKonca, Redni, Id_Urnik)VALUES(1,'11/5/2017','25/5/2017',1,2)
INSERT INTO Dopust(Id, DatumZačetka, DatumKonca, Redni, Id_Urnik)VALUES(3,'01/5/2017','4/5/2017',0,4)
INSERT INTO Dopust(Id, DatumZačetka, DatumKonca, Redni, Id_Urnik)VALUES(4,'01/5/2017','10/5/2017',1,6)
INSERT INTO Dopust(Id, DatumZačetka, DatumKonca, Redni, Id_Urnik)VALUES(5,'01/5/2017','3/5/2017',0,3)


INSERT INTO Izmena(Id, DatumZacetka, DatumKonca, Id_Urnik)VALUES(1 ,'03/5/2017 06:00','03/5/2017 14:00',1)
INSERT INTO Izmena(Id, DatumZacetka, DatumKonca, Id_Urnik)VALUES(2 ,'04/5/2017 06:00','03/5/2017 14:00',2)
INSERT INTO Izmena(Id, DatumZacetka, DatumKonca, Id_Urnik)VALUES(3 ,'05/5/2017 06:00','03/5/2017 14:00',3)
INSERT INTO Izmena(Id, DatumZacetka, DatumKonca, Id_Urnik)VALUES(4 ,'06/5/2017 06:00','03/5/2017 14:00',4)
INSERT INTO Izmena(Id, DatumZacetka, DatumKonca, Id_Urnik)VALUES(5 ,'08/5/2017 06:00','03/5/2017 14:00',5)

INSERT INTO Opravilo(Id, ZačetekOpravila, KonecOpravila, Opravljeno, Opis, Id_TipOpravila, Id_Izmena)VALUES(1,'03/5/2017 06:00','03/5/2017 14:00',0,'Čiščenje',1,1)
INSERT INTO Opravilo(Id, ZačetekOpravila, KonecOpravila, Opravljeno, Opis, Id_TipOpravila, Id_Izmena)VALUES(2,'03/5/2017 06:00','03/5/2017 14:00',1,'Čiščenje',2,1)
INSERT INTO Opravilo(Id, ZačetekOpravila, KonecOpravila, Opravljeno, Opis, Id_TipOpravila, Id_Izmena)VALUES(3,'03/5/2017 06:00','03/5/2017 14:00',0,'Čiščenje',3,2)
INSERT INTO Opravilo(Id, ZačetekOpravila, KonecOpravila, Opravljeno, Opis, Id_TipOpravila, Id_Izmena)VALUES(4,'03/5/2017 06:00','03/5/2017 14:00',1,'Čiščenje',4,2)
INSERT INTO Opravilo(Id, ZačetekOpravila, KonecOpravila, Opravljeno, Opis, Id_TipOpravila, Id_Izmena)VALUES(5,'03/5/2017 06:00','03/5/2017 14:00',0,'Čiščenje',3,2)









INSERT INTO TipOpravila(Id, Ime) VALUES(1,'Čiščenje delovnih površin')
INSERT INTO TipOpravila(Id, Ime) VALUES(2,'Priprava hrane')
INSERT INTO TipOpravila(Id, Ime) VALUES(3,'Urejanje dokumentacija')
INSERT INTO TipOpravila(Id, Ime) VALUES(4,'Preverjanje rokov')
INSERT INTO TipOpravila(Id, Ime) VALUES(5,'Čiščenje hladilnikov')











ALTER TABLE MesečniUrnik
ADD CONSTRAINT FK_Urnik_Zaposleni
FOREIGN KEY (Id_Zaposleni) REFERENCES Zaposleni(Id)

           


