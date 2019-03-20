namespace PagoAgilFrba.Pagos
{
    partial class RegistroPago
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
            this.group_box_facturas = new System.Windows.Forms.GroupBox();
            this.date_fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.combo_empresas = new System.Windows.Forms.ComboBox();
            this.tx_importe = new System.Windows.Forms.TextBox();
            this.tx_numero_factura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.combo_formas_de_pago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_clientes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data_facturas = new System.Windows.Forms.DataGridView();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.tx_importe_total = new System.Windows.Forms.TextBox();
            this.grupo_cliente = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.group_box_facturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grupo_cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_box_facturas
            // 
            this.group_box_facturas.BackColor = System.Drawing.Color.White;
            this.group_box_facturas.Controls.Add(this.date_fecha_vencimiento);
            this.group_box_facturas.Controls.Add(this.combo_empresas);
            this.group_box_facturas.Controls.Add(this.tx_importe);
            this.group_box_facturas.Controls.Add(this.tx_numero_factura);
            this.group_box_facturas.Controls.Add(this.label6);
            this.group_box_facturas.Controls.Add(this.label5);
            this.group_box_facturas.Controls.Add(this.label3);
            this.group_box_facturas.Controls.Add(this.label2);
            this.group_box_facturas.Controls.Add(this.btn_agregar);
            this.group_box_facturas.Location = new System.Drawing.Point(45, 198);
            this.group_box_facturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_box_facturas.Name = "group_box_facturas";
            this.group_box_facturas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_box_facturas.Size = new System.Drawing.Size(757, 138);
            this.group_box_facturas.TabIndex = 0;
            this.group_box_facturas.TabStop = false;
            this.group_box_facturas.Text = "Datos Factura a Pagar";
            // 
            // date_fecha_vencimiento
            // 
            this.date_fecha_vencimiento.Location = new System.Drawing.Point(276, 96);
            this.date_fecha_vencimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_fecha_vencimiento.Name = "date_fecha_vencimiento";
            this.date_fecha_vencimiento.Size = new System.Drawing.Size(248, 22);
            this.date_fecha_vencimiento.TabIndex = 15;
            // 
            // combo_empresas
            // 
            this.combo_empresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_empresas.FormattingEnabled = true;
            this.combo_empresas.Location = new System.Drawing.Point(371, 43);
            this.combo_empresas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_empresas.Name = "combo_empresas";
            this.combo_empresas.Size = new System.Drawing.Size(121, 24);
            this.combo_empresas.TabIndex = 13;
            // 
            // tx_importe
            // 
            this.tx_importe.Location = new System.Drawing.Point(611, 43);
            this.tx_importe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_importe.Name = "tx_importe";
            this.tx_importe.Size = new System.Drawing.Size(100, 22);
            this.tx_importe.TabIndex = 12;
            // 
            // tx_numero_factura
            // 
            this.tx_numero_factura.Location = new System.Drawing.Point(147, 46);
            this.tx_numero_factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_numero_factura.Name = "tx_numero_factura";
            this.tx_numero_factura.Size = new System.Drawing.Size(100, 22);
            this.tx_numero_factura.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Importe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Vencimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de Factura:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(660, 94);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(91, 30);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // combo_formas_de_pago
            // 
            this.combo_formas_de_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_formas_de_pago.FormattingEnabled = true;
            this.combo_formas_de_pago.Location = new System.Drawing.Point(379, 28);
            this.combo_formas_de_pago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_formas_de_pago.Name = "combo_formas_de_pago";
            this.combo_formas_de_pago.Size = new System.Drawing.Size(121, 24);
            this.combo_formas_de_pago.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Forma de Pago:";
            // 
            // combo_clientes
            // 
            this.combo_clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_clientes.FormattingEnabled = true;
            this.combo_clientes.Location = new System.Drawing.Point(85, 28);
            this.combo_clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_clientes.Name = "combo_clientes";
            this.combo_clientes.Size = new System.Drawing.Size(121, 24);
            this.combo_clientes.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cliente:";
            // 
            // data_facturas
            // 
            this.data_facturas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_facturas.Location = new System.Drawing.Point(45, 378);
            this.data_facturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_facturas.Name = "data_facturas";
            this.data_facturas.ReadOnly = true;
            this.data_facturas.RowTemplate.Height = 24;
            this.data_facturas.Size = new System.Drawing.Size(757, 219);
            this.data_facturas.TabIndex = 1;
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(46, 710);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(91, 30);
            this.btn_atras.TabIndex = 2;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(711, 704);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(91, 30);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_pagar
            // 
            this.btn_pagar.Location = new System.Drawing.Point(366, 704);
            this.btn_pagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(124, 36);
            this.btn_pagar.TabIndex = 4;
            this.btn_pagar.Text = "Realizar Pago";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Listado de facturas a pagar";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Importe Total:";
            // 
            // tx_importe_total
            // 
            this.tx_importe_total.Location = new System.Drawing.Point(645, 28);
            this.tx_importe_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_importe_total.Name = "tx_importe_total";
            this.tx_importe_total.ReadOnly = true;
            this.tx_importe_total.Size = new System.Drawing.Size(100, 22);
            this.tx_importe_total.TabIndex = 16;
            // 
            // grupo_cliente
            // 
            this.grupo_cliente.BackColor = System.Drawing.Color.White;
            this.grupo_cliente.Controls.Add(this.combo_formas_de_pago);
            this.grupo_cliente.Controls.Add(this.label8);
            this.grupo_cliente.Controls.Add(this.tx_importe_total);
            this.grupo_cliente.Controls.Add(this.label4);
            this.grupo_cliente.Controls.Add(this.label7);
            this.grupo_cliente.Controls.Add(this.combo_clientes);
            this.grupo_cliente.Location = new System.Drawing.Point(45, 100);
            this.grupo_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupo_cliente.Name = "grupo_cliente";
            this.grupo_cliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupo_cliente.Size = new System.Drawing.Size(757, 89);
            this.grupo_cliente.TabIndex = 19;
            this.grupo_cliente.TabStop = false;
            this.grupo_cliente.Text = "Datos Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 599);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(338, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nota: La sucursal sera tomada del usuario operador";
            // 
            // RegistroPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 751);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grupo_cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.data_facturas);
            this.Controls.Add(this.group_box_facturas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistroPago";
            this.Text = "Pago";
            this.group_box_facturas.ResumeLayout(false);
            this.group_box_facturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grupo_cliente.ResumeLayout(false);
            this.grupo_cliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_box_facturas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView data_facturas;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_fecha_vencimiento;
        private System.Windows.Forms.ComboBox combo_clientes;
        private System.Windows.Forms.ComboBox combo_empresas;
        private System.Windows.Forms.TextBox tx_importe;
        private System.Windows.Forms.TextBox tx_numero_factura;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox combo_formas_de_pago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grupo_cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tx_importe_total;
        private System.Windows.Forms.Label label9;
    }
}