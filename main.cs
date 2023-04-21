using System;
using System.Text;
using System.Diagnostics;
using System.Linq;


class BaseSequence{

    private int _Length = 12;
    protected double initialTerm;
    internal double[] terms;

    protected int Length {get {return _Length;} set {} }    

    public BaseSequence(){
        terms = new double[Length];
    }
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.GetType().Name);
        sb.Append("(");
       
        for (int i = 0; i < terms.Length; i++)
        {
            sb.Append(terms[i]);
            if (i < terms.Length - 1)
            {
                sb.Append(", ");
            }
        }
        
        sb.Append(")");
        return sb.ToString();
    }    
}



class ArithmeticSequence : BaseSequence{
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

class GeometricSequence: BaseSequence{
    double commonRatio = 2;

    public GeometricSequence(in double initialTerm){
        this.initialTerm = initialTerm;

        this.terms[0] = this.initialTerm;
        for(int i = 1; i < this.terms.Length; i++)
            this.terms[i] += i * this.commonRatio * this.initialTerm;               
    }
}

class ZippedSequence: BaseSequence{
    public ZippedSequence(in BaseSequence seq1, in BaseSequence seq2){
        for(int i = 0; i < Math.Min(seq1.terms.Length, seq2.terms.Length); i++)
            this.terms[i] = seq1.terms[i] + seq2.terms[i];
    }
}


class Program {
    public static void Main (string[] args) {
        ArithmeticSequence arithmeticSequence = new ArithmeticSequence(2);
        Trace.Assert(arithmeticSequence.ToString() == "ArithmeticSequence(0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22)");
        Console.WriteLine(arithmeticSequence.ToString());

        
        GeometricSequence geometricSequence = new GeometricSequence(2);
        Trace.Assert(geometricSequence.ToString() == "GeometricSequence(2, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44)");
        Console.WriteLine(geometricSequence.ToString());

        ZippedSequence zippedSequence = new ZippedSequence(arithmeticSequence, geometricSequence);
        Trace.Assert(zippedSequence.ToString() == "ZippedSequence(2, 6, 12, 18, 24, 30, 36, 42, 48, 54, 60, 66)");
        Console.WriteLine(zippedSequence.ToString());       
    }    
}