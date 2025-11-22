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
    public partial class Registro_Producto : Form
    {
        public Registro_Producto()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=FRANK\\SQLEXPRESS;Initial Catalog=empresa;Integrated Security=True;TrustServerCertificate=True;";
        private void CargarProveedores()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Nif, Nombre FROM PROVEDORES";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbprovedor.DataSource = dt;
                cmbprovedor.DisplayMember = "Nombre";
                cmbprovedor.ValueMember = "Nif";
            }
        }
        private void CargarProductos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT p.Codigo, p.Nombre, p.precio, 
                         , p.nifProveedor, pr.Nombre 
                         FROM Productos p 
                         INNER JOIN Proveedores pr ON p.nifProveedor = pr.Nif";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProductos.DataSource = dt;
            }
        }
        private void Registro_Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empresaDataSet2.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOSTableAdapter.Fill(this.empresaDataSet2.PRODUCTOS);
            CargarProveedores();
            CargarProductos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO PRODUCTOS 
                        (Nombre,precio, nifProveedor)
                        VALUES (@Nombre, @precio, @nifProveedor)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@precio", txtprecio.Text);
                cmd.Parameters.AddWithValue("@nifProveedor", cmbprovedor.SelectedValue);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Producto agregado correctamente.");
                CargarProductos();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE PRODUCTOS SET 
                        Nombre=@Nombre,
                        Precio=@Precio,
                        nifProveedor=@nifProveedor
                        WHERE Codigo=@Codigo";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@precio", txtprecio.Text);
                cmd.Parameters.AddWithValue("@nifProveedor", cmbprovedor.SelectedValue);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Producto actualizado correctamente.");
                CargarProductos();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM PRODUCTOS WHERE Codigo=@Codigo";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Producto eliminado.");
                CargarProductos();
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PRODUCTOS WHERE Codigo=@Codigo";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtprecio.Text = reader["precio"].ToString();
                    cmbprovedor.SelectedValue = reader["nifProveedor"];
                }
                else
                {
                    MessageBox.Show("No se encontró el producto.");
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
