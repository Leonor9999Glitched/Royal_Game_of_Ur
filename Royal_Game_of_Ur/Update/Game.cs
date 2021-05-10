using System;

namespace Royal_Game_of_Ur
{
    public class Game
    {
        private Board board;

        Dices dices = new Dices();

        public int n = 0;

        public int n_copia;

        // Construtor da Classe Game
        public Game()
        {
            board = new Board();
            board.DrawBoard();
        }

        // Classe onde o jogo vai acontecer
        public void Play()
        {
            Console.WriteLine("Player 1 Roll the Dices");

            n_copia = dices.RollDices(n);

            while (!board.Winner())
            {
                if(n_copia == 0)
                {
                    Console.WriteLine("O jogador perdeu a vez.");      
                }
                else
                {
                    Console.WriteLine("O jogador avança" + n_copia);
                }
                board.Winner();
            }

        }
    }
}