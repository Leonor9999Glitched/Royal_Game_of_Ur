using System;
using System.Collections.Generic;

namespace Royal_Dame_of_Ur
{
    public class Block  
    {
        public enum BlockType
        {
            Normal,
            Rosette,
            Start
        }
        public enum TerritoryType
        {
            Neutral,
            Player1,
            Player2
        }

        private BlockType blockType = BlockType.Normal;

        private TerritoryType territoryType = TerritoryType.Neutral;

        public BlockType GetBlockType()
        {
            return blockType;
        }

        public TerritoryType GetTerritoryType()
        {
            return territoryType;
        }
    }
}
