namespace SERVIN
{
    partial class Form_Usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGestionClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCotizar = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGestionEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRepClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10XProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(157, 316);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 9;
            this.btnregresar.Text = "REGRESAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(93, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "OPERATIVO";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SERVIN.Properties.Resources.logo_servin;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(90, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 194);
            this.panel1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGestionClientes,
            this.btnCotizar});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // btnGestionClientes
            // 
            this.btnGestionClientes.Name = "btnGestionClientes";
            this.btnGestionClientes.Size = new System.Drawing.Size(159, 22);
            this.btnGestionClientes.Text = "Gestión Clientes";
            // 
            // btnCotizar
            // 
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(159, 22);
            this.btnCotizar.Text = "Cotizar";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGestionEmpleados});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.empleadosToolStripMenuItem.Text = "Perfil";
            // 
            // btnGestionEmpleados
            // 
            this.btnGestionEmpleados.Name = "btnGestionEmpleados";
            this.btnGestionEmpleados.Size = new System.Drawing.Size(182, 22);
            this.btnGestionEmpleados.Text = "Cambiar Contraseña";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRepClientes,
            this.proyectosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // btnRepClientes
            // 
            this.btnRepClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históricoDeClientesToolStripMenuItem,
            this.históricoToolStripMenuItem,
            this.top10XProyectoToolStripMenuItem});
            this.btnRepClientes.Name = "btnRepClientes";
            this.btnRepClientes.Size = new System.Drawing.Size(152, 22);
            this.btnRepClientes.Text = "Clientes";
            // 
            // históricoDeClientesToolStripMenuItem
            // 
            this.históricoDeClientesToolStripMenuItem.Name = "históricoDeClientesToolStripMenuItem";
            this.históricoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.históricoDeClientesToolStripMenuItem.Text = "Listado";
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.históricoToolStripMenuItem.Text = "Histórico";
            // 
            // top10XProyectoToolStripMenuItem
            // 
            this.top10XProyectoToolStripMenuItem.Name = "top10XProyectoToolStripMenuItem";
            this.top10XProyectoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.top10XProyectoToolStripMenuItem.Text = "Top 10 x proyecto";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // Form_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 361);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem btnGestionClientes;
        public System.Windows.Forms.ToolStripMenuItem btnCotizar;
        public System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem btnRepClientes;
        public System.Windows.Forms.ToolStripMenuItem históricoDeClientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem top10XProyectoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem btnGestionEmpleados;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
    }
}