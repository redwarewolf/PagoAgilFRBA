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
    public partial class ModificacionFactura : MaterialForm
    {

        Factura factura = new Factura();
        DataTable tabla_items = new DataTable();

        public ModificacionFactura(string numero_factura)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            tabla_items.Columns.Add("Detalle", typeof(string));
            tabla_items.Columns.Add("Cantidad", typeof(string));
            tabla_items.Columns.Add("Monto", typeof(string));

            cargarEmpresas();
            cargarClientes();


            factura = FacturasRepositorio.getFactura(Convert.ToInt32(numero_factura));
            combo_clientes.Text = factura.cliente.ToString();
            combo_empresas.Text = factura.empresa_cuit;
            tx_numero_factura.Text = factura.numero.ToString();
            date_fecha_alta_factura.Value = factura.fecha_alta;
            date_vencimiento_factura.Value = factura.fecha_vencimiento;
            foreach (ItemFactura item in factura.get_items_factura)
            {
                tabla_items.Rows.Add(item.detalle, item.cantidad, item.monto);
            }
            actualizarTablaItems();

            if (factura.habilitada)
            {
                check_box_habilitacion.Checked = true;
                check_box_habilitacion.Enabled = false;
            }
            else
            {
                check_box_habilitacion.Checked = false;
                check_box_habilitacion.Enabled = true;
            }
            
        }

        public void cargarClientes()
        {
            List<Cliente> clientes = ClientesRepositorio.getAllClientes();
            foreach (Cliente cliente in clientes)
            {
                combo_clientes.Items.Add(cliente);
            }
            combo_clientes.DisplayMember = "dni";
        }
        public void cargarEmpresas()
        {
            List<Empresa> empresas = EmpresasRepositorio.getAllEmpresas();
            foreach (Empresa empresa in empresas)
            {
                combo_empresas.Items.Add(empresa);
            }
            combo_empresas.DisplayMember = "cuit";
        }

        private void btn_agregar_item_Click(object sender, EventArgs e)
        {
            ItemFactura item = new ItemFactura();
            if (!verificaValidacionesItem()) return;

            item.detalle = tx_detalle_item.Text;
            item.cantidad = Convert.ToInt32(tx_cantidad_item.Text);
            item.monto = Convert.ToDouble(tx_monto_item.Text);
            //El numero de la factura se setea al modificar la factura
            factura.agregarNuevoItem(item);
            tabla_items.Rows.Add(tx_detalle_item.Text, tx_cantidad_item.Text, tx_monto_item.Text);
            actualizarTablaItems();

            limpiarCamposItems();
        }
          private bool verificaValidacionesItem()
        {
            epProvider.Clear();
            if (!formularioItemCompleto()) return false;
            if (!itemVerificaTiposDeDatos()) return false;

            if (factura.esItemRepetido(tx_detalle_item.Text))
            {
                MessageBox.Show("Ya existe un item con el mismo detalle", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

          private bool itemVerificaTiposDeDatos()
          {
              if (!Regex.IsMatch(tx_cantidad_item.Text, @"^[0-9]{1,100}$"))
              {
                  MessageBox.Show("Ingrese una cantidad válida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return false;
              }

              if (!Regex.IsMatch(tx_monto_item.Text, @"^[0-9.]{1,100}$"))
              {
                  MessageBox.Show("Ingrese un monto válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                  return false;
              }
              return true;
          }

        private void btn_eliminar_item_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.data_items.SelectedRows)
            {
                var detalle_item = tabla_items.Rows[item.Index]["detalle"];
                tabla_items.Rows.RemoveAt(item.Index);
                factura.eliminarItem(detalle_item.ToString());
            }
            actualizarTablaItems();
        }

        private void btn_modificar_factura_Click(object sender, EventArgs e)
        {
            
            if (!verificaValidacionesFactura()) return;

            factura.habilitada = check_box_habilitacion.Checked;
            factura.numero = Convert.ToInt32(tx_numero_factura.Text);
            factura.cliente = ((Cliente)combo_clientes.SelectedItem).dni;
            factura.empresa_cuit = ((Empresa)combo_empresas.SelectedItem).cuit;
            factura.fecha_alta = Convert.ToDateTime(date_fecha_alta_factura.Value);
            factura.fecha_vencimiento = Convert.ToDateTime(date_vencimiento_factura.Value);
            factura.setMontoTotal();
            factura.setItemsNumeroFactura();

            FacturasRepositorio.modificar(factura);
            limpiarVentana();
            MessageBox.Show("La factura ha sido modificada exitosamente", "Modificacion factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool facturaVerificaTiposDeDatos()
        {
            if (!Regex.IsMatch(tx_numero_factura.Text, @"^[0-9]{1,10}$"))
            {
                MessageBox.Show("Ingrese un numero de factura válido.");
                return false;
            }
            return true;
        }

        private bool verificaValidacionesFactura()
        {
            epProvider.Clear();
            if (!formularioFacturaCompleto()) return false;
            if (!facturaVerificaTiposDeDatos()) return false;

           
            if (tabla_items.Rows.Count == 0)
            {
                MessageBox.Show("No se han registrado items para la factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DateTime fecha_alta = date_fecha_alta_factura.Value;
            DateTime fecha_vencimiento = date_vencimiento_factura.Value;
            ComparadorFechas comparadorFechas = new ComparadorFechas();
            if (comparadorFechas.esMenor(fecha_vencimiento, fecha_alta))
            {
                MessageBox.Show("La fecha de vencimiento no puede ser menor a la fecha de alta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comparadorFechas.esMenor(fecha_vencimiento, DateTime.Now))
            {
                MessageBox.Show("La fecha de vencimiento no puede ser menor al dia de hoy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comparadorFechas.esMenor(DateTime.Now, fecha_alta))
            {
                MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool formularioFacturaCompleto()
        {
            bool verifica = true;

            var controles = group_facturas.Controls;
            foreach (Control control in controles)
            {
                if (string.IsNullOrWhiteSpace(control.Text) && control != tx_monto_total)
                {
                    epProvider.SetError(control, "Por favor complete el campo");
                    verifica = false;
                }
            }
            return verifica;
        }

        private void btn_vaciar_items_Click(object sender, EventArgs e)
        {
            this.limpiarItems();
        }

        bool formularioCompletoFactura()
        {
            bool error = false;

            var controles = group_facturas.Controls;
            foreach (Control control in controles)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    epProvider.SetError(control, "Por favor complete el campo");
                    error = true;
                }
            }
            return error;
        }

       

        private bool formularioItemCompleto()
        {
            bool verifica = true;

            var controles = group_box_items.Controls;
            foreach (Control control in controles)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    epProvider.SetError(control, "Por favor complete el campo");
                   verifica = false;
                }
            }
            return verifica;
        }

        private void limpiarCamposItems()
        {
            var textboxes = group_box_items.Controls.OfType<TextBox>();
            foreach (TextBox textbox in textboxes)
            {
                textbox.Clear();
            }
            var rich_textboxes = group_box_items.Controls.OfType<RichTextBox>();
            foreach (RichTextBox rich_textbox in rich_textboxes)
            {
                rich_textbox.Clear();
            }
        }

        private void limpiarVentana()
        {
            var textboxes = group_facturas.Controls.OfType<TextBox>();
            foreach (TextBox textbox in textboxes)
            {
                textbox.Clear();
            }
            this.limpiarItems();

        }

        private void actualizarTablaItems()
        {
            data_items.DataSource = tabla_items;
            tx_monto_total.Text = factura.getMontoActual().ToString();
        }


        private void limpiarItems()
        {
            tabla_items.Rows.Clear();
            factura.vaciarItems();
            actualizarTablaItems();
        }


        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

    }
}
