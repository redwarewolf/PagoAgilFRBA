namespace PagoAgilFrba.Devoluciones
{
    partial class RegistroDevolucion
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
            this.group_box_datos_devolucion = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_numero_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_motivo = new System.Windows.Forms.RichTextBox();
            this.data_facturas_pagas = new System.Windows.Forms.DataGridView();
            this.btn_atras = new System.Windows.Forms.Button();
            this.epProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.data_facturas_devolucion = new System.Windows.Forms.DataGridView();
            this.btn_devolucion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_limpiar_pagas = new System.Windows.Forms.Button();
            this.btn_limpiar_devoluciones = new System.Windows.Forms.Button();
            this.group_box_datos_devolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas_pagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas_devolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // group_box_datos_devolucion
            // 
            this.group_box_datos_devolucion.BackColor = System.Drawing.Color.White;
            this.group_box_datos_devolucion.Controls.Add(this.btn_buscar);
            this.group_box_datos_devolucion.Controls.Add(this.label1);
            this.group_box_datos_devolucion.Controls.Add(this.tx_numero_cliente);
            this.group_box_datos_devolucion.Location = new System.Drawing.Point(31, 97);
            this.group_box_datos_devolucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_box_datos_devolucion.Name = "group_box_datos_devolucion";
            this.group_box_datos_devolucion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_box_datos_devolucion.Size = new System.Drawing.Size(489, 100);
            this.group_box_datos_devolucion.TabIndex = 0;
            this.group_box_datos_devolucion.TabStop = false;
            this.group_box_datos_devolucion.Text = "Datos Devolucion";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(240, 69);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(91, 31);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de cliente:";
            // 
            // tx_numero_cliente
            // 
            this.tx_numero_cliente.Location = new System.Drawing.Point(195, 36);
            this.tx_numero_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_numero_cliente.Name = "tx_numero_cliente";
            this.tx_numero_cliente.Size = new System.Drawing.Size(187, 22);
            this.tx_numero_cliente.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(561, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Motivo de Devolucion:";
            // 
            // tx_motivo
            // 
            this.tx_motivo.Location = new System.Drawing.Point(564, 117);
            this.tx_motivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_motivo.Name = "tx_motivo";
            this.tx_motivo.Size = new System.Drawing.Size(460, 80);
            this.tx_motivo.TabIndex = 4;
            this.tx_motivo.Text = "";
            // 
            // data_facturas_pagas
            // 
            this.data_facturas_pagas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_facturas_pagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_facturas_pagas.Location = new System.Drawing.Point(31, 244);
            this.data_facturas_pagas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_facturas_pagas.Name = "data_facturas_pagas";
            this.data_facturas_pagas.ReadOnly = true;
            this.data_facturas_pagas.RowTemplate.Height = 24;
            this.data_facturas_pagas.Size = new System.Drawing.Size(489, 171);
            this.data_facturas_pagas.TabIndex = 1;
            this.data_facturas_pagas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_facturas_pagas_CellClick);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(31, 493);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(97, 36);
            this.btn_atras.TabIndex = 2;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // epProvider
            // 
            this.epProvider.ContainerControl = this;
            // 
            // data_facturas_devolucion
            // 
            this.data_facturas_devolucion.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_facturas_devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_facturas_devolucion.Location = new System.Drawing.Point(564, 244);
            this.data_facturas_devolucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_facturas_devolucion.Name = "data_facturas_devolucion";
            this.data_facturas_devolucion.ReadOnly = true;
            this.data_facturas_devolucion.RowTemplate.Height = 24;
            this.data_facturas_devolucion.Size = new System.Drawing.Size(489, 171);
            this.data_facturas_devolucion.TabIndex = 6;
            this.data_facturas_devolucion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_facturas_devolucion_CellClick);
            // 
            // btn_devolucion
            // 
            this.btn_devolucion.Location = new System.Drawing.Point(480, 421);
            this.btn_devolucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_devolucion.Name = "btn_devolucion";
            this.btn_devolucion.Size = new System.Drawing.Size(123, 59);
            this.btn_devolucion.TabIndex = 8;
            this.btn_devolucion.Text = "Devolver";
            this.btn_devolucion.UseVisualStyleBackColor = true;
            this.btn_devolucion.Click += new System.EventHandler(this.btn_devolucion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(561, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Facturas a Devolver";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Listado de Facturas Pagas";
            // 
            // btn_limpiar_pagas
            // 
            this.btn_limpiar_pagas.Location = new System.Drawing.Point(31, 421);
            this.btn_limpiar_pagas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar_pagas.Name = "btn_limpiar_pagas";
            this.btn_limpiar_pagas.Size = new System.Drawing.Size(91, 31);
            this.btn_limpiar_pagas.TabIndex = 11;
            this.btn_limpiar_pagas.Text = "Limpiar";
            this.btn_limpiar_pagas.UseVisualStyleBackColor = true;
            this.btn_limpiar_pagas.Click += new System.EventHandler(this.btn_limpiar_pagas_Click);
            // 
            // btn_limpiar_devoluciones
            // 
            this.btn_limpiar_devoluciones.Location = new System.Drawing.Point(962, 421);
            this.btn_limpiar_devoluciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar_devoluciones.Name = "btn_limpiar_devoluciones";
            this.btn_limpiar_devoluciones.Size = new System.Drawing.Size(91, 31);
            this.btn_limpiar_devoluciones.TabIndex = 12;
            this.btn_limpiar_devoluciones.Text = "Limpiar";
            this.btn_limpiar_devoluciones.UseVisualStyleBackColor = true;
            this.btn_limpiar_devoluciones.Click += new System.EventHandler(this.btn_limpiar_devoluciones_Click);
            // 
            // RegistroDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 534);
            this.Controls.Add(this.btn_limpiar_devoluciones);
            this.Controls.Add(this.btn_limpiar_pagas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_devolucion);
            this.Controls.Add(this.data_facturas_devolucion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_motivo);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.data_facturas_pagas);
            this.Controls.Add(this.group_box_datos_devolucion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistroDevolucion";
            this.Text = "Devolucion";
            this.group_box_datos_devolucion.ResumeLayout(false);
            this.group_box_datos_devolucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas_pagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas_devolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_box_datos_devolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_numero_cliente;
        private System.Windows.Forms.DataGridView data_facturas_pagas;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.RichTextBox tx_motivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider epProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_devolucion;
        private System.Windows.Forms.DataGridView data_facturas_devolucion;
        private System.Windows.Forms.Button btn_limpiar_devoluciones;
        private System.Windows.Forms.Button btn_limpiar_pagas;
    }
}