<p align="center">
  <img width="250" height="150" src="media/feri_logo.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Avtor:** Primož Ratej Cvahte

# **Naloga:** Naloga 8/III – Evidenca zaposlenih

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

Izdelajte program, ki bo prebral naslednje podatke največ 10 zaposlenih:

-   delovna številka (tipa: [M | Ž][18-80][0-9][0-9][0-9]) - niz znakov  
    Primer: Ž22879 -> spol = Ž, starost = 22, ID1 = 8, ID2 = 7, ID3 = 9,

-   priimek - niz znakov,

-   ime - niz znakov,

-   ter delovna doba (interval: [0 - 65]) - celo število.

Program naj ob vnosu preverja pravilnost vpisanih podatkov.

Na koncu naj program izpiše:

1. Podatke najstarejšega zaposlenega (v primeru, da jih je več, se izpiše vse,
ki si delijo najvišjo starost)

2. Podatke zaposlenega, ki ima najmanjšo delovno dobo (v primeru, da jih je več
takih, ki si delijo najmanjšo delovno dobo, se med temi izpiše samo tiste za
katere velja pogoj ID1 < 7 && ID2 < 7 && ID3 < 7)

3. Celoten seznam zaposlenih (vseh njihovih podatkov), urejen naraščajoče po
(slovenski) abecedi njihovih imen in priimkov. Urejanje izvedite najprej po
imenih, v primeru enakih imen, pa še po priimku. Pri urejanju upoštevajte vse
črke imena in priimka (ne samo prve črke).

Načrtujte ustrezno podatkovno strukturo (strukture) za hrambo podatkov
zaposlenih

# Analiza rešitve problema

## Namen in zahteve naloge

*Namen naloge je izdelati ustrezno strukturo v obliki polja za hranjenje
podatkov o zaposlenih. Naloga tudi zahteva izdelavo nekaj podprogramov, s
katerimi bomo nadzorovali obnašanje strukture ter prikazovali rezultate na
zaslon kot nam ga določajo navodila.*

*Zahteve:*

-   *Struktura v obliki polja v katero bomo hranili podatke o zaposlenih(ime,
    priimek, starost…) maksimalno 10 zaposlenih lahko manj.*

-   *Podprogram za izpis zaposlenih, ki si delijo najvišji starost.*

-   *Podprogram za izpis zaposlenega/ih z najmanjšo delovno dobo katera se bo
    držala omejitev iz navodil.*

-   *Podprogram za izpis vseh zaposlenih v strukturi urejeni naraščajoče po
    slovenski abecedi, najprej po imenu v primeru enakih imen še po priimku.*

## Vhodi

*Za delovanje strukture mora uporabnik vpisati Ime [niz znakov], Priimek [niz
znakov], starost [celo število],spol [niz znakov], ID1[celo število], ID2[celo
število], ID3[celo število], delovna doba [celo število].*

## Izhodi

*Izhodi programa so rezultati operacij podprogramov zapisanih v zahtevah
naloge.*

## Omejitve

*Program nima omejitev glede vhodnih podatkov če predpostavljamo, dabo uporabnik
vnesel podatke,in da bo uporabnik za določeno zahtevo vnesel pravilno vrsto
podatka(celo število, niz znakov…).*

*Struktura pa je omejena na Vpis maksimalno 10 zaposlenih (lahko manj).*

# Načrt rešitve problema

*Problema se bomo lotili z strukturiranim pristopom programiranja. Zaradi
hranjenja podatkov za več oseb bomo uporabili polje strukture v katerih bomo
hranili podatke o zaposlenih in jih z določenimi podprogrami urejali. Z stališča
lepega programiranja je program razdeljen na 5 podprogramov ki pripadajo
strukturi in 3 podprograme ki so namenjeni za splošno rabo in jih potrebujemo za
pravilno delovanje podprogramov v strukturi.*

*Struktura:*

| **Ime**     | **Vidnost** | **Opis**                                                 |
|-------------|-------------|----------------------------------------------------------|
| *Zaposleni* | *Javna*     | *Struktura z osmimi komponentami in petimi podprogrami.* |

*Komponente strukture :*

| **Komponenta**     | **Vidnost** | **Opis**                                                    |
|--------------------|-------------|-------------------------------------------------------------|
| *Delovna številka* | *Javna*     | *Sestavljena iz večih vrednosti (spol+starost+ID1+ID2+ID3)* |
| *Ime*              | *Javna*     | *Predstavlja ime zaposlenega*                               |
| *Priimek*          | *Javna*     | *Predstavlja priimek zaposlenega*                           |
| *Delovna doba*     | *Javna*     | *Predstavlja delovno dobo zaposlenega*                      |
| *Starost*          | *Javna*     | *Predstavlja starost zaposlenega*                           |
| *ID1*              | *Javna*     | *Predstavlja del delovne številke*                          |
| *ID2*              | *Javna*     | *Predstavlja del delovne številke*                          |
| *ID3*              | *Javna*     | *Predstavlja del delovne številke*                          |

*Seznam podprogramov v strukturi:*

| **Podpis**                                                               | **Vidnost** | **Opis**                                                                                                           |
|--------------------------------------------------------------------------|-------------|--------------------------------------------------------------------------------------------------------------------|
| **Procedure** *VpisZaposlenih(Zaposleni[] poljeZaposlenih)*              | *Javna*     | *Ta podprogram nam omogoča vpis zaposlenih v polje v prazno polje strukture in preverja pravilnost vpisa.*         |
| **Procedure** *IzpisNajstarejsegaZaposlenega(Zaposleni[]poljeZaposleni)* | *Javna*     | *Ta podprogram nam omogoča izpis najstarejšega zaposlenega oz. več zaposlenih če si delijo najvišjo starost.*      |
| **Procedure** *NajmanjšaDelovnaDoba(Zaposleni[]poljeZaposlenih)*         | *Javna*     | *Ta podprogram nam omogoča izpis zaposlenega oz. zaposlenih če si osebe delijo najvišjo delovno dobo.*             |
|  *Zaposleni[] sortiranje(Zaposleni[]poljeZaposlenih)*                    | *Javna*     | *Ta podprogram nam celotno polje struktur uredi naraščajoče po abecedi za imena in priimke v primeru enakih imen.* |
| **Procedure** *IzpisVsehZaposlenih(Zaposleni[]poljeZaposlenih)*          | *Javna*     | *Ta podprogram nam celotno polje struktur izpiše od začetka do konca.*                                             |

*Seznam podprogramov v razredu program:*

| **Podpis**                                                        | **Vidnost** | **Opis**                                                                                                                       |
|-------------------------------------------------------------------|-------------|--------------------------------------------------------------------------------------------------------------------------------|
| **Function** *OsebaNajprejPoAbecedi(ime1,ime2,priimek1,priimek2)* | *Javna*     | *Funkcija dobi ime in priimek 2 zaposlenih in vrne celo število, ki nam določa kateri izmed teh 2 oseb je najprej po abecedi.* |
| **Function** *ToLower(beseda)*                                    | *Javna*     | *Funkcija ki nadomesti vse velike črke abecede z malimi.*                                                                      |
| **Function** *BesedaSlovenskeAbecede(beseda)*                     | *Javna*     | *Funkcija ki nam preverja ali so vsi znaki v nizu del slovenske abecede.*                                                      |

**Struktura Zaposlen:**

*V strukturi hranimo podatke o zaposlenem ime, priimek, delovno številko,… V
strukturi uporabljamo metode ki se vežejo na zaposlene.*

*Psevdokod:*
```python
STRUCTURE Zaposlen
	SET DelovnaŠtevilka
	SET Ime
	SET Priimek
	SET DelovnaDoba
	SET starost
	SET ID1
	SET ID2
	SET ID3
	# Psevdokot za metode se nahaja za vsako posebej v dokumentu
	PROCEDURE VpisZaposlenih(Zaposlen[]poljeZaposlenih)
	PROCEDURE IzpisNajstarejšegaZaposlenega(Zaposlen[]poljeZaposlenih)
	PROCEDURE NajmanjšaDelovnaDoba(Zaposlen[]poljeZaposlenih)
	Zaposlen [] Sortiranje(Zaposlen[]poljeZaposlenih)
	PROCEDURE IzpisvsehZaposlenih(Zaposlen[]poljeZaposlenih)
END STRUCTURE
```
**Metode in funkcije strukture zaposleni**

Metoda Vpis zaposlenih:

Metoda za vpis zaposlenih nam omogoča vpis 10 zaposlenih in vse njihove podatke
vhod v metodo je polje zaposlenih. Uporabniku omogočimo vpis zaposlenega metoda
nam tudi preverja če so podatki verodostojni (Kot od nas zahtevajo navodila), če
so jih vpiše v polje drugače vrne uporabniku sporočilo o napaki, če se je
uporabnik zmotil, ko je vpisoval podatke na primer o tretjem zaposlenem mu
program dovoljuje vpis novih zaposlenih od njegove zadnje napake, kar pomeni da
lahko nadaljuje vpis in ponovno vpiše tretjega zaposlenega. V primeru da se
uporabnik odloči in bo vpisal manj kot 10 zaposlenih mu program na koncu vsakega
vpisa zaposlenega to omogoči z vpisom ukaza »KONEC«.

*Psevdokod:*
```python
PROCEDURE VpisZaposlenihZaposlen[] poljeZaposlenih
	# Ta spremenljivka nam predstavlja dolžino polja Zaposleni
	SET dolzinaPoljaZaposleni
	# možen vpis 10 zaposlenih
	FOR i = 0 TO dolzinaPoljaZaposleni DO 
		PRINT "Vpisi ime zaposlenega"
		READ ime
		PRINT "Vpiši priimek zaposlenega"
		READ priimek
		PRINT "Vnesi starost"
		READ starost
		PRINT "Vnesi spol ali moški-M ali ženski-Ž"
		READ spol
		PRINT "Vnesi ID1"
		READ ID1
		PRINT "Vnesi ID2"
		READ ID2
		PRINT "Vnesi ID3"
		READ ID3
		PRINT "Vpiši delovno dobo"
		READ delovnaDoba
		# Program tudi preverja odstopanja glede delovne dobe
		SET najvišjaMožnaDelovnaDoba = starost - 18 
		# Samo če je vpis podatkov pravilen se podatki vpišejo v strukturo in se števec za vpis v naslednjo mesto v strukturi poveča.
		IF (starost >= 18 AND starost <= 80) AND (spol = "M" OR spol =
		"Ž") AND (ID1 >= 0 AND ID1 <= 9) AND (ID2 >= 0 AND ID2 <= 9)
		AND (ID3 >= 0 AND ID3 <= 9) AND (delovnaDoba <=
		najvišjaMožnaDelovnaDoba) AND (Program.BesedaSlovenskeAbecede(ime) = true
		AND Program.BesedaSlovenskeAbecede(priimek) = true) THEN
			poljeZaposlenih[i].Ime = ime
			poljeZaposlenih[i].Priimek = priimek
			poljeZaposlenih[i].DelovnaDoba = delovnaDoba
			poljeZaposlenih[i].starost = starost
			poljeZaposlenih[i].ID1 = ID1
			poljeZaposlenih[i].ID2 = ID2
			poljeZaposlenih[i].ID3 = ID3
			poljeZaposlenih[i].DelovnaŠtevilka = spol + starost + ID1 + ID2 + ID3
			i = i+1 # tukaj preverjamo koliko je bilo pravilnih vpisov in povečujemo kazalec
			# Drugače se nepravilen vpis ne upošteva in ima uporabnik možnost nadaljevanja tam kjer se je zmotil.
		ELSE #Izpis napake pri vpisu
			PRINT "Napaka pri vpisu"
			CONTINUE
		END IF
		PRINT "Za zaključek vpisovanja vpiši KONEC drugače enter"
		READ odlocitev
		IF odlocitev = "KONEC" THEN BREAK END IF
	END FOR
END PROCEDURE
```

Metoda Izpis najstarejšega zaposlenega:

Metoda za izpis najstarejšega zaposlenega prejme polje strukture zaposlenih in
na začetku nastavi najstarejšo vrednost na starost prvega zaposlenega v
strukturi. Nato v zanki preverja vse zaposlene in najstarejši vrednosti v
primeru da je najstarejša vrednost manjša od vrednosti, ki jo program trenutno
gleda priredi to vrednost kot najmanjšo. Na izpiše vse zaposlene, katerim
pripada ta največja vrednost.

*Psevdokod:*
```python
PROCEDURE IzpisNajstarejšegaZaposlenega(Zaposlen[] zaposleni)
	# Ta spremenljivka predstavlja vrednost dolžine polja Zaposleni
	SET dolzinaPoljaZaposleni
	SET najstarejšVrednost = zaposleni[0].starost
	#V tej zanki išče najmanjšo vrednost
	FOR i = 0 TO < dolzinaPoljaZaposleni - 1 
		# Pogoj za najmanjšo vrednost
		IF najstarejšVrednost < zaposleni[i].starost THEN 
			najstarejšVrednost = zaposleni[i].starost
		END IF
		i = i+1
	END FOR
	# Z zanko gremo čez celo polje
	FOR i = 0 TO dolzinaPoljaZaposleni 
		# In izpišemo vse zaposlene ki si delijo najstarejšo vrednost
		IF zaposleni[i].starost = najstarejšVrednost THEN
			PRINT zaposleni[i].DelovnaŠtevilka+" "+zaposleni[i].Ime + " " +
			zaposleni[i].Priimek+"
			"+zaposleni[i].starost+" "+zaposleni[i].DelovnaDoba
		END IF
		i = i+1
	END FOR
END PROCEDURE
```

Metoda Izpis zaposlenih z najmanjšo delovno dobo:

Metoda za izpis zaposlenih z najmanjšo delovno dobo najprej poišče katera je
najmanjša delovna doba. Nato preverja koliko zaposlenih je takšnih katerim
pripada najmanjša delovna doba, če je zaposlen samo eden ga izpiše, če pa je
takšnih zaposlenih več se program izpiše samo tiste katerih vsi trije IDji so
manjši od 7.

*Psevdokod:*
```python
PROCEDURE NajmanjšaDelovnaDoba(Zaposlen[]zaposleni)
	# ničto delovno dobo nastavimo kot najmanjšo
	SET najmanjšaVrednostDelovneDobe = zaposleni[0].DelovnaDoba
	SET dolzinaPoljaZaposleni # predstavlja dolžino polja zaposlenih
	FOR i = 0 TO dolzinaPoljaZaposleni - 1 DO # iščemo najmanjšo delovno dobo
		# preverjamo da program gleda samo vpisane osebe
		IF (najmanjšaVrednostDelovneDobe >
		zaposleni[i].DelovnaDoba)AND(zaposleni[i].Ime != null) THEN
			najmanjšaVrednostDelovneDobe = zaposleni[i].DelovnaDoba
		END IF
		i = i+1
	END FOR
	SET števecMINdelovnaDoba = 0
	FOR i = 0 TO dolzinaPoljaZaposleni DO # Preverimo koliko je
		zaposlenih z isto delovno dobo
		IF zaposleni[i].DelovnaDoba = najmanjšaVrednostDelovneDobe THEN
			števecMINdelovnaDoba = števecMINdelovnaDoba+1
		END IF
		i = i+1
	END FOR
	IF števecMINdelovnaDoba = 1 THEN # če je samo en tak tega izpišemo
		FOR j = 0 TO dolzinaPoljaZaposleni - 1 DO
		IF (zaposleni[j].DelovnaDoba =
		najmanjšaVrednostDelovneDobe)AND(Zaposleni[j].Ime NOT null) THEN
			PRINT zaposleni[j].DelovnaŠtevilka + " " + zaposleni[j].Ime + " " +
			zaposleni[j].Priimek + " " +zaposleni[j].starost+ " "+ zaposleni[j].DelovnaDoba
		END IF
		j = j+1
		END FOR
	END IF
	# če je več zaposlenih z isto delovno dobo se držimo pravila iz navodil
	IF števecMINdelovnaDoba > 1 THEN
		FOR j = 0 TO dolzinaPoljaZaposleni - 1 DO
			IF (zaposleni[j].DelovnaDoba = najmanjšaVrednostDelovneDobe) AND
			(zaposleni[j].ID1 < 7 AND zaposleni[j].ID2 < 7 AND zaposleni[j].ID3 <
			7) AND(Zaposleni[j].Ime NOT null) THEN
				PRINT zaposleni[j].DelovnaŠtevilka + " " + zaposleni[j].Ime + " " +
				zaposleni[j].Priimek + " " + zaposleni[j].starost + " " +
				+zaposleni[j].DelovnaDoba
			END IF
			j=j+1
		END FOR
	END IF
END PROCEDURE
```

Konstruktor za sortiranje zaposlenih po abecedi:

Konstruktor za sortiranje po abecedi deluje po principu mehurnega urejanja, če
je potrebno v strukturi zamenja zaposlene pomaga si z funkcijo
OsebaNajprejPoAbecedi, ki določi ali je potrebna zamenjava ali ne.

*Psevdokod:*
```python
CONSTRUCTOR Zaposlen[] Sortiranje(Zaposlen[]poljeZaposlenih)
	SET dolzinaPoljaZaposleni # ta spremenjivka predstavlja dolžino polja Zaposleni
	FOR i = 0 TO dolzinaPoljaZaposleni-1 DO #bubble sort za urejanje
		FOR j = i+1 TO dolzinaPoljaZaposleni-1 DO
			IF poljeZaposlenih[j].Ime = null THEN break # prekini ko ni več zaposlenih
				ELSE IF Program.OsebaNajprejPoAbecedi(poljeZaposlenih[i].Ime,poljeZaposlenih[j].Ime,poljeZaposlenih[i].Priimek,poljeZaposlenih[j].Priimek) = 2 THAN
					# če je zamenjava potrebna zamenjaj
					Zaposlen temp = poljeZaposlenih[i]
					poljeZaposlenih[i] = poljeZaposlenih[j]
					poljeZaposlenih[j] = temp
				END IF
			END IF
			j = j+1
		END FOR
		i = i+1
	END FOR
	RETURN poljeZaposlenih
END CONSTRUCTOR
```
Metoda izpis vseh zaposlenih:

Metoda za izpis vseh zaposlenih samo izpiše v zanke vse zaposlene od začetka do
konca in da ne izpiše nevpisanih vrednosti.

*Psevdokod:*
```python
PROCEDURE IzpisvsehZaposlenih(Zaposlen[]poljeZaposlenih)
	SET dolzinaPoljaZaposleni # Ta spremenljivka nam predstavlja dolžino polja
	Zaposleni
	FOR i = 0 TO dolzinaPoljaZaposleni DO # izpis v zanki
		IF poljeZaposlenih[i].Ime = null break END IF # ko pride do nevpisane vrednosti prekini
		PRINT poljeZaposlenih[i].DelovnaŠtevilka + " " + poljeZaposlenih[i].Ime +"
		"+ poljeZaposlenih[i].Priimek + " " + poljeZaposlenih[i].starost + " " +
		+poljeZaposlenih[i].DelovnaDoba
		i = i+1
	END FOR
END PROCEDURE
```

**Metode in funkcije razreda Program**

Funkcija oseba najprej po abecedi

OsebaNajprejPoAbecedi je funkcija ki prejme 2 imena in 2 priimka oseb, ki nam
pove katera oseba je po abecedi največja funcija lahko vrne samo 3 rezultate:

[0] = osebi imata enako ime in priimek

[1] = oseba 1 je po abecedi večja

[2] = oseba 2 je po abecedi večja

Ta funkcija je osnova za delovanje metode v strukturi OsebaNajprejPoAbecedi

Razlaga:

Najprej preverimo katera beseda je po dolžini večja ter tej besedi na koncu za
toliko črk kolikor je manjša pripišemo a-je zaradi tega ker nam program v
nadaljevanju gleda znak po znak in bi lahko v primeru da je del imena oz.
priimka enak nekemu imenu oz. priimku prišlo do napade.

Primer: »Jan« in »Janja«

V tem primeru bi prišlo do izjeme saj je jan krajši od janje vendar bi se imeni
do 3je črke ujemali nato pa bi prišlo do izjeme;

Rešitev: »Janaa« in »Janja« (oba niza sta enake dolžine in beseda ki je krajša
bi bila avtomatsko prej po abecedi kar je pravilno)

Enako naredimo za Priimek in nize zlepimo skupaj uporabimo funkcijo ToLower, ki
smo jo implementirali sami, da preverjamo vedno male črke drugače algoritem nebi
prav sortiral saj so male in velike črke v ASCII tabeli različne in mi bomo
uporabljali male črke. Nato deklariramo niz abeceda ter ter za vsako črko
posebej preverjamo na katerem indexu se nahaja, če je index od črke na istem
mestu v nizu večji od indexa na istem mestu druge besede pomeni da je ta beseda
večja po abecedi.

*Psevdokod:*
```python
FUNCTION OsebaNajprejPoAbecedi(ime1, ime2, priimek1, priimek2)
	SET večjaBeseda = 0
	SET dolzinaimena1 # to predstavlja dolzino imena 1
	SET dolzinaimena2 # to predstavlja dolzino imena 2
	# povečamo besedo, ki je manjša in za toliko kot je manjša dodamo na koncu a-je
	IF dolzinaimena1 > dolzinaimena2 DO
		FOR i = 0 TO dolzinaimena1-dolzinaimena2 DO
			ime2 = ime2 + "a"
			i=i+1
		END FOR
		ELSE IF dolzinaimena1 < dolzinaimena2 DO
			FOR i = 0 TO dolzinaimena2 - dolzinaimena1
				ime1 = ime1 + "a"
				i = i+1
			END FOR
			END IF
		END IF
		# isto kot z imeni naredimo z priimki
		SET dolzinaPriimka1 # to predstavlja dolzino priimka1
		SET dolzinaPriimka2 # to predstavlja dolzino priimka2
		IF dolzinaPriimka1 > dolzinaPriimka2 THEN
		FOR i = 0 TO dolzinaPriimka1 - dolzinaPriimka2 DO
			ime2 = ime2 + "a"
			i = i+1
		END FOR
		ELSE IF dolzinaPriimka1 < dolzinaPriimka2 THEN
			FOR i = 0 TO dolzinaPriimka2 - dolzinaPriimka1 DO
				priimek1 = priimek1 + "a"
				i = i+1
			END FOR
		END IF
	END IF
	# zlepimo imena in priimke
	SET imePriimek1 = ToLower(ime1 + priimek1)
	SET imePriimek2 = ToLower(ime2 + priimek2)
	SET dolzinaImenaInPriimka # predstavlja dolzino zlepljenega niza ime1 in priimek1
	# preverjali bomo po indexis v tem nizu abeceda
	SET abeceda = "abcčdefghijklmnoprsštuvzž"
	SET dolzinaNizaAbeceda # to predstavlja dolžino niza abeceda
	FOR i = 0 TO dolzinaImenaInPriimka DO
		SET vrednostbesede1 = 0
		SET vrednostbesede2 = 0
		FOR j = 0 TO dolzinaNizaAbeceda DO # preverjamo niz po abecedi
			IF imePriimek1[i]=abeceda[j] THEN
				vrednostbesede1 = j # dobimo index od mesta v abecedi
			END IF
			i =i+1
		END FOR
		# isto naredimo za drugo osebo
		FOR j = 0 TO dolzinaNizaAbeceda DO
			IF imePriimek2[i] = abeceda[j] THEN
				vrednostbesede2 = j
			END IF
			j= j+1
		END FOR
		# če je vrednostbesede1 večji od vrednostbesede2 vrnemo 1
		IF vrednostbesede1 < vrednostbesede2 THEN
			večjaBeseda = 1
			break
			# drugače vrnemo 2
			ELSE IF vrednostbesede1 > vrednostbesede2 THEN
				večjaBeseda = 2
				break
			END IF
		END IF
		i = i+1
	END FOR
	#Če je 1. oseba po abecedi večja ne glede po čem program gleda ime,priimek če je po abecedi večja oseba 2 funkcija vrne 2 če pa sta enaki pa vrne 0/
	#oseba1>osebe2 = 1
	#oseba2>osebe1 = 2
	#oseba1=osebi2 = 0
	return večjaBeseda
END FUNCTION
```

Funkcija ToLower

Funkcija ToLower nam omogoča da pretvorimo niz znakov v male črke.

*Psevdokod:*
```python
FUNCTION ToLower(beseda)
	SET malaBeseda = null
	SET dolzinaBesede # predstavlja dolzino besede
	FOR i = 0 TO dolzinaBesede DO # v zanki preverjamo kakšna črka je
		besedaodI = beseda[i]
		# če je beseda med A in Z jo nadomesstimo z isto malo črko
		IF beseda[i]>='A' AND beseda[i]<='Z' THEN
			SET malacrka = beseda[i]
			SET vrednostCrke = # vrednost male črke po ASCII tabeli
			vrednostCrke = vrednostCrke + 32
			malacrka = # pretvorimo v znak nazaj
			malaBeseda = malaBeseda + malacrka
			# če je beseda Č,Ž,Š jo nadomestimo z isto malo črko
		ELSE IF beseda[i]='Č' OR beseda[i]='Š'OR beseda[i]='Ž' THEN
			SWITCH (beseda[i])
				CASE 'Ž':
				malaBeseda = malaBeseda + 'ž'
				break
				CASE 'Š':
				malaBeseda = malaBeseda + 'š'
				break
				CASE 'Č':
				malaBeseda = malaBeseda + 'č'
				break
			END SWITCH
		END IF
			ELSE # če črka ni velika jo samo prepišemo
			malaBeseda = malaBeseda + beseda[i]
		END IF
		i = i+1
	END FOR
	return malaBeseda
END FUNCTION
```

Funkcija Je beseda slovenske abecede

Funkcija preveri če se vsi od znakov v nizu spadajo v slovensko abecedo če
spadajo funcija vrne true če najde enega ki ne spada vrne false.
```python
FUNCTION BesedaSlovenskeAbecede(beseda)
	SET pravilnost = false
	beseda = ToLower(beseda)
	SET dolzinabesede # predstavlja dolzino besede
	SET abc = "abcčdefghijklmnoprsštuvzž"
	SET dolzinaAbc # predstvlja dolzino abc niza
	FOR i = 0 TO dolzinabesede DO
		FOR j = 0 TO dolzinaAbc DO
			pravilnost = false # če znak ni slovenske abecede nastavimo na FALSE
			IF beseda[i] = abc[j] THEN
				pravilnost = true # če je slovenske abecede nastavimo na TRUE
				break
			END IF
			j = j+1
		END FOR
		IF pravilnost = false THEN # V primeru da ni znak slovenske abecede
			tukaj skočimo iz druge zanke
			pravilnost = false
			break
		END IF
		i = i+1
	END FOR
	return pravilnost
END FUNCTION
```
**Glavni Program:**

V glavnem programu ustvarimo polje strukture dolžine 10 zato, da zadovoljimo
pogoju o vpisu 10tih zaposlenih. Nato z funkcijo VpisZaposlenih v polje vpišemo
zaposlene. Zaradi lepšega izgleda izpisa pobrišemo konzolsko okno. Nato
sortiramo polje zaposlenih z metodo za sortiranje in jih izpišemo. Rezultat
celotnega programa na koncu je tudi izpis najstarejšega oz. najstarejših
zaposlenih katere izpišemo z uporabo metode IzpisNajstarejšegaZaposlenega prav
tako izpišemo še zaposlene z najmanjšo delovno dobo. Sortiranje uporabimo pred
vsemi izpisi prav zato, da nam prav vse metode za izpis vrnejo podatke
sortirane.

*Psevdokod:*
```python
PROCEDURE Main
	SET Zaposlen[] poljeZaposlenih #polje zaposlenih dolžine 10
	Zaposlen.VpisZaposlenih(poljeZaposlenih) # Vpis zaposlenih
	# pobrišemo konzolsko okno
	PRINT "Sortiran izpis zaposlenih po abecedi:"
	Zaposlen.Sortiranje(poljeZaposlenih) # sortiramo po abecedi
	Zaposlen.IzpisvsehZaposlenih(poljeZaposlenih)
	# vstavimo presledek vrstice
	PRINT "Izpis najstarejše oseb/e:"
	Zaposlen.IzpisNajstarejšegaZaposlenega(poljeZaposlenih)
	# vstavimo presledek vrstice
	PRINT "Izpis oseb/e z najmanjšo delovno dobo:"
	Zaposlen.NajmanjšaDelovnaDoba(poljeZaposlenih)
	# program ustavimo da se nam ne zapre
END PROCEDURE
```
# Testni primeri

| *Testni scenariji (Vhodi)*                                                                          | *Rezultat (pričakovan izhod)*                                                                    | *Opomba(opcijsko)*                                                                                 |                                                                                                     |
|-----------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------|
| *Ime: Primož* *Priimek: Ratej* *Starost: 20* *Spol: M* *ID1 2:* *ID2 3:* *ID3: 4:* *Delovna doba:2* | *Ime: Jan* *Priimek: Ratej* *Starost: 22* *Spol: M* *ID1 4:* *ID2 5:* *ID3: 7:* *Delovna doba:3* | *Ime: Primož* *Priimek: Kluk* *Starost: 18* *Spol: M* *ID1 2:* *ID2 3:* *ID3: 4:* *Delovna doba:0* | *Ime: Primož* *Priimek: Ratej* *Starost: 20* *Spol: M* *ID1 2:* *ID2 3:* *ID3: 4:* *Delovna doba:2* |
```bash
user@localhost | Sortiran izpis zaposlenih po abecedi:
user@localhost | M22456 Jan Ratej 22 3
user@localhost | M18234 Primož Kluk 18 0
user@localhost | M20456 Primož Ratej 20 2
user@localhost | M20234 Primož Ratej 20 2
user@localhost | Izpis najstarejše oseb/e:
user@localhost | M22456 Jan Ratej 22 3
user@localhost | Izpis oseb/e z najmanjšo delovno dobo:
user@localhost | M18234 Primož Kluk 18 0
```
*Sortiranje pravilno*

*Izpis pravilen*

| *Ime: Primož* *Priimek: Ratej* *Starost: 80* *Spol: M* *ID1 9:* *ID2 9:* *ID3: 9:* *Delovna doba:62* | *Ime: Primož* *Priimek: Ratej* *Starost: 18* *Spol: M* *ID1 1:* *ID2 1:* *ID3: 1:* *Delovna doba:0* |
|------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------|
```bash
user@localhost | Sortiran izpis zaposlenih po abecedi:
user@localhost | M80999 Primož Ratej 80 62
user@localhost | M18111 Primož Ratej 18 0
user@localhost | Izpis najstarejše oseb/e:
user@localhost | M80999 Primož Ratej 80 62
user@localhost | Izpis oseb/e z najmanjšo delovno dobo:
user@localhost | M18111 Primož Ratej 18 0
```
*Vpis pravilen*

*(Robni primer)*

| *Ime: PriWmož* *Priimek: Ratej* *Starost: 80* *Spol: M* *ID1 9:* *ID2 9:* *ID3: 9:* *Delovna doba:62* | *Ime: Primož* *Priimek: Ratej* *Starost: 80* *Spol: M* *ID1 9:* *ID2 12:* *ID3: 9:* *Delovna doba:62* | *Ime: Primož* *Priimek: Ratej* *Starost: 81* *Spol: M* *ID1 9:* *ID2 9:* *ID3: 9:* *Delovna doba:62* |
|-------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|

Program javi napako
```bash command-line
user@localhost | Napake
user@localhost | »W« v imenu
user@localhost | ID1 =12|
user@localhost | Starost 81|
```
