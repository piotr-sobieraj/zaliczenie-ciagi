using System.Diagnostics;
using Tests;
using System.Globalization;
using System.Threading;


class Program {
    public static void Main (string[] args) {

        // Ustaw kulturę na "en-US"
        CultureInfo culture = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;

        
        TestArithmeticSequence testArithmSequence = new TestArithmeticSequence();
        TestGeometricSequence testGeomSequence = new TestGeometricSequence();
        TestZippedSequence testZippedSequence = new TestZippedSequence();      
        TestReversedSequence testReversed = new TestReversedSequence();              
    }    
}