using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Royal_Game_of_Ur
{
    class Dices
    {
        Random rnd = new Random();

        //private int [] dices = new int [4];
        private int somadecasas = 0;
        private int casaquesaiu;

        public int RollDices()
        {
            for (int i = 0; i < 4; i++)
            {
                casaquesaiu = rnd.Next(0, 1);
                if (casaquesaiu == 1)
                {
                    somadecasas ++;
                }
            }
            return somadecasas;
        }
    }
}