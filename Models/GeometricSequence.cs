namespace Models{
    class GeometricSequence : Sequence{
        double commonRatio = 2;
    
        public GeometricSequence(in double initialTerm){
            this.initialTerm = initialTerm;
    
            this.terms[0] = this.initialTerm;
            for(int i = 1; i < this.terms.Length; i++)
                this.terms[i] += i * this.commonRatio * this.initialTerm;               
        }
    }    
}