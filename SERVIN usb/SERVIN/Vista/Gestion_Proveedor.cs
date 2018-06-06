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
    public partial class Form_Gestion_Proveedor : Form
    {
      
        Validar v = new Validar();
        public Form_Gestion_Proveedor()
        {
            
            InitializeComponent();
        /*

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



        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Administrador c = new Form_Administrador();
            c.Show();
        }

        private void Form_Gestion_Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                String Doc = v.StringNumerico(txtidentificacion.Text);
                String Nom = v.StringPuro(txtnombre.Text);
                String Telefono = v.StringNumerico(txtTelefono.Text);

                DataTable dt = BD.ejecutarBusqueda("SELECT Ciuda_ID FROM Ciudad WHERE Ciuda_Nombre = '" + v.String(cbxCiudad.SelectedItem.ToString()) + "';");

                int Ciudad = v.Entero(dt.Rows[0][0].ToString());
                String Descripcion = v.String(txtDescripcion.Text);
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

                    String sql = "INSERT INTO PROVEEDOR VALUES (" + Tipo + ",'" + Doc + "','" + Nom + "','" + Telefono + "', '" + Descripcion + "' , " + Direccion + ",'" + Ciudad + "','" + Email + "');";
                    BD.ejecutarConsulta(sql);

                }
                else if (rbeditar.Checked)
                {
                    String sql = "UPDATE PROVEEDOR SET Provee_Tipo = " + Tipo + ", Provee_Nombre'" + Nom + "',Provee_Telefono'" + Telefono + "',Provee_Descripcion'" + Descripcion + "' ,Provee_Direccion" + Direccion + ",Provee_Ciudad'" + Ciudad + "',Provee_Email'" + Email + "');";
                    BD.ejecutarConsulta(sql);

                }
                else if (rbeliminar.Checked)
                {
                    String sql = "DELETE FROM PROVEEDOR WHERE Provee_ID = '" + Doc + "';";
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

        private void xtidentificacion_TextChanged(object sender, EventArgs e)
        {/*
            String Doc = v.StringNumerico(txtidentificacion.Text);
            DataTable dt = BD.ejecutarBusqueda("SELECT * FROM PROVEEDOR WHERE Provee_ID LIKE '" + Doc + "%';");
            this.dgvusuarios.DataSource = dt;
            if (dt.Rows.Count == 1)
            {

                txtnombre.Text = dt.Rows[0][3].ToString();
                txtTelefono.Text = dt.Rows[0][4].ToString();
                txtDescripcion.Text = dt.Rows[0][5].ToString();
                txtDireccion.Text = dt.Rows[0][6].ToString();
                txtCorreo.Text = dt.Rows[0][7].ToString();

            }*/


        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

            try
            {/*

                String Doc = v.StringNumerico(txtidentificacion.Text);
                String Nom = v.StringPuro(txtnombre.Text);
                String Telefono = v.StringNumerico(txtTelefono.Text);

                DataTable dt = BD.ejecutarBusqueda("SELECT Ciuda_ID FROM Ciudad WHERE Ciuda_Nombre = '" + v.String(cbxCiudad.SelectedItem.ToString()) + "';");

                int Ciudad = v.Entero(dt.Rows[0][0].ToString());
                String Descripcion = v.String(txtDescripcion.Text);
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

                    String sql = "INSERT INTO PROVEEDOR VALUES (" + Tipo + ",'" + Doc + "','" + Nom + "','" + Telefono + "', '" + Descripcion + "' , " + Direccion + ",'" + Ciudad + "','" + Email + "');";
                    BD.ejecutarConsulta(sql);

                }
                else if (rbeditar.Checked)
                {
                    String sql = "UPDATE PROVEEDOR SET Provee_Tipo = " + Tipo + ", Provee_Nombre'" + Nom + "',Provee_Telefono'" + Telefono + "',Provee_Descripcion'" + Descripcion + "' ,Provee_Direccion" + Direccion + ",Provee_Ciudad'" + Ciudad + "',Provee_Email'" + Email + "');";
                    BD.ejecutarConsulta(sql);

                }
                else if (rbeliminar.Checked)
                {
                    String sql = "DELETE FROM PROVEEDOR WHERE Provee_ID = '" + Doc + "';";
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
    }
}

