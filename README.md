# Uppgiftsbeskrivning

## Scenario: 

Du jobbar som .NET programmerare på en IT-avdelning för en mindre bank. Det finns nu ett behov av en applikation som kan underlätta jobbet med valutaväxling i några valutor. De valutor som applikationen ska kunna stödja är :

● Svenska kronor (SEK)
● Amerikanska dollars (USD)
● Euro (EUR)

Växlingskursen för valutorna är så här :

● USD till SEK : 8,08 SEK
● EUR till SEK : 9,48 SEK
● USD till EUR : 0,85 EUR

De valutorna som finns tillgängliga är:

SEK ○ 500 kr ○ 100 kr ○ 50 kr ○ 20 kr ○ 10 kr ○ 1 kr USD ○ 100 $ ○ 50 $ ○ 20 $ ○ 10 $ ○ 5 $ ○ 2 $ ○ 1 $ ○ 50 cent ○ 25 cent ○ 10 cent ○ 5 cent ○ 1 cent Euro ○ 500 ○ 200 ○ 100 ○ 50 ○ 20 ○ 10 ○ 5 ○ 2 ○ 1 ○ 50 cent ○ 20 cent ○ 10 cent ○ 5 cent ○ 2 cent ○ 1 cent

Exempel på växlingar:
1 USD = 8.08 SEK (1 * 8.08) 1 EUR = 9.48 SEK (1 * 9.48) 1 USD = 0.85 EUR (1 * 0.85)
1 SEK = 0.12 USD (1 / 8.08) 1 SEK = 0.11 EUR (1 / 9.48) 1 EUR = 1.18 USD (1 / 0.85)

## Kriterier för Godkänt

I denna övning ska du ta fram en console-applikation som du ska kunna:

● Mata in den valutan du vill växla från, samt belopp.
● Mata in till den valutan du vill få beloppet växlat till.

Resultatet ska ge svaret för de olika valörerna som du ska växla till. Se exempel nedan.

Om användaren vill växla 100 USD till SEK. (100 USD är alltså 808 SEK.) Du ska då få svaret att man ska få

- 1st 500:-
- 3st 100:-
- 8st 1:-

Om svaret blir en summa med ett antal decimaler, så skall detta svar avrundas till två decimaler. Exempel:

1 SEK till USD blir: 0,123762376237624 och detta ska alltså avrundas till 0,12 USD, d.v.s. 12 cent
