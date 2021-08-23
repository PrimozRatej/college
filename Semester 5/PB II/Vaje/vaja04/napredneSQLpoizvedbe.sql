use mydb;
/*POVPRAŠEVAJA*/
/*1. Izberi vse artikle kjer je enota 'EFG' in zaloga večja od 40.*/
SELECT * FROM artikel
WHERE EXISTS (SELECT naziv FROM enota WHERE id = artikel.enota_id AND enota.enota = 'EFG' AND artikel.zaloga > 40);

/*2. Izberi vse artikle kjer je naziv 'efghijk' ali 'ghijklm' ali 'cdefghi'.*/
SELECT * FROM artikel
WHERE naziv IN ('efghijk', 'ghijklm', 'cdefghi');

/*3. Izberi vse artikle naziv ni 'efghijk' ali 'ghijklm' ali 'cdefghi'. Ampak je naziv 'bcdefgh', 'fghijkl', 'bcdefgh'*/
SELECT * FROM artikel
WHERE naziv NOT IN ('efghijk', 'ghijklm', 'cdefghi') 
AND naziv IN ('bcdefgh','fghijkl','bcdefgh');

/*4. Izpiše artikel id, naziv, in nujnost nabave, če je na zalogi manj kot 20 enot posameznega artikla 
izpiše 'Nujno nabavi', manj kot 40 enot 'Nabavi' drugače pa 'Dovolj na zalogi'.*/
SELECT id, naziv, CASE zaloga WHEN zaloga < 20 THEN 'Nujno nabavi'
							  WHEN zaloga < 40 THEN 'Nabavi'
                                         ELSE 'Dovolj na zalogi'
       END AS 'Nabava'
FROM artikel;

/*5. LEFT JOIN na tabelah artikel enota kjer je enota 'EFG'.*/
SELECT * FROM artikel
LEFT JOIN enota ON artikel.enota_id = enota.id
WHERE enota.enota = 'EFG';

/*6. Stavek združimo id artikla in zalogo enote*/
(SELECT id FROM artikel WHERE zaloga < 30 ORDER BY zaloga LIMIT 10)
UNION
(SELECT id FROM enota WHERE enota = 'DEFG' ORDER BY enota LIMIT 10);

/*7. Prešteje vse artikle.*/
SELECT COUNT(id) AS 'Število artiklov' FROM artikel;

/*8. Sešteje vse kose artiklov*/
SELECT SUM(zaloga) AS 'Skladišče'
FROM artikel

/*9. Sešteje vse iste artikle pri katerih je zaloga večja od 5*/
SELECT COUNT(id) as število, naziv
FROM artikel
GROUP BY zaloga
HAVING COUNT(zaloga) > 5;

/*10. Izpiše artikel id, naziv, in nujnost nabave, če je na zalogi manj kot 20 enot posameznega artikla izpiše 
'Nujno nabavi', manj kot 40 enot 'Nabavi' drugače pa 'Dovolj na zalogi'.*/
SELECT id, naziv, CASE zaloga WHEN zaloga < 20 THEN 'Nujno nabavi'
							  WHEN zaloga < 40 THEN 'Nabavi'
                                         ELSE 'Dovolj na zalogi'
       END AS 'Nabava' 
FROM artikel;

/*ODGOVORI NA VPRAŠANJA*/
/*1. Kakšna je vrednost vseh izpisanih računov dne '30.03.2002'?*/
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

/*2. Koliko denarja imamo v zalogah?*/
SELECT SUM(artikel.zaloga*cena.cenaNabavna) as 'Denar v zalogah'
FROM artikel
    JOIN artikel_ima_cena
        ON artikel.id = artikel_ima_cena.artikel_id
    JOIN cena
        ON cena.id = artikel_ima_cena.cena_id;

/*3. Koliko znaša povprečni račun?*/
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
 
 /*4. Katere jedi so dražje od povprečja?*/
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
	GROUP BY(jed.id)
    HAVING Cena > (SELECT AVG(Cena) as povprecje FROM (SELECT jed.*, SUM(cena.cenaDDV*kolicina) as 'Cena'
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
