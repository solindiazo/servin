namespace SERVIN
{
    partial class Form_Gestion_Proveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnregresar = new System.Windows.Forms.Button();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbaccion = new System.Windows.Forms.GroupBox();
            this.rbeliminar = new System.Windows.Forms.RadioButton();
            this.rbeditar = new System.Windows.Forms.RadioButton();
            this.rbagregar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCiudad = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoPersona = new System.Windows.Forms.ComboBox();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.lblidentificacion = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbltipopersona = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.gbaccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(582, 402);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 13;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Location = new System.Drawing.Point(12, 487);
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.RowHeadersVisible = false;
            this.dgvusuarios.Size = new System.Drawing.Size(702, 159);
            this.dgvusuarios.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(582, 365);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // gbaccion
            // 
            this.gbaccion.Controls.Add(this.rbeliminar);
            this.gbaccion.Controls.Add(this.rbeditar);
            this.gbaccion.Controls.Add(this.rbagregar);
            this.gbaccion.Location = new System.Drawing.Point(18, 72);
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
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION PROVEEDOR";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SERVIN.Properties.Resources.logo_servin;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(527, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 194);
            this.panel1.TabIndex = 0;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(183, 403);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(253, 20);
            this.txtCorreo.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Correo Electronico";
            // 
            // cbxCiudad
            // 
            this.cbxCiudad.FormattingEnabled = true;
            this.cbxCiudad.Location = new System.Drawing.Point(183, 324);
            this.cbxCiudad.Name = "cbxCiudad";
            this.cbxCiudad.Size = new System.Drawing.Size(253, 21);
            this.cbxCiudad.TabIndex = 35;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(183, 377);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(253, 20);
            this.txtTelefono.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(183, 351);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(253, 20);
            this.txtDireccion.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ciudad";
            // 
            // cbxTipoPersona
            // 
            this.cbxTipoPersona.FormattingEnabled = true;
            this.cbxTipoPersona.Location = new System.Drawing.Point(183, 245);
            this.cbxTipoPersona.Name = "cbxTipoPersona";
            this.cbxTipoPersona.Size = new System.Drawing.Size(253, 21);
            this.cbxTipoPersona.TabIndex = 29;
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(183, 272);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(253, 20);
            this.txtidentificacion.TabIndex = 27;
            // 
            // lblidentificacion
            // 
            this.lblidentificacion.AutoSize = true;
            this.lblidentificacion.Location = new System.Drawing.Point(34, 279);
            this.lblidentificacion.Name = "lblidentificacion";
            this.lblidentificacion.Size = new System.Drawing.Size(90, 13);
            this.lblidentificacion.TabIndex = 24;
            this.lblidentificacion.Text = "No. Identificacion";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(183, 298);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(253, 20);
            this.txtnombre.TabIndex = 28;
            // 
            // lbltipopersona
            // 
            this.lbltipopersona.AutoSize = true;
            this.lbltipopersona.Location = new System.Drawing.Point(34, 253);
            this.lbltipopersona.Name = "lbltipopersona";
            this.lbltipopersona.Size = new System.Drawing.Size(70, 13);
            this.lbltipopersona.TabIndex = 26;
            this.lbltipopersona.Text = "Tipo Persona";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(34, 305);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 25;
            this.lblnombre.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(183, 429);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(253, 20);
            this.txtDescripcion.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Descripcion";
            // 
            // Form_Gestion_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 676);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxCiudad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTipoPersona);
            this.Controls.Add(this.txtidentificacion);
            this.Controls.Add(this.lblidentificacion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbltipopersona);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.dgvusuarios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbaccion);
            this.Controls.Add(this.label1);
            this.Name = "Form_Gestion_Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.gbaccion.ResumeLayout(false);
            this.gbaccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbaccion;
        private System.Windows.Forms.RadioButton rbeliminar;
        private System.Windows.Forms.RadioButton rbeditar;
        private System.Windows.Forms.RadioButton rbagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCiudad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoPersona;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.Label lblidentificacion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lbltipopersona;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
    }
}