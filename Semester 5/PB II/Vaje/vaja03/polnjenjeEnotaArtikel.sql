use mydb;


SELECT * FROM artikel WHERE zaloga = 44 limit 10000000;

ALTER TABLE artikel
DROP FOREIGN KEY enota_id;

CREATE INDEX i_artikel_enota ON artikel (naziv) USING HASH;
CREATE INDEX i_artikel_naziv ON artikel (zaloga) USING BTREE;
DROP INDEX i_artikel_enota ON artikel;
DROP INDEX i_artikel_naziv ON artikel;

DROP PROCEDURE insertArtikel;
DROP PROCEDURE insertEnota;
DROP PROCEDURE insertArtikel_noCons;

SELECT *
FROM artikel
INNER JOIN enota ON artikel.enota_id = enota.id
WHERE enota.enota = 'FG' limit 10000000;

SELECT *
FROM artikel
WHERE artikel.zaloga = 14 limit 10000000;

SELECT *
FROM artikel
WHERE artikel.zaloga = 14 limit 10000000;

select * from artikel limit 10000000;

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
        START TRANSACTION;
		WHILE x <= stVnosov DO
			FETCH cur_enotaId INTO enotaId;
			SET @rand_naziv = substring(@chars,CEILING(RAND() * 7),7);
            SET @rand_opis = substring(@chars,CEILING(RAND() * 30),7);
            SET @rand_zaloga = ROUND((RAND() * (60-0))+0);
			INSERT INTO mydb.artikel (naziv, opis, zaloga, enota_id)
			VALUES (@rand_naziv, @rand_opis, @rand_zaloga, enotaId);
            SET x = x + 1;
        END WHILE;
        COMMIT;
END procedure_artikel_Insert

DELIMITER procedure_artikel_Insert_noConst
CREATE PROCEDURE insertArtikel_noCons(IN stVnosov INT)
	BEGIN
		DECLARE enotaId, x INT;
        SET x = 1;
        SET @chars = 'abcdefghijklmnoprstuvz';
		SET @rand_naziv = '';
        SET @rand_opis = '';
        START TRANSACTION;
		WHILE x <= stVnosov DO
			SET @rand_naziv = substring(@chars,CEILING(RAND() * 7),7);
            SET @rand_opis = substring(@chars,CEILING(RAND() * 55),10);
            SET @rand_zaloga = ROUND((RAND() * (60-0))+0);
            SET enotaId = ROUND((RAND() * (60-0))+0);
			INSERT INTO mydb.artikel (naziv, opis, zaloga, enota_id)
			VALUES (@rand_naziv, @rand_opis, @rand_zaloga, enotaId);
            SET x = x + 1;
        END WHILE;
        COMMIT;
END procedure_artikel_Insert_noConst


DELIMITER procedure_artikel_update_noConst
CREATE PROCEDURE updateArtikel(IN stVnosov INT)
	BEGIN
		DECLARE enotaId, x INT;
        SET x = 1;
        SET @chars = 'abcdefghijklmnoprstuvz';
		SET @rand_naziv = '';
        SET @rand_opis = '';
		WHILE x <= stVnosov DO
			SET @rand_naziv = substring(@chars,CEILING(RAND() * 7),7);
            SET @rand_opis = substring(@chars,CEILING(RAND() * 55),10);
            SET @rand_zaloga = ROUND((RAND() * (60-0))+0);
            SET enotaId = ROUND((RAND() * (60-0))+0);
			UPDATE artikel
			SET naziv = @rand_naziv, opis = @rand_opis, zaloga = @rand_zaloga, enota_id = enotaId
			WHERE id = x;
            SET x = x + 1;
        END WHILE;
END procedure_artikel_update_noConst


-- --------- ENOTA ------------
DELIMITER procedure_enotaInsert
CREATE PROCEDURE insertEnota(IN stVnosov INT)
	BEGIN
		DECLARE x INT;
        SET x = 1;
        SET @chars = 'ABCDEFG';
		SET @charLen = length(@chars);
		SET @randomString = '';
        START TRANSACTION;
		WHILE x <= stVnosov DO
			SET @randomString = substring(@chars,CEILING(RAND() * @charLen),5);
			INSERT INTO mydb.enota (enota)
			VALUES (@randomString);
            SET x = x + 1;
        END WHILE;
        COMMIT;
END procedure_enotaInsert

SELECT * FROM  mysql.general_log  WHERE command_type ='Query';

CALL insertArtikel(10000000);
CALL insertArtikel_noCons(1000000);
CALL insertEnota(10000000);
CALL updateArtikel(10000000);

DELETE FROM artikel;
DELETE FROM enota;

CALL insertEnota(10000000);
SELECT * FROM artikel LIMIT 10000000;

SELECT * FROM artikel WHERE naziv = 'fghijkl' AND opis = 'mnoprst' LIMIT 10000000;

