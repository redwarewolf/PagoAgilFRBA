namespace PagoAgilFrba.AbmSucursal
{
    partial class AltaSucursal
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
            this.grupo_sucursal = new System.Windows.Forms.GroupBox();
            this.btn_alta_sucursal = new System.Windows.Forms.Button();
            this.tx_codigo_postal_sucursal = new System.Windows.Forms.TextBox();
            this.tx_direccion_sucursal = new System.Windows.Forms.TextBox();
            this.tx_nombre_sucursal = new System.Windows.Forms.TextBox();
            this.lb_codigo_postal_sucursal = new System.Windows.Forms.Label();
            this.lb_direccion_sucursal = new System.Windows.Forms.Label();
            this.lb_nombre_sucursal = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.epProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grupo_sucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grupo_sucursal
            // 
            this.grupo_sucursal.BackColor = System.Drawing.Color.White;
            this.grupo_sucursal.Controls.Add(this.btn_alta_sucursal);
            this.grupo_sucursal.Controls.Add(this.tx_codigo_postal_sucursal);
            this.grupo_sucursal.Controls.Add(this.tx_direccion_sucursal);
            this.grupo_sucursal.Controls.Add(this.tx_nombre_sucursal);
            this.grupo_sucursal.Controls.Add(this.lb_codigo_postal_sucursal);
            this.grupo_sucursal.Controls.Add(this.lb_direccion_sucursal);
            this.grupo_sucursal.Controls.Add(this.lb_nombre_sucursal);
            this.grupo_sucursal.Location = new System.Drawing.Point(25, 71);
            this.grupo_sucursal.Name = "grupo_sucursal";
            this.grupo_sucursal.Size = new System.Drawing.Size(443, 169);
            this.grupo_sucursal.TabIndex = 0;
            this.grupo_sucursal.TabStop = false;
            this.grupo_sucursal.Text = "Datos de sucursal";
            // 
            // btn_alta_sucursal
            // 
            this.btn_alta_sucursal.Location = new System.Drawing.Point(317, 76);
            this.btn_alta_sucursal.Name = "btn_alta_sucursal";
            this.btn_alta_sucursal.Size = new System.Drawing.Size(98, 34);
            this.btn_alta_sucursal.TabIndex = 4;
            this.btn_alta_sucursal.Text = "Dar de alta sucursal";
            this.btn_alta_sucursal.UseVisualStyleBackColor = true;
            this.btn_alta_sucursal.Click += new System.EventHandler(this.btn_alta_sucursal_Click);
            // 
            // tx_codigo_postal_sucursal
            // 
            this.tx_codigo_postal_sucursal.Location = new System.Drawing.Point(133, 139);
            this.tx_codigo_postal_sucursal.Name = "tx_codigo_postal_sucursal";
            this.tx_codigo_postal_sucursal.Size = new System.Drawing.Size(100, 20);
            this.tx_codigo_postal_sucursal.TabIndex = 3;
            // 
            // tx_direccion_sucursal
            // 
            this.tx_direccion_sucursal.Location = new System.Drawing.Point(133, 84);
            this.tx_direccion_sucursal.Name = "tx_direccion_sucursal";
            this.tx_direccion_sucursal.Size = new System.Drawing.Size(100, 20);
            this.tx_direccion_sucursal.TabIndex = 3;
            // 
            // tx_nombre_sucursal
            // 
            this.tx_nombre_sucursal.Location = new System.Drawing.Point(133, 36);
            this.tx_nombre_sucursal.Name = "tx_nombre_sucursal";
            this.tx_nombre_sucursal.Size = new System.Drawing.Size(100, 20);
            this.tx_nombre_sucursal.TabIndex = 3;
            // 
            // lb_codigo_postal_sucursal
            // 
            this.lb_codigo_postal_sucursal.AutoSize = true;
            this.lb_codigo_postal_sucursal.Location = new System.Drawing.Point(55, 142);
            this.lb_codigo_postal_sucursal.Name = "lb_codigo_postal_sucursal";
            this.lb_codigo_postal_sucursal.Size = new System.Drawing.Size(74, 13);
            this.lb_codigo_postal_sucursal.TabIndex = 2;
            this.lb_codigo_postal_sucursal.Text = "Codigo postal:";
            // 
            // lb_direccion_sucursal
            // 
            this.lb_direccion_sucursal.AutoSize = true;
            this.lb_direccion_sucursal.Location = new System.Drawing.Point(55, 87);
            this.lb_direccion_sucursal.Name = "lb_direccion_sucursal";
            this.lb_direccion_sucursal.Size = new System.Drawing.Size(55, 13);
            this.lb_direccion_sucursal.TabIndex = 1;
            this.lb_direccion_sucursal.Text = "Direccion:";
            // 
            // lb_nombre_sucursal
            // 
            this.lb_nombre_sucursal.AutoSize = true;
            this.lb_nombre_sucursal.Location = new System.Drawing.Point(55, 39);
            this.lb_nombre_sucursal.Name = "lb_nombre_sucursal";
            this.lb_nombre_sucursal.Size = new System.Drawing.Size(47, 13);
            this.lb_nombre_sucursal.TabIndex = 0;
            this.lb_nombre_sucursal.Text = "Nombre:";
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(59, 265);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(95, 31);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // epProvider
            // 
            this.epProvider.ContainerControl = this;
            // 
            // AltaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 305);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.grupo_sucursal);
            this.Name = "AltaSucursal";
            this.Text = "AltaSucursal";
            this.grupo_sucursal.ResumeLayout(false);
            this.grupo_sucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo_sucursal;
        private System.Windows.Forms.TextBox tx_nombre_sucursal;
        private System.Windows.Forms.Label lb_codigo_postal_sucursal;
        private System.Windows.Forms.Label lb_direccion_sucursal;
        private System.Windows.Forms.Label lb_nombre_sucursal;
        private System.Windows.Forms.TextBox tx_codigo_postal_sucursal;
        private System.Windows.Forms.TextBox tx_direccion_sucursal;
        private System.Windows.Forms.Button btn_alta_sucursal;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ErrorProvider epProvider;
    }
}