using System;
using System.Collections;
using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    public class DiceRoller 
    {

        // Use this for initialization
        void start()
        {
            DiceValues = new int[4];
        }


        public int[] DiceValues;

       
    }

    public void RollTheDice()
    {

        // In Ur, you roll four dice (classically Tetrahedron), which
        // have half their faces have a value of "1" and half have a value
        // of zero.
        // We are going to use random number generation.

        DiceTotal = 0;

        for (int i = 0; i < DiceValues.Length; i++)
        {
            DiceValues[i] = Random.Range(0, 2);
            DiceTotal += DiceValues[i];
        }

       
        
        //CheckLegalMoves();


        Console.WriteLine("Rolled: " + DiceTotal);
    }
}