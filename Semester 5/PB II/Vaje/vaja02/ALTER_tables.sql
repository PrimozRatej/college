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



