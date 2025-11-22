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
    public partial class compra : Form
    {
        
        public compra()
        {
            InitializeComponent();
            CargarClientes();
            CargarProductos();
            MostrarTabla();
        }
        


        private void compra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empresaDataSet3.COMPRA' Puede moverla o quitarla según sea necesario.
            this.cOMPRATableAdapter.Fill(this.empresaDataSet3.COMPRA);

        }
        string connectionString = "Data Source=FRANK\\SQLEXPRESS;Initial Catalog=empresa;Integrated Security=True;TrustServerCertificate=True;";
        private void CargarClientes()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                string query = "SELECT DniCliente FROM COMPRA";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbdni.DataSource = dt;
                cmbdni.DisplayMember = "DniCliente";
                cmbdni.ValueMember = "DniCliente";
            }
        }
        private void CargarProductos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                string query = "SELECT CodProducto FROM PRODUCTOS";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbcodprodcuto.DataSource = dt;
                cmbcodprodcuto.DisplayMember = "CodProducto";
                cmbcodprodcuto.ValueMember = "CodProducto";
            }
        }
        private void MostrarTabla()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM COMPRA";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCompra.DataSource = dt;
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                {
                    string query = "INSERT INTO COMPRA (DniCliente, CodProducto) VALUES (@Dni, @Cod)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Dni", cmbdni.SelectedValue);
                    cmd.Parameters.AddWithValue("@Cod", cmbcodprodcuto.SelectedValue);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MostrarTabla();
                    MessageBox.Show("Compra agregada correctamente");
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Compra WHERE DniCliente = @Dni AND CodProducto = @Cod";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Dni", cmbdni.SelectedValue);
                cmd.Parameters.AddWithValue("@Cod", cmbcodprodcuto.SelectedValue);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MostrarTabla();
                MessageBox.Show("Registro eliminado correctamente");
            }
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            MostrarTabla();
        }
    }
}
