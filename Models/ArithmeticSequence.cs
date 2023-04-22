namespace Models
{
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
}