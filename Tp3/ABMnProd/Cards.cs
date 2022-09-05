using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMnProd
{
    public class Cards : Product
    {
        public enum Type
        {
            Gambling,
            TCG
        }

        private Type cType;

        public string CType
        {
            get
            {
                return cType.ToString();
            }
        }

        public Cards(string nName,Type nType) : base(nName)
        {
            cType = nType;
        }

        public Cards(string nName, int nStock, Type nType) : base(nName, nStock)
        {
            cType = nType;
        }

        public Cards(string nName, int nStock, float nPrice, Type nType) : base(nName, nStock, nPrice)
        {
            cType = nType;
        }
    }
}
