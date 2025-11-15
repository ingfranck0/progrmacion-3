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
    public partial class Informacion_personal : Form
    {
        public Informacion_personal()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RBE.Checked)
            {
                CBEnfermedad.Show();
            }
            else
            {
                CBEnfermedad.Hide();
            }
        }

        private void RBA_CheckedChanged(object sender, EventArgs e)
        {
            if (RBA.Checked)
            {
                CBAlergias.Show();
            }
            else
            {
                CBAlergias.Hide();
            }
        }

        private void RBO_CheckedChanged(object sender, EventArgs e)
        {
            if (RBO.Checked)
            {
                CBOperacion.Show();
            }
            else
            {
                CBOperacion.Hide();
            }
        }

        private void RBEj_CheckedChanged(object sender, EventArgs e)
        {
            if (RBEj.Checked)
            {
                CBEjercicio.Show();
            }
            else
            {
                CBEjercicio.Hide();
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