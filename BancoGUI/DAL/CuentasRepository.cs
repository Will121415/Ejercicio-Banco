using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class CuentasRepository
    {
        private List<Cuenta> Cuentas;

        public CuentasRepository()
        {
            Cuentas = new List<Cuenta>();
        }

        public void Guardar(Cuenta cuenta)
        {
            Cuentas.Add(cuenta);
        }

        public void Eliminar(Cuenta cuenta)
        {
            Cuentas.Remove(cuenta);
        }

        public List<Cuenta> ListaCuentas()
        {
            return Cuentas;
        }

        public Cuenta BuscarCuenta (Decimal indentificacion)
        {
            foreach (var item in Cuentas)
            {
                if (item.Numero == indentificacion)
                {
                    return item;

                }
            }
            return null;
        }

        public void Modificar(Cuenta cuentaEliminada, Cuenta cuentaModificada)
        {
            Cuentas.Add(cuentaModificada);
            Cuentas.Remove(cuentaEliminada);
        }

    }
}
