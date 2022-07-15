using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    class sistemaVotacion
    {

        Boolean opcion1;
        Boolean opcion2;
        Boolean opcion3;
        Boolean opcion4;
        string usuario;
        string contrasena;

        //Encapsulacion de variables que provienen de los parametros ingresados

        public bool _Opcion1 { get => opcion1; set => opcion1 = value; }
        public bool _Opcion2 { get => opcion2; set => opcion2 = value; }
        public bool _Opcion3 { get => opcion3; set => opcion3 = value; }
        public bool _Opcion4 { get => opcion4; set => opcion4 = value; }
        public string _Usuario { get => usuario; set => usuario = value; }
        public string _Contrasena { get => contrasena; set => contrasena = value; }


          


    }







}
