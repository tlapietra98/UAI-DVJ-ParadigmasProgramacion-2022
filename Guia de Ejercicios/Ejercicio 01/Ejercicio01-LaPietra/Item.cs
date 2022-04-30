using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio01_LaPietra
{
    public class Item
    {

        public Producto Producto;

        public int Cantidad;

        public float Calcular()
        {
            return Cantidad * Producto.Precio;

        }
    }
}