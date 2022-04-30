using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01_LaPietra
{
    public partial class Form1 : Form
    {

        Libreria libreria = new Libreria();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.CodigoBarra = textBox1.Text;
            p.Nombre = textBox2.Text;
            p.Descripcion = textBox3.Text;
            p.Precio = float.Parse(textBox4.Text);

            listBox1.Items.Add(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            libreria.IniciarVenta();
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Item item = new Item();

            item.Cantidad = int.Parse(textBox5.Text);
            item.Producto = (Producto)listBox1.SelectedItem;

            libreria.AgregarProducto(item);

            Venta venta = libreria.DevolverVenta();

            label7.Text = "Subtotal = $" + venta.MostrarSubtotal();

            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            libreria.FinalizarVenta();
            button3.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label8.Text = "Total Recaudado: $" + libreria.ObtenerRecaudacion().ToString();
        }
    }
}
