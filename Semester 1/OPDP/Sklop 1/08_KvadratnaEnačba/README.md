<p align="center">
  <img width="250" height="150" src="media/feri_logo.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Avtor:** Primož Ratej Cvahte

# **Naloga:** 8. Kvadratna enačba

**Vsebina:**


[1. Besedilo naloge](#besedilo-naloge)

[2. Analiza rešitve problema](#_Toc433146828)

[2.1. Namen in zahteve naloge](#_Toc433146829)

[2.2. Vhodi](#_Toc433146830)

[2.3. Izhodi](#izhodi)

[2.4. Omejitve](#omejitve)

[3. Načrt rešitve problema](#_Toc433146833)

# Besedilo naloge

Izdelajte postopek, ki poišče vse realne rešitve [kvadratne
enačbe](http://sl.wikipedia.org/wiki/Kvadratna_ena%C4%8Dba) **a\*x2+b\*x+c=0.**
Vhodni podatki so vrednosti **a, b** in **c**. Postopek naj izpiše, koliko
realnih ničel ima kvadratna enačba (nobeno, eno ali dve). Nato naj rešitve
izračuna in jih izpiše.

# Analiza rešitve problema

## Namen in zahteve naloge

Izdelava programa, ki nam bo omogočala izračun ničel pri kvadratni funkciji in
število le teh na x osi.

-   Vnos vrednosti koeficientov a, b in c

-   Preverjanje ali je a=0, če je program javi napako.

-   Računanje diskriminante.

-   Ugotavljanje koliko ničel ima funkcija

-   Izračun ničel

-   Izpis števila ničel in točke kjer se nahajajo.

## Vhodi

*Vhodi so koeficienti a, b in c.*

## Izhodi

*Izhod pa je število ničel na x osi in njihove točke.*

## Omejitve

*Program je omejen na operiranje z realnimi števili.*

# Načrt rešitve problema

Najprej uporabnika povprašamo po koeficientih a, b in c in preverimo ali je
vnesen a slučajno število 0, če je program javi napako saj bi se nam pri
nadaljnjem računanju pojavila možnost deljenja z 0 kar pa je prepovedano, če je
vneseno število pravilno najprej izračunamo diskriminanto zato, da bomo lahko
videli sploh koliko ničel ima kvadratna funkcija. Diskriminanto izračunamo po
enačbi D=b\^2-4ac, če je diskriminanta večja od 0 pomeni, da funkcija seka x os
v 2 točkah, če je diskriminanta 0 pomeni, da se funkcija x osi dotika in ima
samo eno realno ničlo oz. sta obe ničli enaki in se smatrata kot ena če pa je
diskriminanta manjša od 0 pa pomeni da je funkcija premaknjena višje po y osi in
z x osjo nima nikakršnega stika zato taka funkcija nima ničel. V primeru, da smo
ugotovili, da sta ničli 2 izračunamo ničle po enačbi x1=(-b+D\^(1/2))/(2\*a) In
x1=(-b-D\^(1/2))/(2\*a), da dobimo obe možni rešitvi, če smo ugotovila, da je
ničla samo ena zadovoljuje da uporabimo samo eno od prej omenjenih enačb in
izračunamo ničlo, če pa smo ugotovili, da funkcija ne vsebuje ničel pa enostavno
izpišemo obvestilo. Na koncu izpišemo število ničel in njihove točke na x osi.
``` python
SET a, b, c, diskriminanta
READ a, b, c
IF a != 0 THEN
	diskriminanta = b * b - 4 * a * c
	IF diskriminanta > 0 THAN
		PRINT Ničli sta dve.
		SET x1 = (-b + diskriminanta^(1/2)) / (2 * a)
		SET x1 = (-b - diskriminanta^(1/2)) / (2 * a)
		PRINT x1, x2
	END IF
END IF
IF diskriminanta = 0 THAN
	PRINT Ničla je samo ena.
	SET x1 = (-b + diskriminanta^(1/2)) / (2 * a)
	PRINT x1
END IF
```

