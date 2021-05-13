using System;
using System.Collections;
using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    public class PieceController
    {
        private List<PieceLocationData> pieces = new ist<PieceLocationData>();

        public void AddPiece(Piece p, BoardBlock t)
        {
            PieceLocationData newData = new PieceLocationData(p, t);
            pieces.Add(newData);
        }

        public void RemovePiece(Piece p)
        {
            foreach (PieceLocationData pld in pieces)
            {
                if (pld.GetPiece() == p)
                {
                    pieces.Remove(pld);
                    return;
                }
            }
        }

        public bool ContainsPiece(Piece Key)
        {
            foreach(PieceLocationData pld in pieces)
            {
                if(pld.GetPiece() == key)
                {
                    return true;
                }
            }

            return false;
        }

        public PieceLocationData this [int index]
        {
            get { return pieces [index]; }
        }

        public bool IsOnBoard(Piece piece)
        {
            foreach(PieceLocationData pld in pieces)
            {
                if (pld.GetPiece() == piece)
                {
                    return pld.IsOnBoard();
                }
            }

            return false;
        }

        public Piece GetPiece(int pieceid)
        {
            Piece result = null;

            foreach (PieceLocationData pld in pieces)
            {
                if (pld.GetPiece() == piece)
                {
                    result = pld.GetTile();
                }
            }

            return result;
        }

        public int IndexOf (Piece piece)
        {
            for (int i = 0; i < pieces.Count; i++)
            {
                if(ContainsPiece(piece))
                {
                    return i;
                }
            }

            return -1;
        }

        public PieceLocationData GetLPD(Piece piece)
        {
            foreach (PieceLocationData pld in pieces)
            {
                if(pld.GetPiece() == piece)
                {
                    return pld;
                }
            }

            return null;
        }

        public void SetTile(Piece piece, BoardBlock tile)
        {
            GetLPD(piece).SetTile(tile);
        }

    }

    public class PieceLocationData
    {
        private Piece piece;
        private BoardBlock tile;
        private bool hasTile;

        public PieceLocationData(Piece piece, BoardBlock tile = null)
        {
            this.piece = piece;
            this.tile = tile;
            hasTile = tile != null;
        }

        public void SetPiece(Piece p)
        {
            piece = p;
        }

        public void SetTile(BoardBlock t)
        {
            tile = t;
            hasTile = tile != null;
        }

        public BoardBlock GetTile()
        {
            return tile;
        }

        public bool IsOnBoard()
        {
            return hasTile;
        }
    }
}