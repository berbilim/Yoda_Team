using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    class Validaingreso : sistemaVotacion
    {

       
        public void Ingreso(sistemaVotacion objUsuario)
        {
            //Declaracion de variables estaticos
            string usuario_validacion = "user"; 
            string pwd_validacion = "user"; 


            //estos vienen de los campos de texto 
            string IdUser = objUsuario._Usuario;
            string pwdUser = objUsuario._Contrasena;


            //Control de y manejo de excepciones 

            // Validacion del usuario votante
            try
            {
               
                if (IdUser.Equals(usuario_validacion))
                {
                  
                    if (pwdUser.Equals(pwd_validacion))
                    {
                        Form formulariomenuvotante = new frmMenuvotante();
                        formulariomenuvotante.ShowDialog();  
                                            }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta");
                    }

                }
                else
                {
                    MessageBox.Show("No se reconoce usuario");
                }             


            }
            
            catch(Exception ex)
            {
                MessageBox.Show("Error +" + ex.Message,"Validación", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        //Contructor de la clase Ingreso que recibe los paremetros digitados como password y contraseña
        public Validaingreso(string usuario, string contrasena)
        {
            sistemaVotacion objUsuario = new sistemaVotacion();

            objUsuario._Usuario = usuario;
            objUsuario._Contrasena = contrasena;

            Ingreso(objUsuario);
        }


    }
}
