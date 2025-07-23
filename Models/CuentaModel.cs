using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosBanco.Models
{
    public class CuentaModel
    {
        public int ID { get; set; }
        public decimal Saldo { get; set; }
        public int ID_Cliente { get; set; }
        public string NombreCliente { get; set; }
    }
}
