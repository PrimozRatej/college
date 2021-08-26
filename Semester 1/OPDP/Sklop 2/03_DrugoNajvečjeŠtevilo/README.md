<p align="center">
  <img width="250" height="150" src="media/feri_logo.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Avtor:** Primož Ratej Cvahte

# **Naloga:** 3./II - naloga – Drugo najmanjše število

**Vsebina:**

[1. Besedilo naloge](#besedilo-naloge)

[2. Analiza rešitve problema](#analiza-rešitve-problema)

[2.1. Namen in zahteve naloge](#_Toc368395465)

[2.2. Vhodi](#_Toc368395466)

[2.3. Izhodi](#izhodi)

[2.4. Omejitve](#omejitve)

[3. Načrt rešitve problema](#_Toc368395469)

[4. Testni primeri](#_Toc368395470)

# Besedilo naloge

Izdelajte program, ki bo prebral od 2 do 10 števil in izpisal drugo najmanjše
med njimi. Vnos podatkov lahko predhodno zaključimo z vnosom vrednosti 0
(vrednost 0 pomeni prekinitev nadaljnjega vnašanja podatkov in se ne upošteva
pri določanju drugega najmanjšega števila).  
V primeru, da drugega najmanjšega števila ni mogoče določiti, naj se izpiše
opozorilo o napaki.

# Analiza rešitve problema

## Namen in zahteve naloge

*Naloga od nas zahteva izdelavo programa, ki nam bo omogočal na podlagi vnesenih
števil določi drugo najmanjše število spodnja meja vnesenih števil je 2 zgornja
pa 10 uporabnik lahko prekine vnašanje z vpisom 0 vendar se 0 v izračun ne
upošteva.*

-   *Program uporabnika povpraša po številih.*

-   *Preveri če je bil vpis pravilen.*

-   *Izpiše drugo najmanjše število.*

## Vhodi

-   *Vsa cela števila*

## Izhodi

-   Drugo najmanjše število (Celo število)

-   Ob nepravilnem vnosu napaka

## Omejitve

*Program je omejen na operiranje z celimi števili.*

# Načrt rešitve problema

**Glavni program:**

Na začetku uporabnika povprašamo po 10 številih. Števila vpisuje postopoma. Nato
izračunamo največje in najmanjše število z napisanima funkcijama. Nato nastavimo
drugo najmanjše število na največje. Nato v zanki preverjamo katero je drugo
najmanjše število. Če pa je drugo najmanjše število 0 ali pa hkrati najmanjše
pomeni, da je uporabnik vpisal samo 0 ali pa same enake vrednosti zato ne moremo
izračunati drugega najmanjšega števila in javimo napako.

**Funkcija za izračun najmanjšega števila:**

Najmanjše število v zanki preverjamo z vnesenimi števili in, če je najmanjše
število večje od trenutno obravnavenega števila se mu priredi rednost tega
števila. Funkcija nam vrne najmanjše število.

**Funkcija za izračun najvecjega števila:**

Funkcija deluje isto kot funkcija za najmanjše število razlika je samo ta, da
smo pri funkciji za največje število obrnili pogoj tako, da se številu prireja
največja vrednost.

Psevdokode
``` python
FUNCTION MIN(polje)
	// Funkcija za izračun najmanjšega števila
	SET najmanjseStevilo = polje[0]
	SET dolzinaPolja // Predstavlja vrednost dolžine polja
	FOR i = 0 TO dolzinaPolja - 1 DO
		IF polje[i] = 0 THAN
			BREAK
		END IF
		IF najmanjseStevilo \> polje[i] THAN
			najmanjseStevilo = polje[i]
		END IF
		i = i+1
	END FOR
	// Funkcija vrne najmanjše število
END FUNCTION
// funkcija za izračun najvecjega števila
FUNCTION MAX(polje)
	SET najvecjeStevilo = polje[0]
	SET dolzinaPolja // Predstavlja vrednost dolžine polja
	FOR i = 0 TO dolzinaPolja - 1
		IF polje[i] = 0 THAN
			BREAK
		END IF
		IF najvecjeStevilo \< polje[i] THAN
			najvecjeStevilo = polje[i]
		END IF
		i = i+1
	END FOR
// Funkcija vrne najvecje stevilo
END FUNCTION
PROCEDURE Main
	PRINT "Vpiši 10 števil"
	SET [] polje // kreiramo polje z dolžino 10
	FOR a = 0 TO 9 DO //vpis števila po število
		READ polje[a]
		IF polje[a] = 0 THAN
			break
		END IF
		a = a+1
	END FOR
	//KLICANJE FUNKCIJ
	SET drugoNajmanjseStevilo = MAX(polje) // drugo najmanjše število nastavimo
	na začetku na največje
	SET najmanjseStevilo = MIN(polje)
	// Izračun drugega najmanjšega števila
	FOR a = 0 TO 9 DO
		IF polje[a] = 0 THAN
			break
		ELSE IF polje[a] = najmanjseStevilo THAN
				continue
			END IF
		ELSE IF drugoNajmanjseStevilo \> polje[a] THAN
				drugoNajmanjseStevilo = polje[a]
			END IF
		END IF
		a = a+1
	END FOR
	// če je drugo najmanjše število v tem delu največje število obenem 0 ali pa
	enako najmanjšemu pomeni da ali je uporabnik vpisal samo 0 ali pa samo enake
	vrednosti.
	IF drugoNajmanjseStevilo = 0 OR najmanjseStevilo = drugoNajmanjseStevilo THAN
		PRINT "Napaka" // javi napako
	ELSE
		// Izpis drugega najmanjšega števila če so vnosi pravilni
		PRINT "Drugo najmanjše število je: "+drugoNajmanjseStevilo 
	END IF
END PROCEDURE
```

# Testni primeri

| **Testni scenariji** | **Rezultat (pričakovani izhodi)** | **Opomba (opcijsko)**             |
|----------------------|-----------------------------------|-----------------------------------|
| 0                    | Javi napako                       | Ni vpisanih vrednosti             |
| 1,0                  | Javi napako                       | Samo ena vrednost                 |
| 1,1,1,1,1,1,1,0      | Javi napako                       | Vse vrednosti so enake            |
| 1,2,3,4,5,0          | Pravilno 2                        | Vnos pravilen                     |
| 1,2,3,4,5,6,7,8,9,10 | Pravilno 2                        | Vnos pravilen                     |
| 45,23,78,-5,1,0      | Pravilno 1                        | Vnos pravilen                     |
| -5,-6,-9,5,0         | Pravilno -6                       | Vnos pravilen (Negativna števila) |
