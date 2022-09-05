using System;
using System.Text;
using System.Collections.Generic;

namespace ABMnProd
{

    public interface Products
    {
        public string Name
        {
            get;
        }

        public float Price
        {
            get;
            set;
        }
        public int Stock
        {
            get;
            set;
        }

        //public static int operator +(Product nProduct, int nStock);

    }

    public class Julian
    {
        private readonly string name = "Julian Sabarino";
        private List<string> knowledges;

        public bool Learn(string newKnowledge)
        {
            bool addNewKnowledge;
            if (newKnowledge != null)
            {
                addNewKnowledge = true;
                knowledges.Add(newKnowledge);
            }
            else
                addNewKnowledge = false;
            return addNewKnowledge;
        }

        public void LearningLoop()
        {
            string knowledge;
            while (true)
            {
                knowledge = Console.ReadLine();
                Learn(knowledge);
            }
        
        }

        public Julian(){}
    }

    public abstract class Product : Products
    {
        private string name;
        private float price;
        private int stock;

        #region Getters and Setters
        public string Name
        {
            get { return name; }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }
        #endregion

        public Product(string nName)
        {
            name = nName;
        }

        public Product(string nName, int nStock) : this(nName)
        {
            stock = nStock;
        }

        public Product(string nName, int nStock, float nPrice) : this(nName, nStock)
        {
            price = nPrice;
        }

        public static Product operator +(Product nProduct, int nStock)
        {
            int currentStock = nProduct.Stock;
            currentStock += nStock;
            nProduct.Stock = currentStock;
            return nProduct;
        }

        public static Product operator +(Product nProduct, float nPrice)
        {
            float currentPrice = nProduct.Price;
            currentPrice += nPrice;
            nProduct.Price = currentPrice;
            return nProduct;
        }

        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.Append(string.Format($"{this.Name}"));
            return data.ToString();
        }

    }
}
