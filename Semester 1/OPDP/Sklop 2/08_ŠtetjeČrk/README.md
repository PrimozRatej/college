<p align="center">
  <img width="250" height="150" src="media/feri_logo.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Avtor:** Primož Ratej Cvahte

# **Naloga:** 9./II - naloga – Štetje črk

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

Izdelajte program, ki bo prebral niz znakov in določil kolikokrat se v besedilu
ponovi neka črka slovenske abecede. Male in velike črke obravnavajte ločeno.
Program naj na koncu (urejeno po abecedi) izpiše ločena seznama črk (za male in
velike črke), ki se pojavljajo v besedilu in njihovo frekvenco/število
ponovitev. Upoštevajte samo črke slovenske abecede.  
Program naj tudi izpiše koliko števil je nastopilo v nizu.

# Analiza rešitve problema

## Namen in zahteve naloge

*Naloga od nas zahteva izdelavo programa, ki nam bo omogočal izpis seznama črk
ki se pojavijo v nizu in njihovo število ponovitev. Ter tudi koliko števk je
nastopalo v nizu.*

-   *Vpis besedila (niz)*

-   *Izračun števila ponovitev za male in velike črke.*

-   *Izračun števila števk, ki se pojavljajo v nizu.*

-   *Izris tabele črk in število njihovih ponovitev.*

-   *Izpis števila števil, ki se pojavljajo v vnesenem nizu.*

## Vhodi

-   *Naključen niz znakov.*

## Izhodi

-   Izpis tabele slovenske abecede malih in velikih črk ter njihovo število
    ponovitev v nizu.

-   Izpis števila števil ki se pojavijo v nizu

## Omejitve

Program je omejen na operiranje z vsemi znaki UNICODE standarda za kodiranje
znakov.

# Načrt rešitve problema

**Glavni program:**

Uporabnika najprej povprašamo po nizu znakov. Nato z funkcijo za določitev
števila malih in velikih črk izračunamo ferkvenco črk, ki se pojavljajo v
vnesenem nizu. Nato pa z funkcijo za določitev ferkvence ponovitev števil
izračunamo koliko števk se pojavlja v vnesenem nizu.

Potem izrišemo tabelo slovenske abecede malih in velikih črk in število
ponovitev za vsak znak posebej.

Na koncu pa tudi število števil, ki se pojavljajo v nizu.

**Metoda za izračun ponovitev malih in velikih črk:**

Za hranjenje števila ponovitev bomo uporabili polje celih števil. Potem pa
preverjamo za vsak znak slovenske abecede posebej kolikokrat se ponovi v
vnesenem nizu. To pomeni da preverjamo 2x. Vsak znak slovenske abecede
preverjamo z vsakim znakom vnesenem v nizu in, če se ta znaka ujemata se na
mesto, v polju prišteje 1. To pomeni, če je vnesen niz »aaabb« se bo na 0-to
mesto shranilo 3 na 1. mesto pa 2. Funkcija nam vrne polje celih števil katere
vrednosti predstavljajo ferkvenco ponovitev za znake slovenske abecede po vrsti
od 0-24.

**Metoda za izračun števila števil v nizu:**

Funkcija za izračun števil v zanki preverja če je določen znak števka kar
pomeni, če je znak večji ali enak 0 in manjši ali enak 9 pomeni, da je ta znak
število če je ta pogoj izpolnjen števec, ki nam šteje števila povečamo za 1.
Funkcija nam vrne celo število, ki predstavlja število števil v vnesenem nizu.

Psevdokode
``` python
FUNCTION [] StetjeCrk(niz,abeceda)
	// dolžina števca je nastavljena na število črk v slovenski
	SET [] stevci 
	abecedi.
	FOR crka = 0 TO 25 DO
		SET steviloZnakovVnizu // Predstavlja število znakov v vnesenem nizu.
		FOR znak = 0 TO steviloZnakovVnizu DO
			IF abeceda[crka] = niz[znak] THEN
			stevci[crka] = stevci[crka] + 1
			END IF
			znak = znak+1
		END FOR
		crka = crka+1
	END FOR
	// nakoncu funkcija vrne polje stevci
END FUNCTION

// Funkcija za izracun števila števil v nizu
FUNCTION StejCifre(niz)
	SET steviloZnakovVnizu // Predstavlja število znakov v vnesenem nizu.
	SET stevec = 0 // Ta števec šteje števila v nizu.
	FOR i = 0 TO steviloZnakovVnizu DO
		IF niz[i] >= '0' AND niz[i] <= '9' THAN
			stevec = stevec + 1
		END IF
		i = i+1
	END FOR
	// na koncu funcija vrne celo stevilo stevil, ki so se pojavili v nizu.
END FUNCTION

PROCEDURE MAIN
	PRINT "Vpiši niz znakov"
	READ nizZnakov
	SET slovenskaAbecedaMALE = "abcčdefghijklmnoprsštuvzž"
	SET slovenskaAbecedaVELIKE = "ABCČDEFGHIJKLMNOPRSŠTUVZŽ"
	ST[] steviloVelikihCrk = StejCrke(nizZnakov, slovenskaAbecedaVELIKE)
	SET[] steviloMalihCrk = StejCrke(nizZnakov, slovenskaAbecedaMALE)
	SET stevecStevil = StejCifre(nizZnakov)
	// Izris tabele črk
	PRINT "Tabela koliko črk se pojavlja v danem zapisu:"
	FOR v = 0 TO 24
		PRINT slovenskaAbecedaMALE[v] +" "+ steviloMalihCrk[v] + " " +
		slovenskaAbecedaVELIKE[v] + " " + steviloVelikihCrk[v]
		v = v+1
	END FOR
	// Izpis števila števil ki se pojavljajo v nizu.
	PRINT "Število števil, ki se pojavljajo v nizu je: " + stevecStevil
END PROCEDURE
```

# Testni primeri

| **Testni scenariji**                                                | **Rezultat (pričakovani izhodi)** | **Opomba (opcijsko)**         |
|---------------------------------------------------------------------|-----------------------------------|-------------------------------|
| Vse male črke **+ »-,.-»!/& %\$/« +** Vse velike črke + vsa števila | Pravilen                          | Vsaka vrednost je natančno 1. |
| !"\#\$%&/()=?\*:_ł€[\\\|€\|}\<Łł}]{}§Ł]}@]                          | Pravilen                          | Samo znaki vse vrednosti so 0 |
| 3215791835                                                          | Pravilen 10                       | Samo števila                  |
| aaaabbb                                                             | Pravilen za a = 4 za b = 3        | Preverimo štetje              |
| F43978ZT N78ZT9V Ujdhfgiuw73254                                     | Pravilen                          | Vse možnosti                  |
