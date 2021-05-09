using System;

namespace Royal_Game_of_Ur
{
    public class Game
    {
        private Board board;

        // Construtor da Classe Game
        public Game()
        {
            board = new Board();
            board.DrawBoard();
        }

        // Classe onde o jogo vai acontecer
        public void Play()
        {
            Console.WriteLine("Game very soon!!!");
            while (!board.Winner())
            {
                Console.WriteLine(board);
                board.Winner();
            }

        }
    }
}