namespace PagoAgilFrba.AbmSucursal
{
    partial class ModificacionSucursal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_direccion_sucursal = new System.Windows.Forms.Label();
            this.lb_CP_sucursal = new System.Windows.Forms.Label();
            this.txt_direccion_sucursal = new System.Windows.Forms.TextBox();
            this.txt_CP_sucursal = new System.Windows.Forms.TextBox();
            this.txt_nombre_sucursal = new System.Windows.Forms.TextBox();
            this.group_sucursal = new System.Windows.Forms.GroupBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.epProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.check_habilitada = new System.Windows.Forms.CheckBox();
            this.group_sucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // lb_direccion_sucursal
            // 
            this.lb_direccion_sucursal.AutoSize = true;
            this.lb_direccion_sucursal.Location = new System.Drawing.Point(38, 59);
            this.lb_direccion_sucursal.Name = "lb_direccion_sucursal";
            this.lb_direccion_sucursal.Size = new System.Drawing.Size(55, 13);
            this.lb_direccion_sucursal.TabIndex = 1;
            this.lb_direccion_sucursal.Text = "Direccion:";
            // 
            // lb_CP_sucursal
            // 
            this.lb_CP_sucursal.AutoSize = true;
            this.lb_CP_sucursal.Location = new System.Drawing.Point(38, 26);
            this.lb_CP_sucursal.Name = "lb_CP_sucursal";
            this.lb_CP_sucursal.Size = new System.Drawing.Size(74, 13);
            this.lb_CP_sucursal.TabIndex = 2;
            this.lb_CP_sucursal.Text = "Codigo postal:";
            // 
            // txt_direccion_sucursal
            // 
            this.txt_direccion_sucursal.Location = new System.Drawing.Point(118, 52);
            this.txt_direccion_sucursal.Name = "txt_direccion_sucursal";
            this.txt_direccion_sucursal.Size = new System.Drawing.Size(100, 20);
            this.txt_direccion_sucursal.TabIndex = 3;
            // 
            // txt_CP_sucursal
            // 
            this.txt_CP_sucursal.Location = new System.Drawing.Point(118, 23);
            this.txt_CP_sucursal.Name = "txt_CP_sucursal";
            this.txt_CP_sucursal.ReadOnly = true;
            this.txt_CP_sucursal.Size = new System.Drawing.Size(100, 20);
            this.txt_CP_sucursal.TabIndex = 3;
            // 
            // txt_nombre_sucursal
            // 
            this.txt_nombre_sucursal.Location = new System.Drawing.Point(341, 23);
            this.txt_nombre_sucursal.Name = "txt_nombre_sucursal";
            this.txt_nombre_sucursal.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_sucursal.TabIndex = 3;
            // 
            // group_sucursal
            // 
            this.group_sucursal.BackColor = System.Drawing.Color.White;
            this.group_sucursal.Controls.Add(this.check_habilitada);
            this.group_sucursal.Controls.Add(this.txt_nombre_sucursal);
            this.group_sucursal.Controls.Add(this.btn_modificar);
            this.group_sucursal.Controls.Add(this.txt_CP_sucursal);
            this.group_sucursal.Controls.Add(this.lb_direccion_sucursal);
            this.group_sucursal.Controls.Add(this.txt_direccion_sucursal);
            this.group_sucursal.Controls.Add(this.label1);
            this.group_sucursal.Controls.Add(this.lb_CP_sucursal);
            this.group_sucursal.Location = new System.Drawing.Point(44, 78);
            this.group_sucursal.Name = "group_sucursal";
            this.group_sucursal.Size = new System.Drawing.Size(494, 132);
            this.group_sucursal.TabIndex = 4;
            this.group_sucursal.TabStop = false;
            this.group_sucursal.Text = "Datos de la sucursal";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(203, 94);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 0;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(85, 234);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // epProvider
            // 
            this.epProvider.ContainerControl = this;
            // 
            // check_habilitada
            // 
            this.check_habilitada.AutoSize = true;
            this.check_habilitada.Location = new System.Drawing.Point(291, 59);
            this.check_habilitada.Name = "check_habilitada";
            this.check_habilitada.Size = new System.Drawing.Size(73, 17);
            this.check_habilitada.TabIndex = 4;
            this.check_habilitada.Text = "Habilitada";
            this.check_habilitada.UseVisualStyleBackColor = true;
            // 
            // ModificacionSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 274);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.group_sucursal);
            this.Name = "ModificacionSucursal";
            this.Text = "ModificacionSucursal";
            this.group_sucursal.ResumeLayout(false);
            this.group_sucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_direccion_sucursal;
        private System.Windows.Forms.Label lb_CP_sucursal;
        private System.Windows.Forms.TextBox txt_direccion_sucursal;
        private System.Windows.Forms.TextBox txt_CP_sucursal;
        private System.Windows.Forms.TextBox txt_nombre_sucursal;
        private System.Windows.Forms.GroupBox group_sucursal;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ErrorProvider epProvider;
        private System.Windows.Forms.CheckBox check_habilitada;
    }
}