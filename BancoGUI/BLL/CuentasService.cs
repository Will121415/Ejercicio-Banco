using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
namespace BLL
{
    public class CuentasService
    {
        public static CuentasRepository cuentasRepository;

        public static  void Guardar(Cuenta cuenta)
        {
            cuentasRepository.Guardar(cuenta);
        }

        public static  void Eliminar(Cuenta cuenta)
        {
            cuentasRepository.Eliminar(cuenta);
        }

        public static List<Cuenta> ListaCuentas()
        {
            return cuentasRepository.ListaCuentas();
        }

        public  static Cuenta BuscarCuenta(Decimal indentificacion)
        {
            return cuentasRepository.BuscarCuenta(indentificacion);
        }

        public static void Modificar(Cuenta cuentaEliminada, Cuenta cuentaModificada)
        {
            cuentasRepository.Modificar(cuentaEliminada,cuentaModificada);
        }



    }
}
