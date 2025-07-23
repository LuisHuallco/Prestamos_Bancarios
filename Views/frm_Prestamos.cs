using MySql.Data.MySqlClient;
using PrestamosBanco.Controllers;
using PrestamosBanco.Data;
using PrestamosBanco.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrestamosBanco.Views
{
    public partial class frm_Prestamos : Form
    {
        private PrestamoController controller = new PrestamoController();
        private int idSeleccionado = -1;
        private List<ClienteModel> clientes = new List<ClienteModel>();

        public frm_Prestamos()
        {
            InitializeComponent();
            CargarClientes();
            CargarPrestamos();
        }

        private void CargarClientes()
        {
            clientes = controller.ObtenerClientes();
            cbClientes.DataSource = clientes;
            cbClientes.DisplayMember = "Nombre";
            cbClientes.ValueMember = "ID";
        }

        private void CargarPrestamos()
        {
            dgvPrestamos.DataSource = controller.ObtenerPrestamos();

            // Ocultar columnas internas
            dgvPrestamos.Columns["ID"].Visible = false;
            dgvPrestamos.Columns["ID_Cliente"].Visible = false;

            // (Opcional) Mejora los encabezados
            dgvPrestamos.Columns["NombreCliente"].HeaderText = "Cliente";
            dgvPrestamos.Columns["Monto"].HeaderText = "Monto";
            dgvPrestamos.Columns["Interes"].HeaderText = "Interés (%)";
            dgvPrestamos.Columns["Plazo"].HeaderText = "Plazo (meses)";
            dgvPrestamos.Columns["TotalPagar"].HeaderText = "Total a Pagar";
        }


        private void CalcularTotal()
        {
            if (decimal.TryParse(txtMonto.Text, out decimal monto) &&
                decimal.TryParse(txtInteres.Text, out decimal interes))
            {
                decimal total = monto + (monto * (interes / 100));
                lblResultado.Text = total.ToString("0.00");
            }
            else
            {
                lblResultado.Text = "0.00";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex == -1 || txtMonto.Text == "" || txtInteres.Text == "" || txtPlazo.Text == "")
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            if (idSeleccionado == -1)
            {
                // NUEVO PRÉSTAMO
                PrestamoModel nuevo = new PrestamoModel
                {
                    ID_Cliente = Convert.ToInt32(cbClientes.SelectedValue),
                    Monto = Convert.ToDecimal(txtMonto.Text),
                    Interes = Convert.ToDecimal(txtInteres.Text),
                    Plazo = Convert.ToInt32(txtPlazo.Text)
                };

                controller.AgregarPrestamo(nuevo);

                // 💡 Suma el monto prestado al saldo de la cuenta asociada al cliente:
                SumarSaldoCuentaPorCliente(nuevo.ID_Cliente, nuevo.Monto);

                MessageBox.Show("Préstamo agregado y saldo de cuenta actualizado.");
            }
            else
            {
                // EDICIÓN (no se suma de nuevo el saldo)
                PrestamoModel editar = new PrestamoModel
                {
                    ID = idSeleccionado,
                    Monto = Convert.ToDecimal(txtMonto.Text),
                    Interes = Convert.ToDecimal(txtInteres.Text),
                    Plazo = Convert.ToInt32(txtPlazo.Text)
                };

                controller.EditarPrestamo(editar);
                MessageBox.Show("Préstamo actualizado.");
            }

            CargarPrestamos();
            Limpiar();
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvPrestamos.Rows[e.RowIndex].Cells["ID"].Value);
                txtMonto.Text = dgvPrestamos.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
                txtInteres.Text = dgvPrestamos.Rows[e.RowIndex].Cells["Interes"].Value.ToString();
                txtPlazo.Text = dgvPrestamos.Rows[e.RowIndex].Cells["Plazo"].Value.ToString();
                string nombre = dgvPrestamos.Rows[e.RowIndex].Cells["NombreCliente"].Value.ToString();
                cbClientes.SelectedIndex = cbClientes.FindStringExact(nombre);
                CalcularTotal();
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void txtInteres_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void Limpiar()
        {
            txtMonto.Text = "";
            txtInteres.Text = "";
            txtPlazo.Text = "";
            lblResultado.Text = "0.00";
            idSeleccionado = -1;
            cbClientes.SelectedIndex = 0;
            dgvPrestamos.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un préstamo para eliminar.");
                return;
            }

            controller.EliminarPrestamo(idSeleccionado);
            MessageBox.Show("Préstamo eliminado.");
            CargarPrestamos();
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 🔵 Método para sumar saldo a la cuenta del cliente cuando recibe un préstamo
        public void SumarSaldoCuentaPorCliente(int idCliente, decimal monto)
        {
            using (var conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE cuenta SET Saldo = Saldo + @Monto WHERE ID_Cliente = @ID_Cliente";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Monto", monto);
                cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
                cmd.ExecuteNonQuery();
            }
        }

        private void frm_Prestamos_Load(object sender, EventArgs e)
        {
            btnGuardar.BackColor = ColorTranslator.FromHtml("#2762A5");
            btnGuardar.ForeColor = Color.White;

            btnEliminar.BackColor = ColorTranslator.FromHtml("#DC3545");
            btnEliminar.ForeColor = Color.White;

            btnCancelar.BackColor = ColorTranslator.FromHtml("#E6EAF0");
            btnCancelar.ForeColor = ColorTranslator.FromHtml("#2762A5");

            btnLimpiar.BackColor = ColorTranslator.FromHtml("#E6EAF0");
            btnLimpiar.ForeColor = ColorTranslator.FromHtml("#2762A5");
        }
    }
}
