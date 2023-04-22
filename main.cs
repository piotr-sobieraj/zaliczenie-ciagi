using System;
using System.Diagnostics;
using Models;

class Program {
    public static void Main (string[] args) {
        ArithmeticSequence arithmeticSequence = new ArithmeticSequence(2);
        Trace.Assert(arithmeticSequence.ToString() == "ArithmeticSequence(0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22)");
        Trace.Assert(arithmeticSequence.Mean == 11);
        Console.WriteLine(arithmeticSequence.ToString());
        arithmeticSequence.PrintMean();
        
        GeometricSequence geometricSequence = new GeometricSequence(2);
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