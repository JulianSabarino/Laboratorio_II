using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMnProd
{
    public class Props : Product
    {
        public enum Type
        {
            Dice,
            Tabletop,
            Mini,
            other
        }

        private Type pType;

        public string PType
        {
            get
            {
                return pType.ToString();
            }
        }

        public Props(string nName, Type nType) : base(nName)
        {
            pType = nType;
        }

        public Props(string nName, int nStock, Type nType) : base(nName, nStock)
        {
            pType = nType;
        }

        public Props(string nName, int nStock, float nPrice, Type nType) : base(nName, nStock, nPrice)
        {
            pType = nType;
        }

        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.Append(string.Format($"{this.Name}({this.pType})"));
            return data.ToString();
        }
    }
}
