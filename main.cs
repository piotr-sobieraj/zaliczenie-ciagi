using System.Diagnostics;
using Tests;
using System.Globalization;
using System.Threading;
using Models;
using System;


class Program {
    public static void Main (string[] args) {

        // Ustaw kulturę na "en-US"
        // CultureInfo culture = new CultureInfo("en-US");
        // Thread.CurrentThread.CurrentCulture = culture;
        // Thread.CurrentThread.CurrentUICulture = culture;

        
        // TestArithmeticSequence testArithmSequence = new TestArithmeticSequence();
        // TestGeometricSequence testGeomSequence = new TestGeometricSequence();
        // TestZippedSequence testZippedSequence = new TestZippedSequence();      
        // TestReversedSequence testReversed = new TestReversedSequence();         

        

        string input = "";
        try{
            
            Console.WriteLine(new Fibonacci(input));
        }
        catch(OverflowException){
            Console.Write("OverflowException for argument {0} when calculating Fibonacci.", input);
        }
        catch(ArgumentException){
            Console.Write("Invalid argument ('{0}') when calculating Fibonacci.", input);
        }        
    }    
}