<p align="center">
  <img width="250" height="150" src="media/feri_logo.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Avtor:** Primož Ratej Cvahte

# **Naloga:** 11./II - naloga – Animacija kvadratni semafor

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

Izdelajte algoritem, ki bo prebral uporabniško vpisano vrednost v velikosti med
4 in 20 (vključno s tema dvema vrednostma). Če uporabnik vpiše liho število naj
ga program opozori, da mora biti vpisano sodo število (algoritem to počne tako
dolgo, dokler uporabnik ne vpiše sode vrednosti).  

Algoritem nato vertikalno izriše tri polne bele kvadrate (enega pod drugim).
Robovi stranic kvadratov naj bodo modri. Velikost stranice kvadrata je vrednost,
ki jo je na začetku vpisal uporabnik.  
Uporabniku se nato ponudi seznam za izbiro nadaljnjih akcij (pri izpisu seznama
uporabniku ne izpisujte opisov, ki so podani zraven akcij):

-   Rdeči semafor (opis: vsebina prvega kvadrata je obarvana rdeče, pri ostalih
    dveh je vsebina bela)

-   Rumeni semafor (opis: vsebina drugega kvadrata je obarvana rumeno, pri
    ostalih dveh je vsebina bela)

-   Zeleni semafor (opis: vsebina tretjega kvadrata je obarvana zeleno, pri
    ostalih dveh je vsebina bela)

-   Utripaj (opis: na drugem kvadratu se vsako sekundo zamenja vsebina kvadrata
    - zamenjujeta se rumena in bela barva)

-   Konec (opis: algoritem se zaključi)

Ob vpisu oznake/niza ("Rdeca", "Rumena" ali "Zelena") se uporabniku izriše nov
semafor kjer se ustrezen kvadrat obarva v izbrani barvi. Če uporabnik vpiše
"Utripaj", se naj trikrat izriše zaporedje rumena-bela. Če uporabnik vpiše
"Konec" se algoritem zaključi.

# Analiza rešitve problema

## Namen in zahteve naloge

*Naloga od nas zahteva izdelavo programa, ki nam bo omogočal izris prometnega
semaforja v obliki kvadrata iz zvezdic z modrim robom. Semafor bo spreminjal
barvo kot pravi semafor.*

-   *Program uporabnika povpraša po velikosti semaforja.*

-   *Izris semaforja z modrim robom velikosti, ki jo je vnesel uporabnik.*

-   *Ob nepravilnem vnosu program javi napako Pravilen vnos: (x je element
    [4-20], x je sodo število).*

-   *Program ponudi uporabniku možnosti rdeči, zeleni, rumeni semafor animacijo
    utripanja ter zaključitev programa.*

-   *Program se ponavlja tako dolgo dokler ga uporabnik ne zaključi.*

## Vhodi

-   *Cela števila ter nizi znakov.*

## Izhodi

*Izris semaforja v obliki zvezdic ter različne vrste semaforjev, če uporabnik to
od nas zahteva.*

## Omejitve

*Vpis velikosti (število): Program je omejen na operiranje z celimi števili*

*Vpis vrste semaforja (znaki): Program ni omejen ker ob nepravilnem vnosu niza
javi napako, če predpostavljamo da niz ni prazen.*

# Načrt rešitve problema

**Glavni program:**

Na začetku povpraša uporabnika po velikosti semaforja, če vnos ni pravilen
program javi napako in uporabnika tako dolgo povprašuje po številu dokler vnos
ni pravilen. Potem izriše obliko kvadratnega semaforja kjer je ena lučka takšne
velikosti kot jo je vpisal uporabnik. Nato nam program ponudi možnosi za izris
zelenega, rumenega, rdečega ali utripajočega semaforja. Ponudi pa nam tudi
možnost za zaključitev programa. Če uporabik vpiše Zeleni se mu bo na zaslon
prikazal semafor na katerem bo gorela zelena luč prav tako za rumeni in rdeč
semafor. Pri utripajočem kvadratu pa se izrisujeta beli in rumen vendar se
izmenjujeta vsako sekundo izmenjata pa se 3x. Če vpisan niz ni pravilen program
javi napako in uporabnika spet povpraša po tem kakšen semafor se naj izpiše.
Program to počne tako dolgo dokler ga uporabnik ne prekine z vnosom niza
»Konec«.

**Metoda za izris semaforja:**

Metoda nam izriše kvadrat velikosti kot jo je vpisal uporabnik vendar moramo
narediti kvadrat z modrim robom to pomeni da je zgornja in spodnja vrstica
kvadrata modra ter vsaka prva in zadnja zvezdica v vrstici. Ko enkrat izrišemo
kvadrat ta Izpis ponovimo 3x zaradi tega ker ima semafor 3 lučke.

Sedaj pa moramo še upoštevati, da bo uporabnik lahko izbral katera lučka bo
gorela. Na primer, če bo uporabnik izbral zeleno barvo se mu bo v tretjem
kvadratku vse notranje zvezdice obarvale zeleno. To naredimo tako, da preverjamo
kdaj bo program izpisoval 3tji kvadratek in ko ga bo izpisoval bo barva zvezdic
nastavljena na zeleno. Isti pristop uporabimo za izris drugih barv.

Psevdokode

``` python
PROCEDURE Semafor( dolžinaKvadrata, barva)
FOR sem = 1 TO 3 DO
SET vrstica = 1
	FOR a = 0 TO dolzinaKvadrata DO
		IF vrstica = 1 THEN // barva znakov v konzoli se tukaj spremeni v modro
			FOR u = 0 TO dolzinaKvadrata DO PRINT (˝\˝)
				u = u+1
			END FOR
		END IF
			IF vrstica NOT 1 AND vrstica NOT dolzinaKvadrata THEN
			PRINT ˝\˝
			FOR g = 0 TO dolzinaKvadrata-2 DO
				IF barva = 3 AND sem = 3 THEN
					// Nastavi barvo znakov konzolskega okna na ZELENO
				ELSE IF  barva = 2 AND sem = 2 THEN
					// Nastavi barvo znakov konzolskega okna na RUMENO
				END IF
				ELSE IF barva = 1 AND sem = 1 THEN
					// Nastavi barvo znakov konzolskega okna na RDEČO
				END IF
				ELSE // Nastavi barvo znakov konzolskega okna na BELO
				END IF
				PRINT  ˝\˝
				g = g+1
			END FOR
			// Nastavi barvo znakov konzolskega okna na MODRO
			PRINT  ˝\˝
			// skok v novo vrsto.
			END IF
		IF vrstica = dolzinaKvadrata THEN
		// Nastavi barvo znakov konzolskega okna na MODRO
		FOR u= 0 TO dolzinaKvadrata
			PRINT ˝\˝
			u = u+1
		END FOR
			// skok v novo vrsto
		END IF
		vrstica = vrstica +1
		a = a+1
	END FOR
sem = sem+1
// skok v novo vrsto
sem = sem+1
END FOR
END PROCEDURE

PROCEDURE MAIN
SET velikost = 0
WHILE true DO
	PRINT "Vpiši velikost kvadrata, ki bo soda in bo vrednost med 4 in 20"
	READ velikost
	IF velikost % 2 = 0 AND velikost \>=4 AND velikost \<=20  THEN 
		break
	ELSE 
		PRINT "Napaka"
	END IF
END WHILE
Semafor(velikost,0)
WHILE  true DO
	// Nastavi barvo znakov v konzolskem oknu na belo
	PRINT  "----Možnosti semaforja----"
	PRINT  "--Rdeči semafor (Rdeci)---"
	PRINT  "--Zeleni semafor (Zeleni)-"
	PRINT  "----Rumeni (Rumeni)-------"
	PRINT  "----Utripaj (Utripaj)-------"
	PRINT  "------Konec (Konec)-------"
	READ vrsta
	IF vrsta = "Rdeci" THEN
		Semafor(velikost,1)
	ELSE IF vrsta = "Zeleni" THEN
		Semafor(velikost,3)
	END IF
	ELSE IF vrsta = "Rumeni" THEN
		Semafor(velikost,2)
	END IF
	ELSE IF vrsta = "Utripaj" THEN
		Semafor(velikost,2)
	FOR i = 0 TO 3 DO
		//Ustavi Program za 1000 milisekund
		Semafor(velikost,0)
		//Ustavi Program za 1000 milisekund
		Semafor(Velikost,2)
		I=i+1
	END FOR
		Semafor(Velikost,0)
	END IF
	ELSE IF vrsta = "Konec" THEN
		break
	END IF
	ELSE PRINT "Napaka"
	END IF
END WHILE
END PROCEDURE

```

# Testni primeri

| **Testni scenariji za števila** (predpostavljamo da so vhodi cela števila) | **Rezultat (pričakovani izhodi)** | **Opomba (opcijsko)**               |
|----------------------------------------------------------------------------|-----------------------------------|-------------------------------------|
| 4                                                                          | Izris pravilen                    | Spodnja meja                        |
| 20                                                                         | Izris pravilen                    | Zgornja meja                        |
| 3                                                                          | Javi napako                       | Pod spodnjo mejo                    |
| 21                                                                         | Javi napako                       | Nad zgornjo mejo                    |
| 5                                                                          | Javi napako                       | Je med mejama vendar ni deljiv z 2. |
| 8                                                                          | Izris pravilen                    | Med mejama                          |
| -5                                                                         | Javi napako                       | Pod spodnjo mejo                    |

| **Testni scenariji za nize** | **Rezultat (pričakovani izhodi)** | **Opomba (opcijsko)**                              |
|------------------------------|-----------------------------------|----------------------------------------------------|
| »Zeleni«                     | Izris pravilen                    |                                                    |
| »Rumeni«                     | Izris pravilen                    |                                                    |
| »Rdeci«                      | Izris pravilen                    |                                                    |
| Izris pravilen               | Izris pravilen                    |                                                    |
| »Utripaj«                    | Animacija pravilna                |                                                    |
| -5                           | Javi napako                       |                                                    |
| »rumeni«                     | Javi napako                       | Javi napako zato ker »rumeni« ni isto kot »Rumeni« |
| Ne vpišemo ničesar           |  Javi napako                      | Prazen niz ne ustreza                              |
