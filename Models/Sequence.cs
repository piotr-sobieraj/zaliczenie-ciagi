using System;
using System.Text;


namespace Models
{
    public class Sequence{
    
        private int _Length = 12;
        protected double initialTerm;
        internal double[] terms;
    
        public int Length {get {return _Length;} set {} }    
        public double Mean {get {return _Mean();} set {} }    
        
    
        public Sequence(){
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
    
        private double _Mean(){
            int Length = this.Length;
    
            if(Length == 0){
                throw new DivideByZeroException("The sequence is empty. Make sure it contains at least one element.");
            }
            
            double sum = 0;
            
            foreach (double term in this.terms)
                sum += term;
    
            return sum / Length;        
        } 
    
        public void PrintMean(){
            Console.WriteLine("Mean of {0} equals {1}", this.ToString(), this.Mean);
        }
    }
}
    