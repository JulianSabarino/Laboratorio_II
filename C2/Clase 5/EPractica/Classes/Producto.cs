using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EPractica.Classes
{
    public class Producto
    {
        private string _codigoDeBarras;
        private string _marca;
        private float _precio;

        #region Sobrecargas

        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" ");
            if (p is not null)
            {
                sb.Clear();
                sb.Append($"{p.CodigoDeBarras}");
            }
            return sb.ToString();
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool b = false;
            if (p is not null)
            {
                b = (p.Marca == marca);
            }
            return b;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator ==(Producto p, Producto p2)
        {
            bool b = false;
            if (p is not null && p2 is not null)
            {
                b = (p.Marca == p2.Marca && p.CodigoDeBarras == p.CodigoDeBarras);
            }
            return b;
        }

        public static bool operator !=(Producto p, Producto p2)
        {
            return !(p == p2);
        }

        #endregion

        #region Getters
        public string CodigoDeBarras
        {
            get { return _codigoDeBarras; }
        }

        public string Marca
        {
            get { return _marca; }
        }

        public float Precio
        {
            get { return _precio; }
        }

        #endregion

        public static string MostrarProductos(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{p.CodigoDeBarras}|{p.Marca}      ${p.Precio}");
            sb.AppendLine("_____________");

            return sb.ToString();
        }

        public Producto(string codigoDeBarras, string marca, float precio)
        {
            _codigoDeBarras = codigoDeBarras;
            _marca = marca;
            _precio = precio;
        }
    }
}
