using System.Globalization;
using System.Threading;
using System;
using Models;
using Tests;


class Program {

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
        
        Console.Write("Twój wybór (liczba naturalna >= 0): ");

        int choice;
        bool isInteger = int.TryParse(Console.ReadLine(), out choice);

        if(isInteger){
            if (choice == 0) {
                Console.Write("Do zobaczenia!"); 
                return;   
            }
            else{
                ArithmeticSequence arithmetic = new ArithmeticSequence(difference: choice);
                GeometricSequence geometric = new GeometricSequence(initialTerm: choice);
                ZippedSequence zipped = new ZippedSequence(arithmetic, geometric);
                Sequence reversed = zipped.Reverse();

                Console.WriteLine("Wygenerowane ciągi ");
                Console.WriteLine(arithmetic);
                Console.WriteLine(geometric);
                Console.WriteLine(zipped);
                Console.WriteLine(reversed);
                              
                               
            }
        }
        

        menu();
    }
    
    
    public static void Main (string[] args) {
        
        // Run tests, if --test is given as a parameter
        if(Array.IndexOf(args, "--test") >= 0)
            runTests();   
        
        // Run the main method
        menu();
    }    
}