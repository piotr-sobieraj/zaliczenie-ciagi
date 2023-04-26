using System;
using Models;
using System.Diagnostics;


namespace Tests{
    class TestArithmeticSequence{
        public TestArithmeticSequence(){
            Console.WriteLine("##### Starting tests of the ArithmeticSequence class #####");
            
            ArithmeticSequence seq1 = new ArithmeticSequence(difference: 0);
            Console.WriteLine("GIVEN arithmetic sequence where initial term is 0 and the difference is 0");            
            Trace.Assert(seq1.ToString() == "ArithmeticSequence(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)");
            Console.WriteLine("THEN the sequence is 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0");            
            Trace.Assert(seq1.Mean == 0);
            Console.WriteLine("AND the mean is 0");            
            

            ArithmeticSequence seq2 = new ArithmeticSequence(difference: -1.5);
            Console.WriteLine("GIVEN arithmetic sequence where initial term is 0 and the difference is -1.5");            
            Trace.Assert(seq2.ToString() == "ArithmeticSequence(0, -1.5, -3, -4.5, -6, -7.5, -9, -10.5, -12, -13.5, -15)");
            Console.WriteLine("THEN the sequence is 0, -1.5, -3, -4.5, -6, -7.5, -9, -10.5, -12, -13.5, -15");            
            Trace.Assert(seq2.Mean == -7.5);
            Console.WriteLine("AND the mean is -7.5");            
        }
        
    }

    class TestGeometricSequence{
        public TestGeometricSequence(){
            Console.WriteLine("\n\n##### Starting tests of the GeometricSequence class #####");

            GeometricSequence seq1 = new GeometricSequence(initialTerm: 0);    
            Console.WriteLine("GIVEN geometric sequence where initial term is 0 and the common ratio is 2");            
            Trace.Assert(seq1.ToString() == "GeometricSequence(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)");
            Console.WriteLine("THEN the sequence is 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0");            
            Trace.Assert(seq1.Mean == 0);
            Console.WriteLine("AND the mean is 0");     
            
            GeometricSequence seq2 = new GeometricSequence(initialTerm: -1.5);
            Console.WriteLine("GIVEN geometric sequence where initial term is -1.5 and the common ratio is 2");
            Trace.Assert(seq2.ToString() == "GeometricSequence(-1.5, -3, -6, -9, -12, -15, -18, -21, -24, -27, -30)");
            Console.WriteLine("THEN the sequence is -1.5, -3, -6, -9, -12, -15, -18, -21, -24, -27, -30");            
            Trace.Assert(seq2.Mean == -15.136363636363637);
            Console.WriteLine("AND the mean is -15.136363636363637");     
            
                
                
            
        }
    }    

    class TestZippedSequence{
        public TestZippedSequence(){
            Console.WriteLine("\n\n##### Starting tests of the ZippedSequence class #####");
            ArithmeticSequence seq1 = new ArithmeticSequence(difference: 0.75);
            GeometricSequence seq2 = new GeometricSequence(initialTerm: 0.5);
            ZippedSequence seq3 = new ZippedSequence(seq1, seq2);

            Console.WriteLine("GIVEN arithmetic sequence 0.0, 0.75, 1.5, 2.25, 3.0, 3.75, 4.5, 5.25, 6.0, 6.75, 7.5");
            Console.WriteLine("AND   geometric sequence  0.5, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0");
            Console.WriteLine("WHEN their terms are added one by one");
            Trace.Assert(seq3.ToString() == "ZippedSequence(0.5, 1.75, 3.5, 5.25, 7, 8.75, 10.5, 12.25, 14, 15.75, 17.5)");            
            Console.WriteLine("THEN the outcome sequence is 0.5, 1.75, 3.5, 5.25, 7.0, 8.75, 10.5, 12.25, 14.8, 15.75, 17.5");
            Trace.Assert(seq3.Mean == 8.795454545454545);
            Console.WriteLine("AND mean of the new sequence is 8.795454545454545");
       }
    }
}

