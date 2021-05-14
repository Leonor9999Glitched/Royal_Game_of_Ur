using System;
using System.Collections;
using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    public class Board
    {
        class PieceData
        {
            public Piece piece;
            public int position;

            public PieceData(Piece p, int pos)
            {
                piece = p;
                position = pos;
            }
        }

        private int player1Score = 0;
        private int player2Score = 0;

        private PlayerType currentTurn = PlayerType.Player1;
        private bool finishedTurn = true;
        private bool boardSettled = true;
        private int roll = 0;


        List<BoardBlock> player1Pathway = new List<BoardBlock>();

        List<BoardBlock> player2Pathway = new List<BoardBlock>();


        List<Piece> player1Pieces = new List<Piece>();

        List<Piece> player2Pieces = new List<Piece>();


        // Usado para Guardar multiplas peças por jogador

        List<PieceData> player1Positions = new List<PieceData>();

        List<PieceData> player2Positions = new List<PieceData>();

        private char[][] board = new char[3][];
        void Start()
        {

            // Set all player pieces' positions to -1 (off the board)
            for (int i = 0; i < 7; i++)
            {
                player1Pieces[i].SetPieceID(i);
                player2Pieces[i].SetPieceID(i);

                player1Positions.Add(new PieceData(player1Pieces[i], -1));
                player2Positions.Add(new PieceData(player2Pieces[i], -1));
            }

            // Update both players' positions
            for (int i = 0; i < player1Positions.Count; i++)
            {
              
            }

            //print(currentTurn + "'s turn!");
        }
    }
}