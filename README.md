# Opis działania programu
Program pobiera od użytkownika niezerową liczbę całkowitą.
Działa on w pętli, do momentu wprowadzenia przez użytkownika liczby 0.
Tworzy dwa ciągi po 11 elementów:
  - arytmetyczny, w którym wyraz początkowy to 0, a pobrana wcześniej liczba to różnica ciągu
  - geometryczny, w którym wyraz początkowy to również pobrana wcześniej liczba, ale iloraz ciągu wynosi -2.
  
Na ich podstawie tworzy trzeci ciąg, sumując kolejno wyrazy o tym samym indeksie z obu ciągów, i również go wypisuje.
Na jego podstawie tworzy czwarty ciąg, odwracając kolejność elementów.
Następnie wypisuje wszystkie cztery ciągi, jeden pod drugim. W dalszej kolejności wypisuje średnie elementów wszystkich czterech ciagów.
Na koniec wyświetla n-ty element ciągu Fibonacciego, gdzie n jest pobraną liczbą, o ile wczytana liczba była większa od zera. 
## Przykłady

```
Twój wybór (liczba naturalna lub 0, aby zakończyć): 12
Pobrano liczbę 12.
Wygenerowane ciągi 
ArithmeticSequence(0, 12, 24, 36, 48, 60, 72, 84, 96, 108, 120)
GeometricSequence(12, -24, 48, -96, 192, -384, 768, -1536, 3072, -6144, 12288)
ZippedSequence(12, -12, 72, -60, 240, -324, 840, -1452, 3168, -6036, 12408)
Sequence(12408, -6036, 3168, -1452, 840, -324, 240, -60, 72, -12, 12)

Mean of ArithmeticSequence(0, 12, 24, 36, 48, 60, 72, 84, 96, 108, 120) equals 60
Mean of GeometricSequence(12, -24, 48, -96, 192, -384, 768, -1536, 3072, -6144, 12288) equals 745.0909090909091
Mean of ZippedSequence(12, -12, 72, -60, 240, -324, 840, -1452, 3168, -6036, 12408) equals 805.0909090909091
Mean of Sequence(12408, -6036, 3168, -1452, 840, -324, 240, -60, 72, -12, 12) equals 805.0909090909091

Obliczam 12. wyraz ciągu Fibonacciego...
Fibonacci(12) = 233
```

## Kontrola wprowadzanych danych
Program kontroluje wprowadzane dane pod kątem ich poprawności akceptowane są jedynie liczby naturalne oraz zero. 
W przypadku podania nieakceptowanych danych wyświetlany jest odpowiedni komunikat. 

```
Twój wybór (liczba naturalna lub 0, aby zakończyć): -90
Pobrano liczbę -90.

'-90' nie jest liczbą naturalną. Spróbuj jeszcze raz.
```
```
Twój wybór (liczba naturalna lub 0, aby zakończyć): c#

'c#' nie jest liczbą naturalną. Spróbuj jeszcze raz.
```

# Duże liczby Fibonacciego
Rekurencyjne obliczanie liczb Fibonacciego powoduje relatywnie szybkie przekroczenie zakresu liczb naturalnych. 
Ostanią liczbą Fibonacciego mieszczącą się w zakresie `System.Int32` jest F(45) = 1836311903.

W razie podania liczby > 45 program wygeneruje wyjątek, po czym będzie kontynuował działanie
```Obliczam 46. wyraz ciągu Fibonacciego...
OverflowException for argument 46 when calculating Fibonacci.
```

