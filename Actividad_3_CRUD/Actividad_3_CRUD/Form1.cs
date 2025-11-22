using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a la tienda en linea ZAPATERIA UMI, donde podra encontrar todo lo que usted necesita y si no lo encuentra se lo conseguimos.\r\nSomos su mejor opcion hoy y siempre.", "Bienvenida");

        }

        private void quiénesSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Somos una empreza mexicana, que trata de apoyar al comercio mexicano, todos nuestros productos son 100% mexicanos, por que creemos en nosotros y por que sabemos que podemos.", "¿Quiénes Somos?.  ");

        }

        private void misionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuestra mision es darnos a conocer a nivel nacional y lograr el objetivo Ole que todos los mexicanos utilicen productos mexicanos, que abramos los ojos y veamos que no por que el producto sea de otro pais, signifique que es mejor", "Mision");

        }

        private void visionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuestra vision es que una vez que nos encontremos a nivel nacional, buscaremos el mercado internacional y llevaremos el nombre de nusetro producto, de nuestro pais, a todo el mundo para que sepan de lo que somos capaces", "Vision");

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGISTRO_CLIENTES REGISTRO = new REGISTRO_CLIENTES();
            REGISTRO.Show();
            this.Hide();
        }

        private void provedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Provedores provedores = new Registro_Provedores();
            provedores.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registro_Producto producto = new Registro_Producto();
            producto.Show();
            this.Hide();
        }

        private void damasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compra compra = new compra();
            compra.Show(); 
            this.Hide();
        }
    }
}
