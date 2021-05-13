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
        private int casaquesaiu;

        // Definir quando é que há casa para o jogador avançar
        public int RollDices(int n)
        {

            for (int i = 0; i < 4; i++)
            {
                casaquesaiu = rnd.Next(2);

                if (casaquesaiu == 1)
                {
                    n ++;
                }
            }
            return n;
        }
    }
}