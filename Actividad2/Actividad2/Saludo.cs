using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class Saludo : Form
    {
        public Saludo()
        {
            InitializeComponent();
        }

        private void BTNSaludar_Click(object sender, EventArgs e)
        {
            //Obtener el Nombre del textbox
            string Nombre = TXTNombre.Text;

            //Verificar si el textbox no esta vacio
            if (!string.IsNullOrEmpty(Nombre))
            {
                //Crear Mensaje de Saludo
                String Mensaje = "Hola ," + Nombre + " Que tal tu dia?";
                MessageBox.Show(Mensaje, "Saludo Personalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
