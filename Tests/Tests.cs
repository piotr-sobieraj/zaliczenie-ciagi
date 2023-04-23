using System;
using Models;
using System.Diagnostics;


namespace Tests{
    class TestArithmeticSequence{
        public TestArithmeticSequence(){
            Console.WriteLine("##### Starting tests of the ArithmeticSequence class #####");

            // Difference = 0
            Console.WriteLine("     - Testing ArithmeticSequence with difference 0");            
            ArithmeticSequence seq1 = new ArithmeticSequence(difference: 0);

            Trace.Assert(seq1.ToString() == "ArithmeticSequence(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)");
            Console.WriteLine("        - Sequence OK");            
            
            Trace.Assert(seq1.Mean == 0);
            Console.WriteLine("        - Mean OK");            

            // Difference = -1.5
            Console.WriteLine("\n      - Testing ArithmeticSequence with difference -1.5");            
            ArithmeticSequence seq2 = new ArithmeticSequence(difference: -1.5);
            
            Trace.Assert(seq2.ToString() == "ArithmeticSequence(0, -1.5, -3, -4.5, -6, -7.5, -9, -10.5, -12, -13.5, -15, -16.5)");
            Console.WriteLine("        - Sequence OK");            

            Trace.Assert(seq2.Mean == -8.25);
            Console.WriteLine("        - Mean OK");           
            
            Console.Write("##### Tests of the ArithmeticSequence class succedded #####\n\n");
        }
        
    }

    class TestGeometricSequence{
        public TestGeometricSequence(){
            Console.WriteLine("\n\n##### Starting tests of the GeometricSequence class #####");
    
                // Difference = 0
                Console.WriteLine("      - Testing GeometricSequence with initial term 0");            
                GeometricSequence seq1 = new GeometricSequence(initialTerm: 0);
    
                Trace.Assert(seq1.ToString() == "GeometricSequence(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)");
                Console.WriteLine("        - Sequence OK");            
                
                Trace.Assert(seq1.Mean == 0);
                Console.WriteLine("        - Mean OK");            
    
                // Difference = -1.5
                Console.WriteLine("\n      - Testing GeometricSequence with difference -1.5");            
                GeometricSequence seq2 = new GeometricSequence(initialTerm: -1.5);

               
                Trace.Assert(seq2.ToString() == "GeometricSequence(-1.5, -3, -6, -9, -12, -15, -18, -21, -24, -27, -30, -33)");
                Console.WriteLine("        - Sequence OK");            

                Trace.Assert(seq2.Mean == -16.625);
                Console.WriteLine("        - Mean OK");           
                
                Console.Write("###### Tests of the GeometricSequence class succedded #####\n\n");
        }
    }
    
}

// ArithmeticSequence arithmeticSequence = new ArithmeticSequence(2);
// Trace.Assert(arithmeticSequence.ToString() == "ArithmeticSequence(0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22)");
// Trace.Assert(arithmeticSequence.Mean == 11);