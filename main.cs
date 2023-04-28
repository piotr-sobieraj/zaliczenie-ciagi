using System.Globalization;
using System.Threading;
using System;
using Models;
using Tests;


class Program {

    static bool runFirstTime = true;
    
    public static void setUpCulture(){
        // Set culture to "en-US"
        CultureInfo culture = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;

    }
    
    public static void runTests(){
        // To make always commas the decimal separator
        setUpCulture();   
        
        TestArithmeticSequence testArithmSequence = new TestArithmeticSequence();
        TestGeometricSequence testGeomSequence = new TestGeometricSequence();
        TestZippedSequence testZippedSequence = new TestZippedSequence();      
        TestReversedSequence testReversed = new TestReversedSequence();         
        TestFibonacci testFib = new TestFibonacci();  
    }

    public static void menu(){

        if(runFirstTime){
            runFirstTime = false;
            Console.WriteLine("\nProgram pobiera od użytkownika niezerową liczbę całkowitą.");
            Console.WriteLine("Działa on w pętli, do momentu wprowadzenia przez użytkownika liczby 0.");
            Console.WriteLine("Tworzy dwa ciągi po 11 elementów:");
            Console.WriteLine("  → arytmetyczny, w którym wyraz początkowy to 0, a pobrana wcześniej liczba to różnica ciągu");
            Console.WriteLine("  → geometryczny, w którym wyraz początkowy to również pobrana wcześniej liczba, ale iloraz ciągu wynosi -2");
            Console.WriteLine("Na ich podstawie tworzy trzeci ciąg, sumując kolejno wyrazy o tym samym indeksie z obu ciągów, i również go wypisuje.");
            Console.WriteLine("Na jego podstawie tworzy czwarty ciąg, odwracając kolejność elementów.");        
            Console.WriteLine("Następnie wypisuje wszystkie cztery ciągi, jeden pod drugim");
            Console.WriteLine("W dalszej kolejności wypisuje średnie elementów wszystkich czterech ciagów.");
            Console.WriteLine("Na koniec wyświetla n-ty element ciągu Fibonacciego, gdzie n jest pobraną liczbą.");
        }
        Console.Write("\nTwój wybór (liczba naturalna lub 0, aby zakończyć): ");

        int choice;
        string line = Console.ReadLine();
        bool isInteger = int.TryParse(line, out choice);

        if(isInteger){
            Console.WriteLine("Pobrano liczbę {0}.", choice);
            
            if (choice == 0) {
                Console.WriteLine("Najnowszą wersję programu znajdziesz na https://github.com/piotr-sobieraj/zaliczenie-ciagi");
                Console.WriteLine("Do zobaczenia!"); 
                return;   
            }
            else if (choice > 0){
                ArithmeticSequence arithmetic = new ArithmeticSequence(difference: choice);
                GeometricSequence geometric = new GeometricSequence(initialTerm: choice);
                ZippedSequence zipped = new ZippedSequence(arithmetic, geometric);
                Sequence reversed = zipped.Reverse();

                Console.WriteLine("Wygenerowane ciągi ");
                Console.WriteLine(arithmetic);
                Console.WriteLine(geometric);
                Console.WriteLine(zipped);
                Console.WriteLine(reversed);

                Console.WriteLine();
                arithmetic.PrintMean();
                geometric.PrintMean();
                zipped.PrintMean();
                reversed.PrintMean();

                Console.WriteLine();
                Console.WriteLine("Obliczam {0}. wyraz ciągu Fibonacciego...", choice);
                
                Console.WriteLine(new Fibonacci(choice.ToString()));
            }
            // Integer, but < 0
            else Console.WriteLine("\n'{0}' nie jest liczbą naturalną. Spróbuj jeszcze raz.", line);
            
        }
        // Not integer 
        else{
            Console.WriteLine("\n'{0}' nie jest liczbą naturalną. Spróbuj jeszcze raz.", line);
        }       

        menu();
    }
    
    
    public static void Main (string[] args) {
        
        // Run tests, if --test is given as a parameter
        if(Array.IndexOf(args, "--test") >= 0)
            runTests();   
        
        // Run the main loop
        menu();
    }    
}