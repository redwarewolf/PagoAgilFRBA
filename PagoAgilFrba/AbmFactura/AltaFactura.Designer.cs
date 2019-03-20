namespace PagoAgilFrba.AbmFactura
{
    partial class AltaFactura
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
            this.components = new System.ComponentModel.Container();
            this.group_facturas = new System.Windows.Forms.GroupBox();
            this.combo_clientes = new System.Windows.Forms.ComboBox();
            this.combo_empresas = new System.Windows.Forms.ComboBox();
            this.date_vencimiento_factura = new System.Windows.Forms.DateTimePicker();
            this.tx_monto_total = new System.Windows.Forms.TextBox();
            this.l_fecha_vencimiento_factura = new System.Windows.Forms.Label();
            this.date_fecha_alta_factura = new System.Windows.Forms.DateTimePicker();
            this.lb_monto_total = new System.Windows.Forms.Label();
            this.l_fecha_alta = new System.Windows.Forms.Label();
            this.tx_numero_factura = new System.Windows.Forms.TextBox();
            this.l_numero_factura = new System.Windows.Forms.Label();
            this.l_cuit = new System.Windows.Forms.Label();
            this.l_documento = new System.Windows.Forms.Label();
            this.btn_agregar_item = new System.Windows.Forms.Button();
            this.group_box_items = new System.Windows.Forms.GroupBox();
            this.tx_monto_item = new System.Windows.Forms.TextBox();
            this.tx_cantidad_item = new System.Windows.Forms.TextBox();
            this.tx_detalle_item = new System.Windows.Forms.RichTextBox();
            this.lb_monto_item = new System.Windows.Forms.Label();
            this.lb_cantidad_item = new System.Windows.Forms.Label();
            this.l_detalle_item = new System.Windows.Forms.Label();
            this.btn_alta_factura = new System.Windows.Forms.Button();
            this.epProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grupoItems = new System.Windows.Forms.GroupBox();
            this.data_items = new System.Windows.Forms.DataGridView();
            this.btn_vaciar_items = new System.Windows.Forms.Button();
            this.btn_eliminar_item = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.group_facturas.SuspendLayout();
            this.group_box_items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProvider)).BeginInit();
            this.grupoItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_items)).BeginInit();
            this.SuspendLayout();
            // 
            // group_facturas
            // 
            this.group_facturas.Controls.Add(this.combo_clientes);
            this.group_facturas.Controls.Add(this.combo_empresas);
            this.group_facturas.Controls.Add(this.date_vencimiento_factura);
            this.group_facturas.Controls.Add(this.tx_monto_total);
            this.group_facturas.Controls.Add(this.l_fecha_vencimiento_factura);
            this.group_facturas.Controls.Add(this.date_fecha_alta_factura);
            this.group_facturas.Controls.Add(this.lb_monto_total);
            this.group_facturas.Controls.Add(this.l_fecha_alta);
            this.group_facturas.Controls.Add(this.tx_numero_factura);
            this.group_facturas.Controls.Add(this.l_numero_factura);
            this.group_facturas.Controls.Add(this.l_cuit);
            this.group_facturas.Controls.Add(this.l_documento);
            this.group_facturas.Location = new System.Drawing.Point(43, 91);
            this.group_facturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_facturas.Name = "group_facturas";
            this.group_facturas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_facturas.Size = new System.Drawing.Size(905, 174);
            this.group_facturas.TabIndex = 0;
            this.group_facturas.TabStop = false;
            this.group_facturas.Text = "Datos de Factura";
            // 
            // combo_clientes
            // 
            this.combo_clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_clientes.FormattingEnabled = true;
            this.combo_clientes.Location = new System.Drawing.Point(123, 33);
            this.combo_clientes.Name = "combo_clientes";
            this.combo_clientes.Size = new System.Drawing.Size(116, 24);
            this.combo_clientes.TabIndex = 15;
            // 
            // combo_empresas
            // 
            this.combo_empresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_empresas.FormattingEnabled = true;
            this.combo_empresas.Location = new System.Drawing.Point(123, 89);
            this.combo_empresas.Name = "combo_empresas";
            this.combo_empresas.Size = new System.Drawing.Size(116, 24);
            this.combo_empresas.TabIndex = 14;
            // 
            // date_vencimiento_factura
            // 
            this.date_vencimiento_factura.Location = new System.Drawing.Point(451, 89);
            this.date_vencimiento_factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_vencimiento_factura.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.date_vencimiento_factura.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.date_vencimiento_factura.Name = "date_vencimiento_factura";
            this.date_vencimiento_factura.Size = new System.Drawing.Size(268, 22);
            this.date_vencimiento_factura.TabIndex = 9;
            // 
            // tx_monto_total
            // 
            this.tx_monto_total.Location = new System.Drawing.Point(805, 135);
            this.tx_monto_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_monto_total.Name = "tx_monto_total";
            this.tx_monto_total.ReadOnly = true;
            this.tx_monto_total.Size = new System.Drawing.Size(100, 22);
            this.tx_monto_total.TabIndex = 13;
            // 
            // l_fecha_vencimiento_factura
            // 
            this.l_fecha_vencimiento_factura.AutoSize = true;
            this.l_fecha_vencimiento_factura.Location = new System.Drawing.Point(245, 89);
            this.l_fecha_vencimiento_factura.Name = "l_fecha_vencimiento_factura";
            this.l_fecha_vencimiento_factura.Size = new System.Drawing.Size(198, 17);
            this.l_fecha_vencimiento_factura.TabIndex = 8;
            this.l_fecha_vencimiento_factura.Text = "Fecha vencimiento de factura:";
            // 
            // date_fecha_alta_factura
            // 
            this.date_fecha_alta_factura.Location = new System.Drawing.Point(397, 37);
            this.date_fecha_alta_factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_fecha_alta_factura.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.date_fecha_alta_factura.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.date_fecha_alta_factura.Name = "date_fecha_alta_factura";
            this.date_fecha_alta_factura.Size = new System.Drawing.Size(268, 22);
            this.date_fecha_alta_factura.TabIndex = 7;
            // 
            // lb_monto_total
            // 
            this.lb_monto_total.AutoSize = true;
            this.lb_monto_total.Location = new System.Drawing.Point(698, 140);
            this.lb_monto_total.Name = "lb_monto_total";
            this.lb_monto_total.Size = new System.Drawing.Size(87, 17);
            this.lb_monto_total.TabIndex = 10;
            this.lb_monto_total.Text = "Monto Total:";
            // 
            // l_fecha_alta
            // 
            this.l_fecha_alta.AutoSize = true;
            this.l_fecha_alta.Location = new System.Drawing.Point(245, 39);
            this.l_fecha_alta.Name = "l_fecha_alta";
            this.l_fecha_alta.Size = new System.Drawing.Size(146, 17);
            this.l_fecha_alta.TabIndex = 6;
            this.l_fecha_alta.Text = "Fecha alta de factura:";
            // 
            // tx_numero_factura
            // 
            this.tx_numero_factura.Location = new System.Drawing.Point(123, 133);
            this.tx_numero_factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_numero_factura.Name = "tx_numero_factura";
            this.tx_numero_factura.Size = new System.Drawing.Size(116, 22);
            this.tx_numero_factura.TabIndex = 5;
            // 
            // l_numero_factura
            // 
            this.l_numero_factura.AutoSize = true;
            this.l_numero_factura.Location = new System.Drawing.Point(7, 135);
            this.l_numero_factura.Name = "l_numero_factura";
            this.l_numero_factura.Size = new System.Drawing.Size(76, 17);
            this.l_numero_factura.TabIndex = 4;
            this.l_numero_factura.Text = "N° factura:";
            // 
            // l_cuit
            // 
            this.l_cuit.AutoSize = true;
            this.l_cuit.Location = new System.Drawing.Point(7, 87);
            this.l_cuit.Name = "l_cuit";
            this.l_cuit.Size = new System.Drawing.Size(102, 17);
            this.l_cuit.TabIndex = 2;
            this.l_cuit.Text = "CUIT empresa:";
            // 
            // l_documento
            // 
            this.l_documento.AutoSize = true;
            this.l_documento.Location = new System.Drawing.Point(7, 39);
            this.l_documento.Name = "l_documento";
            this.l_documento.Size = new System.Drawing.Size(80, 17);
            this.l_documento.TabIndex = 1;
            this.l_documento.Text = "DNI cliente:";
            // 
            // btn_agregar_item
            // 
            this.btn_agregar_item.Location = new System.Drawing.Point(56, 220);
            this.btn_agregar_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar_item.Name = "btn_agregar_item";
            this.btn_agregar_item.Size = new System.Drawing.Size(171, 28);
            this.btn_agregar_item.TabIndex = 3;
            this.btn_agregar_item.Text = "Agregar item";
            this.btn_agregar_item.UseVisualStyleBackColor = true;
            this.btn_agregar_item.Click += new System.EventHandler(this.btn_agregar_item_Click);
            // 
            // group_box_items
            // 
            this.group_box_items.Controls.Add(this.tx_monto_item);
            this.group_box_items.Controls.Add(this.tx_cantidad_item);
            this.group_box_items.Controls.Add(this.tx_detalle_item);
            this.group_box_items.Controls.Add(this.lb_monto_item);
            this.group_box_items.Controls.Add(this.lb_cantidad_item);
            this.group_box_items.Controls.Add(this.l_detalle_item);
            this.group_box_items.Controls.Add(this.btn_agregar_item);
            this.group_box_items.Location = new System.Drawing.Point(633, 271);
            this.group_box_items.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_box_items.Name = "group_box_items";
            this.group_box_items.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_box_items.Size = new System.Drawing.Size(315, 249);
            this.group_box_items.TabIndex = 6;
            this.group_box_items.TabStop = false;
            this.group_box_items.Text = "Nuevo Item";
            // 
            // tx_monto_item
            // 
            this.tx_monto_item.Location = new System.Drawing.Point(163, 162);
            this.tx_monto_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_monto_item.Name = "tx_monto_item";
            this.tx_monto_item.Size = new System.Drawing.Size(100, 22);
            this.tx_monto_item.TabIndex = 14;
            // 
            // tx_cantidad_item
            // 
            this.tx_cantidad_item.Location = new System.Drawing.Point(0, 162);
            this.tx_cantidad_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_cantidad_item.Name = "tx_cantidad_item";
            this.tx_cantidad_item.Size = new System.Drawing.Size(100, 22);
            this.tx_cantidad_item.TabIndex = 10;
            // 
            // tx_detalle_item
            // 
            this.tx_detalle_item.Location = new System.Drawing.Point(0, 52);
            this.tx_detalle_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_detalle_item.Name = "tx_detalle_item";
            this.tx_detalle_item.Size = new System.Drawing.Size(263, 78);
            this.tx_detalle_item.TabIndex = 13;
            this.tx_detalle_item.Text = "";
            
            // 
            // lb_monto_item
            // 
            this.lb_monto_item.AutoSize = true;
            this.lb_monto_item.Location = new System.Drawing.Point(196, 143);
            this.lb_monto_item.Name = "lb_monto_item";
            this.lb_monto_item.Size = new System.Drawing.Size(51, 17);
            this.lb_monto_item.TabIndex = 12;
            this.lb_monto_item.Text = "Monto:";
            // 
            // lb_cantidad_item
            // 
            this.lb_cantidad_item.AutoSize = true;
            this.lb_cantidad_item.Location = new System.Drawing.Point(5, 143);
            this.lb_cantidad_item.Name = "lb_cantidad_item";
            this.lb_cantidad_item.Size = new System.Drawing.Size(64, 17);
            this.lb_cantidad_item.TabIndex = 11;
            this.lb_cantidad_item.Text = "Cantidad";
            // 
            // l_detalle_item
            // 
            this.l_detalle_item.AutoSize = true;
            this.l_detalle_item.Location = new System.Drawing.Point(83, 32);
            this.l_detalle_item.Name = "l_detalle_item";
            this.l_detalle_item.Size = new System.Drawing.Size(56, 17);
            this.l_detalle_item.TabIndex = 10;
            this.l_detalle_item.Text = "Detalle:";
            // 
            // btn_alta_factura
            // 
            this.btn_alta_factura.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_alta_factura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_alta_factura.Location = new System.Drawing.Point(689, 571);
            this.btn_alta_factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_alta_factura.Name = "btn_alta_factura";
            this.btn_alta_factura.Size = new System.Drawing.Size(168, 46);
            this.btn_alta_factura.TabIndex = 7;
            this.btn_alta_factura.Text = "Dar de alta factura";
            this.btn_alta_factura.UseVisualStyleBackColor = false;
            this.btn_alta_factura.Click += new System.EventHandler(this.btn_alta_factura_Click);
            // 
            // epProvider
            // 
            this.epProvider.ContainerControl = this;
            // 
            // grupoItems
            // 
            this.grupoItems.Controls.Add(this.data_items);
            this.grupoItems.Controls.Add(this.btn_vaciar_items);
            this.grupoItems.Controls.Add(this.btn_eliminar_item);
            this.grupoItems.Location = new System.Drawing.Point(43, 271);
            this.grupoItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoItems.Name = "grupoItems";
            this.grupoItems.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoItems.Size = new System.Drawing.Size(584, 246);
            this.grupoItems.TabIndex = 12;
            this.grupoItems.TabStop = false;
            this.grupoItems.Text = "Lista Items";
            // 
            // data_items
            // 
            this.data_items.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_items.Location = new System.Drawing.Point(5, 21);
            this.data_items.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_items.Name = "data_items";
            this.data_items.ReadOnly = true;
            this.data_items.RowTemplate.Height = 24;
            this.data_items.Size = new System.Drawing.Size(572, 183);
            this.data_items.TabIndex = 14;
            // 
            // btn_vaciar_items
            // 
            this.btn_vaciar_items.Location = new System.Drawing.Point(5, 210);
            this.btn_vaciar_items.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_vaciar_items.Name = "btn_vaciar_items";
            this.btn_vaciar_items.Size = new System.Drawing.Size(175, 30);
            this.btn_vaciar_items.TabIndex = 13;
            this.btn_vaciar_items.Text = "Vaciar items";
            this.btn_vaciar_items.UseVisualStyleBackColor = true;
            this.btn_vaciar_items.Click += new System.EventHandler(this.btn_vaciar_items_Click);
            // 
            // btn_eliminar_item
            // 
            this.btn_eliminar_item.Location = new System.Drawing.Point(409, 210);
            this.btn_eliminar_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar_item.Name = "btn_eliminar_item";
            this.btn_eliminar_item.Size = new System.Drawing.Size(175, 30);
            this.btn_eliminar_item.TabIndex = 12;
            this.btn_eliminar_item.Text = "Eliminar item";
            this.btn_eliminar_item.UseVisualStyleBackColor = true;
            this.btn_eliminar_item.Click += new System.EventHandler(this.btn_eliminar_item_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(53, 587);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(105, 30);
            this.btn_atras.TabIndex = 15;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // AltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(960, 628);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.grupoItems);
            this.Controls.Add(this.btn_alta_factura);
            this.Controls.Add(this.group_box_items);
            this.Controls.Add(this.group_facturas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AltaFactura";
            this.Text = "Alta Factura";
            this.group_facturas.ResumeLayout(false);
            this.group_facturas.PerformLayout();
            this.group_box_items.ResumeLayout(false);
            this.group_box_items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProvider)).EndInit();
            this.grupoItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_facturas;
        private System.Windows.Forms.Label l_documento;
        private System.Windows.Forms.Label l_cuit;
        private System.Windows.Forms.TextBox tx_numero_factura;
        private System.Windows.Forms.Label l_numero_factura;
        private System.Windows.Forms.Label l_fecha_alta;
        private System.Windows.Forms.DateTimePicker date_fecha_alta_factura;
        private System.Windows.Forms.DateTimePicker date_vencimiento_factura;
        private System.Windows.Forms.Label l_fecha_vencimiento_factura;
        //private System.Windows.Forms.ListBox list_items;
        private System.Windows.Forms.Button btn_agregar_item;
        private System.Windows.Forms.GroupBox group_box_items;
        private System.Windows.Forms.Label l_detalle_item;
        private System.Windows.Forms.Label lb_monto_item;
        private System.Windows.Forms.Label lb_cantidad_item;
        private System.Windows.Forms.RichTextBox tx_detalle_item;
        private System.Windows.Forms.TextBox tx_monto_item;
        private System.Windows.Forms.TextBox tx_cantidad_item;
        private System.Windows.Forms.Button btn_alta_factura;
        private System.Windows.Forms.ErrorProvider epProvider;
        private System.Windows.Forms.Label lb_monto_total;
        //private System.Windows.Forms.Label lb_monto_total_calculo;
        private System.Windows.Forms.GroupBox grupoItems;
        private System.Windows.Forms.DataGridView data_items;
        private System.Windows.Forms.Button btn_vaciar_items;
        private System.Windows.Forms.Button btn_eliminar_item;
        private System.Windows.Forms.TextBox tx_monto_total;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.ComboBox combo_empresas;
        private System.Windows.Forms.ComboBox combo_clientes;
    }
}