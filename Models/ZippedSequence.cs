using System;

namespace Models{
    class ZippedSequence : Sequence{
        public ZippedSequence(in Sequence seq1, in Sequence seq2){
            for(int i = 0; i < Math.Min(seq1.terms.Length, seq2.terms.Length); i++)
                this.terms[i] = seq1.terms[i] + seq2.terms[i];
        }
    }
}