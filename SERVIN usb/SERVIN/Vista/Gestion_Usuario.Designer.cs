namespace SERVIN
{
    partial class Form_Gestion_Usuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltipousu = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.gbaccion = new System.Windows.Forms.GroupBox();
            this.rbeliminar = new System.Windows.Forms.RadioButton();
            this.rbeditar = new System.Windows.Forms.RadioButton();
            this.rbagregar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.gbaccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION USUARIO";
            // 
            // lbltipousu
            // 
            this.lbltipousu.AutoSize = true;
            this.lbltipousu.Location = new System.Drawing.Point(15, 377);
            this.lbltipousu.Name = "lbltipousu";
            this.lbltipousu.Size = new System.Drawing.Size(70, 13);
            this.lbltipousu.TabIndex = 7;
            this.lbltipousu.Text = "Tipo_Usuario";
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(582, 389);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 17;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Location = new System.Drawing.Point(12, 474);
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.RowHeadersVisible = false;
            this.dgvusuarios.Size = new System.Drawing.Size(702, 159);
            this.dgvusuarios.TabIndex = 16;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(582, 352);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(152, 328);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(253, 20);
            this.txtcontraseña.TabIndex = 11;
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(15, 335);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(61, 13);
            this.lblcontraseña.TabIndex = 6;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(15, 293);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(54, 13);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "Empleado";
            // 
            // gbaccion
            // 
            this.gbaccion.Controls.Add(this.rbeliminar);
            this.gbaccion.Controls.Add(this.rbeditar);
            this.gbaccion.Controls.Add(this.rbagregar);
            this.gbaccion.Location = new System.Drawing.Point(26, 59);
            this.gbaccion.Name = "gbaccion";
            this.gbaccion.Size = new System.Drawing.Size(495, 100);
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::SERVIN.Properties.Resources.logo_servin;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(527, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 194);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(150, 368);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(253, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // Form_Gestion_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 645);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbltipousu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.dgvusuarios);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.gbaccion);
            this.Controls.Add(this.label1);
            this.Name = "Form_Gestion_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.gbaccion.ResumeLayout(false);
            this.gbaccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltipousu;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.GroupBox gbaccion;
        private System.Windows.Forms.RadioButton rbeliminar;
        private System.Windows.Forms.RadioButton rbeditar;
        private System.Windows.Forms.RadioButton rbagregar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}