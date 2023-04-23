using System;
using System.Diagnostics;
using Models;
using Tests;

class Program {
    public static void Main (string[] args) {
        TestArithmeticSequence testArithmSequence = new TestArithmeticSequence();
        TestGeometricSequence testGeomSequence = new TestGeometricSequence();
        
        ArithmeticSequence arithmeticSequence = new ArithmeticSequence(difference: 2);
        Console.WriteLine(arithmeticSequence.ToString());
        arithmeticSequence.PrintMean();
        
        GeometricSequence geometricSequence = new GeometricSequence(initialTerm: 2);
        Trace.Assert(geometricSequence.ToString() == "GeometricSequence(2, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44)");
        Trace.Assert(geometricSequence.Mean == 22.166666666666668);
        Console.WriteLine();
        Console.WriteLine(geometricSequence.ToString());
        geometricSequence.PrintMean();

        ZippedSequence zippedSequence = new ZippedSequence(arithmeticSequence, geometricSequence);
        Trace.Assert(zippedSequence.ToString() == "ZippedSequence(2, 6, 12, 18, 24, 30, 36, 42, 48, 54, 60, 66)");
        Trace.Assert(zippedSequence.Mean == 33.166666666666664);
        Console.WriteLine();        
        Console.WriteLine(zippedSequence.ToString());
        zippedSequence.PrintMean();        
    }    
}