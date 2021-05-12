using System;
using System.Collections;
using System.Collections.Generic;

namespace Royal_Dame_of_Ur
{
    
    // A BoardBlock class é responsavel por guardar dados,
    // cordena instancias, posições no board,
    // se está ocupado por outra peça, por qual jogador.
    
    class BoardBlock
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

        
        // Principalmente usado para criar os block´s usados pelo player
        public BoardBlock(PlayerType owner, int position)
        {
            BoardBlockName = owner.ToString() + " BoardBlock " + position;
            this.owner = owner;
            this.position = position;
            isRosette = (position == 3 || position == 7 || position == 13);
            shared = owner != PlayerType.Neutral;
        }
    }
}




