using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CuentaAhorro : Cuenta
    {
        public decimal TOPE = 10000;
        public List<Movimiento> Movimientos { get; set; }

        public CuentaAhorro ()
        {
            Movimientos = new List<Movimiento>();
        }

        public CuentaAhorro(decimal numero , Cliente cliente, string tipo)
        {
            Numero = numero;
            Cliente = cliente;
            Tipo = tipo;
            Movimientos = new List<Movimiento>();
        }



        public override string Consignar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                RegistrarMovimiento(valor, "Consignacion");
                return $"Se Consigno {valor}";
            }
            return $"No Se Acepto El Valor Regitrado";
        }
        private void RegistrarMovimiento (decimal valor , string tipo)
        {
            Movimiento movimiento = new Movimiento();
            movimiento.Fecha = DateTime.Now;
            movimiento.Tipo = Tipo;
            movimiento.Saldo = Saldo;
            movimiento.Valor = valor;
            Movimientos.Add(movimiento);
        }

        public override string Retirar(decimal valor)
        {
            if ((Saldo-valor)>=TOPE)
            {
                Saldo -= valor;
                RegistrarMovimiento(valor, "Retiro");
                return $"Se Retiro {valor} Su nuevo Saldo es {Saldo}";
            }
            return $"Saldo Insuficiente No es Posible Retirar {valor}";
        }
    }
}
