<p align="center">
  <img width="250" height="150" src="media/feri_logo.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Ime:** Primož

**Priimek:** Ratej Cvahte

# **Naloga:** 5. Tehnica

**Vsebina:**

[1. Besedilo naloge 2](#besedilo-naloge)

[2. Analiza rešitve problema 2](#_Toc433790091)

[2.1. Namen in zahteve naloge 2](#_Toc433790092)

[2.2. Vhodi 2](#_Toc433790093)

[2.3. Izhodi 2](#izhodi)

[2.4. Omejitve 2](#omejitve)

[3. Načrt rešitve problema 3](#_Toc433790096)

# Besedilo naloge

Izdelajte postopek, ki bo izračunal skupno in povprečno težo sedmih sadežev. Če
je kateri od sadežev lažji od 85 gramov ali težji od 177 gramov, se takšen sadež
izloči in se v izračunih ne upošteva. Postopek naj na začetku prečita sedem
vrednosti in na koncu izpiše rezultata računanja (v kolikor je to seveda
mogoče).

# Analiza rešitve problema

## Namen in zahteve naloge

*Izdelava programa, ki nam bo omogočala izračun skupne in povprečne teže nekih
sadežev v gramih, takrat ko njihova teža zadovoljujejo določenim omejitvam.*

-   *Vnos sedmih sadežev*

-   *Preverjanje ali so vneseni sadeži težji oz. lažji od predpisane omejitve*

-   *Izračun skupne teže in povprečne teže samo za dovoljene teže sadežev.*

-   *Izpis skupne teže in povprečne teže za dovoljene sadeže.*

## Vhodi

*Vhodi so teže sedmih sadežev v gramih.*

## Izhodi

*Izhoda pa sta skupna in povprečna teža za dovoljene sadeže.*

## Omejitve

*Program je omejen na operiranje z realnimi števili.*

# Načrt rešitve problema

Najprej program povpraša uporabnika po teži sedmih sadežev. Nato preverjamo če
je kateri izmed sadežev lažji od 85 in težji od 177, če se nam zgodi, da kateri
sadež ne ustreza predpisanim kriterijem ga enostavno ne obravnavamo v končen
izračun in ga izpustimo, če pa teža sadeža pravilna klub omejitvam. Izračunamo
seštevek in povprečno težo to naredimo tako, da seštevku oz. vsoti za vsak
pravilni vnos prirejamo vrednost in jo povečujemo. Za povprečno vrednost pa prav
tako pri vsakem pravem vnosu najprej štejemo koliko je bilo pravilnih vnosov in
dobljeno vsoto sadežev delimo s številom pravilno vnesenih sadežev. To ponovimo
za vse sadeže, da dobimo vsoto in povprečno težo prav za vse.
```python
READ sadež1, sadež2, sadež3, sadež4, sadež5, sadež6, sadež7 
SET seštevek = 0
SET povprečnaTeža = 0
SET številoPravilniVnosev = 0
// če je kateri izmed sadežev manjši od od 85 in večji od 177 ga v izračun ne
upoštevamo
// če vnos ustreza izračun povprečne teže in skupne teže za vse sadeže.
IF sadež1 >= 85 IN sadež1 <= 177 DO  
  SET seštevek = seštevek + sadež1
  SET številoPravilnihVnosov++
  SET povprečnaTeza = seštevek / številoPravilnihVnosov
ENDIF
IF sadež2 >= 85 IN sadež2 <= 177 DO
  SET seštevek = seštevek + sadež2
  SET številoPravilnihVnosov++
  SET povprečnaTeza = seštevek / številoPravilnihVnosov
ENDIF
IF sadež3 >= 85 IN sadež3 <= 177 DO
  SET seštevek = seštevek + sadež3
  SET številoPravilnihVnosov++
  SET povprečnaTeza = seštevek / številoPravilnihVnosov
ENDIF
IF sadež4 >= 85 IN sadež4 <= 177 DO
  SET seštevek = seštevek + sadež4
  SET številoPravilnihVnosov++
  SET povprečnaTeza = seštevek / številoPravilnihVnosov
ENDIF
IF sadež5 >= 85 IN sadež5 <= 177 DO
  SET seštevek = seštevek + sadež5
  SET številoPravilnihVnosov++
  SET povprečnaTeza = seštevek / številoPravilnihVnosov
ENDIF
IF sadež6 >= 85 IN sadež6 <= 177 DO
  SET seštevek = seštevek + sadež6
  SET številoPravilnihVnosov++
  SET povprečnaTeza = seštevek / številoPravilnihVnosov
ENDIF
IF sadež7 >= 85 IN sadež7 <= 177 DO
  SET seštevek = seštevek + sadež7
  SET številoPravilnihVnosov++
  SET povprečnaTeza = seštevek / številoPravilnihVnosov
ENDIF
PRINT seštevek, povprečnaTeža // Izpis skupne in povprečne teže za dovoljene sadeže.
```
