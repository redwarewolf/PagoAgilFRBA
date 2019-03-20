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
using System.Text.RegularExpressions;

namespace PagoAgilFrba.AbmFactura
{
    public partial class ListadoFacturas : MaterialForm
    {
        DataTable tabla_facturas = new DataTable();
        String modo;
        public ListadoFacturas(String modo)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.modo = modo;
            tabla_facturas.Columns.Add("Numero", typeof(string));
            tabla_facturas.Columns.Add("Empresa", typeof(string));
            tabla_facturas.Columns.Add("Cliente", typeof(string));
            tabla_facturas.Columns.Add("Monto", typeof(string));
            tabla_facturas.Columns.Add("Fecha de alta", typeof(string));
            tabla_facturas.Columns.Add("Fecha de vencimiento", typeof(string));
            tabla_facturas.Columns.Add("Habilitada", typeof(string));

            actualizarTablaFacturas();
            cargarEmpresas();
            cargarBotonLogico();
        }

        private void cargarBotonLogico()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();

            if (modo.Equals("modificacion"))
            {

                button.HeaderText = "Modificar";
                button.Text = "Modificar";
                button.Name = "btn_modificacion";
                button.UseColumnTextForButtonValue = true;
            }
            else
            {
                button.HeaderText = "Bajar";
                button.Text = "Inhabilitar";
                button.Name = "btn_baja";
                button.UseColumnTextForButtonValue = true;
            }
            
            data_facturas.Columns.Add(button);
        }

     

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarFacturas();
        }

        private void limpiarFacturas()
        {
            tabla_facturas.Rows.Clear();
            actualizarTablaFacturas();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!verificaValidaciones()) return;
            tabla_facturas.Rows.Clear();
            List<Factura> facturas = FacturasRepositorio.getFacturas(tx_numero_factura.Text,tx_cliente.Text, combo_empresas.Text, date_fecha_alta.Value,
                date_fecha_vencimiento.Value, cb_fecha_alta.Checked, cb_fecha_vencimiento.Checked);

           
            foreach (Factura factura in facturas)
            {
                String[] row = new String[] { factura.numero.ToString(), factura.empresa_cuit, 
                    factura.cliente.ToString(), factura.total.ToString(), factura.fecha_alta.ToString(), factura.fecha_vencimiento.ToString(),factura.habilitada.ToString() };
               tabla_facturas.Rows.Add(row);
            }
            actualizarTablaFacturas();
        }

        public bool verificaValidaciones()
        {
            if (!String.IsNullOrWhiteSpace(tx_cliente.Text) && !Regex.IsMatch(tx_cliente.Text, @"\d{7}$"))
            {
                    MessageBox.Show("Ingrese un DNI valido para el cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }
            return true;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void data_facturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (tabla_facturas.Rows.Count == 0) return;
            if (tabla_facturas.Rows.Count < e.RowIndex + 1) return;
            if (e.ColumnIndex == 7 || e.ColumnIndex == 0) 
            {
                int indice = e.RowIndex;
                String factura = data_facturas.Rows[indice].Cells["Numero"].Value.ToString();
                if (modo.Equals("modificacion")) modificarFactura(factura);
                else bajarFactura(factura,indice);
            }
          
        }

        private void modificarFactura(string factura)
        {
            
            this.Hide();
            new ModificacionFactura(factura).ShowDialog();
            tabla_facturas.Rows.Clear();
            actualizarTablaFacturas();
            this.Show();
        }

        private void bajarFactura(string factura,int indice)
        {


            if (FacturasRepositorio.esFacturaRendida(factura))
            {
                MessageBox.Show("La factura no puede ser inhabilitada porque ya fue rendida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FacturasRepositorio.esFacturaPagada(factura))
            {
                MessageBox.Show("La factura no puede ser inhabilitada porque ya fue pagada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FacturasRepositorio.inhabilitar(factura);
            tabla_facturas.Rows[indice].Delete();
            actualizarTablaFacturas();
            MessageBox.Show("La factura ha sido inhabilitada exitosamente", "Inhabilitacion de factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void actualizarTablaFacturas()
        {
            data_facturas.DataSource = tabla_facturas;
            
        }

    

        private void cargarEmpresas()
        {
            List<Empresa> empresas = EmpresasRepositorio.getAllEmpresas();
            foreach (Empresa empresa in empresas)
            {
                combo_empresas.Items.Add(empresa);
            }

            combo_empresas.DisplayMember = "cuit";
            
        }

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            this.limpiarFacturas();
        }

        
    }
}
