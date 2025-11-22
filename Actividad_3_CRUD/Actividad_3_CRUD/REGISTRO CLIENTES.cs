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
    public partial class REGISTRO_CLIENTES : Form
    {
        string connectionString = "Data Source=FRANK\\SQLEXPRESS;Initial Catalog=empresa;Integrated Security=True;TrustServerCertificate=True;";
        public REGISTRO_CLIENTES()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CLIENTES", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGVClientes.DataSource = dt;
            }
        }
        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txttelefono.Clear();
            DTPfecha.Value = DateTime.Now;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO CLIENTES (Nombre,Apellidos,FechaNac,Tlfn)" + " VALUES (@Nombre,@Apellidos,@Fecha,@Telefono)", con);
                cmd.Parameters.AddWithValue("@Nombre", txtNombres.Text);
                cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
                cmd.Parameters.AddWithValue("@fecha", DTPfecha.Value.Date);
                cmd.Parameters.AddWithValue("@Telefono", txttelefono.Text);

                cmd.ExecuteNonQuery();
            }
            CargarDatos();
            LimpiarCampos();
            MessageBox.Show("Cliente Agregado correctamente ");

        }

        private void REGISTRO_CLIENTES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empresaDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.empresaDataSet.CLIENTES);
            CargarDatos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CLIENTES SET  Nombre=@Nombre,Apellidos=@Apellidos,FechaNac=@fecha,Tlfn= @Telefono" +
                    "WHERE Dni=@Dni", con);
                cmd.Parameters.AddWithValue("@Nombre", txtNombres.Text);
                cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
                cmd.Parameters.AddWithValue("@FechaNac", DTPfecha.Value.Date);
                cmd.Parameters.AddWithValue("@Tlfn", txttelefono.Text);

                cmd.ExecuteNonQuery();
            }
            CargarDatos();
            LimpiarCampos();
            MessageBox.Show("CLiente Actualizado");

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Selecciona un Cliente");
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM CLIENTES WHERE Dni=@Dni", con);
                cmd.Parameters.AddWithValue("@Dni", txtDNI.Text);
                cmd.ExecuteNonQuery();
                LimpiarCampos();
                MessageBox.Show("Empleado Cliente");
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Por favor, ingresa un DNI.");
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CLIENTES WHERE Dni = @Dni";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Dni", txtDNI.Text);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Cargar datos en los TextBox
                    txtDNI.Text = reader["Dni"].ToString();
                    txtNombres.Text = reader["Nombre"].ToString();
                    txtApellidos.Text = reader["Apellidos"].ToString();
                    DTPfecha.Text = reader["FechaNac"].ToString();
                    txttelefono.Text = reader["Tlfn"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente con ese DNI.");
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
