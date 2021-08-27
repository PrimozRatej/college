<p align="center">
  <img width="250" height="150" src="media/feri_logo.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Avtor:** Primož Ratej Cvahte

# **Naloga:** Naloga 1/III – Delo z osmiškimi števili

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

Potrebno je implementirati:

1.  podprogram za pretvorbo iz naravnega v osmiško število,

2.  podprogram za pretvorbo iz osmiškega v naravno število,

3.  podprogram za izračun vsote dveh osmiških števil.

Prvi podprogram prejme naravno število in ga pretvori v osmiško število ter ga
vrne [v obliki niza znakov].  
Drugi podprogram prejme osmiško število [v obliki niza znakov], ga pretvori v
naravno število ter ga vrne.  
Tretji podprogram prejme dve osmiški števki [dva niza znakov] ter izračuna in
vrne vsoto teh dveh osmiških števil [v obliki niza znakov].

V glavnem programu boste uporabniku ponudili izbiro podprograma, ki naj se
izvrši. Poskrbite, da bo uporabnik pri posamezni izbiri vpisal samo tisto, kar
izbrani podprogram zahteva (v primeru, da je zahtevan vpis osmiškega števila in
uporabnik vpiše kakšen znak, ki mu ne pripada, naj se izpiše napaka). Rezultat,
ki ga vrne podprogram, v glavnem programu nato izpišite uporabniku.

*Opomba: pri 3. podprogramu, si lahko pomagate z uporabo 1. in 2. podprograma.  
Opomba 2: metod, ki samodejno pretvarjajo števila med posameznimi številskimi
osnovami, ni dovoljeno uporabiti (npr. Convert.ToInt32()). Lahko jih uporabite
samo v primeru, če jih implementirate sami.*

# Analiza rešitve problema

## Namen in zahteve naloge

*Namen naloge je izdelati program, ki bo pretvarjal med dvema številskima
sestavama osmiškim in desetiškim ter še enega, ki bo preverjal ali so v nizu
shranjena res samo števila. Omogočal nam bo tudi lep prikaz možnosti, ki nam jih
program ponuja.*

*Zahteve:*

-   *Podprogram za pretvorbo iz osmiškega v desetiški sistem*

-   *Podprogram za pretvorbo iz desetiškega v osmiški*

-   *Podprogram za preverjanje pravilnosti niza*

## Vhodi

*Vhodi so nizi znakov in cela števila (števila namenjena za pretvorbo).*

-   *10-tiška števila [cela števila]*

-   *Osmiška števila [nizi znakov]*

## Izhodi

Nizi znakov ter cela števila (isto kot pri vhodih).

## Omejitve

Program je omejen na operiranje z pozitivnimi celimi števili (naravna števila).

# Načrt rešitve problema

*Naloga od nas zahteva vsaj 4 podprograme enega za pretvorbo me 10škimi v 8miški
številski sistem in obratno, enega ki bo preverjal pravilnost vpisanih nizov oz.
števil ter še enega ki bo sešteval vsoto dveh osmiških števil.*

*Celoten program si bomo razdelili na probleme in za njih napisali podprograme:*

| **Podpis**                       | **Vidnost** | **Opis**                                                                                                             |
|----------------------------------|-------------|----------------------------------------------------------------------------------------------------------------------|
| *Function* *Iz10v8(število)*     | *Javna*     | *Funkcija prejme celo število in ga pretvori v osmiško število, ter vrne z znakov.*                                  |
| *Function* *Iz8v10(število)*     | *Javna*     | *Funkcija prejme niz znakov, ki predstavlja celo število in ga pretvori v desetiško število, ter vrne celo število.* |
| *Function* *[] števila(število)* | *Javna*     | *Funkcija prejme niz znakov, ki predstavljajo celo število in ga pretvori v števke vrne polje celih števil.*         |
| *Function* *Pow(osnova,stopnja)* | *Javna*     | *Funkcija ki prejme dve celi števili in izračuna potenco nekega števila z neko osnovo.*                              |
| *Function* *SoŠtevila(število)*  | *Javna*     | *Funkcija prejme niz znakov in preveri če so vsa števila v nizu znakov res števila.*                                 |

Funkcija Iz10v8

Funkcija na začetku prejme celo število in preveri če je število različno od nič
potem gre računati osmiško število po postopku drugače izpiše 0. Postopek
računanja osmiškega števila je je ostanek celoštevilčnega deljenja, ko dobimo
ostanke jih v vsakem koraku lepimo skupaj enega za drugim, ko izračunamo pa vse
ostanke in je celo število različno od nič še moramo naš niz znakov obrniti da
dobimo osmiško število v pravem zaporedju.

Psevdokod:
``` python
FUNCTION Iz10v8(število)
	SET osmiškoŠtevilo = null
	SET ostanek = 0
	SET celoštevilo = število
	IF celoštevilo != 0 THEN
		WHILE celoštevilo != 0 DO # računanje ostankov števila ter leplenje nizov skupaj
			ostanek = celoštevilo % 8
			celoštevilo = celoštevilo / 
			osmiškoŠtevilo = osmiškoŠtevilo + ostanek
		END WHILE
		SET obrnjenoŠtevilo = null
		SET dolzinaOsmiskegaStevila # ta spremenljivka predstavlja dolžino niza osmiškega stevila
		FOR i = dolzinaOsmiskegaStevila - 1 TO 0 DO
			#Vendar je zapis v obratnem vrstnem redu zato jih zapišemo od zadaj naprej(obrnemo niz)
			obrnjenoŠtevilo = obrnjenoŠtevilo + osmiškoŠtevilo[i]
			i = i-1
		END FOR
		osmiškoŠtevilo = obrnjenoŠtevilo
	ELSE osmiškoŠtevilo = "0"
		return osmiškoŠtevilo
	END IF
END FUNCTION
```

Funkcija Iz8v10

Funkcija na vhodu prejme niz znakov katerega smo prej preverili če so to res
števila. Niz predstavlja osmiško število. Če želimo osmiško število pretvarjati
ga moramo spremeniti v polje posameznih števk za to število ker ga bomo računali
kot polinom z utežjo 8.

**Pretvorimo število 3037(8) v desetiški (decimalni) sistem X(10)**

-   3037(8) = X(10)

-   3 2 1 0 ..... označimo število mest

-   izraz zapišemo v obliki polinoma:

-   3\***8**3 + 0\***8**2 + 3\***8**1 + 7\***8**0 = 1536 + 24 +7 = 1567

VIR: <http://projekti.gimvic.org/>

Zato število najprej obrnemo in ga nato index po index računamo kot polinom.
Funkcija nam vrne celo število ki predstavlja desetiško število pretvorjenega
osmiškega števila.

Psevdokod:
```python
FUNCTION Iz8v10(število8)
	SET število10 = 0
	SET obrnjenoŠtevilo = null
	SET dolzinaStevila8 # predstavlja dolzino niza osmiškega števila
	FOR i = dolzinaStevila8 - 1 TO 0 DO # najprej število obrnemo da bomo lahko zračunali desetiško po utežeh
		obrnjenoŠtevilo = obrnjenoŠtevilo + število8[i]
		i=i-1
	END FOR
	SET[] polje8števil = števila(obrnjenoŠtevilo) # z funkcijo pretvorimo
	števila v posamezne števke
	SET dolzinaObrnjenoŠtevilo # ta spremenljivka predstavlja dolzino
	obrnjenega stevila
	FOR i = 0 TO dolzinaObrnjenoŠtevilo DO
		število10 = število10 + (polje8števil[i] \ Pow(8, i))
		# nato izračunamo vsoto polinoma ki nastane po utežeh, ki so določene
		i= i+1
	END FOR
	RETURN število10
END FUNCTION
```

Funkcija [] števila

Ta funkcija nam omogoča da pretvorimo število v polje njegovih števk. To
funkcijo potrebujemo če bomo hoteli računati iz osmiškega v desetiško število z
načinom polinoma. Algoritem v zanki vsak znak v nizu shrani kot števko v polje
po vrstnem redu.

Psevdokod:
```python
FUNCTION [] števila(število)
	#Ta funkcija se uporablja da niz znakov premenimo v polje števil za pretvorbo
	SET[] polještevilo # generiramo polje celih števil velikosti enako znakom v nizu število
	SET dolzinaNizaŠtevilo # ta spremenljivka predstavlja dolzino niza število
	FOR i = 0 TO dolzinaNizaŠtevilo DO
		polještevilo[i] = "0"+število[i] # da shranimo niz znakov ne pa celo število
		uporabimo trik
		i = i+1
	END FOR
	RETURN polještevilo
END FUNCTION
```
Funkcija Pow

Funkcija Pow nam predstavlja potenciranje v programu. Vhod sta dve celi števili
osnova in stopnja funkcija pa nam vrne potencirano število. To funkcijo
potrebujemo pri pretvorbi iz osmiškega v desetiški sestav. Rezultat funkcije na
začetku nastavimo na 1 zaradi množenja.V zanko ponovimo tolikokrat kot je
velikost stopnje v zanki pa množimo osnove, če pa vstavimo v funkcijo kot
stopnjo 0 vrne 1.

Psevdokod:
```python
FUNCTION Pow(osnova, stopnja)
	# funkcija za izračun potence nekega števila vrne pa celo število
	SET rezultat = 1
	# začnemo z 1 zaradi množenja ne sme biti 0, ter če pride do potence 0 vrnemo 1 kar je pravilno
	FOR i = 1 TO stopnja DO
		rezultat = rezultat\osnova
		i = i+1
	END FOR
	RETURN rezultat
END FUNCTION
```

Funkcija SoŠtevila

Ta funkcija je logičnega tipa kar pomeni da vrača samo true ali false pove pa
nam, če je niz znakov katerega je uporabnik vpisal res naravno število. Na
začetku nastavimo pravilnost na true. Nato v zanki pregledujemo znak po znak in
ga primerjamo če je manjši znaka od 0 ali večji od znaka 9 se pravilnost nastavi
na false program skoči iz zanke in funkcija vrne vrednost.

Psevdokod:
```python
FUNCTION SoŠtevila(število)
	# funkcija ki nam pove če so vsa števila v nizu res števila 10-tiškega sistema 1-9
	SET pravilnost = true
	SET dolzinaNizaŠtevila # predstavlja spremenljiko dolzine niza število
	FOR i = 0 TO dolzinaNizaŠtevila DO
		IF število[i]\<'0' OR število[i]\>'9' THEN
			pravilnost = false
			break
		END IF
		i = i+1
	END FOR
	return pravilnost
END FUNCTION
```
Glavni program

Na začetku v glavnem programu izrišemo meni možnosti ki jih program ponuja.
Celoten program se izvaja v zanki če se uporabnik odloči zapustiti program vpiše
ukaz KONEC. Za pretvorbo iz desetiški v osmiškega sestav vpišemo ukaz 10in8
program najprej povpraša uporabnika po številu. Nato preveri če, je vpisani niz
res naravno število če ni se izpiše napaka. Drugače pa izpišemo osmiško število,
ki ga izračunamo z funkcijo Iz10v8. Za pretvorbo iz desetiškega je postopek enak
razen kar se zamenja funkcija za pretvorbo (Iz8v10). Za seštevanje 2 osmiških
števil pa se mi ni zdelo potrebno pisanje še ene funkcije ker je postopek zelo
enostaven če si lahko pomagamo z pretvorbo. Najprej uporabnika povprašamo po 2
številih nato s funkcijo preverimo če je vpisani niz res naravno število. Ter
pretvorimo ti dve osmiški števili v desetiška jih seštejemo in nato pretvorimo
nazaj v desetiško število ter ga izpišemo.

Psevdokod:
```python
PROCEDURE MAIN
	# izris menija in njegove možnosti
	PRINT "-----PRETVORNIK MED ŠTEVILSKIMI SESTAVI -----"
	PRINT "-----Iz desetiškega v osmiški ukaz: 10in8 -----"
	PRINT "-----Iz osmiškega v desetiški ukaz: 8in10 -----"
	PRINT "-----Za izracun vsote dveh osmiških števil: sestevanje8in8-"
	PRINT "-----Za zaključitev programa ukaz: KONEC -----"
	PRINT
	"----------------------------------------------------------------------"
	SET ukaz = null
	WHILE ukaz != "KONEC" DO # ob ukazu KONEC se delovanje programa konča
		READ ukaz
		# delovanje programa je logično za naprej Za vsako funcijo posebej preverjamo če so števila v nizu res števila
		SWITCH (ukaz)
			CASE "10in8":
				PRINT "Vpiši desetiško število: "
				READ število10
				IF SoŠtevila(število10) = false THEN 
					PRINT "Napaka"
				ELSE
					SET število10Int = število10
					PRINT "Desetiško število je " + število10 + " njegovo osmiško število je " + Iz10v8(število10Int)
				END IF
				BREAK
			CASE "8in10":
				PRINT "Vpiši osmiško število: "
				READ število8
				IF SoŠtevila(število8) = false THEN 
					PRINT "Napaka"
				ELSE
					PRINT "Osmiško število je " + število8 + " njegovo desetiško število je " +
					Iz8v10(število8)
				END IF
				BREAK
			# pri seštevanju dveh osmiških števil si pomagamo s pretvorbo v desetiško in nazaj v osmiško.
			CASE "sestevanje8in8":
				PRINT "Vnesi prvo osmiško število: "
				READ oct1
				PRINT "Vnesi drugo osmiško število: "
				READ oct2
				SET tempoc12 = oct1 + oct2
				IF SoŠtevila(tempoc12) = false THEN 
					PRINT "Napaka"
				ELSE
					SET prvo10 = Iz8v10(oct1)
					SET drugo10 = Iz8v10(oct2)
					SET rezulta = prvo10 + drugo10
					PRINT "Seštevek osmiških števil " + oct1 + " in " + oct2 + " je " + Iz10v8(rezulta)
				END IF
				break
		END SWITCH
	END WHILE
END PROCEDURE
```

# Testni primeri

| **Testni scenariji (vhodi)**                                                   | **Rezultat(pričakovan izhod)**                        | **Opomba**                                                                                                                                            |
|--------------------------------------------------------------------------------|-------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------|
| »10in8« Vpiši desetiško število: 0                                             | Desetiško število je 0 njegovo osmiško število je 0   | Robni primer za pretvorbo iz 10 v osmiški.                                                                                                            |
| »8in10« Vpiši osmiško število: 0                                               | Osmiško število je 0 njegovo desetiško število je 0   | Robni primer za pretvorbo iz osmiškega v desetiško.                                                                                                   |
|  »sestevanje8in8« Vnesi prvo osmiško število: 0 Vnesi drugo osmiško število: 0 | Seštevek osmiških števil 0 in 0 je 0                  | Robni primer za seštevanje osmiških števil                                                                                                            |
| »10in8« Vpiši desetiško število: -5                                            | Napaka                                                | Napaka negativno število                                                                                                                              |
| 10in8 Vpiši desetiško število: 45                                              | Desetiško število je 45 njegovo osmiško število je 55 |  Preverjeno vir: <http://www.rapidtables.com/convert/number/octal-to-decimal.htm>                                                                     |
| 8in10 Vpiši osmiško število: 46                                                | Osmiško število je 46 njegovo desetiško število je 38 |  Preverjeno vir: <http://www.rapidtables.com/convert/number/octal-to-decimal.htm>                                                                     |
| sestevanje8in8 Vnesi prvo osmiško število: 46 Vnesi drugo osmiško število: 12  | Seštevek osmiških števil 46 in 12 je 60               | 46(8) = 38(10) 12(8)=10(10) 46(8)+12(8)=60(8) 38(10)+10(10)=48(10)  Preverjeno vir: <http://www.rapidtables.com/convert/number/octal-to-decimal.htm>  |
