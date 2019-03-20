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
    public partial class ListadoSucursales : MaterialForm
    {
        DataTable tabla_sucursales = new DataTable();
        Char modo;

        public ListadoSucursales(Char modo)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            this.modo = modo;

            tabla_sucursales.Columns.Add("Codigo postal");
            tabla_sucursales.Columns.Add("Nombre");
            tabla_sucursales.Columns.Add("Direccion");
            tabla_sucursales.Columns.Add("Habilitada");

            DataGridViewButtonColumn btn_accion = new DataGridViewButtonColumn();

            if (modo.Equals('B'))
            {
                btn_accion.HeaderText = "Baja";
                btn_accion.Text = "Deshabilitar";
                btn_accion.Name = "btn_baja_sucursal";
                btn_accion.UseColumnTextForButtonValue = true;
            }
            else
            {
                btn_accion.HeaderText = "Modificacion";
                btn_accion.Text = "Modificar";
                btn_accion.Name = "btn_modificacion_sucursal";
                btn_accion.UseColumnTextForButtonValue = true;
            }

            refreshValues();
            data_listado_sucursales.Columns.Add(btn_accion);
        }

        private void refreshValues()
        {
            data_listado_sucursales.DataSource = tabla_sucursales;
        }

        private void limpiarSucursales()
        {
            tabla_sucursales.Rows.Clear();
            refreshValues();
        }

        private void btn_buscar_sucursal_Click(object sender, EventArgs e)
        {
            tabla_sucursales.Rows.Clear();
            List<Sucursal> sucursales = SucursalesRepositorio.getSucursales(tx_codigo_postal_sucursal.Text, tx_nombre_sucursal.Text, tx_direccion_sucursal.Text);

            foreach (Sucursal sucursal in sucursales)
            {
                String[] row = new String[] { Convert.ToString(sucursal.codigo_postal), sucursal.nombre, sucursal.direccion, Convert.ToString(sucursal.habilitado) };
                tabla_sucursales.Rows.Add(row);
            }

            refreshValues();
        }

        private void btn_volver_sucursal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_limpiar_sucursal_Click(object sender, EventArgs e)
        {
            this.limpiarSucursales();
        }

        private void data_listado_sucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_sucursales.Rows.Count == 0) return;

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int indice = e.RowIndex;
                DataGridViewRow row = data_listado_sucursales.Rows[indice];
                Sucursal sucursal = new Sucursal();
                sucursal.codigo_postal = int.Parse(row.Cells["Codigo postal"].Value.ToString());
                sucursal.direccion = row.Cells["Direccion"].Value.ToString();
                sucursal.nombre = row.Cells["Nombre"].Value.ToString();
                sucursal.habilitado = Convert.ToBoolean(row.Cells["Habilitada"].Value);
                if (modo.Equals('M')) modificarSucursal(sucursal);
                else bajarSucursal(sucursal.codigo_postal.ToString(), indice);
            }
        }

        private void modificarSucursal(Sucursal sucursal)
        {
            this.Hide();
            new ModificacionSucursal(sucursal).ShowDialog();
            tabla_sucursales.Rows.Clear();
            refreshValues();
            this.Show();
        }
        
        private void bajarSucursal(String CP_sucursal, int indice)
        {
            SucursalesRepositorio.deshabilitar(CP_sucursal);
            tabla_sucursales.Rows[indice].Delete();
            refreshValues();
        }

        private void habilitarSucursal(String CP_sucursal, int indice)
        {
            SucursalesRepositorio.habilitar(CP_sucursal);
            tabla_sucursales.Rows[indice].Delete();
            refreshValues();
        }
    }
}
