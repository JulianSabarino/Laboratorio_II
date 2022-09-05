using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMnProd
{
    public class PrimaryWH : Warehouse
    {
        List<SecondaryWH> secondaryWHs;

        public List<SecondaryWH> SecondaryWHs
        {
            get
            {
                return secondaryWHs;
            }
        }

        public PrimaryWH(string name, string direct) : base(name, direct)
        {
            secondaryWHs = new List<SecondaryWH>();
        }

        public void AddSecondaryWH(SecondaryWH nSecondaryWH)
        {
            secondaryWHs.Add(nSecondaryWH);
        }

    }
}
