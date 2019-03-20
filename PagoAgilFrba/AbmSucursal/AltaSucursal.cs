using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Modelo;
using PagoAgilFrba.Repositorios;
using MaterialSkin.Controls;
using MaterialSkin;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class AltaSucursal : MaterialForm
    {
        Sucursal sucursal = new Sucursal();
        public AltaSucursal()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_alta_sucursal_Click(object sender, EventArgs e)
        {
            epProvider.Clear();
            if(validarCamposSucursal()) { return; }

            if (SucursalesRepositorio.esSucursalExistente(int.Parse(tx_codigo_postal_sucursal.Text)))
            {
                MessageBox.Show("Ya existe una sucursal con el codigo postal ingresado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sucursal.codigo_postal = int.Parse(tx_codigo_postal_sucursal.Text);
            sucursal.nombre = tx_nombre_sucursal.Text;
            sucursal.direccion = tx_direccion_sucursal.Text;
            sucursal.habilitado = true;

            SucursalesRepositorio.agregar(sucursal);
            limpiarVentana();
        }

        private bool validarCamposSucursal()
        {
            bool error = false;
            int number;

            var controles = grupo_sucursal.Controls;
            foreach(Control control in controles)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    epProvider.SetError(control, "Por favor complete el campo");
                    error = true;
                }

            }
            if(!Int32.TryParse(tx_codigo_postal_sucursal.Text, out number))
            {
                MessageBox.Show("El codigo postal debe ser un valor numerico");
                error = true;
            }

            return error;
        }

        private void limpiarVentana()
        {
            var textBoxes = grupo_sucursal.Controls.OfType<TextBox>();
            foreach(TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

    }
}
