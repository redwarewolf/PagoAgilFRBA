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
using System.Text.RegularExpressions;

namespace PagoAgilFrba.Pagos
{
    public partial class RegistroPago : MaterialForm
    {
        Usuario usuario;
        DataTable tabla_facturas = new DataTable();
        int cliente = -1;
        Pago pago = new Pago();

        public RegistroPago(Usuario usuario)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            cargarEmpresas();
            cargarClientes();
            cargarFormasDePago();
            this.usuario = usuario;

            tabla_facturas.Columns.Add("Numero Factura", typeof(string));
            tabla_facturas.Columns.Add("Empresa", typeof(string));
            tabla_facturas.Columns.Add("Cliente", typeof(string));
            tabla_facturas.Columns.Add("Fecha de Vencimiento", typeof(string));
            tabla_facturas.Columns.Add("Importe", typeof(string));
            tabla_facturas.Columns.Add("Forma de Pago", typeof(string));

            actualizarTablaFacturas();

        }

        public void actualizarTablaFacturas()
        {
            data_facturas.DataSource = tabla_facturas;
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
        public void cargarClientes()
        {
            List<Cliente> clientes = ClientesRepositorio.getAllClientes(); //Traigo todas las empresas, sin ningun filtro
            foreach (Cliente cliente in clientes)
            {
                combo_clientes.Items.Add(cliente);
            }
            combo_clientes.DisplayMember="dni";
        }

        public void cargarFormasDePago()
        {
            List<String> formas_de_pago = PagosRepositorio.getFormasDePago();
            foreach (String forma_de_pago in formas_de_pago)
            {
                combo_formas_de_pago.Items.Add(forma_de_pago);
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiarTablaFacturas();
        }

        private void limpiarTablaFacturas()
        {
            tabla_facturas.Rows.Clear();
            actualizarTablaFacturas();
            pago.eliminarFacturasAPagar();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {

            if (!verificaValidacionesPago()) return;
           
            pago.cliente = Convert.ToInt32(combo_clientes.Text);
            pago.total = Convert.ToDouble(tx_importe_total.Text);
            pago.fecha_cobro = DateTime.Now;
            pago.sucursal = usuario.sucursal.codigo_postal;
            pago.medio_pago = combo_formas_de_pago.Text;
            PagosRepositorio.agregarPago(pago);

            MessageBox.Show("El pago ha sido procesado exitosamente", "Pago", MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
            reiniciarPago();
        }

        public void reiniciarPago()
        {
            limpiarTablaFacturas();
            limpiarVentana();
            this.cliente = -1;
        }

        public bool verificaValidacionesPago()
        {
            if (!pago.existenFacturasAPagar())
            {
                MessageBox.Show("No ha ingresado facturas a pagar", "ERROR", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return false;
            }

            if (!ClientesRepositorio.esClienteHabilitado(Convert.ToInt32(combo_clientes.Text)))
            {
                MessageBox.Show("El cliente no esta habilitado para realizar pagos", "ERROR", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void limpiarVentana()
        {
            var textboxes = grupo_cliente.Controls.OfType<TextBox>();
            foreach (TextBox textbox in textboxes)
            {
                textbox.Clear();
            }
            var comboboxes = grupo_cliente.Controls.OfType<ComboBox>();
            foreach (ComboBox combo_box in comboboxes)
            {
                combo_box.Text = "";
            }

            textboxes = group_box_facturas.Controls.OfType<TextBox>();
            foreach (TextBox textbox in textboxes)
            {
                textbox.Clear();
            }
           comboboxes = group_box_facturas.Controls.OfType<ComboBox>();
            foreach (ComboBox combo_box in comboboxes)
            {
                combo_box.Text= "";
            }

            this.cliente = -1;
            limpiarTablaFacturas();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
           if( verificaValidacionesFactura()) return;

            String[] row = new String[] { tx_numero_factura.Text, combo_empresas.Text , combo_clientes.Text, 
                date_fecha_vencimiento.Value.ToString(),tx_importe.Text,combo_formas_de_pago.Text };
            tabla_facturas.Rows.Add(row);

            registrarNuevaFactura();
            actualizarTablaFacturas();
            actualizarImporteTotal(); 
        }

        public void actualizarImporteTotal()
        {
            pago.aumentarImporteTotal(tx_importe.Text);
            tx_importe_total.Text = pago.total.ToString();
        }

        public void registrarNuevaFactura()
        {
            Factura factura = new Factura();
            factura.numero = Convert.ToInt32(tx_numero_factura.Text);
            factura.empresa_cuit = ((Empresa)(combo_empresas.SelectedItem)).cuit;
            factura.fecha_vencimiento = date_fecha_vencimiento.Value;
            pago.agregarFacturaAPagar(factura);

        }

        public bool verificaValidacionesFactura()
        {
            bool error = true;
            errorProvider1.Clear();
            if (!verificaFormularioCompleto()) return error;
            if (!verificaTiposDatosFactura()) return error;
            DateTime fecha_vencimiento = date_fecha_vencimiento.Value;
            DateTime fecha_actual = DateTime.Now;

            if (!clienteDefinido() ) inicializarCliente();
            else 
            {
                if (this.cliente != Convert.ToInt32(combo_clientes.Text))
                {
                    MessageBox.Show("El pago solo puede realizarse para un unico cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return error;
                }

            }

            if(esFacturaYaAgregadaParaPagar(tx_numero_factura.Text)){
                MessageBox.Show("La factura ya fue ingresada para pagar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return error;
            }

            if (!FacturasRepositorio.esFacturaExistente(tx_numero_factura.Text))
            {
                MessageBox.Show("La factura no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return error;
            }
            if (FacturasRepositorio.esFacturaPagada(tx_numero_factura.Text))
            {
                MessageBox.Show("La factura ya fue pagada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return error;
            }

            if (!FacturasRepositorio.esFacturaHabilitada(tx_numero_factura.Text))
            {
                MessageBox.Show("La factura no esta habilitada para pagar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return error;
            }

            if (!EmpresasRepositorio.esEmpresaHabilitada(((Empresa)(combo_empresas.SelectedItem)).cuit))
            {
                MessageBox.Show("La empresa no esta habilitada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return error;
            }

            if (!FacturasRepositorio.esFacturaDelCliente(tx_numero_factura.Text, combo_clientes.Text))
            {
                MessageBox.Show("La factura no le corresponde al cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return error;
            }

            if (!FacturasRepositorio.esFacturaDeLaEmpresa(tx_numero_factura.Text, ((Empresa)combo_empresas.SelectedItem).cuit))
            {
                MessageBox.Show("La factura no le corresponde a la empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return error;
            }
  
            if (Convert.ToDouble(tx_importe.Text) <= 0)
            {
                MessageBox.Show("El importe ingresado no puede ser menor o igual a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return error;
            }

            
     
            if (!FacturasRepositorio.verificaFechaVencimiento(tx_numero_factura.Text,fecha_vencimiento))
            {
                MessageBox.Show("La fecha de vencimiento ingresada no coincide con la fecha de vencimiento de la factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return error;
            }
            ComparadorFechas comparadorFechas = new ComparadorFechas();
            if (comparadorFechas.esMenor(fecha_vencimiento,fecha_actual))
            {
                MessageBox.Show("La fecha de vencimiento ha expirado, el cliente debera regularizar su situacion con su proveedor del servicio", 
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return error;
            }

            if (!FacturasRepositorio.esImporteCorrecto(tx_numero_factura.Text, tx_importe.Text))
            {
                MessageBox.Show("El importe ingresado no coincide con el importe de la factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return error;
            }

            
             error = false;
            return error;

        }

        public bool clienteDefinido()
        {
            return this.cliente != -1 && tabla_facturas.Rows.Count > 1;
        }

        public void inicializarCliente()
        {
            
            this.cliente = Convert.ToInt32(combo_clientes.Text);
           
        }


        public bool verificaFormularioCompleto()
        {
            bool verifica = true;

            var controles_grupo_factura = group_box_facturas.Controls;
            foreach (Control control in controles_grupo_factura)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    errorProvider1.SetError(control, "Por favor complete el campo");
                   verifica = false;
                }
            }
            var controles_grupo_cliente= grupo_cliente.Controls;
            foreach (Control control in controles_grupo_cliente)
            {
                if (string.IsNullOrWhiteSpace(control.Text) && control != tx_importe_total)
                {
                    errorProvider1.SetError(control, "Por favor complete el campo");
                    verifica = false;
                }
            }

            return verifica;
        }

        public bool verificaTiposDatosFactura()
        {

            if (!Regex.IsMatch(tx_numero_factura.Text, @"^[0-9]{1,10}$"))
            {
                MessageBox.Show("Ingrese un numero de factura válido.","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(tx_importe.Text, @"^[0-9.]{1,100}$"))
            {
                MessageBox.Show("Ingrese un importe valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        public  bool esFacturaYaAgregadaParaPagar(String numero_factura)
        {
            List<int> facturas = new List<int>();
            foreach (DataRow row in tabla_facturas.Rows)
            {
                facturas.Add(Convert.ToInt32(row.Field<String>("Numero Factura")));
            }
            return facturas.Contains(Convert.ToInt32(numero_factura));
        }
    }
}
