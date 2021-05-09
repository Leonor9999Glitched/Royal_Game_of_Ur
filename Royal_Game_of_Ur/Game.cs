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
            Console.WriteLine("Roll the Dices");
        }
    }
}