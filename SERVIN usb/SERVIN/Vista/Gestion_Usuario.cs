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
    public partial class Form_Gestion_Usuario : Form
    {
        
        Validar v = new Validar();
        public Form_Gestion_Usuario()
        {
            InitializeComponent();
          
            /*
            DataTable u = BD.ejecutarBusqueda("SELECT Emple_ID FROM EMPLEADO;");
            for (int i = 0; i < u.Rows.Count; i++)
            {
               this.comboBox1.Items.Add(u.Rows[i][0].ToString());
            }

            u = BD.ejecutarBusqueda("SELECT Rol_Nombre FROM ROL;");
            for (int i = 0; i < u.Rows.Count; i++)
            {
                this.comboBox2.Items.Add(u.Rows[i][0].ToString());
            }*/

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
            {/*
                String ID = v.StringNumerico(comboBox1.SelectedItem.ToString());
                String Pass = v.String(txtcontraseña.Text);
                String Rol = v.String(comboBox2.SelectedItem.ToString());
                
                if (rbagregar.Checked)
                {

                    String sql = "INSERT INTO LOGIN VALUES ('" + ID + "','" + Pass + "','" + Rol + "');";
                    BD.ejecutarConsulta(sql);

                }
                else if (rbeditar.Checked)
                {

                    
                    String sql = "UPDATE LOGIN SET Login_Pass ='" + Pass + "', Login_Rol ='" + Rol + "' WHERE Login_Usuario = '"+ID+"';";
                    BD.ejecutarConsulta(sql);
                    

                }
                else if (rbeliminar.Checked)
                {
                    String sql = "DELETE FROM LOGIN WHERE Login_Usuario = '" + ID + "';";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            String ID = v.StringNumerico(comboBox1.SelectedItem.ToString());
            DataTable dt = BD.ejecutarBusqueda("SELECT * FROM LOGIN WHERE Login_Usuario LIKE '" + ID + "%';");
            dgvusuarios.DataSource = dt;
            if (dt.Rows.Count == 1)
            {
                txtcontraseña.Text = dt.Rows[0][1].ToString();
                
            }

            */
        }
    }
    }

