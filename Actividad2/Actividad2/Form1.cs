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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saludo saludo = new Saludo();
            saludo.Show();
        }

        private void operacionesBasicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Operaciones_Básicas operaciones_Básicas = new Operaciones_Básicas();
            operaciones_Básicas.Show();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informacion_personal informacion_Personal = new Informacion_personal();
            informacion_Personal.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
