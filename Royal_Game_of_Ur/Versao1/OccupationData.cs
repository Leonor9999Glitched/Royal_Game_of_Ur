namespace Royal_Game_of_Ur
{
    public class OccupationData
    {
        private bool isOccupied;
        private int playerID;
        private int pieceID;
        private bool selfOccupied;
        private bool opponentOverlap;
        private int overLapperID;
        private int overLapLocation;

        public OccupationData()
        {
            isOccupied = false;
            playerID = -1;
            pieceID = -1;
        }

        public void Occupy(int playerid, int pieceid)
        {
            isOccupied = true;
            playerID = playerid;
            pieceID = pieceid;
        }

        public void UnOccupy()
        {
            isOccupied = false;
            playerID = -1;
            pieceID = -1;
            selfOccupied = false;
        }

        public bool IsOccupied
        {
            get { return isOccupied; }
            set { isOccupied = value; }
        }

        public int PlayerID
        {
            get { return playerID; }
            set { playerID = value; }
        }

        public int PieceID
        {
            get { return pieceID; }
            set { pieceID = value; }
        }

        public bool SelfOccupied
        {
            get { return selfOccupied; }
            set { selfOccupied = value; }
        }

        public int OverLapperID
        {
            get { return overLapperID; }
            set { overLapperID = value; }
        }

        public bool OpponentOverlap
        {
            get { return opponentOverlap; }
            set { opponentOverlap = value; }
        }

        public int OverLapLocation
        {
            get { return overLapLocation; }
            set { overLapLocation = value; }
        }
    }
}