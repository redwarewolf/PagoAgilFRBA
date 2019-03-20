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
    public partial class ModificacionSucursal : MaterialForm
    {
        Sucursal sucursal = new Sucursal();
        public ModificacionSucursal(Sucursal sucursalSeleccionada)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            this.sucursal = sucursalSeleccionada;
            txt_CP_sucursal.Text = sucursal.codigo_postal.ToString();
            txt_direccion_sucursal.Text = sucursal.direccion;
            txt_nombre_sucursal.Text = sucursal.nombre;
            check_habilitada.Checked = sucursal.habilitado;
            if (sucursal.habilitado) check_habilitada.Enabled = false;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            epProvider.Clear();
            if (validarCamposVacios()) { return; }

            sucursal.nombre = txt_nombre_sucursal.Text;
            sucursal.direccion = txt_direccion_sucursal.Text;
            sucursal.habilitado = check_habilitada.Checked;

            SucursalesRepositorio.modificar(sucursal);
            limpiarVentana();
            this.Hide();
        }

        private void limpiarVentana()
        {
            var textboxes = group_sucursal.Controls.OfType<TextBox>();
            foreach(TextBox textbox in textboxes)
            {
                textbox.Clear();
            }
        }

        private bool validarCamposVacios()
        {
            bool error = false;

            var textboxes = group_sucursal.Controls.OfType<TextBox>();

            foreach(TextBox textbox in textboxes)
            {
                if (String.IsNullOrWhiteSpace(textbox.Text))
                {
                    epProvider.SetError(textbox, "Por favor, complete el campo");
                    error = true;
                }
            }
            return error;
        }
    }
}
