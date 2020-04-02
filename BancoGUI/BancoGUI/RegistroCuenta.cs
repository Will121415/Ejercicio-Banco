using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;
namespace BancoGUI
{
    public partial class RegistroCuenta : Form
    {
        public RegistroCuenta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente();
            cliente.Indentificacion = decimal.Parse(TxtIdentificacion.Text);
            cliente.Nombre = TxtNombre.Text;

            if(CbbTipo.Text == "Ahorro")
            {
                Cuenta cuentaAhorro = new CuentaAhorro(decimal.Parse(TxtNumero.Text),cliente, CbbTipo.Text);
                CuentasService.Guardar(cuentaAhorro);
            }
            else
            {
                Cuenta cuentaCorriente = new CuentaCorriente(decimal.Parse(TxtNumero.Text), cliente, CbbTipo.Text);
                CuentasService.Guardar(cuentaCorriente);

            }
        }
    }
}
