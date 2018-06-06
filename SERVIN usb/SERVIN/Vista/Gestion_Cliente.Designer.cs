namespace SERVIN
{
    partial class Form_Gestion_Cliente
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
            this.btnregresar = new System.Windows.Forms.Button();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.lblidentificacion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbltipopersona = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.gbaccion = new System.Windows.Forms.GroupBox();
            this.rbeditar = new System.Windows.Forms.RadioButton();
            this.rbagregar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTipoPersona = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.gbaccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(564, 349);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 13;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = true;
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(173, 420);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(253, 20);
            this.txtestado.TabIndex = 6;
            this.txtestado.TextChanged += new System.EventHandler(this.txtidentificacion_TextChanged);
            // 
            // lblidentificacion
            // 
            this.lblidentificacion.AutoSize = true;
            this.lblidentificacion.Location = new System.Drawing.Point(28, 248);
            this.lblidentificacion.Name = "lblidentificacion";
            this.lblidentificacion.Size = new System.Drawing.Size(90, 13);
            this.lblidentificacion.TabIndex = 3;
            this.lblidentificacion.Text = "No. Identificacion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(564, 305);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(173, 282);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(253, 20);
            this.txtnombre.TabIndex = 7;
            // 
            // lbltipopersona
            // 
            this.lbltipopersona.AutoSize = true;
            this.lbltipopersona.Location = new System.Drawing.Point(24, 213);
            this.lbltipopersona.Name = "lbltipopersona";
            this.lbltipopersona.Size = new System.Drawing.Size(70, 13);
            this.lbltipopersona.TabIndex = 5;
            this.lbltipopersona.Text = "Tipo Persona";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(28, 282);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "Nombre";
            // 
            // gbaccion
            // 
            this.gbaccion.Controls.Add(this.rbeditar);
            this.gbaccion.Controls.Add(this.rbagregar);
            this.gbaccion.Location = new System.Drawing.Point(19, 83);
            this.gbaccion.Name = "gbaccion";
            this.gbaccion.Size = new System.Drawing.Size(317, 100);
            this.gbaccion.TabIndex = 2;
            this.gbaccion.TabStop = false;
            this.gbaccion.Text = "ACCION_A_REALIZAR";
            // 
            // rbeditar
            // 
            this.rbeditar.AutoSize = true;
            this.rbeditar.Location = new System.Drawing.Point(202, 42);
            this.rbeditar.Name = "rbeditar";
            this.rbeditar.Size = new System.Drawing.Size(65, 17);
            this.rbeditar.TabIndex = 1;
            this.rbeditar.Text = "EDITAR";
            this.rbeditar.UseVisualStyleBackColor = true;
            // 
            // rbagregar
            // 
            this.rbagregar.AutoSize = true;
            this.rbagregar.Location = new System.Drawing.Point(40, 42);
            this.rbagregar.Name = "rbagregar";
            this.rbagregar.Size = new System.Drawing.Size(78, 17);
            this.rbagregar.TabIndex = 0;
            this.rbagregar.Text = "AGREGAR";
            this.rbagregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION CLIENTE";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SERVIN.Properties.Resources.logo_servin;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(530, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 194);
            this.panel1.TabIndex = 0;
            // 
            // cbxTipoPersona
            // 
            this.cbxTipoPersona.FormattingEnabled = true;
            this.cbxTipoPersona.Items.AddRange(new object[] {
            "Natural",
            "Jurídico"});
            this.cbxTipoPersona.Location = new System.Drawing.Point(173, 213);
            this.cbxTipoPersona.Name = "cbxTipoPersona";
            this.cbxTipoPersona.Size = new System.Drawing.Size(253, 21);
            this.cbxTipoPersona.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(173, 349);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(253, 20);
            this.txtDireccion.TabIndex = 18;
            this.txtDireccion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(173, 381);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(253, 20);
            this.txtTelefono.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Direccion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(173, 315);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(253, 20);
            this.txtApellidos.TabIndex = 25;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(28, 420);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado";
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(173, 248);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(253, 20);
            this.txtidentificacion.TabIndex = 27;
            // 
            // Form_Gestion_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 478);
            this.Controls.Add(this.txtidentificacion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTipoPersona);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblidentificacion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbltipopersona);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.gbaccion);
            this.Controls.Add(this.label1);
            this.Name = "Form_Gestion_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbaccion.ResumeLayout(false);
            this.gbaccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnregresar;
        public System.Windows.Forms.TextBox txtestado;
        public System.Windows.Forms.Label lblidentificacion;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.Label lbltipopersona;
        public System.Windows.Forms.Label lblnombre;
        public System.Windows.Forms.GroupBox gbaccion;
        public System.Windows.Forms.RadioButton rbeditar;
        public System.Windows.Forms.RadioButton rbagregar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxTipoPersona;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtApellidos;
        public System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.TextBox txtidentificacion;
    }
}