using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVIN
{
    public partial class Form_Consultar : Form
    {
      
        public Form_Consultar()
        {
            InitializeComponent();
            
        }

        private void Form_Consultar_Load(object sender, EventArgs e)
        {
          /*  String Usuario = this.txtidentificacion.Text.ToString();
            DataTable dt = BD.ejecutarBusqueda("Select p.* from Producto_cotizado p where p.ProdC_Documento like '" + Usuario + "%';");

            this.dgvusuarios.DataSource = dt;*/


        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Usuario c = new Form_Usuario();
            c.Show();
        }

        private void dgvusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtidentificacion_TextChanged(object sender, EventArgs e)
        {
           /* String Usuario = this.txtidentificacion.Text.ToString();
            DataTable dt = BD.ejecutarBusqueda("Select p.* from Producto_cotizado p where p.ProdC_Documento like '" + Usuario + "%';");

            this.dgvusuarios.DataSource = dt;*/
        }
    }
}
