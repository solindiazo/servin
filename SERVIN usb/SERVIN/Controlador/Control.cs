using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using SERVIN.Vista;

namespace SERVIN.Controlador
{
    class Control
    {
        Conexion BD = new Conexion();
        Form_Ingreso fi = new Form_Ingreso();
        Form_Administrador fa = new Form_Administrador();
        Form_Usuario FormOperativo = new Form_Usuario();
        Form_Gestion_Cliente fc = new Form_Gestion_Cliente();
        Form_Gestion_Proveedor fp = new Form_Gestion_Proveedor();
        Form_Gestion_Persona FormPersona = new Form_Gestion_Persona();
        Form_Gestion_Empleado fe = new Form_Gestion_Empleado();
        Form_Gestion_Usuario fus = new Form_Gestion_Usuario();
        //Form_Gestion_Material fm = new Form_Gestion_Material();
        DataTable u = new DataTable();

        public void iniciar()
        {
            inicializarEventos(); //Donde se asignaran los eventos
            iniciarFormularioIngreso();
            Application.Run(fi);

        }



        private void iniciarFormularioIngreso()
        {
            u.Clear();
            u = BD.ejecutarBusqueda("SELECT Login_Usuario FROM LOGIN;");

            for (int i = 0; i < u.Rows.Count; i++)
            {
                fi.cbxUsuario.Items.Add(u.Rows[i][0].ToString());
            }

            fi.Show();
        }


        public void Ingresar(object sender, EventArgs e)
        {

            String Usuario, Clave;
            try
            {
                Usuario = fi.cbxUsuario.SelectedItem.ToString();
                Clave = fi.txtClave.Text.ToString();
            }
            catch
            {
                Usuario = "Hola";
                Clave = "123";
            }
            String sql = "SELECT Login_Rol FROM LOGIN WHERE Login_Usuario = '" + Usuario + "' AND Login_Pass = '" + Clave + "';";
            DataTable dt = BD.ejecutarBusqueda(sql);


            if (dt.Rows.Count == 1)
            {
                fi.Hide();
                fi.txtClave.Clear();

                if (dt.Rows[0][0].ToString() == "Administrador")
                {
                    BD.establecerInicioDeSesion("Administrador", fi.cbxUsuario.SelectedItem.ToString());
                    
                    iniciarFormularioAdministrador();
                }

                else if (dt.Rows[0][0].ToString() == "Operativo")
                {
                    BD.establecerInicioDeSesion("Operativo", fi.cbxUsuario.SelectedItem.ToString());
                    
                    iniciarFormularioUsuario();
                    
                }
                
            }
            else
            {
                MessageBox.Show("Datos erroneos");
            }



        }

        private void iniciarFormularioUsuario()
        {
            FormOperativo.Show();
        }

        private void iniciarFormularioAdministrador()
        {
            fa.Show();
        }

        private void login(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void iniciarFormularioClientes(object sender, EventArgs e)
        {
            fa.Hide();
            FormOperativo.Hide();
            fc.Show();
        }

        private void iniciarFormularioPersona(object sender, EventArgs e)
        {
            fa.Hide();
            FormOperativo.Hide();
            FormPersona.Show();
        }

        private void iniciarFormularioProveedor(object sender, EventArgs e)
        {
            fp.Show();
        }

        private void inicialFormularioMateriales(object sender, EventArgs e)
        {
            //fm.Show();
            MessageBox.Show("Formulario Materiales");
        }

        private void inicialFormularioEmpleados(object sender, EventArgs e)
        {
            fe.Show();
        }

        private void iniciarFormularioUsuarios(object sender, EventArgs e)
        {
            fus.Show();
        }

        private void iniciarFormularioFunciones(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario Funciones");
        }

        private void iniciarFormularioRecursos(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario Recursos");
        }

        private void iniciarFormularioProyectos(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario Proyectos");
        }

        private void iniciarFormularioCotizar(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario Cotizar");
        }

        private void inicializarEventos()
        {
            //Evento Formulario Login
            fi.btnIngresar.Click += new EventHandler(this.Ingresar);
            //Eventos Formulario de Administrador
            fa.btnGestionClientes.Click += new EventHandler(this.iniciarFormularioPersona);
            fa.btnCotizar.Click += new EventHandler(this.iniciarFormularioCotizar);
            fa.btnGestionProveedor.Click += new EventHandler(this.iniciarFormularioProveedor);
            fa.btnGestionMateriales.Click += new EventHandler(this.inicialFormularioMateriales);
            fa.btnGestionEmpleados.Click += new EventHandler(this.inicialFormularioEmpleados);
            fa.btnGestionUsuarios.Click += new EventHandler(this.iniciarFormularioUsuarios);
            fa.btnGestionProyectos.Click += new EventHandler(this.iniciarFormularioProyectos);
            fa.btnGestionRecursos.Click += new EventHandler(this.iniciarFormularioRecursos);
            fa.btnGestionFunciones.Click += new EventHandler(this.iniciarFormularioFunciones);
            fa.btnregresar.Click += new EventHandler(this.login);
            //Eventos Formulario Operativo
            FormOperativo.btnGestionClientes.Click += new EventHandler(this.iniciarFormularioPersona);
            FormOperativo.btnCotizar.Click += new EventHandler(this.iniciarFormularioCotizar);
            FormOperativo.btnGestionEmpleados.Click += new EventHandler(this.inicialFormularioEmpleados);
            FormOperativo.btnregresar.Click += new EventHandler(this.login);
            //Eventos Formulario de Clientes

            FormPersona.Load += new EventHandler(this.CargarGestionPersona);



            FormPersona.btnRegresar.Click += new EventHandler(this.closeGestPersona);
            FormPersona.btnAceptar.Click += new EventHandler(this.aceptarGestPersona);
            FormPersona.txtDocumento.TextChanged += new EventHandler(this.buscarPersona);
           // fc.txtidentificacion.TextChanged += new EventHandler(this.buscarIdentificacion);


        }

        private void aceptarGestPersona(object sender, EventArgs e)
        {
          



        }

        private void CargarGestionPersona(object sender, EventArgs e)
        {
            u.Clear();
            u = BD.ejecutarBusqueda("Select * from Persona");
            if(BD.Sesion() == "Administrador")
            {
                FormPersona.checkCliente.Enabled = true;
                FormPersona.checkFuncional.Enabled = true;
                FormPersona.checkProveedor.Enabled = true;
                FormPersona.cbxFuncion.Visible = true;
                FormPersona.lblFuncion.Visible = true;
                FormPersona.txtDescripcion.Visible = true;
                FormPersona.lblDescripcion.Visible = true;

            }
            else
            {
                FormPersona.checkCliente.Enabled = false;
                FormPersona.checkFuncional.Enabled = false;
                FormPersona.checkProveedor.Enabled = false;
                FormPersona.cbxFuncion.Visible = false;
                FormPersona.lblFuncion.Visible = false;
                FormPersona.txtDescripcion.Visible = false;
                FormPersona.lblDescripcion.Visible = false;
                FormPersona.txtApellidos.Enabled = false;
                FormPersona.lblApellidos.Enabled = false;
            }
        }

        private bool[] buscarIdentificacion(String Identificacion)  //Busca una identificación dada por parámetro y devuelve un boleano
        {

            bool[] Persona = new bool[3];

            Persona[0] = false; //Funcionario
            Persona[1] = false; //Cliente
            Persona[2] = false; //Proveedor
            
            for (int i = 0; i < u.Rows.Count; i++)
            {
                if (Identificacion == u.Rows[i][0].ToString())
                {
                    
                    if(BD.verificarExistencia("Select count(1) from Cliente where Clien_ID = '"+ Identificacion + "';"))
                    {
                        Persona[1] = true; //Cliente
                    }
                    if(BD.verificarExistencia("Select count(1) from Proveedor where Provee_ID = '" + Identificacion + "';"))
                    {
                        Persona[2] = true; //Proveedor
                    }
                    if (BD.verificarExistencia("Select count(1) from Empleado where Emple_ID = '" + Identificacion + "';"))
                    {
                        Persona[0] = true; //Funcionario
                    }
                }
            }
            
            return Persona;
        }

        private void buscarPersona(object sender, EventArgs e)
        {
            bool exist = false;
            if(FormPersona.txtDocumento.Text != "")
            {

                FormPersona.txtnombre.Enabled = true;
                FormPersona.txtApellidos.Enabled = true;
                FormPersona.txtTelefono.Enabled = true;
                FormPersona.txtDireccion.Enabled = true;
                FormPersona.lblTipoCliente.Enabled = true;
                FormPersona.txtDescripcion.Enabled = true;
                FormPersona.cbxFuncion.Enabled = true;

                FormPersona.lblnombre.Enabled = true;
                FormPersona.lblApellidos.Enabled = true;
                FormPersona.lblTelefono.Enabled = true;
                FormPersona.lblDireccion.Enabled = true;
                FormPersona.lblTipoDocumento.Enabled = true;
                FormPersona.lblDescripcion.Enabled = true;
                FormPersona.lblFuncion.Enabled = true;


                bool[] Persona = buscarIdentificacion(FormPersona.txtDocumento.Text);

                FormPersona.checkFuncional.Checked = false;
                FormPersona.checkCliente.Checked = false;
                FormPersona.checkProveedor.Checked = false;


                if (Persona[0]) //Funcionario
                {
                    FormPersona.checkFuncional.Checked = true;
                    FormPersona.lblFuncion.Enabled = true;
                    FormPersona.cbxFuncion.Enabled = true;
                    FormPersona.lblDescripcion.Enabled = false;
                    FormPersona.txtDescripcion.Enabled = false;
                    exist = true;
                }
                if (Persona[1]) //Cliente
                {
                    FormPersona.checkCliente.Checked = true;
                    FormPersona.lblFuncion.Enabled = false;
                    FormPersona.cbxFuncion.Enabled = false;
                    FormPersona.lblDescripcion.Enabled = false;
                    FormPersona.txtDescripcion.Enabled = false;
                    exist = true;
                }
                if (Persona[2]) //Proveedor
                {
                    FormPersona.checkProveedor.Checked = true;
                    FormPersona.lblFuncion.Enabled = false;
                    FormPersona.cbxFuncion.Enabled = false;
                    FormPersona.lblDescripcion.Enabled = true;
                    FormPersona.txtDescripcion.Enabled = true;
                    exist = true;
                }

                if (exist)
                {
                    DataTable d = BD.ejecutarBusqueda("Select * from Persona where Perso_ID = '"+ FormPersona.txtDocumento.Text + "';");
                    FormPersona.txtnombre.Text = d.Rows[0][1].ToString();
                    FormPersona.txtApellidos.Text = d.Rows[0][2].ToString();
                    FormPersona.txtTelefono.Text = d.Rows[0][3].ToString();
                    FormPersona.txtDireccion.Text = d.Rows[0][4].ToString();
                    FormPersona.btnAceptar.Text = "Modificar";

                    if (d.Rows[0][6].ToString() == "N")
                    {
                        FormPersona.lblTipoCliente.Text = "Natural";
                    }
                    else
                    {
                        FormPersona.lblTipoCliente.Text = "Jurídico";
                    }
                    if (Persona[2])
                    {
                        d = BD.ejecutarBusqueda("Select Provee_Descripcion From Proveedor where Provee_ID = '" + FormPersona.txtDocumento.Text + "';");
                        FormPersona.txtDescripcion.Text = d.Rows[0][0].ToString();
                    }
                }
                else
                {
                    FormPersona.txtnombre.Clear();
                    FormPersona.txtApellidos.Clear();
                    FormPersona.txtTelefono.Clear();
                    FormPersona.txtDireccion.Clear();
                    FormPersona.lblTipoCliente.Text = "";
                    FormPersona.txtDescripcion.Clear();
                    FormPersona.btnAceptar.Text = "Agregar";
                }




            }else
            {
                FormPersona.txtnombre.Enabled = false;
                FormPersona.txtApellidos.Enabled = false;
                FormPersona.txtTelefono.Enabled = false;
                FormPersona.txtDireccion.Enabled = false;
                FormPersona.lblTipoCliente.Enabled = false;
                FormPersona.txtDescripcion.Enabled = false;
                FormPersona.cbxFuncion.Enabled = false;

                FormPersona.lblnombre.Enabled = false;
                FormPersona.lblApellidos.Enabled = false;
                FormPersona.lblTelefono.Enabled = false;
                FormPersona.lblDireccion.Enabled = false;
                FormPersona.lblTipoDocumento.Enabled = false;
                FormPersona.lblDescripcion.Enabled = false;
                FormPersona.lblFuncion.Enabled = false;
            }


        }

        private void aceptarGestClientes(object sender, EventArgs e)
        {
            if (fc.rbagregar.Checked)
            {
                String ID, Nombre, Apellido, Direccion, Telefono;
                
                Telefono = fc.txtTelefono.Text;
                Direccion = fc.txtDireccion.Text;
                ID = fc.txtestado.Text;
                Nombre = fc.txtnombre.Text;
                Apellido = fc.txtApellidos.Text;
                BD.ejecutarConsulta("BEGIN TRANSACTION;");

                if (fc.cbxTipoPersona.SelectedItem.ToString().Equals("Natural"))
                {
                    if (!BD.ejecutarConsulta("insert into Persona Values ('" + ID + "','" + Nombre + "','" + Apellido + "','" + Telefono + "','" + Direccion + "','1','N');"))
                     {
                         MessageBox.Show("Ha ocurrido un error");
                         
                     }
                     else if (!BD.ejecutarConsulta("Insert into Cliente Values ('" + ID + "');"))
                     {

                        BD.ejecutarConsulta("ROLLBACK TRANSACTION;");
                        MessageBox.Show("Ha ocurrido un error");
                        
                     }
                     else
                     {

                        BD.ejecutarConsulta("COMMIT;");
                        MessageBox.Show("Se ha agregado exitosamente el Cliente");
                        
                     }
                }
                else
                {

                    if(!BD.ejecutarConsulta("insert into Persona (Perso_ID, Perso_Nombre, Perso_Telefono, Perso_Direccion, Perso_Estado, Perso_Tipo) Values ('" + ID + "','" + Nombre + "','" + Telefono + "','" + Direccion + "','1','J');"))
                    {  MessageBox.Show("Ha ocurrido un error");

                    }
                         else if (!BD.ejecutarConsulta("Insert into Cliente Values ('" + ID + "');"))
                    {

                        BD.ejecutarConsulta("ROLLBACK TRANSACTION;");
                        MessageBox.Show("Ha ocurrido un error");

                    }
                    else
                    {

                        BD.ejecutarConsulta("COMMIT;");
                        MessageBox.Show("Se ha agregado exitosamente el Cliente");

                    }
            }
                

            }
        }

        private void closeGestPersona(object sender, EventArgs e)
        {
            FormPersona.Hide();
            this.close();
        }

        private void close()
        {
            
            if (BD.Sesion().Equals("Administrador"))
            {
                iniciarFormularioAdministrador();
            }else
            {
                iniciarFormularioUsuario();
            }
        }

       
    }
}
