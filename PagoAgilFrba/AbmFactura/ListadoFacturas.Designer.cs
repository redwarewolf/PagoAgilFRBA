namespace PagoAgilFrba.AbmFactura
{
    partial class ListadoFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_facturas = new System.Windows.Forms.DataGridView();
            this.GrupoFiltros = new System.Windows.Forms.GroupBox();
            this.date_fecha_alta = new System.Windows.Forms.DateTimePicker();
            this.date_fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.cb_fecha_alta = new System.Windows.Forms.CheckBox();
            this.cb_fecha_vencimiento = new System.Windows.Forms.CheckBox();
            this.tx_numero_factura = new System.Windows.Forms.TextBox();
            this.tx_cliente = new System.Windows.Forms.TextBox();
            this.combo_empresas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas)).BeginInit();
            this.GrupoFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_facturas
            // 
            this.data_facturas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_facturas.Location = new System.Drawing.Point(21, 224);
            this.data_facturas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_facturas.Name = "data_facturas";
            this.data_facturas.ReadOnly = true;
            this.data_facturas.RowTemplate.Height = 24;
            this.data_facturas.Size = new System.Drawing.Size(760, 296);
            this.data_facturas.TabIndex = 2;
            this.data_facturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_facturas_CellClick);
            // 
            // GrupoFiltros
            // 
            this.GrupoFiltros.BackColor = System.Drawing.Color.White;
            this.GrupoFiltros.Controls.Add(this.date_fecha_alta);
            this.GrupoFiltros.Controls.Add(this.date_fecha_vencimiento);
            this.GrupoFiltros.Controls.Add(this.cb_fecha_alta);
            this.GrupoFiltros.Controls.Add(this.cb_fecha_vencimiento);
            this.GrupoFiltros.Controls.Add(this.tx_numero_factura);
            this.GrupoFiltros.Controls.Add(this.tx_cliente);
            this.GrupoFiltros.Controls.Add(this.combo_empresas);
            this.GrupoFiltros.Controls.Add(this.label3);
            this.GrupoFiltros.Controls.Add(this.label2);
            this.GrupoFiltros.Controls.Add(this.label1);
            this.GrupoFiltros.Controls.Add(this.btn_buscar);
            this.GrupoFiltros.Location = new System.Drawing.Point(117, 75);
            this.GrupoFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrupoFiltros.Name = "GrupoFiltros";
            this.GrupoFiltros.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrupoFiltros.Size = new System.Drawing.Size(572, 137);
            this.GrupoFiltros.TabIndex = 6;
            this.GrupoFiltros.TabStop = false;
            this.GrupoFiltros.Text = "Filtros de Busqueda";
            // 
            // date_fecha_alta
            // 
            this.date_fecha_alta.Location = new System.Drawing.Point(142, 106);
            this.date_fecha_alta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date_fecha_alta.Name = "date_fecha_alta";
            this.date_fecha_alta.Size = new System.Drawing.Size(198, 20);
            this.date_fecha_alta.TabIndex = 15;
            // 
            // date_fecha_vencimiento
            // 
            this.date_fecha_vencimiento.Location = new System.Drawing.Point(142, 71);
            this.date_fecha_vencimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date_fecha_vencimiento.Name = "date_fecha_vencimiento";
            this.date_fecha_vencimiento.Size = new System.Drawing.Size(198, 20);
            this.date_fecha_vencimiento.TabIndex = 14;
            // 
            // cb_fecha_alta
            // 
            this.cb_fecha_alta.AutoSize = true;
            this.cb_fecha_alta.Location = new System.Drawing.Point(7, 110);
            this.cb_fecha_alta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_fecha_alta.Name = "cb_fecha_alta";
            this.cb_fecha_alta.Size = new System.Drawing.Size(79, 17);
            this.cb_fecha_alta.TabIndex = 13;
            this.cb_fecha_alta.Text = "Fecha alta:";
            this.cb_fecha_alta.UseVisualStyleBackColor = true;
            // 
            // cb_fecha_vencimiento
            // 
            this.cb_fecha_vencimiento.AutoSize = true;
            this.cb_fecha_vencimiento.Location = new System.Drawing.Point(7, 72);
            this.cb_fecha_vencimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_fecha_vencimiento.Name = "cb_fecha_vencimiento";
            this.cb_fecha_vencimiento.Size = new System.Drawing.Size(119, 17);
            this.cb_fecha_vencimiento.TabIndex = 12;
            this.cb_fecha_vencimiento.Text = "Fecha vencimiento:";
            this.cb_fecha_vencimiento.UseVisualStyleBackColor = true;
            // 
            // tx_numero_factura
            // 
            this.tx_numero_factura.Location = new System.Drawing.Point(394, 31);
            this.tx_numero_factura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tx_numero_factura.Name = "tx_numero_factura";
            this.tx_numero_factura.Size = new System.Drawing.Size(76, 20);
            this.tx_numero_factura.TabIndex = 11;
            // 
            // tx_cliente
            // 
            this.tx_cliente.Location = new System.Drawing.Point(51, 29);
            this.tx_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tx_cliente.Name = "tx_cliente";
            this.tx_cliente.Size = new System.Drawing.Size(76, 20);
            this.tx_cliente.TabIndex = 10;
            // 
            // combo_empresas
            // 
            this.combo_empresas.FormattingEnabled = true;
            this.combo_empresas.Location = new System.Drawing.Point(196, 29);
            this.combo_empresas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_empresas.Name = "combo_empresas";
            this.combo_empresas.Size = new System.Drawing.Size(92, 21);
            this.combo_empresas.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(489, 98);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(74, 28);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(21, 533);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(74, 28);
            this.btn_atras.TabIndex = 7;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(707, 533);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(74, 28);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // ListadoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.GrupoFiltros);
            this.Controls.Add(this.data_facturas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListadoFacturas";
            this.Text = "Listado de Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas)).EndInit();
            this.GrupoFiltros.ResumeLayout(false);
            this.GrupoFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_facturas;
        private System.Windows.Forms.GroupBox GrupoFiltros;
        private System.Windows.Forms.TextBox tx_numero_factura;
        private System.Windows.Forms.TextBox tx_cliente;
        private System.Windows.Forms.ComboBox combo_empresas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DateTimePicker date_fecha_alta;
        private System.Windows.Forms.DateTimePicker date_fecha_vencimiento;
        private System.Windows.Forms.CheckBox cb_fecha_alta;
        private System.Windows.Forms.CheckBox cb_fecha_vencimiento;

    }
}