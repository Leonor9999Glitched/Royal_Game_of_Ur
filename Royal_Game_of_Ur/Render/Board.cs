using System;

namespace Royal_Game_of_Ur
{
    public class Board
    {

        private char [][] board = new char [3][];

        //Construtor da Board
        public Board()
        {
            board[0] = new char[8] {'#', 'O', 'O', 'I', ' ', ' ', 'F', 'O'};
            board[1] = new char[8] {'O', 'O', 'O', '#', 'O', 'O', 'O', 'O'};
            board[2] = new char[8] {'#', 'O', 'O', 'I', ' ', ' ', 'F', 'O'};
        }

        // Desenha o tbuleiro
        public void DrawBoard()
        {
            for ( int i = 0 ; i < 3; i ++)
            {
                for ( int j = 0 ; j < 8; j++)
                {
                    Console.Write ( board[i][j] + " " );
                }
                Console.WriteLine();
            }
        }

        //Metodo para definir o fim do jogo
        public bool Winner(bool endofgame)
        {
            //O jogo acaba quando um dos jogadores consegue colocar as sete peças no final
            return true;
        }

    }
}