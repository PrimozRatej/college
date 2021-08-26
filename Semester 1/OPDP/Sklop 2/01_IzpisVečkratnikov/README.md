<p align="center">
  <img width="250" height="150" src="media/feri_logo.png" />
</p>

# Od problema do programa (obrazec za vaje)

**Avtor:** Primož Ratej Cvahte

# **Naloga:** 1./II - naloga – Izpis večkratnikov

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

Izdelajte program, ki na zaslon izpiše prvih 800 večkratnikov števila 5 z
uporabo zanke.

# Analiza rešitve problema

## Namen in zahteve naloge

*Naloga od nas zahteva izdelavo programa, ki nam bo omogočal izpis prvih 800
večkratnikov števila 5.*

-   *Izračun prvih 800 večkratnikov števila 5.*

-   *Izpis 800 večkratnikov števila 5.*

## Vhodi

*Vhodov ni.*

## Izhodi

*Izhodi so večkratniki števila 5 od 5 do 4000.*

## Omejitve

*Program je omejen na operiranje z naravnimi števili.*

# Načrt rešitve problema

**Glavni program:**

Program na začetku v zanki šteje kar nam bo predstavljalo množenec v končnem
izračunu. Množitelj pa je konstanta saj iščemo večkratnik nekega določenega
števila. Z funkcijo za večkratnik nekega števila dobimo zmnožek. Na koncu ga
izpišemo.

**Funkcija za večkratnik števila 5:**

Za izračun večkratnika nekega števila uporabimo množenec ki ga dobimo iz
glavnega programa. Množitelja nam bo predstavljala konstanta 5 saj iščemo njen
večkratnik. Funkcija večkratnik izračuna in ga vrne.

Psevdokode
``` python
FUNCTION Večkratnik(Množenec)
	SET večkratnik = množenec * 5 // 5 je konstanta
	RETURN veckratnik
END FUNCTION
PROCEDURE MAIN
	FOR( set a = 1; a<=800; a=a+1) DO
		PRINT (Veckratnik(a))
	END FOR
END PROCEDURE
```

# Testni primeri

| **Testni scenariji (vhodi)** | **Rezultat (pričakovani izhodi)** | **Opomba (opcijsko)** |
|------------------------------|-----------------------------------|-----------------------|
| Ni vhodov                    | 5, 10, 15, 20, 25, …, 4000        | Izhod je vedno isti.  |
