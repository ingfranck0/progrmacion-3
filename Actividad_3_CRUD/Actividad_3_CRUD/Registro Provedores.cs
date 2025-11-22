using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3_CRUD
{
    public partial class Registro_Provedores : Form
    {
        string connectionString = "Data Source=FRANK\\SQLEXPRESS;Initial Catalog=empresa;Integrated Security=True;TrustServerCertificate=True;";
        public Registro_Provedores()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PROVEDORES", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGVProvedores.DataSource = dt;
            }
        }
        private void LimpiarCampos()
        {
            TxtNif.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
        }

        private void Registro_Provedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empresaDataSet1.PROVEDORES' Puede moverla o quitarla según sea necesario.
            this.pROVEDORESTableAdapter.Fill(this.empresaDataSet1.PROVEDORES);

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO PROVEDORES (Nif,Nombre,Direccion)" + " VALUES (@Nif,@Nombre,@Direccion)", con);
                cmd.Parameters.AddWithValue("@Nif", TxtNif.Text);
                cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);

                cmd.ExecuteNonQuery();
            }
            CargarDatos();
            LimpiarCampos();
            MessageBox.Show("provedor Agregado correctamente ");

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TxtNif.Text == "")
            {
                MessageBox.Show("Seleccione un provedor");
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE PROVEDORES SET  Nombre=@Nombre,Direccion=@Direccion" +
                    "WHERE Nif=@Nif", con);
                cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);

                cmd.ExecuteNonQuery();
            }
            CargarDatos();
            LimpiarCampos();
            MessageBox.Show("Provedor Actualizado");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtNif.Text == "")
            {
                MessageBox.Show("Selecciona un Provedor");
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM PROVEDORES WHERE Nif=@Nif", con);
                cmd.Parameters.AddWithValue("@Nif", TxtNif.Text);
                cmd.ExecuteNonQuery();
                LimpiarCampos();
                MessageBox.Show("Empleado eliminado");
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNif.Text))
            {
                MessageBox.Show("Por favor, ingresa un NIF.");
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PROVEDORES WHERE Nif = @Nif";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nif", TxtNif.Text);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Cargar datos en los TextBox
                    TxtNif.Text = reader["Nif"].ToString();
                    TxtNombre.Text = reader["Nombre"].ToString();
                    TxtDireccion.Text = reader["Direccion"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún Provedor con ese Nif.");
                }

                con.Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
