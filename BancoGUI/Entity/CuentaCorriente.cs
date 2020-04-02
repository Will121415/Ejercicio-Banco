using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CuentaCorriente : Cuenta
    {
        public decimal Cupo { get; set; }
        public List<Movimiento> Movimientos { get; set; }

        public CuentaCorriente()
        {
            Movimientos = new List<Movimiento>();
        }

        public CuentaCorriente(decimal numero, Cliente cliente, string tipo)
        {
            Numero = numero;
            Cliente = cliente;
            Tipo = tipo;
            Cupo = 100000;
            Movimientos = new List<Movimiento>();
        }

        public override string Consignar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Cupo += valor;
                RegistrarMovimiento(valor, "Consignacion");
                return $"Se Consigno Correctamente su nuevo saldo es de: {Saldo} y cupo: {Cupo} ";
            }
            return $"Valor Fuera del cupo Admitido";
        }
        private void RegistrarMovimiento(decimal valor, string tipo)
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
            if (valor <= Cupo)
            {
                Saldo += valor;
                Cupo -= valor;
                RegistrarMovimiento(valor, "Consignacion");
                return $"Se Retiro Correctamente su nuevo saldo es de: {Saldo} y cupo: {Cupo} ";
            }
            return $"Valor Fuera del cupo Admitido";
        }
    }
}
