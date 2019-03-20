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

namespace PagoAgilFrba.Devoluciones
{
    public partial class RegistroDevolucion : MaterialForm
    {
        int cliente = -1;
        DataTable tabla_facturas_pagas = new DataTable();
        DataTable tabla_facturas_devolucion = new DataTable();
        Devolucion devolucion = new Devolucion();
        public RegistroDevolucion()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            setearTablaFacturasPagas();
            setearTablaFacturasDevolucion();
            
        }

        public void setearTablaFacturasPagas()
        {
            tabla_facturas_pagas.Columns.Add("Cliente", typeof(string));
            tabla_facturas_pagas.Columns.Add("Factura", typeof(string));
            tabla_facturas_pagas.Columns.Add("Total", typeof(string));
            tabla_facturas_pagas.Columns.Add("Fecha de vencimiento", typeof(string));

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();

            button.HeaderText = "Devolucion";
            button.Text = "Devolver";
            button.Name = "btn_devolucion";
            button.UseColumnTextForButtonValue = true;

            actualizarTablaFacturasPagas();
            data_facturas_pagas.Columns.Add(button);
        }

        public void setearTablaFacturasDevolucion()
        {
            tabla_facturas_devolucion.Columns.Add("Cliente", typeof(string));
            tabla_facturas_devolucion.Columns.Add("Factura", typeof(string));
            tabla_facturas_devolucion.Columns.Add("Total", typeof(string));
            tabla_facturas_devolucion.Columns.Add("Fecha de vencimiento", typeof(string));

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();

            button.HeaderText = "Eliminar";
            button.Text = "Eliminar";
            button.Name = "btn_eliminar";
            button.UseColumnTextForButtonValue = true;

            actualizarTablaFacturasDevolucion();
            data_facturas_devolucion.Columns.Add(button);
        }


        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(tx_numero_cliente.Text))
            {
                MessageBox.Show("Debe ingresar un DNI", "Devolucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(tx_numero_cliente.Text, @"^[0-9]{7,8}$"))
            {
                MessageBox.Show("Ingrese un DNI válido.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            tabla_facturas_pagas.Rows.Clear();
            List<Factura> facturas =  FacturasRepositorio.getFacturasPagasActualesDeCliente(tx_numero_cliente.Text);

           foreach (Factura factura in facturas)
           {
               String[] row = new String[] { factura.cliente.ToString(),factura.numero.ToString(), factura.total.ToString(),factura.fecha_vencimiento.ToString()};
               tabla_facturas_pagas.Rows.Add(row);
           }
           actualizarTablaFacturasPagas();

        }


        private void actualizarTablaFacturasPagas()
        {
            data_facturas_pagas.DataSource = tabla_facturas_pagas;

        }

        private void actualizarTablaFacturasDevolucion()
        {
            data_facturas_devolucion.DataSource = tabla_facturas_devolucion;
            if (tabla_facturas_devolucion.Rows.Count == 0) this.cliente = -1;
        }

      
        private bool verificarCamposVaciosDevolucion()
        {
            bool error = false;
            var control = tx_motivo;

            if (string.IsNullOrWhiteSpace(control.Text))
            {
                epProvider.SetError(control, "Por favor complete el campo");
                error = true;
            }
            return error;

        }

       
        private void btn_devolucion_Click(object sender, EventArgs e)
        {
            if (!verificaValidaciones()) return;
            
            devolucion.motivo = tx_motivo.Text;
            devolucion.fecha_devolucion = DateTime.Now;

            DevolucionesRepositorio.agregarDevolucion(devolucion);

            MessageBox.Show("La devolucion ha sido procesada exitosamente","Devolucion", MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
            reiniciarDevolucion();
     
        }

        private bool verificaValidaciones()
        {
            if (verificarCamposVaciosDevolucion()) return false;
            if (!devolucion.existenFacturasADevolver())
            {
                MessageBox.Show("No ha ingresado facturas a devolver", "ERROR", MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void reiniciarDevolucion()
        {
            
            this.cliente = -1;
            limpiarVentana();
            limpiarDevoluciones();
            limpiarPagos();
        }

        private void limpiarVentana()
        {
            tx_motivo.Clear();
        }

        private void data_facturas_pagas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (tabla_facturas_pagas.Rows.Count == 0) return;
            if (tabla_facturas_pagas.Rows.Count < e.RowIndex) return;
            if (e.ColumnIndex == 4 || e.ColumnIndex == 0)
            {
                int indice = e.RowIndex;
                DataGridViewRow row = data_facturas_pagas.Rows[indice];
                String numero_factura = row.Cells["Factura"].Value.ToString();
                String numero_cliente = row.Cells["Cliente"].Value.ToString();
                String total = row.Cells["Total"].Value.ToString();
                String fecha_vencimiento = row.Cells["Fecha de vencimiento"].Value.ToString();

                agregarFacturaADevoluciones(numero_cliente, numero_factura, total,fecha_vencimiento);

            }
        }

        private void agregarFacturaADevoluciones(String cliente, String factura, String total,String vencimiento)
        {

            if (!clienteDefinido()) definirCliente(cliente);
            else
            {
                if (this.cliente != Convert.ToInt32(cliente))
                {
                    MessageBox.Show("Solo se puede realizar una devolucion para un unico cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (esFacturaYaIngresadaADevolver(Convert.ToInt32(factura)))
            {
                MessageBox.Show("La factura ya fue ingresada para su devolucion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime fecha_vencimiento = Convert.ToDateTime(vencimiento);
            DateTime fecha_actual = DateTime.Now;
            if(new ComparadorFechas().esMenor(fecha_vencimiento,fecha_actual))
            {
                MessageBox.Show("La factura no puede ser devuelta porque la fecha de vencimiento ha caducado, el cliente debera contactarse con el proveedor del servicio",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                String[] row = new String[] { cliente, factura,total,vencimiento};

                devolucion.agregarFacturaADevolver(Convert.ToInt32(factura));
                tabla_facturas_devolucion.Rows.Add(row);
                actualizarTablaFacturasDevolucion();
        }

        public bool esFacturaYaIngresadaADevolver(int numero_factura)
        {
            return devolucion.contiene(numero_factura);
        }

        public bool clienteDefinido()
        {
            return this.cliente != -1;
        }

        public void definirCliente(String numero_cliente)
        {
            this.cliente = Convert.ToInt32(numero_cliente);
        }

        private void data_facturas_devolucion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (tabla_facturas_devolucion.Rows.Count == 0) return;
            if(tabla_facturas_devolucion.Rows.Count < e.RowIndex) return;
            if (e.ColumnIndex == 4 || e.ColumnIndex == 0)
            {
                int indice = e.RowIndex;
                DataGridViewRow row = data_facturas_devolucion.Rows[indice];
                String numero_factura = row.Cells["Factura"].Value.ToString();
                
                devolucion.eliminarFacturaADevolver(Convert.ToInt32(numero_factura));
                tabla_facturas_devolucion.Rows.RemoveAt(indice);

                actualizarTablaFacturasDevolucion();
            }
        }

        private void btn_limpiar_devoluciones_Click(object sender, EventArgs e)
        {
            limpiarDevoluciones();
        }

        private void limpiarDevoluciones()
        {
            tabla_facturas_devolucion.Rows.Clear();
            actualizarTablaFacturasDevolucion();
            devolucion.eliminarFacturasADevolver();
            this.cliente = -1;
        }

        private void btn_limpiar_pagas_Click(object sender, EventArgs e)
        {
            limpiarPagos();
        }

        private void limpiarPagos()
        {
            tabla_facturas_pagas.Rows.Clear();
            actualizarTablaFacturasPagas();
        }



    }
}
