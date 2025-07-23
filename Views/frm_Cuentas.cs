using PrestamosBanco.Controllers;
using PrestamosBanco.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrestamosBanco.Views
{
    public partial class frm_Cuentas : Form
    {
        private CuentaController cuentaController = new CuentaController();
        private int idSeleccionado = -1;
        private List<ClienteModel> clientes = new List<ClienteModel>();

        public frm_Cuentas()
        {
            InitializeComponent();
            CargarClientes();
            CargarCuentas();
        }

        private void CargarClientes()
        {
            clientes = cuentaController.ObtenerClientes();
            cbClientes.DisplayMember = "Nombre";
            cbClientes.ValueMember = "ID";
            cbClientes.DataSource = clientes;
        }

        private void CargarCuentas()
        {
            dgvCuentas.DataSource = cuentaController.ObtenerCuentas();

            // Ocultar columnas innecesarias
            dgvCuentas.Columns["ID"].Visible = false;
            dgvCuentas.Columns["ID_Cliente"].Visible = false;

            // (Opcional) Cambia los encabezados si quieres
            dgvCuentas.Columns["Saldo"].HeaderText = "Saldo";
            dgvCuentas.Columns["NombreCliente"].HeaderText = "Cliente";
        }


        private void Limpiar()
        {
            txtSaldo.Text = "";
            idSeleccionado = -1;
            cbClientes.SelectedIndex = 0;
            dgvCuentas.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex == -1 || txtSaldo.Text == "")
            {
                MessageBox.Show("Completa los datos.");
                return;
            }

            if (idSeleccionado == -1)
            {
                // NUEVA CUENTA
                CuentaModel nueva = new CuentaModel
                {
                    ID_Cliente = Convert.ToInt32(cbClientes.SelectedValue),
                    Saldo = Convert.ToDecimal(txtSaldo.Text)
                };

                cuentaController.AgregarCuenta(nueva);
                MessageBox.Show("Cuenta agregada.");
            }
            else
            {
                // EDITAR CUENTA
                CuentaModel editar = new CuentaModel
                {
                    ID = idSeleccionado,
                    Saldo = Convert.ToDecimal(txtSaldo.Text)
                };

                cuentaController.EditarCuenta(editar);
                MessageBox.Show("Cuenta actualizada.");
            }

            CargarCuentas();
            Limpiar();
        }

        private void dgvCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvCuentas.Rows[e.RowIndex].Cells["ID"].Value);
                txtSaldo.Text = dgvCuentas.Rows[e.RowIndex].Cells["Saldo"].Value.ToString();
                string nombreCliente = dgvCuentas.Rows[e.RowIndex].Cells["NombreCliente"].Value.ToString();
                cbClientes.SelectedIndex = cbClientes.FindStringExact(nombreCliente);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona una cuenta.");
                return;
            }

            cuentaController.EliminarCuenta(idSeleccionado);
            MessageBox.Show("Cuenta eliminada.");
            CargarCuentas();
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void frm_Cuentas_Load(object sender, EventArgs e)
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
