using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4.Classes
{
    public class Producto
    {
        private string _id;
        private string _name;
        private float _precio;
        private int _stock;

        public Producto(string name)
        {
            _name = name;
            _stock = 0;
            _precio = 0;
            Random rnd = new Random();
            _id = name + "_" + rnd.Next(0, 999);
        }

        public Producto(string name, float precio) : this(name)
        {
            _precio = precio;
        }

        public Producto(string name, float precio, int stock) : this(name, precio)
        {
            _stock = stock;
        }

        public float Precio
        {
            set { this._precio = value; }
            get { return _precio; }
        }

        public int Stock
        {
            set { this._stock = value; }
            get { return _stock; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this._id} {this._name} {this._precio} {this._stock}");

            return sb.ToString();
        }

        public static float operator +(Producto p1, Producto p2)
        {
            return p1.Precio + p2.Precio;
        }

        public static int operator +(Producto p1, int stock)
        {
            return p1.Stock + stock;
        }

        public static int operator -(Producto p1, int retiro)
        {
            return p1.Stock - retiro;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1._name == p2._name);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);//sobrecarga ==
        }
    }
}
