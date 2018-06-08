namespace baseDeDatos
{
    partial class Form1
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.lblIDProduct = new System.Windows.Forms.Label();
            this.lblDaysToManufacture = new System.Windows.Forms.Label();
            this.txtDaysToManufacture = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 66);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(50, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Producto";
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // cmbId
            // 
            this.cmbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Location = new System.Drawing.Point(149, 12);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(121, 21);
            this.cmbId.TabIndex = 1;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(149, 59);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(100, 20);
            this.txtNameProduct.TabIndex = 2;
            // 
            // lblIDProduct
            // 
            this.lblIDProduct.AutoSize = true;
            this.lblIDProduct.Location = new System.Drawing.Point(13, 20);
            this.lblIDProduct.Name = "lblIDProduct";
            this.lblIDProduct.Size = new System.Drawing.Size(18, 13);
            this.lblIDProduct.TabIndex = 3;
            this.lblIDProduct.Text = "ID";
            // 
            // lblDaysToManufacture
            // 
            this.lblDaysToManufacture.AutoSize = true;
            this.lblDaysToManufacture.Location = new System.Drawing.Point(16, 98);
            this.lblDaysToManufacture.Name = "lblDaysToManufacture";
            this.lblDaysToManufacture.Size = new System.Drawing.Size(106, 13);
            this.lblDaysToManufacture.TabIndex = 4;
            this.lblDaysToManufacture.Text = "Dias de Manufactura";
            this.lblDaysToManufacture.Click += new System.EventHandler(this.lblDaysToManufacture_Click);
            // 
            // txtDaysToManufacture
            // 
            this.txtDaysToManufacture.Location = new System.Drawing.Point(149, 90);
            this.txtDaysToManufacture.Name = "txtDaysToManufacture";
            this.txtDaysToManufacture.Size = new System.Drawing.Size(100, 20);
            this.txtDaysToManufacture.TabIndex = 5;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(47, 160);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(195, 160);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(325, 160);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(295, 10);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(105, 23);
            this.btnCargarProducto.TabIndex = 9;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 262);
            this.Controls.Add(this.btnCargarProducto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtDaysToManufacture);
            this.Controls.Add(this.lblDaysToManufacture);
            this.Controls.Add(this.lblIDProduct);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.cmbId);
            this.Controls.Add(this.lblProductName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cmbId;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label lblIDProduct;
        private System.Windows.Forms.Label lblDaysToManufacture;
        private System.Windows.Forms.TextBox txtDaysToManufacture;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCargarProducto;
    }
}

