# Acceptanstester

## Acceptanstest 1: Se Historik

### Steg:
1. Öppna applikationen.
2. När huvudmenyn visas, skriv in `1` och tryck `Enter`.

### Förväntat resultat:
- Applikationen skriver ut alla tidigare beräkningar. Om det inte finns några beräkningar ska applikationen visa ett meddelande som "Ingen historik tillgänglig".

## Acceptanstest 2: Göra en Uträkning (Addition)

### Steg:
1. Öppna applikationen.
2. När huvudmenyn visas, skriv in `2` och tryck `Enter`.
3. När räknesättsmenyn visas, skriv in `1` (för Addition) och tryck `Enter`.
4. Skriv in `5` som första tal och tryck `Enter`.
5. Skriv in `3` som andra tal och tryck `Enter`.

### Förväntat resultat:
- Applikationen skriver ut "Resultatet är: 8".
- Beräkningen "5 + 3 = 8" sparas i historiken.

## Acceptanstest 3: Hantera Division med Noll

### Steg:
1. Öppna applikationen.
2. När huvudmenyn visas, skriv in `2` och tryck `Enter`.
3. När räknesättsmenyn visas, skriv in `4` (för Division) och tryck `Enter`.
4. Skriv in `10` som första tal och tryck `Enter`.
5. Skriv in `0` som andra tal och tryck `Enter`.

### Förväntat resultat:
- Applikationen visar ett meddelande "Division med noll är inte tillåtet."
- Ingen beräkning sparas i historiken för detta försök.
