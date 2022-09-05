using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMnProd
{
    public interface Deposit
    {
        public string Name
        {
            get;
        }

        public string Direct
        {
            get;
        }

        public List<Product> Products
        {
            get;
        }
    }
    public abstract class Warehouse : Deposit
    {
        private string name;
        private string direct;
        private List<Product> products;

        public string Name
        {
            get { return name; }
        }

        public string Direct
        {
            get
            {
                return direct;
            }
        }

        public List<Product> Products
        {
            get
            {
                return products;
            }
        }

        public void AddProduct(Product nProduct)
        {
            products.Add(nProduct);
        }

        public Warehouse(string name, string direct)
        {
            this.name = name;
            this.direct = direct;
            products = new List<Product>();
        }

        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.Append(string.Format($"{this.Name}, ({this.Direct})"));
            return data.ToString();
        }

    }
}
