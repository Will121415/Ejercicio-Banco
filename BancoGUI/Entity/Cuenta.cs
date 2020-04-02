using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Cuenta
    {
        public decimal Numero { get; set; }
        public Cliente Cliente { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }

        List<Movimiento> Movimientos { get; set; }

        public abstract string Consignar(decimal valor);
        public abstract string Retirar(decimal valor);
    }
}
