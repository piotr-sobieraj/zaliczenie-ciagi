using System;
using System.Diagnostics;
using Models;

class ArithmeticSequence : Sequence{
    private double difference;
    
    public ArithmeticSequence(in double difference)
    {
        this.initialTerm = 0;
        this.difference = difference;       

        this.terms[0] = this.initialTerm;
        for(int i = 1; i < this.terms.Length; i++)
            this.terms[i] += i * this.difference + this.initialTerm;        
    }   
}

class GeometricSequence : Sequence{
    double commonRatio = 2;

    public GeometricSequence(in double initialTerm){
        this.initialTerm = initialTerm;

        this.terms[0] = this.initialTerm;
        for(int i = 1; i < this.terms.Length; i++)
            this.terms[i] += i * this.commonRatio * this.initialTerm;               
    }
}

class ZippedSequence : Sequence{
    public ZippedSequence(in Sequence seq1, in Sequence seq2){
        for(int i = 0; i < Math.Min(seq1.terms.Length, seq2.terms.Length); i++)
            this.terms[i] = seq1.terms[i] + seq2.terms[i];
    }
}


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