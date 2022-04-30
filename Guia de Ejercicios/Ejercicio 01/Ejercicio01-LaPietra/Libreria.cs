using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio01_LaPietra
{
    public class Libreria
    {

        private float recaudacion;

        private Venta venta;

        public float ObtenerRecaudacion()
        {
            return recaudacion;
        }

        public void IniciarVenta()
        {
            venta = new Venta();
        }

        public void AgregarProducto(Item item)
        {
            venta.AgregarProducto(item);

        }

        public void FinalizarVenta()
        {
            recaudacion += venta.MostrarSubtotal();
        }

        public Venta DevolverVenta()
        {
            return venta;
        }

    }
}