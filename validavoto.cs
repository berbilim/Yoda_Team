using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    class validavoto : sistemaVotacion
    {
        public string conteovotos()
        {

            //Declaracion de variables d contadores de votos para presidente y diputado
            double contP1 = 0;
            double contP2 = 0;
            double contD1 = 0;
            double contD2 = 0;
            
            // Validacion de los campos CheckBox en caso de ser seleccionado con valor booleano
            try
            {

                if (_Opcion1 == true)
                {

                    contP1 = contP1 + 1;
                }

                else
                {
                    if (_Opcion2 == true)
                    {

                        contP2 = contP2 + 1;
                    }

                }

                if (_Opcion3 == true)
                {

                    contD1 = contD2 + 1;
                }

                else
                {
                    if (_Opcion4 == true)
                    {

                        contD2 = contD2 + 1;
                    }

                }      

                                        
                        }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return "Se han almacenado los siguientes votos" + " " +
                     "Presidente #1 :" + " " + contP1 + "," +
                     "Presidente #2 :" + " " + contP2 + "," +
                     "Diputado  #1 :" + " " + contD1 + "," +
                     "Diputado  #2 :" + " " + contD2;


            
        }

        //Contructor de la clase validavoto que recibe los 4 paremtros de los checkbox
        public validavoto(Boolean opcion1, Boolean opcion2, Boolean opcion3, Boolean opcion4)
        {
            this._Opcion1 = opcion1;
            this._Opcion2 = opcion2;
            this._Opcion3 = opcion3;
            this._Opcion4 = opcion4;

        }

    }
}
