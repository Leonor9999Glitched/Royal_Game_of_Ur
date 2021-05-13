using System;

namespace Royal_Game_of_Ur
{
    public class Game
    {
        private Board board;
        Dices dices = new Dices();
        Piece newpiece = new Piece();
        public int n = 0;
        public int n_copia;
        public bool endofgame;

        // Construtor da Classe Game
        public Game()
        {
            board = new Board();
            board.DrawBoard();
        }

        // Classe onde o jogo vai acontecer
        public void Play()
        {
            endofgame = false;

            while (endofgame == false)
            {
                Console.WriteLine("Player 1 Roll the Dices");

                n_copia = dices.RollDices(n);    

                newpiece.MovePiece(n_copia);
                
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

                endofgame = board.Winner(endofgame);
            }

        }
    }
}