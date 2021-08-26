<p align="center">
  <img width="250" height="150" src="media/feri_logo.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Avtor:** Primož Ratej Cvahte

# **Naloga:** 7. Uporaba Pitagorovega izreka

**Vsebina:**

[1. Besedilo naloge](#besedilo-naloge)

[2. Analiza rešitve problema](#_Toc432610658)

[2.1. Namen in zahteve naloge](#_Toc432610659)

[2.2. Vhodi](#_Toc432610660)

[2.3. Izhodi](#izhodi)

[2.4. Omejitve](#omejitve)

[3. Načrt rešitve problema](#_Toc432610663)

# Besedilo naloge

Izdelajte postopek, ki izračuna dolžino hipotenuze pravokotnega trikotnika
(uporabite Pitagorov izrek). Vhodni podatki so dolžine vseh treh stranic (**a**,
**b** in **c**). Postopek naj preveri, ali so vhodni podatki veljavni (večji od
nič) ter če vpisane dolžine stranic res tvorijo trikotnik s pravim kotom. V
primeru napačnih vrednosti vhodnih podatkov ali pa da stranice ne tvorijo
pravokotnega trikotnika naj se namesto rezultata izpiše opozorilo o napaki.

# Analiza rešitve problema

## Namen in zahteve naloge

Namen naloge je izračun hipotenuze v pravokotnem trikotniku, na podlagi vnesenih
podatkov s strani uporabnika in preverjanje pravilnosti o vneseni dolžini
hipotenuze.

-   Vnos dolžine katet a in b.

-   Vnos dolžine hipotenuze.

-   Izračun hipotenuze na podlagi vnesenih dolžin katet.

-   Primerjava pravilnosti hipotenuz med vneseno in izračunano.

-   Ob napaki izpiše opozorilo

-   Pri pravilnih vrednostih izpiše dolžino hipotenuze.

## Vhodi

*Vhodi so dolžine katet a in b ter dolžina hipotenuze c.*

## Izhodi

*Izhod je dolžina hipotenuze c ali pa opozorilo ob napaki za nepravilno vnesene
podatke.*

## Omejitve

*Program je omejen na operiranje z realnimi števili večjimi od 0.*

# Načrt rešitve problema

Program najprej povpraša uporabnika po dolžini treh stranic, katet a in b ter
hipotenuzi c, ter preveri ali so podane stranice veljavne torej če so večje od 0. 
Nato po Pitagorovem izreku (c^2=a^2+b^2) izračuna dolžino hipotenuze ter
primerja to izračunano dolžino z vneseno dolžino, če se izračunana hipotenuza in
vnesena ujemata pomeni da so podatki pravilni in je to res pravokotni trikotnik
potem izpišemo dolžino hipotenuze, če temu ni tako se izpiše opozorilo o
nepravilno vnesenih podatkih.
