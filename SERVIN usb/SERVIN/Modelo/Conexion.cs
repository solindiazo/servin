       using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace SERVIN
{
    public partial class Conexion
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-L0GLE2A;Initial Catalog=SERVIN_MADRIGAL;Integrated Security=True");
        private DataSet ds = new DataSet();
        private DataTable dt;
        private String Usuario;
        private String Rol;

        public Conexion()
        {
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("ERROR DE CONEXION A LA BASE DE DATOS");
            }
           
        }
       
        public void establecerInicioDeSesion(String rol, String User)
        {
            Usuario = User;
            Rol = rol;
        }

        public String Sesion()
        {
            return Rol;
        }
        public DataTable ejecutarBusqueda(String sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }catch
            {
               
            }
            return null;
        }

        public bool verificarExistencia(String sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "" + '0')
                {
                    return false;
                } else
                {
                    return true;
                }
                
            }
            catch
            {
                return false;
            }
            
        }

        public bool ejecutarConsulta(String sql)
        {
            try
            {
               // MessageBox.Show(sql);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
              //  MessageBox.Show("Exitoso.");
                return true;
            }
            catch(Exception)
            {
                
            }
            return false;
        }

    }
}
