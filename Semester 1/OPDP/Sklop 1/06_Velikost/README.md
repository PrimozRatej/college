<p align="center">
  <img width="250" height="150" src="media/9df5055488fae6703a7a88740516d4ee.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Ime:** Primož

**Priimek:** Ratej Cvahte

# **Naloga:** 6. Velikost

**Vsebina:**


[1. Besedilo naloge 2](#besedilo-naloge)

[2. Analiza rešitve problema 2](#_Toc433146828)

[2.1. Namen in zahteve naloge 2](#_Toc433146829)

[2.2. Vhodi 2](#_Toc433146830)

[2.3. Izhodi 2](#izhodi)

[2.4. Omejitve 2](#omejitve)

[3. Načrt rešitve problema 3](#_Toc433146833)

# Besedilo naloge

Izdelajte postopek, ki bo določil drugo najvišjo osebo (uporabnik vnese
velikosti štirih oseb v centimetrih). Če je katera izmed vpisanih vrednosti
manjša od 48, naj se izpiše opozorilo o prekoračitvi spodnje mejne vrednosti. V
tem primeru se naj druge najvišje velikosti osebe ne izpiše. V kolikor sta
vneseni vsaj dve velikosti, ki sta višji od 251, naj se izpiše obvestilo o
napaki.  
Postopek naj na začetku prečita štiri vrednosti in na koncu izpiše ali drugo
najvišjo osebo ali opozorilo ali pa obvestilo o napaki.

# Analiza rešitve problema

## Namen in zahteve naloge

Izdelava programa, ki nam bo izpisal drugo najvišjo osebo na podlagi primerjanja
med ostalimi štirimi osebami katere bo vnesel uporabnik, ter bo v primeru
napačnih vnosov vrnil obvestilo o napaki.

-   Vnos višin štirih oseb.

-   Preverjanje če je katera oseba manjša od 48cm v tem primeru program javi
    napako.

-   Preverjanje ali sta od štirih oseb dve osebi višji od 251cm v tem primeru
    javi napako.

-   Določitev druge najvišje osebe.

-   Izpis druge najvišje osebe.

## Vhodi

*Vhodi so višine štirih oseb v cm.*

## Izhodi

*Izhod je višina druge najvišje osebe izmed štirih v cm.*

## Omejitve

*Program je omejen na operiranje z realnimi števili.*

# Načrt rešitve problema

*Najprej uporabnika povprašamo po višinah štirih različnih oseb. Nato preverimo
ali je katera vpisana višina manjša od 48cm, če je program javi da smo
prekoračili spodnjo mejo vrednosti. Nato spet preverimo, če sta od štirih višin
dve višini takšni ki sta večji od 251 to naredimo s primerjanjem npr. oseba1 je
večja od 251 in oseba2 je večja od 215 nato tako primerjamo vse osebe z vsako
rezen same sabo. V primeru da se pojavita 2 višini, ki sta večji od 215 program
javi napako, če pa se izkaže, da so bili vsi podatki vneseni pravilno program
začne z izločanjem druge najvišje osebe. To naredimo tako da predpostavljamo, da
je vedno ena oseba višja od druge vendar sta pa ostali dve manjši npr. oseba1 je
manjša od osebe2 vendar je večja od oseb 3 in 4 vendar moramo paziti da pri tem
zavzamemo vse možne kombinacije. Na koncu program izpiše drugo najvišjo osebo.*

**READ** oseba1, oseba2, oseba3, oseba4

**IF** oseba1\>=48 **AND** oseba2\>=48 **AND** oseba3\>=48 **AND** oseba4\>=48
**THAN**

**IF** oseba1\>251 **AND** oseba2\>251 **OR** oseba1\>251 **AND** oseba3\>251
**OR** oseba1\>251 **AND** oseba4\>251 **OR** oseba2\>251 **AND** oseba3\>251
**OR** oseba2\>251 **AND** oseba4\>251 **OR** oseba3\>251 **AND** oseba4\>251
**THAN**

**PRINT** napaka

**ELSE**

**IF** oseba1\<oseba2 **AND** oseba1\>oseba3 **AND** oseba1\>oseba4 **OR**
oseba1\>oseba2 **AND** oseba1\<oseba3 **AND** oseba1\>oseba4 **OR**
oseba1\>oseba2 **AND** oseba1\>oseba3 **AND** oseba1\<oseba4 **THAN**

**PRINT oseba1**

**END IF**

**IF** oseba2\<oseba1 **AND** oseba2\>oseba3 **AND** oseba2\>oseba4 **OR**
oseba2\>oseba1 **AND** oseba2\<oseba3 **AND** oseba2\>oseba4 **OR**
oseba2\>oseba1 **AND** oseba2\>oseba3 **AND** oseba2\<oseba4 **THAN**

**PRINT oseba2**

**END IF**

**IF** oseba3\<oseba1 **AND** oseba3\>oseba2 **AND** oseba3\>oseba4 **OR**
oseba3\>oseba1 **AND** oseba3\<oseba2 **AND** oseba3\>oseba4 **OR**
oseba3\>oseba1 **AND** oseba3\>oseba2 **AND** oseba3\<oseba4 **THAN**

**PRINT oseba3**

**END IF**

**IF** oseba4\<oseba1 **AND** oseba4\>oseba2 **AND** oseba4\>oseba3 **OR**
oseba4\>oseba1 **AND** oseba4\<oseba2 **AND** oseba4\>oseba3 **OR**
oseba4\>oseba1 **AND** oseba4\>oseba2 **AND** oseba4\<oseba3 **THAN**

**PRINT oseba4**

**END IF**

**END IF**

**ELSE**

**PRINT** Prekoračitev spodnje meje

**END IF**
