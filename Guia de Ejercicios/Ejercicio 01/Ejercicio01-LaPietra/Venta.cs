using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio01_LaPietra
{
    public class Venta
    {

        private float subtotal;

        public void AgregarProducto(Item item)
        {
            subtotal += item.Calcular();
        }

        public float MostrarSubtotal()
        {
            return subtotal;

        }

    }
}