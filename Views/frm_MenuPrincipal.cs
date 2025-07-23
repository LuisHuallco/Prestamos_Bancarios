using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosBanco.Views
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frm_Clientes ventana = new frm_Clientes();
            ventana.ShowDialog();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            frm_Cuentas ventana = new frm_Cuentas();
            ventana.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            frm_Prestamos ventana = new frm_Prestamos();
            ventana.ShowDialog();
        }

    }
}