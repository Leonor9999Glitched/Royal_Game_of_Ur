using System;

namespace Royal_Game_of_Ur
{
    public class Game
    {
        private Board board;

        public Game()
        {
            board = new Board();
        }

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