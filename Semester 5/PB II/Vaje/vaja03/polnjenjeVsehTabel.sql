
DROP PROCEDURE IF EXISTS insertPVlogaOsebe;
DROP PROCEDURE IF EXISTS insertPosta;
DROP PROCEDURE IF EXISTS insertEnota;
DROP PROCEDURE IF EXISTS insertVrstaJedi;
DROP PROCEDURE IF EXISTS insertCena;
DROP PROCEDURE IF EXISTS insertArtikel;
DROP PROCEDURE IF EXISTS insertVlogaOsebe;
DROP PROCEDURE IF EXISTS insertArtikelImaCena;
DROP PROCEDURE IF EXISTS insertJed;
DROP PROCEDURE IF EXISTS insertNaslov;
DROP PROCEDURE IF EXISTS insertOseba;
DROP PROCEDURE IF EXISTS insertRacun;
DROP PROCEDURE IF EXISTS insertSestavine;
DROP PROCEDURE IF EXISTS insertSkupina;
DROP PROCEDURE IF EXISTS insertNarocilo;


-- ---------- CENA -----------
USE mydb;
DELIMITER procedure_cenaInsert
CREATE PROCEDURE insertCena(IN stVnosov INT)
	BEGIN
		DECLARE x, DDV, cena_DDV, cenaBrez_DDV DECIMAL(5,2);
        SET x = 1;
        SET DDV = 22;
		WHILE x<= stVnosov DO
            SET cena_DDV = ROUND(RAND()*(5-1)+1,2);
            SET cenaBrez_DDV = (cena_DDV*(100-DDV)/100);
			INSERT INTO mydb.cena (cenaDDV, cenaBrezDDV, cenaNabavna)
			VALUES (cena_DDV, cenaBrez_DDV, cenaBrez_DDV-0.6);
            SET x = x + 1;
		END WHILE;
END procedure_cenaInsert

-- --------- ENOTA ------------
DELIMITER procedure_enotaInsert
CREATE PROCEDURE insertEnota(IN stVnosov INT)
	BEGIN
		DECLARE x INT;
        SET x = 1;
        SET @chars = 'ABCDEFG';
		SET @charLen = length(@chars);
		SET @randomString = '';
		WHILE x <= stVnosov DO
			SET @randomString = substring(@chars,CEILING(RAND() * @charLen),5);
			INSERT INTO mydb.enota (enota)
			VALUES (@randomString);
            SET x = x + 1;
        END WHILE;
END procedure_enotaInsert

-- --------- VRSTA_JEDI ------------
DELIMITER procedure_vrsta_jedi_Insert
CREATE PROCEDURE insertVrstaJedi(IN stVnosov INT)
	BEGIN
		DECLARE x INT;
        SET x = 1;
        SET @chars = 'abcdefghijklmnoprstuvz';
		SET @randomString_naziv = '';
        SET @randomString_opis = '';
		WHILE x <= stVnosov DO
			SET @randomString_naziv = substring(@chars,CEILING(RAND() * 7),7);
            SET @randomString_opis = substring(@chars,CEILING(RAND() * 55),10);
			INSERT INTO mydb.vrsta_jedi (naziv, opis)
			VALUES (@randomString_naziv, @randomString_opis);
            SET x = x + 1;
        END WHILE;
END procedure_vrsta_jedi_Insert

-- --------- POSTA ------------
DELIMITER procedure_posta_Insert
CREATE PROCEDURE insertPosta(IN stVnosov INT)
	BEGIN
		DECLARE x INT;
        SET x = 1;
        SET @chars = 'abcdefghijklmnoprstuvz';
		SET @rand_stevilka = '';
        SET @rand_kraj = '';
        SET @stevilka = 1200;
		WHILE x <= stVnosov DO
			SET @rand_kraj = substring(@chars,CEILING(RAND() * 7),7);
            SET @stevilka = @stevilka +30;
			INSERT INTO mydb.posta (stevilka, kraj)
			VALUES (@stevilka, @rand_kraj);
            SET x = x + 1;
        END WHILE;
END procedure_posta_Insert

-- --------- VLOGA_OSEBA  ------------
DELIMITER procedure_vloga_osebe_Insert
CREATE PROCEDURE insertVlogaOsebe(IN stVnosov INT)
	BEGIN
		DECLARE x INT;
        SET x = 1;
        SET @chars = 'abcdefghijklmnoprstuvz';
		SET @rand_naziv = '';
        SET @rand_opis = '';
		WHILE x <= stVnosov DO
			SET @rand_naziv = substring(@chars,CEILING(RAND() * 7),7);
            SET @rand_opis = substring(@chars,CEILING(RAND() * 55),10);
			INSERT INTO mydb.vloga_osebe (naziv, opis)
			VALUES (@rand_naziv, @rand_opis);
            SET x = x + 1;
        END WHILE;
END procedure_vloga_osebe_Insert

-- ----------- ARTIKEL -----------
DELIMITER procedure_artikel_Insert
CREATE PROCEDURE insertArtikel(IN stVnosov INT)
	BEGIN
		DECLARE enotaId, x INT;
		DECLARE cur_enotaId CURSOR FOR SELECT id FROM mydb.enota;
        OPEN cur_enotaId;
        SET x = 1;
        SET @chars = 'abcdefghijklmnoprstuvz';
		SET @rand_naziv = '';
        SET @rand_opis = '';
		WHILE x <= stVnosov DO
			FETCH cur_enotaId INTO enotaId;
			SET @rand_naziv = substring(@chars,CEILING(RAND() * 7),7);
            SET @rand_opis = substring(@chars,CEILING(RAND() * 55),10);
            SET @rand_zaloga = ROUND((RAND() * (60-0))+0);
			INSERT INTO mydb.artikel (naziv, opis, zaloga, enota_id)
			VALUES (@rand_naziv, @rand_opis, @rand_zaloga, enotaId);
            SET x = x + 1;
        END WHILE;
END procedure_artikel_Insert

-- --------- ARTIKEL_IMA_CENA --------------
DELIMITER procedure_artikel_ima_cena_Insert
CREATE PROCEDURE insertArtikelImaCena(IN stVnosov INT)
	BEGIN
		DECLARE artikelId, cenaId, x INT;
		DECLARE cur_artikelId CURSOR FOR SELECT id FROM mydb.artikel;
        DECLARE cur_cenaId CURSOR FOR SELECT id FROM mydb.cena;
        OPEN cur_artikelId;
        OPEN cur_cenaId;
        SET x = 1;
        SET @dateVelj = FROM_UNIXTIME(UNIX_TIMESTAMP('2010-04-30 14:53:27') + FLOOR(0 + (RAND() * 63072000)));
		WHILE x <= stVnosov DO
			FETCH cur_artikelId INTO artikelId;
            FETCH cur_cenaId INTO cenaId;
			INSERT INTO mydb.artikel_ima_cena (artikel_id, cena_id, datumVeljavnosti, datumZapadlosti)
			VALUES (artikelId, cenaId, @dateVelj, @dateVelj);
            SET x = x + 1;
        END WHILE;
END procedure_artikel_ima_cena_Insert

-- -------- JED -------------
DELIMITER procedure_jed_Insert
CREATE PROCEDURE insertJed(IN stVnosov INT)
	BEGIN
		DECLARE vrstaJediId, x INT;
		DECLARE cur_vrstaJediId CURSOR FOR SELECT id FROM mydb.vrsta_jedi;
        OPEN cur_vrstaJediId;
        SET x = 1;
		WHILE x <= stVnosov DO
			SET @dateVelj = FROM_UNIXTIME(UNIX_TIMESTAMP('2010-04-30 14:53:27') + FLOOR(0 + (RAND() * 63072000)));
			FETCH cur_vrstaJediId INTO vrstaJediId;
            SET @rand_naziv = substring(@chars,CEILING(RAND() * 7),7);
            SET @rand_opis = substring(@chars,CEILING(RAND() * 55),10);
			INSERT INTO mydb.jed (naziv, opis, vrsta_jedi_id)
			VALUES (@rand_naziv, @rand_opis, vrstaJediId);
            SET x = x + 1;
        END WHILE;
END procedure_jed_Insert

-- ------- NASLOV ---------------
DELIMITER procedure_naslov_Insert
CREATE PROCEDURE insertNaslov(IN stVnosov INT)
	BEGIN
		DECLARE postnaStevilka, x INT;
		DECLARE cur_postnaStevilka CURSOR FOR SELECT stevilka FROM mydb.posta;
        OPEN cur_postnaStevilka;
        SET x = 1;
        
		WHILE x <= stVnosov DO
			FETCH cur_postnaStevilka INTO postnaStevilka;
            SET @rand_kraj = substring(@chars,CEILING(RAND() * 7),7);
            SET @rand_stevilka = ROUND((RAND() * (60-1))+1);
			INSERT INTO mydb.naslov (kraj, stevilka, posta_stevilka)
			VALUES (@rand_kraj, @rand_stevilka, postnaStevilka);
            SET x = x + 1;
        END WHILE;
END procedure_naslov_Insert

-- ------- OSEBA ---------------
DELIMITER procedure_oseba_Insert
CREATE PROCEDURE insertOseba(IN stVnosov INT)
	BEGIN
		DECLARE davcna, telefon, naslovId, vlogaOsebeId, x INT;
        DECLARE ime, priimek, trr, email TEXT;
        DECLARE datumRojstva DATE;
		DECLARE cur_naslovId CURSOR FOR SELECT id FROM mydb.naslov;
        DECLARE cur_vlogaOsebeId CURSOR FOR SELECT id FROM mydb.vloga_osebe;
        OPEN cur_naslovId;
        OPEN cur_vlogaOsebeId;
        SET x = 1;
        
		WHILE x <= stVnosov DO
			FETCH cur_naslovId INTO naslovId;
            FETCH cur_vlogaOsebeId INTO vlogaOsebeId;
            SET davcna = FLOOR(RAND() * 99999999);
            SET telefon = FLOOR(RAND() * 9999999999);
            SET ime = substring(@chars,CEILING(RAND() * 7),7);
            SET priimek = substring(@chars,CEILING(RAND() * 15),7);
            SET trr = substring(@chars,CEILING(RAND() * 15),7);
            SET email = substring(@chars,CEILING(RAND() * 25),7);
            SET datumRojstva = FROM_UNIXTIME(UNIX_TIMESTAMP('1980-04-30 14:53:27') + FLOOR(0 + (RAND() * 630720000)));
			INSERT INTO mydb.oseba (ime, priimek, davcna, datumRojstva, naslov_id, vloga_osebe_id, telefon, trr, email)
			VALUES (ime, priimek, davcna, datumRojstva, naslovId, vlogaOsebeId, telefon, trr, email);
            SET x = x + 1;
        END WHILE;
END procedure_oseba_Insert

-- ------- RACUN ----------
DELIMITER procedure_racun_Insert
CREATE PROCEDURE insertRacun(IN stVnosov INT)
	BEGIN
		DECLARE osebaPlacaId, osebaIzdaId, x INT;
        DECLARE nacinPlacila TEXT;
        DECLARE datumIzdaje DATE;
        SET x = 1;
        
		WHILE x <= stVnosov DO
			SET osebaIzdaId = ROUND((RAND() * (15-1))+1);
            SET osebaPlacaId = ROUND((RAND() * (100-15))+15);
            SET nacinPlacila = substring(@chars,CEILING(RAND() * 15),7);
            SET datumIzdaje = FROM_UNIXTIME(UNIX_TIMESTAMP('2015-04-30 14:53:27') + FLOOR(0 + (RAND() * 63072000)));
			INSERT INTO mydb.racun (osebaPlaca_id, datumIzdaje, nacinPlacila, osebaIzda_id)
			VALUES (osebaPlacaId, datumIzdaje, nacinPlacila, osebaIzdaId);
            SET x = x + 1;
        END WHILE;
END procedure_racun_Insert


-- ------- NAROCILO ----------
DELIMITER procedure_narocilo_Insert
CREATE PROCEDURE insertNarocilo(IN stVnosov INT)
	BEGIN
		DECLARE skupinaId, osebaId, x INT;
        DECLARE opis TEXT;
        DECLARE casIzdaje, casNarocila DATE;
        SET x = 1;
		WHILE x <= stVnosov DO
			SET skupinaId = ROUND((RAND() * (100-1))+1);
            SET osebaId = ROUND((RAND() * (100-1))+1);
            SET opis = substring(@chars,CEILING(RAND() * 15),7);
            SET casIzdaje = FROM_UNIXTIME(UNIX_TIMESTAMP('2010-04-30 14:53:27') + FLOOR(0 + (RAND() * 63072000)));
            SET casNarocila = casIzdaje - FLOOR(0 + (RAND() * 630));
			INSERT INTO mydb.narocilo (skupina_id, oseba_id, opis, cas_izdaje, cas_narocila)
			VALUES (skupinaId, osebaId, opis, casIzdaje, casNarocila);
            SET x = x + 1;
        END WHILE;
END procedure_narocilo_Insert

-- ------- JED_NA_RACUN ----------
DELIMITER procedure_jed_na_racun_Insert
CREATE PROCEDURE insertJedNaRacun(IN stVnosov INT)
	BEGIN
		DECLARE jedId, racunId, kolicina, narociloId, x INT;
        SET x = 1;
		WHILE x <= stVnosov DO
			SET jedId = ROUND((RAND() * (100-1))+1);
            SET racunId = ROUND((RAND() * (100-1))+1);
            SET kolicina = ROUND((RAND() * (10-1))+1);
            SET narociloId = ROUND((RAND() * (100-1))+1);
			INSERT INTO mydb.jed_na_racun (jed_id, racun_id, kolicina, narocilo_id)
			VALUES (jedId, racunId, kolicina, narociloId);
            SET x = x + 1;
        END WHILE;
END procedure_jed_na_racun_Insert

-- ------- JED_NA_RACUN ----------
DELIMITER procedure_skupina_Insert
CREATE PROCEDURE insertSkupina(IN stVnosov INT)
	BEGIN
		DECLARE osebaId, x INT;
        DECLARE opis TEXT;
        SET x = 1;
		WHILE x <= stVnosov DO
			SET opis = substring(@chars,CEILING(RAND() * 15),7);
			SET osebaId = ROUND((RAND() * (100-1))+1);
			INSERT INTO mydb.skupina (opis, oseba_id)
			VALUES (opis, osebaId);
            SET x = x + 1;
        END WHILE;
END procedure_skupina_Insert

DELIMITER procedure_sestavine_Insert
CREATE PROCEDURE insertSestavine(IN stVnosov INT)
	BEGIN
		DECLARE jedId, artikelId, kolicina, x INT;
        SET x = 1;
		WHILE x <= stVnosov DO
			SET jedId = ROUND((RAND() * (100-1))+1);
            SET artikelId = ROUND((RAND() * (100-1))+1);
			SET kolicina = ROUND((RAND() * (30-1))+1);
			INSERT INTO mydb.sestavine (jed_id, artikel_id, kolicina)
			VALUES (jedId, artikelId, kolicina);
            SET x = x + 1;
        END WHILE;
END procedure_sestavine_Insert

DELIMITER procedure_miza_Insert
CREATE PROCEDURE insertMiza(IN stVnosov INT)
	BEGIN
		DECLARE skupinaId, stStolov, dostopInvalidom, x INT;
        SET x = 1;
		WHILE x <= stVnosov DO
			SET skupinaId = ROUND((RAND() * (100-1))+1);
            SET stStolov = ROUND((RAND() * (12-1))+1);
			SET dostopInvalidom = RAND();
			INSERT INTO mydb.miza (skupina_id, st_stolov, dostop_invalidom)
			VALUES (skupinaId, stStolov, dostopInvalidom);
            SET x = x + 1;
        END WHILE;
END procedure_miza_Insert

CALL insertVlogaOsebe(100);
CALL insertCena(100);
CALL insertEnota(100);
CALL insertVrstaJedi(100);
CALL insertPosta(100);
CALL insertArtikel(100);
CALL insertArtikelImaCena(100);
CALL insertJed(100);
CALL insertNaslov(100);
CALL insertOseba(100);
CALL insertRacun(100);
CALL insertSestavine(100);
CALL insertSkupina(100);
CALL insertNarocilo(100);
CALL insertJedNaRacun(100);
CALL insertMiza(100);


