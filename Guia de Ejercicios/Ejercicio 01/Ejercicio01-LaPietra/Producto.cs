using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio01_LaPietra
{
    public class Producto
    {

        public string CodigoBarra;
        public string Nombre;
        public string Descripcion;
        public float Precio;

        public override string ToString()
        {
            return "CB: " + CodigoBarra + ", Nombre: " + Nombre + ", Precio: $" + Precio.ToString();
        }

    }
}