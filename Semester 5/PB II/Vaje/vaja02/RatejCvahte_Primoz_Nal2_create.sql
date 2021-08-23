-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`enota`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.enota (
  id INT NOT NULL,
  enota VARCHAR(45) NOT NULL);

-- -----------------------------------------------------
-- Table `mydb`.`artikel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.artikel (
  id INT NOT NULL,
  naziv VARCHAR(45) NOT NULL,
  opis VARCHAR(255) NULL,
  zaloga INT NOT NULL,
  enota_id INT NOT NULL);

-- -----------------------------------------------------
-- Table `mydb`.`vrsta_jedi`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.vrsta_jedi (
  id INT NOT NULL,
  naziv VARCHAR(45) NOT NULL,
  opis VARCHAR(150) NOT NULL);


-- -----------------------------------------------------
-- Table `mydb`.`cena`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.cena (
  id INT NOT NULL,
  cenaBrezDDV DECIMAL(6,2) NOT NULL,
  cenaDDV DECIMAL(6,2) NOT NULL,
  cenaNabavna DECIMAL(6,2) NOT NULL);


-- -----------------------------------------------------
-- Table `mydb`.`posta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.posta (
  stevilka INT NOT NULL,
  Kraj VARCHAR(100) NOT NULL);
  
-- -----------------------------------------------------
-- Table `mydb`.`naslov`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.naslov (
  id INT NOT NULL,
  kraj VARCHAR(50) NOT NULL,
  stevilka VARCHAR(8) NOT NULL,
  posta_stevilka INT NOT NULL);


-- -----------------------------------------------------
-- Table `mydb`.`vloga_osebe`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.vloga_osebe (
  id INT NOT NULL,
  naziv VARCHAR(100) NOT NULL,
  opis VARCHAR(255) NULL);


-- -----------------------------------------------------
-- Table `mydb`.`oseba`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.oseba (
  id INT NOT NULL,
  ime VARCHAR(45) NOT NULL,
  priimek VARCHAR(45) NOT NULL,
  davcna VARCHAR(8) NULL,
  datumRojstva DATE NULL,
  naslov_id INT NOT NULL,
  vloga_osebe_id INT NOT NULL,
  telefon VARCHAR(45) NULL,
  trr VARCHAR(45) NULL,
  email VARCHAR(45) NULL);


-- -----------------------------------------------------
-- Table `mydb`.`skupina`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.skupina (
  id INT NOT NULL,
  opis VARCHAR(255) NULL,
  oseba_id INT NOT NULL);


-- -----------------------------------------------------
-- Table `mydb`.`narocilo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.narocilo (
  id INT NOT NULL,
  skupina_id INT NOT NULL,
  oseba_id INT NOT NULL,
  opis VARCHAR(45) NULL,
  cas_izdaje DATE NOT NULL,
  cas_narocila DATE NOT NULL);


-- -----------------------------------------------------
-- Table `mydb`.`racun`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.racun (
  id INT NOT NULL,
  osebaPlaca_id INT NULL,
  datumIzdaje DATETIME NOT NULL,
  nacinPlacila VARCHAR(255) NOT NULL,
  osebaIzda_id INT NOT NULL);


-- -----------------------------------------------------
-- Table `mydb`.`miza`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.miza (
  id INT NOT NULL,
  skupina_id INT NOT NULL,
  st_stolov INT NOT NULL,
  dostop_invalidom BIT NOT NULL);


-- -----------------------------------------------------
-- Table `mydb`.`jed`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.jed (
  id INT NOT NULL,
  naziv VARCHAR(45) NOT NULL,
  opis VARCHAR(255) NULL,
  vrsta_jedi_id INT NOT NULL);


-- -----------------------------------------------------
-- Table `mydb`.`sestavine`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.sestavine (
  jed_id INT NOT NULL,
  artikel_id INT NOT NULL,
  kolicina INT NOT NULL);


-- -----------------------------------------------------
-- Table `mydb`.`jed_na_racun`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.jed_na_racun (
  jed_id INT NOT NULL,
  racun_id INT NOT NULL,
  kolicina INT NOT NULL,
  narocilo_id INT NOT NULL);


-- -----------------------------------------------------
-- Table `mydb`.`artikel_ima_cena`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.artikel_ima_cena (
  artikel_id INT NOT NULL,
  cena_id INT NOT NULL,
  datumVeljavnosti DATE NOT NULL,
  datumZapadlosti DATE NULL);

ALTER TABLE cena ADD PRIMARY KEY(id);
ALTER TABLE cena MODIFY COLUMN id INT auto_increment;
ALTER TABLE artikel ADD PRIMARY KEY (id);
ALTER TABLE artikel MODIFY COLUMN id INT auto_increment;
ALTER TABLE artikel_ima_cena ADD FOREIGN KEY (artikel_id) REFERENCES artikel(id);
ALTER TABLE artikel_ima_cena ADD FOREIGN KEY (cena_id) REFERENCES cena(id);
ALTER TABLE enota ADD PRIMARY KEY (id);
ALTER TABLE enota MODIFY COLUMN id INT auto_increment;
ALTER TABLE artikel ADD FOREIGN KEY (enota_id) REFERENCES enota(id);
ALTER TABLE jed ADD PRIMARY KEY (id);
ALTER TABLE jed MODIFY COLUMN id INT auto_increment;
ALTER TABLE sestavine ADD FOREIGN KEY (jed_id) REFERENCES jed(id);
ALTER TABLE sestavine ADD FOREIGN KEY (artikel_id) REFERENCES artikel(id);
ALTER TABLE vrsta_jedi ADD PRIMARY KEY (id);
ALTER TABLE vrsta_jedi MODIFY COLUMN id INT auto_increment;
ALTER TABLE jed ADD FOREIGN KEY (vrsta_jedi_id) REFERENCES vrsta_jedi(id);
ALTER TABLE miza ADD PRIMARY KEY (id);
ALTER TABLE miza MODIFY COLUMN id INT auto_increment;
ALTER TABLE skupina ADD PRIMARY KEY (id);
ALTER TABLE skupina MODIFY COLUMN id INT auto_increment;
ALTER TABLE posta ADD PRIMARY KEY (stevilka);
ALTER TABLE naslov ADD PRIMARY KEY (id);
ALTER TABLE naslov MODIFY COLUMN id INT auto_increment;
ALTER TABLE vloga_osebe ADD PRIMARY KEY (id);
ALTER TABLE vloga_osebe MODIFY COLUMN id INT auto_increment;
ALTER TABLE oseba ADD PRIMARY KEY (id);
ALTER TABLE oseba MODIFY COLUMN id INT auto_increment;
ALTER TABLE narocilo ADD PRIMARY KEY (id);
ALTER TABLE narocilo MODIFY COLUMN id INT auto_increment;
ALTER TABLE racun ADD PRIMARY KEY (id);
ALTER TABLE racun MODIFY COLUMN id INT auto_increment;
ALTER TABLE jed_na_racun ADD FOREIGN KEY (jed_id) REFERENCES jed(id);
ALTER TABLE jed_na_racun ADD FOREIGN KEY (racun_id) REFERENCES racun(id);
ALTER TABLE jed_na_racun ADD FOREIGN KEY (narocilo_id) REFERENCES narocilo(id);
ALTER TABLE racun ADD FOREIGN KEY (osebaPlaca_id) REFERENCES oseba(id);
ALTER TABLE racun MODIFY COLUMN osebaPlaca_id INT ;
ALTER TABLE racun ADD FOREIGN KEY (osebaIzda_id) REFERENCES oseba(id);

ALTER TABLE narocilo ADD FOREIGN KEY (skupina_id) REFERENCES skupina(id);
ALTER TABLE narocilo ADD FOREIGN KEY (oseba_id) REFERENCES oseba(id);
ALTER TABLE miza ADD FOREIGN KEY (skupina_id) REFERENCES skupina(id);
ALTER TABLE skupina ADD FOREIGN KEY (oseba_id) REFERENCES oseba(id);
ALTER TABLE oseba ADD FOREIGN KEY (naslov_id) REFERENCES naslov(id);
ALTER TABLE oseba ADD FOREIGN KEY (vloga_osebe_id) REFERENCES vloga_osebe(id);
ALTER TABLE naslov ADD FOREIGN KEY (posta_stevilka) REFERENCES posta(stevilka);



