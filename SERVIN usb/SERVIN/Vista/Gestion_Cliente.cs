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
    public partial class Form_Gestion_Cliente : Form
    {
      
        Validar v = new Validar();
        public Form_Gestion_Cliente()
        {
            InitializeComponent();
           /*

            if (BD.Sesion().Equals("Usuario"))
            {
                rbeliminar.Enabled = false;
            }

            DataTable dt = BD.ejecutarBusqueda("SELECT Ciuda_Nombre FROM Ciudad");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxCiudad.Items.Add(dt.Rows[i][0].ToString());
            }
            dt = BD.ejecutarBusqueda("SELECT TipoP_TipoPersona FROM Tipo_Persona");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbxTipoPersona.Items.Add(dt.Rows[i][0].ToString());
            }*/
            
        }



      

        public void traerDatos(String Nombre, String Cedula)
        {
            txtnombre.Text = Nombre;
            txtestado.Text = Cedula;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
/*
                String Doc = v.String(txtidentificacion.Text);
                String Nom = v.String(txtnombre.Text);
                String Telefono = v.StringNumerico(txtTelefono.Text);

                DataTable dt = BD.ejecutarBusqueda("SELECT Ciuda_ID FROM Ciudad WHERE Ciuda_Nombre = '" + v.String(cbxCiudad.SelectedItem.ToString()) + "';");

                int Ciudad = v.Entero(dt.Rows[0][0].ToString());

                String Direccion = v.String(txtDireccion.Text);
                String Email = v.String(txtCorreo.Text);


                int Tipo;
                if (cbxTipoPersona.SelectedItem.ToString().Equals("Natural"))
                {
                    Tipo = 1;
                }
                else
                {
                    Tipo = 2;
                }

                if (rbagregar.Checked)
                {

                    String sql = "INSERT INTO PERSONA VALUES ('" + Doc + "','" + Nom + "','" + Telefono + "'," + Ciudad + ",'" + Direccion + "','" + Email + "');";
                    BD.ejecutarConsulta(sql);
                    sql = "INSERT INTO CLIENTE VALUES ('" + Doc + "'," + Tipo + ");";
                    BD.ejecutarConsulta(sql);

                }
                else if (rbeditar.Checked)
                {
                    String sql = "UPDATE PERSONA SET Perso_Nombre ='" + Nom + "', Perso_Telefono ='" + Telefono + "', Perso_Ciudad =" + Ciudad + ",Perso_Direccion ='" + Direccion + "',Perso_Email ='" + Email + "' WHERE Perso_ID = '" + Doc + "';";
                    BD.ejecutarConsulta(sql);

                    sql = "UPDATE CLIENTE SET Clien_TipoPersona = " + Tipo + " WHERE Clien_ID = '" + Doc + "';";


                }
                else if (rbeliminar.Checked)
                {
                    String sql = "DELETE FROM CLIENTE WHERE Clien_ID = '" + Doc + "';";
                    BD.ejecutarConsulta(sql);
                    sql = "DELETE FROM PERSONA WHERE Perso_ID = '" + Doc + "';";
                    BD.ejecutarConsulta(sql);
                }

                if (BD.Sesion().Equals("Usuario"))
                {
                    Form_Usuario c = new Form_Usuario(BD);
                    c.Show();
                    this.Close();
                }
                else
                {
                    Form_Administrador c = new Form_Administrador(BD);
                    c.Show();
                    this.Close();
                }*/
            }
            catch
            {
                
            }

        }

        private void llenarDatos(String Doc)
        {

         /*   DataTable dt = BD.ejecutarBusqueda("SELECT p.* FROM PERSONA p JOIN CLIENTE c ON c.Clien_ID = p.Perso_ID WHERE Perso_ID LIKE '" + Doc + "%';");
            dgvusuarios.DataSource = dt;
            if (dt.Rows.Count == 1)
            {
                
                txtnombre.Text = dt.Rows[0][1].ToString();
                txtTelefono.Text = dt.Rows[0][2].ToString();
                txtDireccion.Text = dt.Rows[0][4].ToString();
                txtCorreo.Text = dt.Rows[0][5].ToString();
                
            }
            
    */

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidentificacion_TextChanged(object sender, EventArgs e)
        {

            llenarDatos(txtestado.Text);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
