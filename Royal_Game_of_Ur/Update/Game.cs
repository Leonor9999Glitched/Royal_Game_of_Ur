using System;

namespace Royal_Game_of_Ur
{
    public class Game
    {
        private Board board;

        Dices dices = new Dices();

        private int n = 0;

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

            dices.RollDices(n);

            while (!board.Winner())
            {
                dices.RollDices(n);

                if(n == 0)
                {
                    Console.WriteLine("O jogador perdeu a vez.");      
                }
                else
                {
                    Console.WriteLine("O jogador avança" + n);
                }
                board.Winner();
            }

        }
    }
}