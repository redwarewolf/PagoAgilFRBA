namespace PagoAgilFrba.AbmSucursal
{
    partial class ListadoSucursales
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
            this.lb_codigo_postal_sucursal = new System.Windows.Forms.Label();
            this.tx_codigo_postal_sucursal = new System.Windows.Forms.TextBox();
            this.lb_nombre_sucursal = new System.Windows.Forms.Label();
            this.tx_nombre_sucursal = new System.Windows.Forms.TextBox();
            this.lb_direccion_sucursal = new System.Windows.Forms.Label();
            this.tx_direccion_sucursal = new System.Windows.Forms.TextBox();
            this.group_filtros_sucursal = new System.Windows.Forms.GroupBox();
            this.btn_buscar_sucursal = new System.Windows.Forms.Button();
            this.data_listado_sucursales = new System.Windows.Forms.DataGridView();
            this.btn_volver_sucursal = new System.Windows.Forms.Button();
            this.btn_limpiar_sucursal = new System.Windows.Forms.Button();
            this.group_filtros_sucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_listado_sucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_codigo_postal_sucursal
            // 
            this.lb_codigo_postal_sucursal.AutoSize = true;
            this.lb_codigo_postal_sucursal.BackColor = System.Drawing.Color.White;
            this.lb_codigo_postal_sucursal.Location = new System.Drawing.Point(29, 106);
            this.lb_codigo_postal_sucursal.Name = "lb_codigo_postal_sucursal";
            this.lb_codigo_postal_sucursal.Size = new System.Drawing.Size(75, 13);
            this.lb_codigo_postal_sucursal.TabIndex = 0;
            this.lb_codigo_postal_sucursal.Text = "Código Postal:";
            // 
            // tx_codigo_postal_sucursal
            // 
            this.tx_codigo_postal_sucursal.Location = new System.Drawing.Point(110, 103);
            this.tx_codigo_postal_sucursal.Name = "tx_codigo_postal_sucursal";
            this.tx_codigo_postal_sucursal.Size = new System.Drawing.Size(100, 20);
            this.tx_codigo_postal_sucursal.TabIndex = 1;
            // 
            // lb_nombre_sucursal
            // 
            this.lb_nombre_sucursal.AutoSize = true;
            this.lb_nombre_sucursal.BackColor = System.Drawing.Color.White;
            this.lb_nombre_sucursal.Location = new System.Drawing.Point(238, 106);
            this.lb_nombre_sucursal.Name = "lb_nombre_sucursal";
            this.lb_nombre_sucursal.Size = new System.Drawing.Size(47, 13);
            this.lb_nombre_sucursal.TabIndex = 2;
            this.lb_nombre_sucursal.Text = "Nombre:";
            // 
            // tx_nombre_sucursal
            // 
            this.tx_nombre_sucursal.Location = new System.Drawing.Point(291, 103);
            this.tx_nombre_sucursal.Name = "tx_nombre_sucursal";
            this.tx_nombre_sucursal.Size = new System.Drawing.Size(100, 20);
            this.tx_nombre_sucursal.TabIndex = 1;
            // 
            // lb_direccion_sucursal
            // 
            this.lb_direccion_sucursal.AutoSize = true;
            this.lb_direccion_sucursal.BackColor = System.Drawing.Color.White;
            this.lb_direccion_sucursal.Location = new System.Drawing.Point(422, 106);
            this.lb_direccion_sucursal.Name = "lb_direccion_sucursal";
            this.lb_direccion_sucursal.Size = new System.Drawing.Size(55, 13);
            this.lb_direccion_sucursal.TabIndex = 3;
            this.lb_direccion_sucursal.Text = "Dirección:";
            // 
            // tx_direccion_sucursal
            // 
            this.tx_direccion_sucursal.Location = new System.Drawing.Point(483, 103);
            this.tx_direccion_sucursal.Name = "tx_direccion_sucursal";
            this.tx_direccion_sucursal.Size = new System.Drawing.Size(100, 20);
            this.tx_direccion_sucursal.TabIndex = 1;
            // 
            // group_filtros_sucursal
            // 
            this.group_filtros_sucursal.BackColor = System.Drawing.Color.White;
            this.group_filtros_sucursal.Controls.Add(this.btn_buscar_sucursal);
            this.group_filtros_sucursal.Location = new System.Drawing.Point(12, 79);
            this.group_filtros_sucursal.Name = "group_filtros_sucursal";
            this.group_filtros_sucursal.Size = new System.Drawing.Size(582, 114);
            this.group_filtros_sucursal.TabIndex = 4;
            this.group_filtros_sucursal.TabStop = false;
            this.group_filtros_sucursal.Text = "Filtros de búsqueda";
            // 
            // btn_buscar_sucursal
            // 
            this.btn_buscar_sucursal.Location = new System.Drawing.Point(249, 76);
            this.btn_buscar_sucursal.Name = "btn_buscar_sucursal";
            this.btn_buscar_sucursal.Size = new System.Drawing.Size(83, 32);
            this.btn_buscar_sucursal.TabIndex = 0;
            this.btn_buscar_sucursal.Text = "Buscar";
            this.btn_buscar_sucursal.UseVisualStyleBackColor = true;
            this.btn_buscar_sucursal.Click += new System.EventHandler(this.btn_buscar_sucursal_Click);
            // 
            // data_listado_sucursales
            // 
            this.data_listado_sucursales.AllowUserToAddRows = false;
            this.data_listado_sucursales.AllowUserToDeleteRows = false;
            this.data_listado_sucursales.AllowUserToOrderColumns = true;
            this.data_listado_sucursales.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_listado_sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_listado_sucursales.Location = new System.Drawing.Point(12, 199);
            this.data_listado_sucursales.Name = "data_listado_sucursales";
            this.data_listado_sucursales.ReadOnly = true;
            this.data_listado_sucursales.Size = new System.Drawing.Size(582, 168);
            this.data_listado_sucursales.TabIndex = 5;
            this.data_listado_sucursales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_listado_sucursales_CellContentClick);
            // 
            // btn_volver_sucursal
            // 
            this.btn_volver_sucursal.Location = new System.Drawing.Point(23, 377);
            this.btn_volver_sucursal.Name = "btn_volver_sucursal";
            this.btn_volver_sucursal.Size = new System.Drawing.Size(81, 32);
            this.btn_volver_sucursal.TabIndex = 6;
            this.btn_volver_sucursal.Text = "Volver";
            this.btn_volver_sucursal.UseVisualStyleBackColor = true;
            this.btn_volver_sucursal.Click += new System.EventHandler(this.btn_volver_sucursal_Click);
            // 
            // btn_limpiar_sucursal
            // 
            this.btn_limpiar_sucursal.Location = new System.Drawing.Point(483, 377);
            this.btn_limpiar_sucursal.Name = "btn_limpiar_sucursal";
            this.btn_limpiar_sucursal.Size = new System.Drawing.Size(82, 32);
            this.btn_limpiar_sucursal.TabIndex = 6;
            this.btn_limpiar_sucursal.Text = "Limpiar";
            this.btn_limpiar_sucursal.UseVisualStyleBackColor = true;
            this.btn_limpiar_sucursal.Click += new System.EventHandler(this.btn_limpiar_sucursal_Click);
            // 
            // ListadoSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 424);
            this.Controls.Add(this.btn_limpiar_sucursal);
            this.Controls.Add(this.btn_volver_sucursal);
            this.Controls.Add(this.data_listado_sucursales);
            this.Controls.Add(this.lb_direccion_sucursal);
            this.Controls.Add(this.lb_nombre_sucursal);
            this.Controls.Add(this.tx_direccion_sucursal);
            this.Controls.Add(this.tx_nombre_sucursal);
            this.Controls.Add(this.tx_codigo_postal_sucursal);
            this.Controls.Add(this.lb_codigo_postal_sucursal);
            this.Controls.Add(this.group_filtros_sucursal);
            this.Name = "ListadoSucursales";
            this.Text = "Listado de sucursales";
            this.group_filtros_sucursal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_listado_sucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codigo_postal_sucursal;
        private System.Windows.Forms.TextBox tx_codigo_postal_sucursal;
        private System.Windows.Forms.Label lb_nombre_sucursal;
        private System.Windows.Forms.TextBox tx_nombre_sucursal;
        private System.Windows.Forms.Label lb_direccion_sucursal;
        private System.Windows.Forms.TextBox tx_direccion_sucursal;
        private System.Windows.Forms.GroupBox group_filtros_sucursal;
        private System.Windows.Forms.Button btn_buscar_sucursal;
        private System.Windows.Forms.DataGridView data_listado_sucursales;
        private System.Windows.Forms.Button btn_volver_sucursal;
        private System.Windows.Forms.Button btn_limpiar_sucursal;
    }
}