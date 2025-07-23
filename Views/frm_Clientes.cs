using System;
using System.Windows.Forms;
using PrestamosBanco.Models;
using PrestamosBanco.Controllers;
using System.Collections.Generic;

namespace PrestamosBanco.Views
{
    public partial class frm_Clientes : Form
    {
        private int idSeleccionado = -1;
        ClienteController controlador = new ClienteController();

        public frm_Clientes()
        {
            InitializeComponent();
            CargarClientes();
        }
        private void CargarClientes()
        {
            List<ClienteModel> clientes = controlador.ObtenerClientes();
            dgvClientes.DataSource = clientes;

            // Ocultar columna ID
            dgvClientes.Columns["ID"].Visible = false;

            // (Opcional) Mejora los encabezados
            dgvClientes.Columns["Nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["Telefono"].HeaderText = "Teléfono";
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            idSeleccionado = -1;
            dgvClientes.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            if (idSeleccionado == -1)
            {
                // REGISTRO NUEVO
                ClienteModel nuevo = new ClienteModel
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text
                };

                controlador.AgregarCliente(nuevo);
                MessageBox.Show("Cliente agregado.");
            }
            else
            {
                // EDICIÓN
                ClienteModel editar = new ClienteModel
                {
                    ID = idSeleccionado,
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text
                };

                controlador.EditarCliente(editar);
                MessageBox.Show("Cliente actualizado.");
            }

            CargarClientes();
            LimpiarCampos();
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un cliente de la tabla.");
                return;
            }

            DialogResult r = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                controlador.EliminarCliente(idSeleccionado);
                MessageBox.Show("Cliente eliminado.");
                CargarClientes();
                LimpiarCampos();
            }
        }

        private void frm_Clientes_Load(object sender, EventArgs e)
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
