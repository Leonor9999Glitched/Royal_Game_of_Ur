using System;
using System.Collections;
using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    
    // A BoardBlock class é responsavel por guardar dados,
    // cordena instancias, posições no board,
    // se está ocupado por outra peça, por qual jogador.
    
    class BoardBlock  //Tile
    {
        string BoardBlockName;

        public enum OwnerTypes { P1, P2, BOTH }
        
        // verifica qual player esta apto para ocupar este block
        
        private PlayerType owner;
        
        // Onde este Block está localizado no board
        
        private int position;
        
        // Se este Block está atualmente ocupado por uma Piece
        
        private bool shared;
        
        // Se este Block contêm uma rosette,
        // o jogador que calhar neste Block
        // está salvo e recebe um novo turno.
        
        private bool isRosette;
        
        // OccupationData dos Block´s
        
        private OccupationData occupationData = new OccupationData();


        //Construtores


        public BoardBlock(int pos)
        {
            position = pos;
            isRosette = (position == 3 || position == 7 || position == 13);
            shared = owner != PlayerType.Neutral;
        }
        public BoardBlock()
        {
            position = -1;
            isRosette = (position == 3 || position == 7 || position == 13);
        }

        public BoardBlock(bool isFinalDestination, PlayerType owner)
        {
            BoardBlockName = "Final Destination BoardBlock";
            this.owner = owner;
            shared = false;
            Console.WriteLine("Meta Final");
        }

        // zona onde estao GET/SET´s

        // Para Aceder
        public int GetPosition()
        {
            return position;
        }
        public bool IsShared()
        {
            return shared;
        }

        // Para alterar
        public void SetPosition(int pos)
        {
            position = pos;
        }

        public bool IsRosette
        {
            get
            {
                return isRosette;
            }

            set
            {
                isRosette = value;
            }
        }

        //Operações

        public OccupationData GetOccupationData(PlayerType owner, int pieceid)
        {
            if (occupationData.IsOccupied)
            {
                // se o jogador esta a ultrapassar uma peça sua
                if (occupationData.PlayerID == (int)owner)
                    occupationData.SelfOccupied = true;
                // se o jogador esta a ultrapassar uma peça do seu oponente
                else
                {
                    occupationData.OverLapperID = pieceid;
                    occupationData.OpponentOverlap = true;
                }

                occupationData.OverLapLocation = position;
            }

            return occupationData;
        }



        public OccupationData Occupy(int playerid, int pieceid, out bool success)
        {
            // Se este Block não esta ocupado
            if (!occupationData.IsOccupied)
            {
                occupationData.Occupy(playerid, pieceid);
                success = true;
            }
            // Se este Block esta ocupado
            else
            {
                success = false;

                // se o jogador esta a ultrapassar uma peça sua
                if (occupationData.PlayerID == playerid)
                    occupationData.SelfOccupied = true;
                // se o jogador esta a ultrapassar uma peça do seu oponente
                else
                {
                    occupationData.OverLapperID = pieceid;
                    occupationData.OpponentOverlap = true;
                }

                occupationData.OverLapLocation = position;
            }

            return occupationData;
        }

        public void Occupy(int playerid, int pieceid)
        {
            occupationData.Occupy(playerid, pieceid);
        }

        public void Unoccupy()
        {
            occupationData.UnOccupy();
        }

    }
}




