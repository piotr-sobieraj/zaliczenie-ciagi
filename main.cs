using System;
using System.Diagnostics;
using Models;
using Tests;

class Program {
    public static void Main (string[] args) {
        TestArithmeticSequence testArithmSequence = new TestArithmeticSequence();
        TestGeometricSequence testGeomSequence = new TestGeometricSequence();
        TestZippedSequence testZippedSequence = new TestZippedSequence();      
        TestReversedSequence testReversed = new TestReversedSequence();              
    }    
}