using System;

namespace Royal_Game_of_Ur
{
    public class Board
    {

        //Construtor da Board
        public Board()
        {
            char [][] board = new char [3][];
            board[0] = new char[8] {'#', 'O', 'O', 'I', ' ', ' ', 'F', 'O'};
            board[1] = new char[8] {'O', 'O', 'O', '#', 'O', 'O', 'O', 'O'};
            board[2] = new char[8] {'#', 'O', 'O', 'I', ' ', ' ', 'F', 'O'};
        }

        //Metodo para definir o fim do jogo
        public bool Winner()
        {
            //O jogo acaba quando um dos jogadores consegue colocar as sete peças no final
            return true;
        }

    }
}