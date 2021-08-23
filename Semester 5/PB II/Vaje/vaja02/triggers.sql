use mydb;

DROP TABLE IF EXISTS log_artikel;
DROP TABLE IF EXISTS log_oseba;

CREATE TABLE IF NOT EXISTS mydb.log_artikel (
  id_artikel INT NOT NULL,
  naziv VARCHAR(45) NOT NULL,
  datumSkladiscenja DATETIME NULL);
  
  CREATE TABLE IF NOT EXISTS mydb.log_oseba (
  id_oseba INT NOT NULL,
  davcna VARCHAR(45) NOT NULL,
  datumVnosa DATETIME NULL,
  tipSpremembe TEXT,
  vloga_osebe VARCHAR(45) NOT NULL);


DROP TRIGGER ins_artikel;
DROP TRIGGER ins_oseba;
DROP TRIGGER upd_oseba;

delimiter ;;
CREATE TRIGGER ins_artikel AFTER INSERT ON artikel FOR EACH ROW
BEGIN
	SET @naziv_ = NEW.naziv;
	SET @id_ = NEW.id;
	SET @date_ = NOW();
    SET @zaloga_ = NEW.zaloga;
	INSERT INTO mydb.log_artikel (id_artikel, naziv, datumSkladiscenja)
	VALUES (@id_, @naziv_, @date_);
END;;
delimiter ;

delimiter ;;
CREATE TRIGGER ins_oseba AFTER INSERT ON oseba FOR EACH ROW
BEGIN
	SET @id = NEW.id;
	SET @davcna = NEW.davcna;
    SET @vlogaOsebeId = NEW.vloga_osebe_id;
    SET @datumVnosa = NOW();
    SET @tipSpremembe = 'Vpis';
	
	INSERT INTO mydb.log_oseba (id_oseba, davcna, datumVnosa, tipSpremembe, vloga_osebe)
	VALUES (@id, @davcna, @datumVnosa, @tipSpremembe, @vlogaOsebeId);
END;;
delimiter ;

delimiter ;;
CREATE TRIGGER del_oseba BEFORE DELETE ON oseba FOR EACH ROW
BEGIN
	SET @id = OLD.id;
	SET @davcna = OLD.davcna;
    SET @vlogaOsebeId = OLD.vloga_osebe_id;
    SET @datumVnosa = NOW();
    SET @tipSpremembe = 'Brisanje';
	
	INSERT INTO mydb.log_oseba (id_oseba, davcna, datumVnosa, tipSpremembe, vloga_osebe)
	VALUES (@id, @davcna, @datumVnosa, @tipSpremembe, @vlogaOsebeId);
END;;
delimiter ;

delimiter ;;
CREATE TRIGGER upd_oseba BEFORE UPDATE ON oseba FOR EACH ROW
BEGIN
	SET @id = NEW.id;
	SET @davcna = NEW.davcna;
    SET @vlogaOsebeId = NEW.vloga_osebe_id;
    SET @datumVnosa = NOW();
    SET @tipSpremembe = 'Sprememba';
	
	INSERT INTO mydb.log_oseba (id_oseba, davcna, datumVnosa, tipSpremembe, vloga_osebe)
	VALUES (@id, @davcna, @datumVnosa, @tipSpremembe, @vlogaOsebeId);
END;;
delimiter ;
