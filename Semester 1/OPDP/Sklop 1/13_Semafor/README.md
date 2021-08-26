<p align="center">
  <img width="250" height="150" src="media/feri_logo.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Avtor:** Primož Ratej Cvahte

# **Naloga:** 12. Denar

**Vsebina:**

[1. Besedilo naloge](#besedilo-naloge)

[2. Analiza rešitve problema](#_Toc433735415)

[2.1. Namen in zahteve naloge](#_Toc433735416)

[2.2. Vhodi](#_Toc433735417)

[2.3. Izhodi](#izhodi)

[2.4. Omejitve](#omejitve)

[3. Načrt rešitve problema](#_Toc433735420)

# Besedilo naloge

Izdelajte postopek, ki bo prebral znesek v eurih in izpisal, koliko posameznih
denarnih enot je potrebnih za izplačilo tega zneska (apoenov po
500/200/100/50/20/10/5 eurov, kovancev za 2/1 euro ter kovancev za
50/20/10/5/2/1 centov). Predpostavite lahko, da bo uporabnik vedno vpisal
znesek, ki bo imel največ dve decimalni mesti.

# Analiza rešitve problema

## Namen in zahteve naloge

*Naloga od nas zahteva izdelavo programa ki bo določen znesek v evrih razdelil
tako, da bomo lahko videli koliko posameznih bankovcev oz. kovancev in katerih
potrebujemo, da sestavimo enak znesek.*

-   *Vnos zneska v evrih.*

-   *Posredno, preverjanje če je število manjše od 0,*

-   *Izračun količine denarnih enot za določeno vrednost*

-   *Izpis koliko in katerih denarnih enot potrebujemo za tak znesek.*

## Vhodi

*Vhod je količina denarja na 2 decimalki natančno.*

## Izhodi

*Izhod pa je koliko in katerih denarnih enot potrebujemo za tako vrednost.*

## Omejitve

*Program je omejen na operiranje z realnimi števili večjimi od 0.*

# Načrt rešitve problema

Najprej moramo uporabnika povprašati po količini denarja ki ga hoče razstaviti
na denarne enote. Nato to količino pretvorimo na celi del in decimalni del ter
decimalni del množimo z 100 da dobimo celo število. S tem smo dobilo celo
število evrov in celo število centov določenega zneska. Najprej izračunamo
denarne enote za celi del to pomeni evre. To naredimo tak da najprej uporabimo
celoštevilčno deljenje za določeno vsoto delimo pa ga z količino tiste ene
denarne enote v katero ga hočemo razstaviti. Nato to isto količino delimo še z
načinom pri katerem dobimo ostanek. Ostanek bomo uporabili pri nadaljnjem
računanju za druge denarne enote. Pravilno število denarnih enot pa je rezultat
pri celoštevilčnem računanju. Ta postopek ponovimo za vse ostale denarne enote
le da moramo paziti da za decimalni del uporabimo decimalni del ki smo ga prej
množili z 100 zato morajo biti tudi sedaj deljenja za decimalni del deljena z
vrednostjo določene denarne enote krat 100 npr. 0,05evrov\*100 = 5 da dobimo
število denarnih enot za 5centov. Program mora tudi pregledati če je vnesen
znesek z strani uporabnika večji ali enak 0 saj ni logično da bi razstavljali
negativno vrednost.

``` python
READ znesek

IF znesek \>= 0 THEN

	SET evri // Pretvorimo decimalno število v celo število tako da mu odrežemo
	decimalni del
	SET centi = (znesek – evri)\100 // Pretvorimo decimalni del v celo število
	SET kolicinaApoenov = 0
	SET ostanek = 0
	SET kolicinaApeonov = evri / 500
	SET ostanek = evri % 500
	SET evri ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = evri / 200
	SET ostanek = evri % 200
	SET evri = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = evri / 100
	SET ostanek = evri % 100
	SET evri = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = evri / 50
	SET ostanek = evri % 50
	SET evri = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = evri / 20
	SET ostanek = evri % 20
	SET evri = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = evri / 10
	SET ostanek = evri % 10
	SET evri = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = evri / 5
	SET ostanek = evri % 5
	SET evri = ostane
	PRINT kolicinaApoenov
	SET kolicinaApeonov = evri / 2
	SET ostanek = evri % 2
	SET evri = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = evri / 1
	SET ostanek = evri % 1
	SET evri = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = centi / 50
	SET ostanek = centi % 50
	SET centi = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = centi / 20
	SET ostanek = centi % 20
	SET centi = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = centi / 10
	SET ostanek = centi % 10
	SET centi = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = centi / 5
	SET ostanek = centi % 5
	SET centi = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = centi / 2
	SET ostanek = centi % 2
	SET centi = ostanek
	PRINT kolicinaApoenov
	SET kolicinaApeonov = centi / 1
	SET ostanek = centi % 1
	SET centi = ostanek
	PRINT kolicinaApoenov

ELSE
	PRINT Napaka
ENDIF
```
