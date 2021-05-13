using System;

namespace Royal_Game_of_Ur
{
    public class Game
    {
        private Board_V2 board_V2;

        Dices dices = new Dices();
        public int n = 0;
        public int n_copia;
        public bool endofgame;

        // Construtor da Classe Game
        public Game()
        {
            board_V2 = new Board_V2();
            board_V2.DrawBoard();
        }

        // Classe onde o jogo vai acontecer
        public void Play()
        {
            endofgame = false;

            while (endofgame == false)
            {
                Console.WriteLine("Player 1 Roll the Dices");

                n_copia = dices.RollDices(n);    
                
                Console.WriteLine("O jogador avança" + n_copia);

                Console.WriteLine("Player 2 Roll the Dices");

                n_copia = dices.RollDices(n);

                if(n_copia == 0)
                {
                    Console.WriteLine("O jogador perdeu a vez.");      
                }
                else
                {
                    Console.WriteLine("O jogador avança" + n_copia);
                }

                endofgame = board_V2.Winner(endofgame);
            }

        }
    }
}