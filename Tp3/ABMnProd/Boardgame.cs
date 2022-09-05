using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMnProd
{
    public class Boardgame : Product
    {
        private int qPlayers;
        private int[] pAge = new int [2];

        public int QPlayers
        {
            get { return qPlayers; }
        }

        public int[] PAge
        {
            get
            {
                return pAge;
            }
            set
            {
                pAge[0] = value[0];
                pAge[1] = value[1];
            }
        }

        public Boardgame(string nName, int nQPlayers) : base(nName)
        {
            qPlayers = nQPlayers;
        }

        public Boardgame(string nName, int nStock, int nQPlayers) : base(nName, nStock)
        {
            qPlayers = nQPlayers;
        }

        public Boardgame(string nName, int nStock, float nPrice, int nQPlayers) : base(nName, nStock, nPrice)
        {
            qPlayers = nQPlayers;
        }

    }
}
