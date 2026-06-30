using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistemaEscolar
{
    internal class clsAlumnos
    {
        //atributos
        private int matricula;
        private string nombreAlumno;
        private string apellidoPaterno;
        private string aoellidoMaterno;
        private string Direccion;
        private string telefono;
        private string Correo;
        private decimal promedioBachillerato;
        private int idTutor;
        private int idCarrera;
        private int idUsuario;
         
        //adaptador y  tabla virtuales de la clase
        private MySqlDataAdapter consulta;
        private DataTable tabla;

        //propiedades
        public int Matricula { get => matricula; set => matricula = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string AoellidoMaterno { get => aoellidoMaterno; set => aoellidoMaterno = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public decimal PromedioBachillerato { get => promedioBachillerato; set => promedioBachillerato = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
