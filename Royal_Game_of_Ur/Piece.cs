using System;
using System.Collections;
using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    public class Piece
    {
        private int piece_ID = -1;
        private PlayerType owner = PlayerType.Player1;
        private bool initialized = false;
        private bool scored;

        //private movement;

        //Inicializar a peça do jogo

        public void Initialized (int id, PlayerType owner)
        {
            if(!initialized)
            {
                initialized = true;

                this.piece_ID = id;
                this.owner = owner;

                Console.WriteLine("Peça colocada no tabuleiro");
            }

            else
            {
                Console.WriteLine("A peça já está no tabuleiro.");
            }
        }
    }
}