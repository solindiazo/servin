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
    public partial class Form_Gestion_Empleado : Form
    {
      
        Validar v = new Validar();
        public Form_Gestion_Empleado()
        {
            InitializeComponent();
          
            /*
            DataTable dt = BD.ejecutarBusqueda("SELECT Funcion_Nombre FROM Funcion");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxCargo.Items.Add(dt.Rows[i][0].ToString());
            }
           */


        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Administrador c = new Form_Administrador();
            c.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                /*
                String Doc = v.StringNumerico(txtidentificacion.Text);
                String Nom = v.StringPuro(txtnombre.Text);
                String Telefono = v.StringNumerico(txtTelefono.Text);

                DataTable dt = BD.ejecutarBusqueda("SELECT Ciuda_ID FROM Ciudad WHERE Ciuda_Nombre = '" + v.String(this.cbxCiudad.SelectedItem.ToString()) + "';");

                int Ciudad = v.Entero(dt.Rows[0][0].ToString());

                String Direccion = v.String(txtDireccion.Text);
                String Email = v.String(txtCorreo.Text);

                String Cargo = v.String(cbxCargo.SelectedItem.ToString());
                String CostoMetro = "" + v.Double(txtvalor.Text);
                if (rbagregar.Checked)
                {

                    String sql = "INSERT INTO PERSONA VALUES ('" + Doc + "','" + Nom + "','" + Telefono + "'," + Ciudad + ",'" + Direccion + "','" + Email + "');";
                    BD.ejecutarConsulta(sql);
                    sql = "INSERT INTO EMPLEADO VALUES ('" + Doc + "','" + Cargo + "', "+ CostoMetro+ ");";
                    BD.ejecutarConsulta(sql);

                }
                else if (rbeditar.Checked)
                {
                    String sql = "UPDATE PERSONA SET Perso_Nombre ='" + Nom + "', Perso_Telefono ='" + Telefono + "', Perso_Ciudad =" + Ciudad + ",Perso_Direccion ='" + Direccion + "',Perso_Email ='" + Email + "' WHERE Perso_ID = '" + Doc + "';";
                    BD.ejecutarConsulta(sql);

                    sql = "UPDATE Empleado SET Emple_Cargo = " + Cargo + ", Emple_CostoMetro = "+ CostoMetro +" WHERE Emple_ID = '" + Doc + "';";


                }
                else if (rbeliminar.Checked)
                {
                    String sql = "DELETE FROM Empleado WHERE Emple_ID = '" + Doc + "';";
                    BD.ejecutarConsulta(sql);
                    sql = "DELETE FROM PERSONA WHERE Perso_ID = '" + Doc + "';";
                    BD.ejecutarConsulta(sql);
                }

                
                    Form_Administrador c = new Form_Administrador(BD);
                    c.Show();
                    this.Close();
                */
            }
            catch
            {
                if (!rbeliminar.Checked)
                {
                    MessageBox.Show("Ingrese todos los datos");
                }

            }


        }

        private void txtidentificacion_TextChanged(object sender, EventArgs e)
        {
            /*
            String Doc = v.StringNumerico(txtidentificacion.Text);
            DataTable dt = BD.ejecutarBusqueda("SELECT p.* FROM PERSONA p JOIN EMPLEADO e ON e.Emple_ID = p.Perso_ID WHERE Perso_ID LIKE '" + Doc + "%';");
            dgvusuarios.DataSource = dt;
            if (dt.Rows.Count == 1)
            {

                txtnombre.Text = dt.Rows[0][1].ToString();
                txtTelefono.Text = dt.Rows[0][2].ToString();
                txtDireccion.Text = dt.Rows[0][4].ToString();
                txtCorreo.Text = dt.Rows[0][5].ToString();

            }*/
        }
    }



}
