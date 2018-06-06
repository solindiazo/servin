namespace SERVIN.Vista
{
    partial class Form_Gestion_Persona
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBoxCategoria = new System.Windows.Forms.GroupBox();
            this.checkProveedor = new System.Windows.Forms.CheckBox();
            this.checkFuncional = new System.Windows.Forms.CheckBox();
            this.checkCliente = new System.Windows.Forms.CheckBox();
            this.cbxFuncion = new System.Windows.Forms.ComboBox();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(639, 334);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 23);
            this.btnRegresar.TabIndex = 67;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(639, 291);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 23);
            this.btnAceptar.TabIndex = 66;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBoxCategoria
            // 
            this.groupBoxCategoria.Controls.Add(this.checkProveedor);
            this.groupBoxCategoria.Controls.Add(this.checkFuncional);
            this.groupBoxCategoria.Controls.Add(this.checkCliente);
            this.groupBoxCategoria.Location = new System.Drawing.Point(615, 90);
            this.groupBoxCategoria.Name = "groupBoxCategoria";
            this.groupBoxCategoria.Size = new System.Drawing.Size(150, 164);
            this.groupBoxCategoria.TabIndex = 65;
            this.groupBoxCategoria.TabStop = false;
            this.groupBoxCategoria.Text = "Categoría";
            // 
            // checkProveedor
            // 
            this.checkProveedor.AutoSize = true;
            this.checkProveedor.Location = new System.Drawing.Point(24, 119);
            this.checkProveedor.Name = "checkProveedor";
            this.checkProveedor.Size = new System.Drawing.Size(75, 17);
            this.checkProveedor.TabIndex = 2;
            this.checkProveedor.Text = "Proveedor";
            this.checkProveedor.UseVisualStyleBackColor = true;
            // 
            // checkFuncional
            // 
            this.checkFuncional.AutoSize = true;
            this.checkFuncional.Location = new System.Drawing.Point(24, 75);
            this.checkFuncional.Name = "checkFuncional";
            this.checkFuncional.Size = new System.Drawing.Size(72, 17);
            this.checkFuncional.TabIndex = 1;
            this.checkFuncional.Text = "Funcional";
            this.checkFuncional.UseVisualStyleBackColor = true;
            // 
            // checkCliente
            // 
            this.checkCliente.AutoSize = true;
            this.checkCliente.Location = new System.Drawing.Point(24, 30);
            this.checkCliente.Name = "checkCliente";
            this.checkCliente.Size = new System.Drawing.Size(58, 17);
            this.checkCliente.TabIndex = 0;
            this.checkCliente.Text = "Cliente";
            this.checkCliente.UseVisualStyleBackColor = true;
            // 
            // cbxFuncion
            // 
            this.cbxFuncion.Enabled = false;
            this.cbxFuncion.FormattingEnabled = true;
            this.cbxFuncion.Location = new System.Drawing.Point(216, 353);
            this.cbxFuncion.Name = "cbxFuncion";
            this.cbxFuncion.Size = new System.Drawing.Size(253, 21);
            this.cbxFuncion.TabIndex = 64;
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Enabled = false;
            this.lblFuncion.Location = new System.Drawing.Point(71, 353);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(45, 13);
            this.lblFuncion.TabIndex = 63;
            this.lblFuncion.Text = "Función";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Enabled = false;
            this.lblTipoCliente.Location = new System.Drawing.Point(213, 153);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(10, 13);
            this.lblTipoCliente.TabIndex = 62;
            this.lblTipoCliente.Text = " ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Enabled = false;
            this.lblDescripcion.Location = new System.Drawing.Point(71, 319);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 60;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(216, 220);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(253, 20);
            this.txtApellidos.TabIndex = 59;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Enabled = false;
            this.lblApellidos.Location = new System.Drawing.Point(70, 220);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 58;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(216, 286);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(253, 20);
            this.txtTelefono.TabIndex = 57;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Enabled = false;
            this.lblTelefono.Location = new System.Drawing.Point(71, 285);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 56;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(216, 254);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(253, 20);
            this.txtDireccion.TabIndex = 55;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Enabled = false;
            this.lblDireccion.Location = new System.Drawing.Point(69, 253);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 54;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(216, 319);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(253, 20);
            this.txtDescripcion.TabIndex = 52;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(216, 187);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(253, 20);
            this.txtnombre.TabIndex = 53;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Enabled = false;
            this.lblnombre.Location = new System.Drawing.Point(71, 187);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 51;
            this.lblnombre.Text = "Nombre";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Enabled = false;
            this.lblTipoDocumento.Location = new System.Drawing.Point(65, 153);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDocumento.TabIndex = 49;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(244, 90);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(156, 20);
            this.txtDocumento.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Documento";
            // 
            // Form_Gestion_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 501);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBoxCategoria);
            this.Controls.Add(this.cbxFuncion);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label1);
            this.Name = "Form_Gestion_Persona";
            this.Text = "Form_Gestion_Persona";
            this.groupBoxCategoria.ResumeLayout(false);
            this.groupBoxCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.GroupBox groupBoxCategoria;
        public System.Windows.Forms.CheckBox checkProveedor;
        public System.Windows.Forms.CheckBox checkFuncional;
        public System.Windows.Forms.CheckBox checkCliente;
        public System.Windows.Forms.ComboBox cbxFuncion;
        public System.Windows.Forms.Label lblFuncion;
        public System.Windows.Forms.Label lblTipoCliente;
        public System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.TextBox txtApellidos;
        public System.Windows.Forms.Label lblApellidos;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.Label lblTelefono;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.Label lblDireccion;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.Label lblnombre;
        public System.Windows.Forms.Label lblTipoDocumento;
        public System.Windows.Forms.TextBox txtDocumento;
        public System.Windows.Forms.Label label1;
    }
}