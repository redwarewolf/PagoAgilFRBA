namespace PagoAgilFrba.ListadoEstadistico
{
    partial class Listados
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
            this.numElem = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.busqueda_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.Label();
            this.date_ano = new System.Windows.Forms.DateTimePicker();
            this.grid_listado = new System.Windows.Forms.DataGridView();
            this.btn_atras = new System.Windows.Forms.Button();
            this.combo_trimestres = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numElem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // numElem
            // 
            this.numElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numElem.Location = new System.Drawing.Point(524, 201);
            this.numElem.Margin = new System.Windows.Forms.Padding(4);
            this.numElem.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numElem.Name = "numElem";
            this.numElem.Size = new System.Drawing.Size(160, 29);
            this.numElem.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 668);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "(*) Por defecto se muestran los 5 primeros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cantidad de elementos a mostrar*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Seleccionar Datos de Busqueda";
            // 
            // busqueda_btn
            // 
            this.busqueda_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busqueda_btn.Location = new System.Drawing.Point(101, 266);
            this.busqueda_btn.Margin = new System.Windows.Forms.Padding(4);
            this.busqueda_btn.Name = "busqueda_btn";
            this.busqueda_btn.Size = new System.Drawing.Size(771, 53);
            this.busqueda_btn.TabIndex = 16;
            this.busqueda_btn.Text = "Busqueda";
            this.busqueda_btn.UseVisualStyleBackColor = true;
            this.busqueda_btn.Click += new System.EventHandler(this.busqueda_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Trimestre";
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.BackColor = System.Drawing.Color.White;
            this.Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desde.Location = new System.Drawing.Point(199, 149);
            this.Desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(45, 24);
            this.Desde.TabIndex = 14;
            this.Desde.Text = "Año";
            // 
            // date_ano
            // 
            this.date_ano.CustomFormat = "yyyy";
            this.date_ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ano.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ano.Location = new System.Drawing.Point(275, 148);
            this.date_ano.Margin = new System.Windows.Forms.Padding(4);
            this.date_ano.Name = "date_ano";
            this.date_ano.Size = new System.Drawing.Size(165, 29);
            this.date_ano.TabIndex = 12;
            // 
            // grid_listado
            // 
            this.grid_listado.AllowUserToAddRows = false;
            this.grid_listado.AllowUserToDeleteRows = false;
            this.grid_listado.AllowUserToOrderColumns = true;
            this.grid_listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_listado.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grid_listado.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.grid_listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grid_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_listado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grid_listado.Location = new System.Drawing.Point(101, 326);
            this.grid_listado.Margin = new System.Windows.Forms.Padding(4);
            this.grid_listado.Name = "grid_listado";
            this.grid_listado.ReadOnly = true;
            this.grid_listado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_listado.Size = new System.Drawing.Size(771, 329);
            this.grid_listado.TabIndex = 11;
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(101, 668);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(88, 37);
            this.btn_atras.TabIndex = 21;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // combo_trimestres
            // 
            this.combo_trimestres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_trimestres.FormattingEnabled = true;
            this.combo_trimestres.Location = new System.Drawing.Point(620, 147);
            this.combo_trimestres.Name = "combo_trimestres";
            this.combo_trimestres.Size = new System.Drawing.Size(121, 24);
            this.combo_trimestres.TabIndex = 22;
            // 
            // Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 718);
            this.Controls.Add(this.combo_trimestres);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.numElem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.busqueda_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.date_ano);
            this.Controls.Add(this.grid_listado);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Listados";
            ((System.ComponentModel.ISupportInitialize)(this.numElem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numElem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button busqueda_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.DateTimePicker date_ano;
        private System.Windows.Forms.DataGridView grid_listado;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.ComboBox combo_trimestres;
    }
}