using System;

namespace Models{
    class Fibonacci{

        private int inputParam;
        private int calculatedFibNumber;

        private bool IsNaturalNumberWithZero(in string paramIn, out int n){
            int number;
            n = -1;
            if (int.TryParse(paramIn, out number)){
                n = number;
                return number >= 0;
            }
            
            return false;
        }
        
        public Fibonacci(in string paramIn){
            int n;
            if(IsNaturalNumberWithZero(in paramIn, out n)){                
                inputParam = n;
                calculatedFibNumber = CalculateFibonacci(n);                
            }
            else throw new ArgumentException("The parameter has to be a positive integer or zero.");
        }
       
        private int CalculateFibonacci(in int n){
            if(n == 0 || n == 1) return 1;

            try{
                checked{
                    return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);             
                }
            }
            catch(OverflowException ex){
                throw new OverflowException("Integer overflow when calculating Fibonacci number: try lower number.", ex);
            }               
        }
        

        public override string ToString(){
            return $"Fibonacci({inputParam}) = {calculatedFibNumber.ToString()}";
        }      
    }
}