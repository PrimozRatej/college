DELETE FROM cena;
INSERT INTO cena (cenaBrezDDV, cenaDDV, cenaNabavna) VALUES (1.20, 1.57, 1.34);
INSERT INTO cena (cenaBrezDDV, cenaDDV, cenaNabavna) VALUES (2.20, 2.57, 2.34);
INSERT INTO cena (cenaBrezDDV, cenaDDV, cenaNabavna) VALUES (3.20, 3.57, 3.34);
INSERT INTO cena (cenaBrezDDV, cenaDDV, cenaNabavna) VALUES (1.25, 1.67, 1.94);
INSERT INTO cena (cenaBrezDDV, cenaDDV, cenaNabavna) VALUES (1.36, 1.75, 1.95);
INSERT INTO cena (cenaBrezDDV, cenaDDV, cenaNabavna) VALUES (1.40, 1.77, 1.54);
INSERT INTO cena (cenaBrezDDV, cenaDDV, cenaNabavna) VALUES (1.80, 2.11, 1.99);


DELETE FROM artikel_ima_cena;
INSERT INTO artikel_ima_cena (artikel_id, cena_id, datumVeljavnosti, datumZapadlosti) 
VALUES (1, 16, STR_TO_DATE('01/01/2016', '%d/%m/%Y'),NULL);
INSERT INTO artikel_ima_cena (artikel_id, cena_id, datumVeljavnosti, datumZapadlosti) 
VALUES (2, 17, STR_TO_DATE('01/01/2016', '%d/%m/%Y'),NULL);
INSERT INTO artikel_ima_cena (artikel_id, cena_id, datumVeljavnosti, datumZapadlosti) 
VALUES (3, 18, STR_TO_DATE('01/01/2016', '%d/%m/%Y'),NULL);
INSERT INTO artikel_ima_cena (artikel_id, cena_id, datumVeljavnosti, datumZapadlosti) 
VALUES (4, 19, STR_TO_DATE('01/01/2016', '%d/%m/%Y'),NULL);
INSERT INTO artikel_ima_cena (artikel_id, cena_id, datumVeljavnosti, datumZapadlosti) 
VALUES (5, 16, STR_TO_DATE('01/01/2016', '%d/%m/%Y'),NULL);
INSERT INTO artikel_ima_cena (artikel_id, cena_id, datumVeljavnosti, datumZapadlosti) 
VALUES (6, 17, STR_TO_DATE('01/01/2016', '%d/%m/%Y'),NULL);
INSERT INTO artikel_ima_cena (artikel_id, cena_id, datumVeljavnosti, datumZapadlosti) 
VALUES (7, 18, STR_TO_DATE('01/01/2016', '%d/%m/%Y'),NULL);
INSERT INTO artikel_ima_cena (artikel_id, cena_id, datumVeljavnosti, datumZapadlosti) 
VALUES (8, 19, STR_TO_DATE('01/01/2016', '%d/%m/%Y'),NULL);


INSERT INTO vrsta_jedi (naziv, opis) 
VALUES ('Sladica', 'Gluten, Jajca, Moka');
INSERT INTO vrsta_jedi (naziv, opis) 
VALUES ('Glavna jed', 'Gluten, Jajca, Moka');
INSERT INTO vrsta_jedi (naziv, opis) 
VALUES ('Vegetarijanska', 'Gluten, Jajca, Moka');
INSERT INTO vrsta_jedi (naziv, opis) 
VALUES ('Pizza', 'Gluten, Jajca, Moka');

INSERT INTO jed (naziv, opis, vrsta_jedi_id) 
VALUES ('Margarita', 'Testo, Palati, Sir',4);
INSERT INTO jed (naziv, opis, vrsta_jedi_id) 
VALUES ('Classica', 'Testo, Palati, Sir, Gobice, Šunka',4);
INSERT INTO jed (naziv, opis, vrsta_jedi_id) 
VALUES ('Kraška', 'Testo, Palati, Sir, Pršut, Olive, Artičoke',4);
INSERT INTO jed (naziv, opis, vrsta_jedi_id) 
VALUES ('Kremna rezina', 'Listnato testo, vanili krema, Smetana',1);
INSERT INTO jed (naziv, opis, vrsta_jedi_id) 
VALUES ('Borovničeva Pita', 'Listnato testo, vanili krema, Smetana, Borovnice',1);
INSERT INTO jed (naziv, opis, vrsta_jedi_id) 
VALUES ('Rogljiček', 'Listnato testo, Marmelada',1);
INSERT INTO jed (naziv, opis, vrsta_jedi_id) 
VALUES ('American roast beef', 'Ameriška govedina, Poprova omaka, Pečen krompirček',2);
INSERT INTO jed (naziv, opis, vrsta_jedi_id) 
VALUES ('Lignji po pariško', 'Lignji, Pomfri, Tatarska omaka',2);
INSERT INTO jed (naziv, opis, vrsta_jedi_id) 
VALUES ('Losos', 'Losos, Polenta, Rukola',2);
INSERT INTO jed (naziv, opis, vrsta_jedi_id) 
VALUES ('solatni krožnik', 'Zelena solata, rukola, kruhovi cmoki, fižol, paradižnik, parmezan, jogutni preliv',3);

INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (1,1,2); /*Margarita ima 2kom artikla 1*/
INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (1,2,1); /*Margarita ima 1kom artikla 2*/
INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (1,3,1); /*Margarita ima 1kom artikla 3*/

INSERT INTO sestavine (jed_id, artikel_id, kolicina)
VALUES (2,5,2); /*Klasika ima 2kom artikla 5*/
INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (2,2,1); /*Klasika ima 1kom artikla 2*/
INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (2,3,1); /*Klasika ima 1kom artikla 3*/
INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (2,4,1); /*Klasika ima 1kom artikla 4*/

INSERT INTO sestavine (jed_id, artikel_id, kolicina)
VALUES (5,6,2); /*Borovničeva Pita ima 2kom artikla 6*/
INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (5,7,1); /*Borovničeva Pita ima 1kom artikla 7*/
INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (5,8,1); /*Borovničeva Pita ima 1kom artikla 8*/
INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (5,9,1); /*Borovničeva Pita ima 1kom artikla 9*/

INSERT INTO sestavine (jed_id, artikel_id, kolicina)
VALUES (7,6,2); /*American roast beef ima 2kom artikla 6*/
INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (7,7,1); /*American roast beef ima 1kom artikla 7*/
INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (7,8,1); /*American roast beef ima 1kom artikla 8*/
INSERT INTO sestavine (jed_id, artikel_id, kolicina) 
VALUES (7,9,1); /*American roast beef ima 1kom artikla 9*/

INSERT INTO posta (stevilka,Kraj) 
VALUES (1000, 'Ljubljana');
INSERT INTO posta (stevilka,Kraj) 
VALUES (2000, 'Maribor');
INSERT INTO posta (stevilka,Kraj) 
VALUES (3000, 'Celje');

INSERT INTO naslov (kraj, stevilka, posta_stevilka) 
VALUES ('Ljubljanska cesta','23b',1000);
INSERT INTO naslov (kraj, stevilka, posta_stevilka) 
VALUES ('Prešernova ulica','2',1000);
INSERT INTO naslov (kraj, stevilka, posta_stevilka) 
VALUES ('Kozekovo','21',1000);
INSERT INTO naslov (kraj, stevilka, posta_stevilka) 
VALUES ('Tilnovo','54a',1000);
INSERT INTO naslov (kraj, stevilka, posta_stevilka) 
VALUES ('Ljubljanska cesta','23b',2000);
INSERT INTO naslov (kraj, stevilka, posta_stevilka) 
VALUES ('Prešernova ulica','2',2000);
INSERT INTO naslov (kraj, stevilka, posta_stevilka) 
VALUES ('Kozekovo','21',2000);
INSERT INTO naslov (kraj, stevilka, posta_stevilka) 
VALUES ('Tilnovo','54a',3000);

DELETE FROM vloga_osebe;
INSERT INTO vloga_osebe (naziv, opis) 
VALUES ('Natakar','What  can i say more');
INSERT INTO vloga_osebe (naziv, opis) 
VALUES ('Kuhar','What  can i say more');
INSERT INTO vloga_osebe (naziv, opis) 
VALUES ('stranka','What  can i say more');
INSERT INTO vloga_osebe (naziv, opis) 
VALUES ('naročnik','What  can i say more');
INSERT INTO vloga_osebe (naziv, opis) 
VALUES ('dobavitelj','What  can i say more');

INSERT INTO oseba (ime, priimek, davcna, datumRojstva, naslov_id, vloga_osebe_id, telefon, trr, email)/*NATAKAR*/ 
VALUES ('Jan', 'Ban', '12345678', STR_TO_DATE('01/01/1996', '%d/%m/%Y'), 1, 6, '040346875', 'et5674839294585', 'janban@gmail.com');
INSERT INTO oseba (ime, priimek, davcna, datumRojstva, naslov_id, vloga_osebe_id, telefon, trr, email)/*KUHAR*/ 
VALUES ('Niko', 'Biko', '12345678', STR_TO_DATE('01/01/1980', '%d/%m/%Y'), 1, 7, '040346875', 'et5674839294585', 'nikoBiko@gmail.com');
INSERT INTO oseba (ime, priimek, davcna, datumRojstva, naslov_id, vloga_osebe_id, telefon, trr, email)/*STRANKA*/ 
VALUES ('Nina', 'Bina', '12345678', STR_TO_DATE('01/01/1983', '%d/%m/%Y'), 1, 8, '040346875', 'et5674839294585', 'ninaBina@gmail.com');
INSERT INTO oseba (ime, priimek, davcna, datumRojstva, naslov_id, vloga_osebe_id, telefon, trr, email)/*STRANKA*/ 
VALUES ('Piko', 'Ciko', '12345678', STR_TO_DATE('01/01/1986', '%d/%m/%Y'), 1, 8, '040346875', 'et5674839294585', 'pikoCiko@gmail.com');
INSERT INTO oseba (ime, priimek, davcna, datumRojstva, naslov_id, vloga_osebe_id, telefon, trr, email)/*STRANKA*/ 
VALUES ('Tino', 'Bino', '12345678', STR_TO_DATE('01/01/1983', '%d/%m/%Y'), 1, 8, '040346875', 'et5674839294585', 'tinoBino@gmail.com');

INSERT INTO racun (osebaPlaca_id, datumIzdaje, nacinPlacila, osebaIzda_id)
VALUES (4, STR_TO_DATE('30/03/2002', '%d/%m/%Y'), 'Kartica', 2);
INSERT INTO racun (osebaPlaca_id, datumIzdaje, nacinPlacila, osebaIzda_id)
VALUES (4, STR_TO_DATE('30/03/2002', '%d/%m/%Y'), 'Gotovina', 2);
INSERT INTO racun (osebaPlaca_id, datumIzdaje, nacinPlacila, osebaIzda_id)
VALUES (5, STR_TO_DATE('30/03/2002', '%d/%m/%Y'), 'Gotovina', 2);
INSERT INTO racun (osebaPlaca_id, datumIzdaje, nacinPlacila, osebaIzda_id)
VALUES (6, STR_TO_DATE('30/03/2002', '%d/%m/%Y'), 'Gotovina', 2);
INSERT INTO racun (osebaPlaca_id, datumIzdaje, nacinPlacila, osebaIzda_id)
VALUES (6, STR_TO_DATE('31/03/2002', '%d/%m/%Y'), 'Gotovina', 2);
INSERT INTO racun (osebaPlaca_id, datumIzdaje, nacinPlacila, osebaIzda_id)
VALUES (6, STR_TO_DATE('29/03/2002', '%d/%m/%Y'), 'Gotovina', 2);
INSERT INTO jed_na_racun (jed_id, racun_id, kolicina, narocilo_id)
VALUES (6, STR_TO_DATE('29/03/2002', '%d/%m/%Y'), 'Gotovina', 2);

INSERT INTO skupina (opis, oseba_id)
VALUES ('Abraham',4);
INSERT INTO skupina (opis, oseba_id)
VALUES ('Zaključek',5);
INSERT INTO skupina (opis, oseba_id)
VALUES ('Obletnica',6);

INSERT INTO narocilo (skupina_id, oseba_id, opis, cas_izdaje, cas_narocila)
VALUES (1, 4, 'Aperitiv', STR_TO_DATE('29/03/2002', '%d/%m/%Y'),STR_TO_DATE('29/03/2002', '%d/%m/%Y'));
INSERT INTO narocilo (skupina_id, oseba_id, opis, cas_izdaje, cas_narocila)
VALUES (1, 4, 'Glavna jed', STR_TO_DATE('29/03/2002', '%d/%m/%Y'),STR_TO_DATE('29/03/2002', '%d/%m/%Y'));
INSERT INTO narocilo (skupina_id, oseba_id, opis, cas_izdaje, cas_narocila)
VALUES (1, 4, 'Sladica', STR_TO_DATE('29/03/2002', '%d/%m/%Y'),STR_TO_DATE('29/03/2002', '%d/%m/%Y'));

INSERT INTO narocilo (skupina_id, oseba_id, opis, cas_izdaje, cas_narocila)
VALUES (2, 5, 'Aperitiv', STR_TO_DATE('29/03/2002', '%d/%m/%Y'),STR_TO_DATE('29/03/2002', '%d/%m/%Y'));
INSERT INTO narocilo (skupina_id, oseba_id, opis, cas_izdaje, cas_narocila)
VALUES (2, 5, 'Glavna jed', STR_TO_DATE('29/03/2002', '%d/%m/%Y'),STR_TO_DATE('29/03/2002', '%d/%m/%Y'));
INSERT INTO narocilo (skupina_id, oseba_id, opis, cas_izdaje, cas_narocila)
VALUES (2, 5, 'Sladica', STR_TO_DATE('29/03/2002', '%d/%m/%Y'),STR_TO_DATE('29/03/2002', '%d/%m/%Y'));

INSERT INTO narocilo (skupina_id, oseba_id, opis, cas_izdaje, cas_narocila)
VALUES (3, 6, 'Aperitiv', STR_TO_DATE('29/03/2002', '%d/%m/%Y'),STR_TO_DATE('29/03/2002', '%d/%m/%Y'));
INSERT INTO narocilo (skupina_id, oseba_id, opis, cas_izdaje, cas_narocila)
VALUES (3, 6, 'Glavna jed', STR_TO_DATE('29/03/2002', '%d/%m/%Y'),STR_TO_DATE('29/03/2002', '%d/%m/%Y'));
INSERT INTO narocilo (skupina_id, oseba_id, opis, cas_izdaje, cas_narocila)
VALUES (3, 6, 'Sladica', STR_TO_DATE('29/03/2002', '%d/%m/%Y'),STR_TO_DATE('29/03/2002', '%d/%m/%Y'));

INSERT INTO jed_na_racun (jed_id, racun_id, kolicina, narocilo_id)
VALUES (1,1,3,1); /*3 margarite na narocilo 1*/
INSERT INTO jed_na_racun (jed_id, racun_id, kolicina, narocilo_id)
VALUES (7,1,3,2); /*3 steaki na narocilo 1*/
INSERT INTO jed_na_racun (jed_id, racun_id, kolicina, narocilo_id)
VALUES (6,1,3,3); /*3 rogljički na narocilo 1*/

INSERT INTO jed_na_racun (jed_id, racun_id, kolicina, narocilo_id)
VALUES (1,2,3,1); /*3 margarite na narocilo 1*/
INSERT INTO jed_na_racun (jed_id, racun_id, kolicina, narocilo_id)
VALUES (7,2,3,2); /*3 steaki na narocilo 1*/
INSERT INTO jed_na_racun (jed_id, racun_id, kolicina, narocilo_id)
VALUES (6,2,3,3); /*3 rogljički na narocilo 1*/
/*
STRANKA: 4,5,6
NATAKAR: 2
*/

SELECT * FROM cena;
SELECT * FROM artikel;
SELECT * FROM artikel_ima_cena;
SELECT * FROM vrsta_jedi;
SELECT * FROM jed;
SELECT * FROM sestavine;
SELECT * FROM vloga_osebe;
SELECT * FROM oseba;
SELECT * FROM racun;
SELECT * FROM skupina;
SELECT * FROM narocilo;
/*racun.id, SUM(cena.cenaDDV * sestavine.kolicina * jed_na_racun.kolicina) as 'Za plačilo'*/
/*racun.*,jed_na_racun.*,jed.*,sestavine.*,artikel.*,artikel_ima_cena.*,cena.**/
/*racun.id as 'Racun id', racun.datumIzdaje,jed_na_racun.narocilo_id as 'Narocilo id', jed_na_racun.kolicina as 'Število jedi', jed.id as 'Jed id', jed.naziv  as 'Naziv jedi', artikel.naziv as 'uporabljen artikel', sestavine.kolicina as 'Kolicina sestavin', cena.cenaDDV*/
/*SUM(sestavine.kolicina*cena.cenaDDV) GROUP BY(jed.id)*/
/*AVG(cena) as 'Povprečni račun' FROM (SELECT SUM(sestavine.kolicina*cena.cenaDDV*jed_na_racun.kolicina) as 'cena'*/
SELECT AVG(cena) as 'Povprečni račun' FROM (SELECT SUM(sestavine.kolicina*cena.cenaDDV*jed_na_racun.kolicina) as 'cena'
FROM racun
    JOIN jed_na_racun
        ON jed_na_racun.racun_id = racun.id
    JOIN jed
        ON jed.id = jed_na_racun.jed_id
    JOIN sestavine
        ON sestavine.jed_id = jed.id
	JOIN artikel
        ON artikel.id = sestavine.artikel_id
	JOIN artikel_ima_cena
        ON artikel_ima_cena.artikel_id = artikel.id
	JOIN cena
        ON cena.id = artikel_ima_cena.cena_id
 WHERE racun.datumIzdaje = '2002-03-30 00:00:00'
 GROUP BY(racun.id)) as table1;
/*GROUP BY(racun.id)) as table22;*/


/*Jed in njena cena*/
SELECT jed.*, SUM(cena.cenaDDV*kolicina) as Cena
	FROM jed
    JOIN sestavine
        ON sestavine.jed_id = jed.id
	JOIN artikel
        ON artikel.id = sestavine.artikel_id
	JOIN artikel_ima_cena
        ON artikel_ima_cena.artikel_id = artikel.id
	JOIN cena
        ON cena.id = artikel_ima_cena.cena_id
	GROUP BY(jed.id);
     
    
    
    DECLARE  @configVar;
	SET @configVar = (SELECT AVG(Cena) as povprecje FROM (SELECT jed.*, SUM(cena.cenaDDV*kolicina) as 'Cena'
					FROM jed
					JOIN sestavine
					ON sestavine.jed_id = jed.id
					JOIN artikel
					ON artikel.id = sestavine.artikel_id
					JOIN artikel_ima_cena
					ON artikel_ima_cena.artikel_id = artikel.id
					JOIN cena
					ON cena.id = artikel_ima_cena.cena_id
					GROUP BY(jed.id)) as tabelaJedi);
    SELECT jed.*, SUM(cena.cenaDDV*sestavine.kolicina) as Cena
	FROM jed
    JOIN sestavine
        ON sestavine.jed_id = jed.id
	JOIN artikel
        ON artikel.id = sestavine.artikel_id
	JOIN artikel_ima_cena
        ON artikel_ima_cena.artikel_id = artikel.id
	JOIN cena
        ON cena.id = artikel_ima_cena.cena_id
	/*WHERE (SUM(cena.cenaDDV*kolicina) < @configVar)*/
	GROUP BY(jed.id)
    HAVING Cena > @configVar;
    
    
    


SELECT AVG(cena) as 'Povprečje računov' FROM tablee;


/*artikel.*, artikel_ima_cena.*, cena.**/
SELECT SUM(artikel.zaloga*cena.cenaNabavna) as 'Denar v zalogah'
FROM artikel
    JOIN artikel_ima_cena
        ON artikel.id = artikel_ima_cena.artikel_id
    JOIN cena
        ON cena.id = artikel_ima_cena.cena_id;
        
SELECT SUM(cena.cenaDDV*jed_na_racun.kolicina) as 'Zaslužek na dan 30.03.2002'
FROM racun
    JOIN jed_na_racun
        ON jed_na_racun.racun_id = racun.id 
    JOIN jed
        ON jed.id = jed_na_racun.jed_id
    JOIN sestavine
        ON sestavine.jed_id = jed_na_racun.jed_id
	JOIN artikel
        ON artikel.id = sestavine.artikel_id
	JOIN artikel_ima_cena
        ON artikel_ima_cena.artikel_id = artikel.id
	JOIN cena
        ON cena.id = artikel_ima_cena.cena_id
	WHERE racun.datumIzdaje = '2002-03-30 00:00:00';

 
 