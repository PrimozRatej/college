![Logo, company name Description automatically
generated](media/9df5055488fae6703a7a88740516d4ee.png)

# Od problema do programa (obrazec za vaje)

**Ime:** Primož

**Priimek:** Ratej Cvahte

# **Naloga:** 1. Obseg pravokotnika

**Vsebina:**

  [1. Besedilo naloge 2](#besedilo-naloge)

  [2. Analiza rešitve problema 2](#_Toc80875947)

  [2.1. Namen in zahteve naloge 2](#_Toc80875948)

  [2.2. Vhodi 2](#_Toc80875949)

  [2.3. Izhodi 2](#izhodi)

  [2.4. Omejitve 2](#omejitve)

  [3. Načrt rešitve problema 3](#_Toc80875952)

# Besedilo naloge

Izdelajte postopek, ki bo izračunal obseg pravokotnika. Vhodna parametra sta
dolžini obeh stranic (**a** ter **b**). Postopek naj preveri, ali sta vhodna
podatka veljavna (večja od nič). V primeru vpisa napačnih vhodnih vrednosti naj
namesto rezultata izpiše opozorilo o napaki.

# Analiza rešitve problema

## Namen in zahteve naloge

*Izdelava programa, ki nam bo omogočala izračun obsega pravokotnika na podlagi
dveh sosednjih podanih stranic.*

-   *Vnos stranice a in b*

-   *Preverjanje ali je katera od stranic krajša od 0*

-   *Računanje obsega po enačbi 2a\*2b=p*

-   *Izpis obsega*

## Vhodi

*Vhodi so dve stranici pravokotnika.*

## Izhodi

*Izhod je obseg pravokotnika.*

## Omejitve

*Program je omejen na operiranje z realnimi števili večjimi od 0.*

# Načrt rešitve problema

Najprej program povpraša uporabnika po dolžini stranice a in dolžini stranice b.
Nato z pogojnim stavkom (if) preverimo ali je katera od stranic a in b krajša od
nič, če je pogoj izpolnjen se nam izpiše opozorilo, če pa temu ni tako se izvede
stavek ki je namenjen, za izvedbo takrat, ko v pogojnem stavku pogoji ne
ustrezajo željenemu (else). Tukaj deklariramo novo spremenljivko kateri bomo
priredili vrednost, ki jo bomo dobili z enačbo za obseg pravokotnika. V
naslednjem koraku v stavku izpišemo kolikšen je obseg določenega pravokotnika
ter program omejimo, da se ne ugasne in čaka na odziv uporabnika.

![Diagram Description automatically
generated](media/f45a79978809bde282ba7817dce796d0.jpeg)
