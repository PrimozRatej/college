<p align="center">
  <img width="250" height="150" src="media/feri_logo.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Avtor:** Primož Ratej Cvahte

# **Naloga:** 4./II - naloga – Aritmetična sredina in standardni odklon števil

**Vsebina:**

[1. Besedilo naloge](#besedilo-naloge)

[2. Analiza rešitve problema](#_Toc368395464)

[2.1. Namen in zahteve naloge](#_Toc368395465)

[2.2. Vhodi](#_Toc368395466)

[2.3. Izhodi](#izhodi)

[2.4. Omejitve](#omejitve)

[3. Načrt rešitve problema](#_Toc368395469)

[4. Testni primeri](#_Toc368395470)

# Besedilo naloge

Izdelajte program, ki bo izračunal aritmetično sredino in standardni odklon
(populacije) vnesenih števil. Na začetku uporabnik vnese največ 10 vrednosti.
Vnos se lahko predhodno zaključi z vnosom vrednosti 0 (vrednost 0 pomeni
prekinitev nadaljnjega vnašanja podatkov in se ne upošteva v izračun aritmetične
sredine ter standardnega odklona). Na koncu se izpiše aritmetična sredina ter
standardni odklon.

# Analiza rešitve problema

## Namen in zahteve naloge

*Naloga od nas zahteva izdelavo programa, ki nam bo omogočal vpis 10 poljubnih
števil, če se bo uporabnik odločil da bo vpisal manj kot 10 števil enostavno ko
bo uporabnik imel dovolj vpiše 0. Program nam bo potem na podlagi vnesenih
števil izračunal Aritmetično sredino in standardni odklon ter ju izpisal.*

-   *Vpis 10 poljubnih števil.*

-   *Možnost prekinitve vpisa z vnosom ničle.*

-   *Izračun aritmetične sredine in standardnega odklona.*

-   *Izpis aritmetične sredine in standardnega odklona.*

## Vhodi

*Vhodi so vsa realna števila.*

## Izhodi

*Izhodi so vsa realna števila.*

## Omejitve

*Program nima omejitev, če predpostavljamo, da so vhodi števila.*

# Načrt rešitve problema

**Glavni program:**

Najprej uporabnika povprašamo po 10. vrednostih. Te vrednosti shranimo v polje,
če se uporabnik odloči vpisati manj kot 10 vrednosti lahko vpiše število 0 in se
bodo pri izračunu upoštevala samo števila, ki so bila vpisana do takrat. Te
vrednosti shranimo v polje z dolžino 10. Od enem, ko uporabnik vpisuje števila
program računa vsoto vpisanih števil ter število števil, ki so bila vpisana te
podatke bomo potrebovali za nadaljnji izračun povprečja in sredine. Potem
uporabimo funkciji za izračun povprečja in standardnega odklona da dobimo
željene rezultate. Na koncu izpišemo povprečje in standardni odklon.

**Funkcija za povprečje:**

Za izračun povprečja uporabimo funkcijo, za katero bomo potrebovali vsoto vseh
vnesenih števil in število števil, ki jih je uporabnik vpisal. Povprečje se
izračuna vsota vseh števil deljeno s številom vseh števil. Funkcija nam vrne
povprečje.

**Funkcija za standardi odklon:**

Za izračun standardnega odklona bomo potrebovali. Povprečje ki smo ga izračunali
prej, število vseh števil, ki smo jih uporabili za izračun že prej povprečja ter
posamezna števila, ki jih je uporabnik vpisal. Standardi odklon izračunamo po
funkciji:

Funkcija nam vrne standardi odklon vseh vpisanih števil.

X z strešico na vrhu predstavlja povprečno vrednost. X zaporedni člen N število
vseh števil, ki so bile uporabljene za izračun funkcije.

Psevdokode
``` python
FUNCTION Povprečje(vsota, številoŠtevil)
	SET povprečje = vsota / številoŠtevil
	RETURN povprečje;
END FUNCTION

FUNCTION StandardiOdklon(vsota, številoŠtevil, stevila[])
	SET povprecje = Povprečje(vsota,številoŠtevil)
	SET mnozenje = 0
	FOR (SET a = 0, a <= stevila.Length – 1, a=a+1) DO
		IF (stevila[a] == 0) DO break; END IF
		mnozenje = mnozenje + (povprecje - stevila[a]) * (povprecje - stevila[a])
	END FOR
	SET standardiOdklon = Sqrt(mnozenje / številoŠtevil)
	RETURN standardiOdklon;
END FUNCTION
PROCEDURE MAIN
	SET vsota = 0
	SET številoŠtevil = 0
	SET [] stevila
	PRINT ("Vnesi 10 števil")
	FOR (SET a =0; a<=9; a=a+1) DO
		READ stevila[a]
		številoŠtevil++
		IF (stevila[a] == 0) DO break END IF
			vsota = vsota + stevila[a]
	END FOR
	IF (stevila[0] !=0) THAN
		PRINT ("Povprečje števil je: " + Povprečje(vsota, številoŠtevil))
		PRINT ("Standardni odklon števil je: "+StandardiOdklon(vsota, številoŠtevil,stevila))
	ELSE 
		PRINT "Program ne more izračunati povprečja in odklona, če nima števil s katerimi bi operiral"
	END IF
END PROCEDURE
```

# Testni primeri

| **Testni scenariji (vhodi)**            | **Rezultat (pričakovani izhodi)**          | **Opomba (opcijsko)**                                                                  |
|-----------------------------------------|--------------------------------------------|----------------------------------------------------------------------------------------|
| 0                                       | Povprečje: Javi napako Odklon: Javi napako | Brez števil ne moreš izračunati povprečja in odklona.                                  |
| 164,181,182,174,185,163,170,170,166,167 | Povprečje: 172,2 Odklon: 7,533             | Naloga z učbenika preverjena z algoritmom.                                             |
| 5,5,5,5,0                               | Povprečje: 5 Odklon: 0                     | Če vnesemo sama velika števila bo povprečje vedno enaku temu število ter nebo odklona. |
| -5,-7,5,9,-7,-2,0                       | Povprečje: -1,166666 Odklon: 6,1214        | Algoritem deluje tudi z negativnimi števili.                                           |
