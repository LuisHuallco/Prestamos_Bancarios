using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosBanco.Models
{
    public class PrestamoModel
    {
        public int ID { get; set; }
        public int ID_Cliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal Monto { get; set; }
        public decimal Interes { get; set; } // en porcentaje
        public int Plazo { get; set; } // en meses
        public decimal TotalPagar => Monto + (Monto * (Interes / 100));
    }
}
