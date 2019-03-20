namespace PagoAgilFrba.Rendicion
{
    partial class Rendicion
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
            this.grupo_rendicion = new System.Windows.Forms.GroupBox();
            this.tx_cant_fact_a_rendir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_porcentaje_comision = new System.Windows.Forms.NumericUpDown();
            this.combo_empresas = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tx_importe_comision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_importe_total_rendicion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.data_facturas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_fecha_rendicion = new System.Windows.Forms.DateTimePicker();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.button_realizar_rendicion = new System.Windows.Forms.Button();
            this.grupo_rendicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_porcentaje_comision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas)).BeginInit();
            this.SuspendLayout();
            // 
            // grupo_rendicion
            // 
            this.grupo_rendicion.BackColor = System.Drawing.Color.White;
            this.grupo_rendicion.Controls.Add(this.tx_cant_fact_a_rendir);
            this.grupo_rendicion.Controls.Add(this.label6);
            this.grupo_rendicion.Controls.Add(this.tx_porcentaje_comision);
            this.grupo_rendicion.Controls.Add(this.combo_empresas);
            this.grupo_rendicion.Controls.Add(this.btn_buscar);
            this.grupo_rendicion.Controls.Add(this.tx_importe_comision);
            this.grupo_rendicion.Controls.Add(this.label5);
            this.grupo_rendicion.Controls.Add(this.tx_importe_total_rendicion);
            this.grupo_rendicion.Controls.Add(this.label4);
            this.grupo_rendicion.Controls.Add(this.label3);
            this.grupo_rendicion.Controls.Add(this.data_facturas);
            this.grupo_rendicion.Controls.Add(this.label2);
            this.grupo_rendicion.Controls.Add(this.label1);
            this.grupo_rendicion.Controls.Add(this.date_fecha_rendicion);
            this.grupo_rendicion.Location = new System.Drawing.Point(52, 73);
            this.grupo_rendicion.Name = "grupo_rendicion";
            this.grupo_rendicion.Size = new System.Drawing.Size(770, 536);
            this.grupo_rendicion.TabIndex = 0;
            this.grupo_rendicion.TabStop = false;
            this.grupo_rendicion.Text = "Datos Rendicion";
            // 
            // tx_cant_fact_a_rendir
            // 
            this.tx_cant_fact_a_rendir.Location = new System.Drawing.Point(254, 382);
            this.tx_cant_fact_a_rendir.Name = "tx_cant_fact_a_rendir";
            this.tx_cant_fact_a_rendir.ReadOnly = true;
            this.tx_cant_fact_a_rendir.Size = new System.Drawing.Size(197, 19);
            this.tx_cant_fact_a_rendir.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cantidad de Facturas A Rendir:";
            // 
            // tx_porcentaje_comision
            // 
            this.tx_porcentaje_comision.Location = new System.Drawing.Point(188, 432);
            this.tx_porcentaje_comision.Name = "tx_porcentaje_comision";
            this.tx_porcentaje_comision.Size = new System.Drawing.Size(61, 19);
            this.tx_porcentaje_comision.TabIndex = 14;
            this.tx_porcentaje_comision.ValueChanged += new System.EventHandler(this.tx_porcentaje_comision_ValueChanged);
            // 
            // combo_empresas
            // 
            this.combo_empresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_empresas.FormattingEnabled = true;
            this.combo_empresas.Location = new System.Drawing.Point(188, 48);
            this.combo_empresas.Name = "combo_empresas";
            this.combo_empresas.Size = new System.Drawing.Size(447, 21);
            this.combo_empresas.TabIndex = 13;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(348, 88);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(287, 30);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.Text = "Buscar Facturas Pagas";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // tx_importe_comision
            // 
            this.tx_importe_comision.Location = new System.Drawing.Point(392, 434);
            this.tx_importe_comision.Name = "tx_importe_comision";
            this.tx_importe_comision.ReadOnly = true;
            this.tx_importe_comision.Size = new System.Drawing.Size(197, 19);
            this.tx_importe_comision.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Importe Comision";
            // 
            // tx_importe_total_rendicion
            // 
            this.tx_importe_total_rendicion.Location = new System.Drawing.Point(196, 475);
            this.tx_importe_total_rendicion.Name = "tx_importe_total_rendicion";
            this.tx_importe_total_rendicion.ReadOnly = true;
            this.tx_importe_total_rendicion.Size = new System.Drawing.Size(393, 19);
            this.tx_importe_total_rendicion.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Importe Total Rendicion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Porcentaje Comision";
            // 
            // data_facturas
            // 
            this.data_facturas.AllowUserToAddRows = false;
            this.data_facturas.AllowUserToDeleteRows = false;
            this.data_facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_facturas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_facturas.Location = new System.Drawing.Point(35, 140);
            this.data_facturas.Name = "data_facturas";
            this.data_facturas.ReadOnly = true;
            this.data_facturas.RowTemplate.Height = 24;
            this.data_facturas.Size = new System.Drawing.Size(600, 224);
            this.data_facturas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Rendicion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empresa:";
            // 
            // date_fecha_rendicion
            // 
            this.date_fecha_rendicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fecha_rendicion.Location = new System.Drawing.Point(188, 90);
            this.date_fecha_rendicion.MaxDate = new System.DateTime(5810, 12, 22, 0, 0, 0, 0);
            this.date_fecha_rendicion.Name = "date_fecha_rendicion";
            this.date_fecha_rendicion.Size = new System.Drawing.Size(135, 19);
            this.date_fecha_rendicion.TabIndex = 0;
            this.date_fecha_rendicion.Value = new System.DateTime(2017, 10, 29, 0, 0, 0, 0);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(694, 213);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(105, 29);
            this.btn_limpiar.TabIndex = 12;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(10, 615);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(89, 33);
            this.btn_atras.TabIndex = 13;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // button_realizar_rendicion
            // 
            this.button_realizar_rendicion.Location = new System.Drawing.Point(552, 612);
            this.button_realizar_rendicion.Name = "button_realizar_rendicion";
            this.button_realizar_rendicion.Size = new System.Drawing.Size(270, 33);
            this.button_realizar_rendicion.TabIndex = 14;
            this.button_realizar_rendicion.Text = "Rendir Facturas";
            this.button_realizar_rendicion.UseVisualStyleBackColor = true;
            this.button_realizar_rendicion.Click += new System.EventHandler(this.button_realizar_rendicion_Click);
            // 
            // Rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 672);
            this.Controls.Add(this.button_realizar_rendicion);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.grupo_rendicion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Rendicion";
            this.Text = "Rendición";
            this.grupo_rendicion.ResumeLayout(false);
            this.grupo_rendicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_porcentaje_comision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo_rendicion;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox tx_importe_comision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_importe_total_rendicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data_facturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_fecha_rendicion;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.ComboBox combo_empresas;
        private System.Windows.Forms.NumericUpDown tx_porcentaje_comision;
        private System.Windows.Forms.TextBox tx_cant_fact_a_rendir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_realizar_rendicion;
    }
}