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
    public partial class Form_Usuario : Form
    {
        public Form_Usuario()
        {
            InitializeComponent();
           
        }

        private void btnconsultarcliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Consultar c = new Form_Consultar();
            c.Show();
        }

        private void btncotizar_Click(object sender, EventArgs e)
        {
            this.Hide();
       
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Ingreso c = new Form_Ingreso();
            c.Show();
        }

    }
}
