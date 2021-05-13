using System;
using System.Collections;
using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    public class Board_V2
    {
        private char [][] board = new char [3][];
        
        public Board_V2()
        {
            board[0] = new char[8] {'#', 'O', 'O', 'I', ' ', ' ', 'F', 'O'};
            board[1] = new char[8] {'O', 'O', 'O', '#', 'O', 'O', 'O', 'O'};
            board[2] = new char[8] {'#', 'O', 'O', 'I', ' ', ' ', 'F', 'O'};
        } 
    }
}