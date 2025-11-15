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
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void Btningreso_Click(object sender, EventArgs e)
        {
            string contra = textBox1.Text;
            if(textBox1.Text == "1234")
            {
                this.Hide();
                Form1 menu = new Form1();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa  la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
