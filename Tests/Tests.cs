using System;
using Models;
using System.Diagnostics;


namespace Tests{
    class TestArithmeticSequence{
        public TestArithmeticSequence(){
            Console.WriteLine("##### Starting tests of the ArithmeticSequence class #####");
            
            ArithmeticSequence seq1 = new ArithmeticSequence(difference: 0);
            Console.WriteLine("GIVEN arithmetic sequence with initial term of 0 and the difference of 0");            
            Trace.Assert(seq1.ToString() == "ArithmeticSequence(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)");
            Console.WriteLine("THEN the generated sequence is 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0");            
            Trace.Assert(seq1.Mean == 0);
            Console.WriteLine("AND its mean is 0");    
            Console.WriteLine();
            

            ArithmeticSequence seq2 = new ArithmeticSequence(difference: -1.5);
            Console.WriteLine("GIVEN arithmetic sequence with the initial term of 0 and the difference of -1.5");            
            
            Trace.Assert(seq2.ToString() == "ArithmeticSequence(0, -1.5, -3, -4.5, -6, -7.5, -9, -10.5, -12, -13.5, -15)");
            Console.WriteLine("THEN the generated sequence is 0, -1.5, -3, -4.5, -6, -7.5, -9, -10.5, -12, -13.5, -15");            
            Trace.Assert(seq2.Mean == -7.5);
            Console.WriteLine("AND its mean is -7.5");            
        }
        
    }

    class TestGeometricSequence{
        public TestGeometricSequence(){
            Console.WriteLine("\n\n##### Starting tests of the GeometricSequence class #####");
            GeometricSequence seq1 = new GeometricSequence(initialTerm: 1);    
            
            Console.WriteLine("GIVEN geometric sequence with initial term of 1 and the common ratio of -2");            
            Trace.Assert(seq1.ToString() == "GeometricSequence(1, -2, 4, -8, 16, -32, 64, -128, 256, -512, 1024)");
            Console.WriteLine("THEN the generated sequence is 1, -2, 4, -8, 16, -32, 64, -128, 256, -512, 1024");            
            Trace.Assert(seq1.Mean == 62.09090909090909);
            Console.WriteLine("AND its mean is 62.09090909090909");     
            
            GeometricSequence seq2 = new GeometricSequence(initialTerm: -1.5);
            
            Console.WriteLine("GIVEN geometric sequence with initial term of -1.5 and the common ratio of -2");
            Trace.Assert(seq2.ToString() == "GeometricSequence(-1.5, 3, -6, 12, -24, 48, -96, 192, -384, 768, -1536)");
            Console.WriteLine("THEN the generated sequence is -1.5, 3, -6, 12, -24, 48, -96, 192, -384, 768, -1536)");            
            Trace.Assert(seq2.Mean == -93.13636363636364);
            Console.WriteLine("AND its mean is -93.13636363636364");     
        }
    }    

    class TestZippedSequence{
        public TestZippedSequence(){
            Console.WriteLine("\n\n##### Starting tests of the ZippedSequence class #####");
            ArithmeticSequence seq1 = new ArithmeticSequence(difference: 0.75);
            GeometricSequence seq2 = new GeometricSequence(initialTerm: 0.5);
            ZippedSequence seq3 = new ZippedSequence(seq1, seq2);

            Console.WriteLine("GIVEN arithmetic sequence 0.0, 0.75, 1.5, 2.25, 3.0, 3.75, 4.5, 5.25, 6.0, 6.75, 7.5");
            Console.WriteLine("AND   geometric sequence  0.5, -1, 2, -4, 8, -16, 32, -64, 128, -256, 512");
            Console.WriteLine("WHEN their terms are added one by one");
            Trace.Assert(seq3.ToString() == "ZippedSequence(0.5, -0.25, 3.5, -1.75, 11, -12.25, 36.5, -58.75, 134, -249.25, 519.5)");            
            Console.WriteLine("THEN the new sequence is 0.5, -0.25, 3.5, -1.75, 11, -12.25, 36.5, -58.75, 134, -249.25, 519.5");
            Trace.Assert(seq3.Mean == 34.79545454545455);
            Console.WriteLine("AND mean of the new sequence is 34.79545454545455");
       }
    }


    class TestReversedSequence{
        public TestReversedSequence(){
            Console.WriteLine("\n\n##### Starting tests of the Sequence.Reverse method #####");
            GeometricSequence geom = new GeometricSequence(initialTerm: 1.125);            

            Console.WriteLine("GIVEN geometric sequence 1.125, -2.25, 4.5, -9, 18, -36, 72, -144, 288, -576, 1152");
            Sequence rev_geom = geom.Reverse();                        
            Console.WriteLine("WHEN a new sequence in reversed order is created");
            Trace.Assert(rev_geom.ToString() == "Sequence(1152, -576, 288, -144, 72, -36, 18, -9, 4.5, -2.25, 1.125)");            
            Console.WriteLine("THEN the new sequence is 1152, -576, 288, -144, 72, -36, 18, -9, 4.5, -2.25, 1.125");            
        }
    }

    class TestFibonacci{
        public TestFibonacci(){
            Console.WriteLine("\n\n##### Starting tests of the Fibonacci numbers generator  #####");

            Console.WriteLine("GIVEN number 0");
            Fibonacci fib1 = new Fibonacci("0");
            Console.WriteLine("WHEN the generator is invoked");
            Trace.Assert(fib1.ToString() == "Fibonacci(0) = 1");            
            Console.WriteLine("THEN the Fiboonacci number is 1");            


            Console.WriteLine();
            Console.WriteLine("GIVEN number 10");
            Fibonacci fib2 = new Fibonacci("10");
            Console.WriteLine("WHEN the generator is invoked");
            Trace.Assert(fib2.ToString() == "Fibonacci(10) = 89");            
            Console.WriteLine("THEN the Fibonacci number is 89");            



            
        }
            
            
            
        
    }
}