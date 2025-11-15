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
    public partial class Operaciones_Básicas : Form
    {

        public Operaciones_Básicas()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNum1.Text = string.Empty;
            txtNum2.Text = string.Empty;
            txtNum3.Text = string.Empty;
            txtNum4.Text = string.Empty;
            txtNum5.Text = string.Empty;
            txtNum6.Text = string.Empty;
            txtResultado.Text = string.Empty;
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            //obtener  numeros de los txtbox
            float num1  = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float num3 = float.Parse(txtNum3.Text);
            float num4 = float.Parse(txtNum4.Text);
            float num5 = float.Parse(txtNum5.Text);
            float num6 = float.Parse(txtNum6.Text);

            //Realizar operacion 
            float suma = num1 + num2 + num3 + num4 + num5 + num6;

            //Mostrar resultado
            txtResultado.ReadOnly = true;
            txtResultado .Text = suma.ToString();

        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            //obtener  numeros de los txtbox
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float num3 = float.Parse(txtNum3.Text);
            float num4 = float.Parse(txtNum4.Text);
            float num5 = float.Parse(txtNum5.Text);
            float num6 = float.Parse(txtNum6.Text);

            //Realizar operacion 
            float resta = num1 - num2 - num3 - num4 - num5 - num6;

            //Mostrar resultado
            txtResultado.ReadOnly = true;
            txtResultado.Text = resta.ToString();
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            //obtener  numeros de los txtbox
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float num3 = float.Parse(txtNum3.Text);
            float num4 = float.Parse(txtNum4.Text);
            float num5 = float.Parse(txtNum5.Text);
            float num6 = float.Parse(txtNum6.Text);

            //Realizar operacion 
            float multiplicacion = num1 * num2 * num3 * num4 * num5 * num6;

            //Mostrar resultado
            txtResultado.ReadOnly = true;
            txtResultado.Text = multiplicacion.ToString();
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            //obtener  numeros de los txtbox
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float num3 = float.Parse(txtNum3.Text);
            float num4 = float.Parse(txtNum4.Text);
            float num5 = float.Parse(txtNum5.Text);
            float num6 = float.Parse(txtNum6.Text);

            //Realizar operacion 
            float division = num1 / num2 /num3 / num4 / num5 / num6;

            //Mostrar resultado
            txtResultado.ReadOnly = true;
            txtResultado.Text = division.ToString();

        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
