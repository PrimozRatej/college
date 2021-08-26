
<p align="center">
  <img width="250" height="150" src="media/9df5055488fae6703a7a88747656d4ee.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Ime:** Primož

**Priimek:** Ratej Cvahte

# **Naloga:** 2. Površina, volumen pokončnega stožca.

**Vsebina:**

[1. Besedilo naloge 2](#besedilo-naloge)

[2. Analiza rešitve problema 2](#_Toc433211252)

[2.1. Namen in zahteve naloge 2](#_Toc433211253)

[2.2. Vhodi 2](#_Toc433211254)

[2.3. Izhodi 2](#izhodi)

[2.4. Omejitve 2](#omejitve)

[3. Načrt rešitve problema 3](#_Toc433211257)

# Besedilo naloge

Izdelajte postopek, ki izračuna površino in volumen [pokončnega krožnega
stožca](https://sl.wikipedia.org/wiki/Sto%C5%BEec). Vhodna podatka sta premer
(**d**) osnovne ploskve stožca ter njegova višina (**v**). Postopek naj preveri,
ali sta vhodna podatka veljavna (večja od nič). V primeru vpisa napačnih vhodnih
vrednosti naj namesto rezultata izpiše opozorilo o napaki. Za PI morate
uporabiti [uporabniško definirano
konstanto](http://msdn.microsoft.com/en-us/library/e6w8fe1b.aspx) (na 6 decimalk
natančno).

# Analiza rešitve problema

## Namen in zahteve naloge

*Izdelava programa, ki bo omogočal izračun volumna in površine pokončnega valja
na podlagi premera kroga in višine valja, ki ju bo uporabnik vpisal. Program pa
bo tudi preverjal če so vpisane vrednosti nepravilne.*

-   *Vpis premera osnovne ploskve in višino valja.*

-   *Pretvorba premera v polmer.*

-   *Ob vpisu 0 ali manj naj program javi napako.*

-   *Ob pravilnih vnosih izračun površine in volumna valja.*

-   *Izpis volumna in površine valja.*

## Vhodi

*Vhoda sta premer osnovne ploskve oz. kroga in višina valja.*

## Izhodi

*Izhoda sta površina in volumen valja.*

## Omejitve

*Program je omejen na operiranje z realnimi števili večjimi od 0.*

# Načrt rešitve problema

Najprej program povpraša uporabnika po premeru oz. diagonali osnovne ploskve
valja v tem primeru kroga, ter o višini valja. Nato izračunamo iz premera polmer
po enačbi r=d/2 za izračun bomo potrebovali tudi število pi, ki pa kot vemo je
konstanta in jo temu primerno tudi obravnavamo, zaokrožimo ga na 6 decimalk
natančno. Program preveri če je katero od vnesenih števil manjše ali enako od
nič zaradi tega ker bi lahko dobili negativen rezultat. Nato izračunamo površino
valja po enačbi površina lika = 2\*površina osnovne ploskve + površina plašča in
volumen valja po enačbi volumen = površina osnovne ploskve \* višina valja.

Na koncu programa izpišemo volumen in površino valja.
```C++
READ d, v
SET r = d/2
SET konstanta pi = 3.141592;
IF d \> 0 THEN
  SET površina = (2\*r\*pi)\*v+(pi\*r\*r\*2)
  PRINT površina
  SET volumen = r \* r \* pi \* v
  PRINT volumen
ELSE
  PRINT Napaka
END IF
```

