# Spis treści
- [Opis działania programu](#opis-działania-programu)
  - [Przykłady](#przykłady)
  - [Kontrola wprowadzanych danych](#kontrola-wprowadzanych-danych)
- [Duże liczby Fibonacciego](#duże-liczby-fibonacciego)
- [Testy](#testy)
---


## Opis działania programu
Program pobiera od użytkownika niezerową liczbę całkowitą.
Działa on w pętli, do momentu wprowadzenia przez użytkownika liczby 0.
Tworzy dwa ciągi po 11 elementów:
  - arytmetyczny, w którym wyraz początkowy to 0, a pobrana wcześniej liczba to różnica ciągu
  - geometryczny, w którym wyraz początkowy to również pobrana wcześniej liczba, ale iloraz ciągu wynosi -2.
  
Na ich podstawie tworzy trzeci ciąg, sumując kolejno wyrazy o tym samym indeksie z obu ciągów, i również go wypisuje.
Na jego podstawie tworzy czwarty ciąg, odwracając kolejność elementów.
Następnie wypisuje wszystkie cztery ciągi, jeden pod drugim. W dalszej kolejności wypisuje średnie elementów wszystkich czterech ciagów.
Na koniec wyświetla n-ty element ciągu Fibonacciego, gdzie n jest pobraną liczbą, o ile wczytana liczba była większa od zera. 
### Przykłady

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

### Kontrola wprowadzanych danych
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

## Duże liczby Fibonacciego
Rekurencyjne obliczanie liczb Fibonacciego powoduje relatywnie szybkie przekroczenie zakresu liczb naturalnych. 
Ostanią liczbą Fibonacciego mieszczącą się w zakresie `System.Int32` jest `F(45) = 1_836_311_903`.

W razie podania liczby > 45 program wygeneruje wyjątek, po czym będzie kontynuował działanie
```Obliczam 46. wyraz ciągu Fibonacciego...
OverflowException for argument 46 when calculating Fibonacci.
```

## Testy
Gdy program został uruchomiony z parametrem `--test`, uruchamiane są testy 


```
dotnet run --test
##### Starting tests of the ArithmeticSequence class #####
GIVEN arithmetic sequence with initial term of 0 and the difference of 0
THEN the generated sequence is 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
AND its mean is 0

GIVEN arithmetic sequence with the initial term of 0 and the difference of -1.5
THEN the generated sequence is 0, -1.5, -3, -4.5, -6, -7.5, -9, -10.5, -12, -13.5, -15
AND its mean is -7.5


##### Starting tests of the GeometricSequence class #####
GIVEN geometric sequence with initial term of 1 and the common ratio of -2
THEN the generated sequence is 1, -2, 4, -8, 16, -32, 64, -128, 256, -512, 1024
AND its mean is 62.09090909090909
GIVEN geometric sequence with initial term of -1.5 and the common ratio of -2
THEN the generated sequence is -1.5, 3, -6, 12, -24, 48, -96, 192, -384, 768, -1536)
AND its mean is -93.13636363636364


##### Starting tests of the ZippedSequence class #####
GIVEN arithmetic sequence 0.0, 0.75, 1.5, 2.25, 3.0, 3.75, 4.5, 5.25, 6.0, 6.75, 7.5
AND   geometric sequence  0.5, -1, 2, -4, 8, -16, 32, -64, 128, -256, 512
WHEN their terms are added one by one
THEN the new sequence is 0.5, -0.25, 3.5, -1.75, 11, -12.25, 36.5, -58.75, 134, -249.25, 519.5
AND mean of the new sequence is 34.79545454545455


##### Starting tests of the Sequence.Reverse method #####
GIVEN geometric sequence 1.125, -2.25, 4.5, -9, 18, -36, 72, -144, 288, -576, 1152
WHEN a new sequence in reversed order is created
THEN the new sequence is 1152, -576, 288, -144, 72, -36, 18, -9, 4.5, -2.25, 1.125


##### Starting tests of the Fibonacci numbers generator  #####
GIVEN number 0
WHEN the generator is invoked
THEN the Fiboonacci number is 1

GIVEN number 10
WHEN the generator is invoked
THEN the Fibonacci number is 89

```

