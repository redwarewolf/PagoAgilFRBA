using MaterialSkin;
using MaterialSkin.Controls;
using PagoAgilFrba.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Modelo;

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class Listados : MaterialForm
    {
        DataTable tabla_listado = new DataTable();
        int opcion;

        public Listados(int opcionListado)
        {
            InitializeComponent();

            opcion = opcionListado;
            inicializarTabla(opcionListado);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            cargarTrimestres();
            combo_trimestres.SelectedItem = 1;
            
        }

        private void cargarTrimestres()
        {
            int i = 1;
            while (i <= 4)
            {
                combo_trimestres.Items.Add(i);
                i++;
            }
           
           
        }


        private void busqueda_btn_Click(object sender, EventArgs e)
        {

            tabla_listado.Rows.Clear();
            actualizarGrid();

            Trimestre trimestre = new Trimestre();
            trimestre.configurar(date_ano.Value.Year, (int)combo_trimestres.SelectedItem);
            
            int cantidad = Convert.ToInt32(numElem.Value);

            if (opcion == 1)
            {

                SqlDataReader lector = ClientesRepositorio.obtenerListadoClientesSP(trimestre.fecha_inicio, trimestre.fecha_fin, cantidad, "totales");
                if (lector.HasRows)
                {
                    int i = 0;
                    while (lector.Read())
                    {
                        tabla_listado.Rows.Add(lector["clie_dni"], lector["clie_apellido"], lector["clie_nombre"], lector["clie_mail"], lector["cant_pagos"], lector["total"]);
                        i++;
                    }
                }
            }
            if (opcion == 2)
            {
                SqlDataReader lector = ClientesRepositorio.obtenerListadoClientesSP(trimestre.fecha_inicio, trimestre.fecha_fin, cantidad, "porcentaje");
                if (lector.HasRows)
                {
                    int i = 0;
                    while (lector.Read())
                    {
                        tabla_listado.Rows.Add(lector["clie_dni"], lector["clie_apellido"], lector["clie_nombre"], lector["clie_mail"], lector["cant_fact"], lector["cant_pagos"], lector["porcentaje"]);
                        i++;
                    }
                }
            }
            if (opcion == 3)
            {
                SqlDataReader lector = EmpresasRepositorio.obtenerListadoEmpresasSP(trimestre.fecha_inicio, trimestre.fecha_fin, cantidad, "rend");
                if (lector.HasRows)
                {
                    int i = 0;
                    while (lector.Read())
                    {
                        tabla_listado.Rows.Add(lector["emp_nombre"], lector["cantidad"], lector["monto"]);
                        i++;
                    }
                }
            }
            if (opcion == 4)
            {
                SqlDataReader lector = EmpresasRepositorio.obtenerListadoEmpresasSP(trimestre.fecha_inicio, trimestre.fecha_fin, cantidad, "fact");
                if (lector.HasRows)
                {
                    int i = 0;
                    while (lector.Read())
                    {
                        tabla_listado.Rows.Add(lector["emp_nombre"], lector["total"], lector["rendidos"], lector["porcentaje"]);
                        i++;
                    }
                }
            }

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Desde_Click(object sender, EventArgs e)
        {

        }

        public void actualizarGrid()
        {
            grid_listado.DataSource = tabla_listado;
        }

        public void inicializarTabla(int opcionListado)
        {
            if (opcionListado == 1)
            { // ClientesPagosTotales
                
                Listados.ActiveForm.Text = "Clientes con más Pagos";
        
                tabla_listado.Columns.Add("DNI", typeof(string));
                tabla_listado.Columns.Add("Apellido", typeof(string));
                tabla_listado.Columns.Add("Nombre", typeof(string));
                tabla_listado.Columns.Add("Mail", typeof(string));
                tabla_listado.Columns.Add("Cantidad Pagos", typeof(string));
                tabla_listado.Columns.Add("Monto Total de Pagos", typeof(string));
            }
            if (opcionListado == 2)
            { // ClientesProcentajePagos

                Listados.ActiveForm.Text = "Clientes con mayores porcentajes de facturas pagadas";

                tabla_listado.Columns.Add("DNI", typeof(string));
                tabla_listado.Columns.Add("Apellido", typeof(string));
                tabla_listado.Columns.Add("Nombre", typeof(string));
                tabla_listado.Columns.Add("Mail", typeof(string));
                tabla_listado.Columns.Add("Cantidad Facturas", typeof(string));
                tabla_listado.Columns.Add("Cantidad Facturas Pagas", typeof(string));
                tabla_listado.Columns.Add("Porcentaje Pago", typeof(string));
            }
            if (opcionListado == 3)
            { // EmpresaMontoRendido

                Listados.ActiveForm.Text = "Empresas con mayor monto rendido";

                tabla_listado.Columns.Add("Empresa", typeof(string));
                tabla_listado.Columns.Add("Cantidad Rendiciones", typeof(string));
                tabla_listado.Columns.Add("Monto Rendido", typeof(string));
            }
            if (opcionListado == 4)
            { // FacturasCobradasEmpresa

                Listados.ActiveForm.Text = "Porcentaje de facturas cobradas por empresa";

                tabla_listado.Columns.Add("Empresa", typeof(string));
                tabla_listado.Columns.Add("Facturas Totales", typeof(string));
                tabla_listado.Columns.Add("Facturas Cobradas", typeof(string));
                tabla_listado.Columns.Add("Porcentaje", typeof(string));
            }
            actualizarGrid();
        }



    }




}
