![](RackMultipart20210826-4-1gzojpa_html_a2fd4c31bb03c84a.png)

**# Od problema do programa**

# **(obrazec za vaje)**

**Ime:** Primož

**Priimek:** Ratej Cvahte

**Naloga:** 1. Obseg pravokotnika

**Vsebina**

[1.Besedilo naloge 2](# __RefHeading___ Toc368395463)

[2.Analiza rešitve problema 2](# __RefHeading___ Toc368395464)

[2.1.Namen in zahteve naloge 2](# __RefHeading___ Toc368395465)

[2.2.Vhodi 2](# __RefHeading___ Toc368395466)

[2.3.Izhodi 2](# __RefHeading___ Toc368395467)

[2.4.Omejitve 2](# __RefHeading___ Toc368395468)

[3.Načrt rešitve problema 3](# __RefHeading___ Toc368395469)

[4.Testni primeri **Napaka! Zaznamek ni definiran.**](# __RefHeading___ Toc368395470)

# 1.Besedilo naloge

Izdelajte postopek, ki bo izračunal obseg pravokotnika. Vhodna parametra sta dolžini obeh stranic ( **a**  ter  **b** ). Postopek naj preveri, ali sta vhodna podatka veljavna (večja od nič). V primeru vpisa napačnih vhodnih vrednosti naj namesto rezultata izpiše opozorilo o napaki.

# 2.Analiza rešitve problema

## 2.1.Namen in zahteve naloge

_Izdelava programa, ki nam bo omogočala izračun obsega pravokotnika na podlagi dveh sosednjih podanih stranic._

- _Vnos stranice a in b_
- _Preverjanje ali je katera od stranic krajša od 0_
- _Računanje obsega po enačbi 2a\*2b=p_
- _Izpis obsega_

## 2.2.Vhodi

_Vhodi so dve stranici pravokotnika._

## 2.3.Izhodi

_Izhod je obseg pravokotnika._

## 2.4.Omejitve

_Program je omejen na operiranje z realnimi števili večjimi od 0._

# 3.Načrt rešitve problema

Najprej program povpraša uporabnika po dolžini stranice a in dolžini stranice b. Nato z pogojnim stavkom (if) preverimo ali je katera od stranic a in b krajša od nič, če je pogoj izpolnjen se nam izpiše opozorilo, če pa temu ni tako se izvede stavek ki je namenjen, za izvedbo takrat, ko v pogojnem stavku pogoji ne ustrezajo željenemu (else). Tukaj deklariramo novo spremenljivko kateri bomo priredili vrednost, ki jo bomo dobili z enačbo za obseg pravokotnika. V naslednjem koraku v stavku izpišemo kolikšen je obseg določenega pravokotnika ter program omejimo, da se ne ugasne in čaka na odziv uporabnika.

![](RackMultipart20210826-4-1gzojpa_html_7605672bf693563b.jpg)
