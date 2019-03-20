using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Repositorios;
using PagoAgilFrba.Modelo;
using MaterialSkin.Controls;
using MaterialSkin;

namespace PagoAgilFrba.Rendicion
{
    public partial class Rendicion : MaterialForm
    {
        double total = 0;
        int cantidadFacturas = 0;
        double comision;
        DataTable tabla_facturas = new DataTable();
        public Rendicion()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            cargarEmpresas();
            date_fecha_rendicion.MaxDate = DateTime.Today;
            
            tabla_facturas.Columns.Add("Numero", typeof(string));
            tabla_facturas.Columns.Add("Empresa", typeof(string));
            tabla_facturas.Columns.Add("Cliente", typeof(string));
            tabla_facturas.Columns.Add("Monto", typeof(string));



        }
        public void cargarEmpresas()
        {
            List<Empresa> empresas = EmpresasRepositorio.getAllEmpresas();
            foreach (Empresa empresa in empresas)
            {
                combo_empresas.Items.Add(empresa.cuit +"-" + empresa.nombre);
            }
        }

        private void mensajeDeErrorEmpresa()
        {
            MessageBox.Show("No se encontraron facturas\nPuede deberse a las siguientes razones:\n *Las facturas ya se encuentran rendidas en este mes\n *La empresa se encuentra inhabilitada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            limpiarFacturas();
            tabla_facturas.Rows.Clear();
  
            List<Factura> facturas = FacturasRepositorio.getFacturasARendirDeEmpresa(combo_empresas.Text, Convert.ToDateTime(date_fecha_rendicion.Text));
           
            if (facturas.Count == 0) mensajeDeErrorEmpresa();
            foreach (Factura factura in facturas)
            {
                total += factura.total;
                cantidadFacturas += 1;

                String[] row = new String[] {
                    factura.numero.ToString(), factura.empresa_cuit,factura.cliente.ToString(),factura.total.ToString()
                };
                tabla_facturas.Rows.Add(row);
            }
            actualizarTablaFacturas();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarFacturas();
        }

        private void limpiarFacturas()
        {
            total = 0;
            cantidadFacturas = 0;
            tabla_facturas.Rows.Clear();
            actualizarTablaFacturas();
        }

        private void actualizarTablaFacturas()
        {
            tx_cant_fact_a_rendir.Text = cantidadFacturas.ToString();
            data_facturas.DataSource = tabla_facturas;

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void tx_porcentaje_comision_ValueChanged(object sender, EventArgs e)
        {

            comision = total * Convert.ToDouble(tx_porcentaje_comision.Value) / 100;
            tx_importe_comision.Text = comision.ToString() + " $";
            tx_importe_total_rendicion.Text = (total - comision).ToString() + " $";
        }

        private void button_realizar_rendicion_Click(object sender, EventArgs e)
        {
            List<int> listaNumFact = new List<int>();

            if (tabla_facturas.Rows.Count == 0) MessageBox.Show("No se encontraron facturas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                foreach (DataGridViewRow factura in data_facturas.Rows)
                {
                    listaNumFact.Add(Convert.ToInt32(tabla_facturas.Rows[factura.Index]["numero"]));
                }

                double porcentajeComision = Convert.ToDouble(tx_porcentaje_comision.Value);
                string empresa = combo_empresas.Text;
                FacturasRepositorio.rendir(listaNumFact, comision, cantidadFacturas, total, porcentajeComision, empresa);
                tabla_facturas.Rows.Clear();
           

                MessageBox.Show("Facturas rendidas correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}