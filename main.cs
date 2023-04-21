using System;



class ArithmeticSequence{
    private double difference;
    private double initialTerm;
    private double[] terms = new double[12];

    public ArithmeticSequence(in double difference)
    {
        this.initialTerm = 0;
        this.difference = difference;       

        this.terms[0] = this.initialTerm;
        for(int i = 1; i < this.terms.Length; i++)
            this.terms[i] += i * this.difference + this.initialTerm;        
    }

    public override string ToString()
    {
        string repr = "ArithmeticSequence(";
        foreach (double term in terms)
        {
            repr += term + ", ";
        }
        repr += "\b\b)";        

        return repr;
    }
}

class GeometricSequence{
    double commonRatio = 2;
    double initialTerm;
    double[] terms = new double[12];   
    
}



class Program {
    public static void Main (string[] args) {
        ArithmeticSequence arithmeticSequence = new ArithmeticSequence(2);
        Console.WriteLine(arithmeticSequence.ToString());
    }    
}