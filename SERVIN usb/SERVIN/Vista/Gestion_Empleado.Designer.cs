namespace SERVIN
{
    partial class Form_Gestion_Empleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.lblidentificacion = new System.Windows.Forms.Label();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.gbaccion = new System.Windows.Forms.GroupBox();
            this.rbeliminar = new System.Windows.Forms.RadioButton();
            this.rbeditar = new System.Windows.Forms.RadioButton();
            this.rbagregar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCiudad = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.gbaccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(223, 415);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(253, 20);
            this.txtvalor.TabIndex = 12;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(74, 418);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(123, 13);
            this.lblvalor.TabIndex = 7;
            this.lblvalor.Text = "Valor  X Metro Cuadrado";
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(590, 396);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 17;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(223, 229);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(253, 20);
            this.txtidentificacion.TabIndex = 8;
            this.txtidentificacion.TextChanged += new System.EventHandler(this.txtidentificacion_TextChanged);
            // 
            // lblidentificacion
            // 
            this.lblidentificacion.AutoSize = true;
            this.lblidentificacion.Location = new System.Drawing.Point(74, 232);
            this.lblidentificacion.Name = "lblidentificacion";
            this.lblidentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblidentificacion.TabIndex = 3;
            this.lblidentificacion.Text = "Identificacion";
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Location = new System.Drawing.Point(20, 481);
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.RowHeadersVisible = false;
            this.dgvusuarios.Size = new System.Drawing.Size(702, 159);
            this.dgvusuarios.TabIndex = 16;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(590, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(223, 255);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(253, 20);
            this.txtnombre.TabIndex = 9;
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Location = new System.Drawing.Point(74, 396);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(35, 13);
            this.lblcargo.TabIndex = 6;
            this.lblcargo.Text = "Cargo";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(74, 258);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "Nombre";
            // 
            // gbaccion
            // 
            this.gbaccion.Controls.Add(this.rbeliminar);
            this.gbaccion.Controls.Add(this.rbeditar);
            this.gbaccion.Controls.Add(this.rbagregar);
            this.gbaccion.Location = new System.Drawing.Point(26, 66);
            this.gbaccion.Name = "gbaccion";
            this.gbaccion.Size = new System.Drawing.Size(503, 100);
            this.gbaccion.TabIndex = 2;
            this.gbaccion.TabStop = false;
            this.gbaccion.Text = "ACCION_A_REALIZAR";
            // 
            // rbeliminar
            // 
            this.rbeliminar.AutoSize = true;
            this.rbeliminar.Location = new System.Drawing.Point(355, 42);
            this.rbeliminar.Name = "rbeliminar";
            this.rbeliminar.Size = new System.Drawing.Size(76, 17);
            this.rbeliminar.TabIndex = 2;
            this.rbeliminar.TabStop = true;
            this.rbeliminar.Text = "ELIMINAR";
            this.rbeliminar.UseVisualStyleBackColor = true;
            // 
            // rbeditar
            // 
            this.rbeditar.AutoSize = true;
            this.rbeditar.Location = new System.Drawing.Point(197, 42);
            this.rbeditar.Name = "rbeditar";
            this.rbeditar.Size = new System.Drawing.Size(65, 17);
            this.rbeditar.TabIndex = 1;
            this.rbeditar.TabStop = true;
            this.rbeditar.Text = "EDITAR";
            this.rbeditar.UseVisualStyleBackColor = true;
            // 
            // rbagregar
            // 
            this.rbagregar.AutoSize = true;
            this.rbagregar.Location = new System.Drawing.Point(19, 40);
            this.rbagregar.Name = "rbagregar";
            this.rbagregar.Size = new System.Drawing.Size(78, 17);
            this.rbagregar.TabIndex = 0;
            this.rbagregar.TabStop = true;
            this.rbagregar.Text = "AGREGAR";
            this.rbagregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION EMPLEADO";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SERVIN.Properties.Resources.logo_servin;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(535, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 194);
            this.panel1.TabIndex = 0;
            // 
            // cbxCargo
            // 
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Location = new System.Drawing.Point(223, 388);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(253, 21);
            this.cbxCargo.TabIndex = 18;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(223, 360);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(253, 20);
            this.txtCorreo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Correo Electronico";
            // 
            // cbxCiudad
            // 
            this.cbxCiudad.FormattingEnabled = true;
            this.cbxCiudad.Location = new System.Drawing.Point(223, 281);
            this.cbxCiudad.Name = "cbxCiudad";
            this.cbxCiudad.Size = new System.Drawing.Size(253, 21);
            this.cbxCiudad.TabIndex = 29;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(223, 334);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(253, 20);
            this.txtTelefono.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(223, 308);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(253, 20);
            this.txtDireccion.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ciudad";
            // 
            // Form_Gestion_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 657);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxCiudad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCargo);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.txtidentificacion);
            this.Controls.Add(this.lblidentificacion);
            this.Controls.Add(this.dgvusuarios);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.gbaccion);
            this.Controls.Add(this.label1);
            this.Name = "Form_Gestion_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.gbaccion.ResumeLayout(false);
            this.gbaccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.Label lblidentificacion;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.GroupBox gbaccion;
        private System.Windows.Forms.RadioButton rbeliminar;
        private System.Windows.Forms.RadioButton rbeditar;
        private System.Windows.Forms.RadioButton rbagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCiudad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}