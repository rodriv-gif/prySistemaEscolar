using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistemaEscolar
{
    internal class clsDocente
    {
        private int clave;
        private string nombreDocente;
        private string puesto;
        private string telefono;
        private string correo;
        private string nombreUsuario;
        private string password;
        private string perfil;
        private int idUsuario;

        private string msg;

        private MySqlCommand comando;
        private MySqlDataAdapter consulta;
        private DataTable tabla;

        public int Clave { get => clave; set => clave = value; }
        public string NombreDocente { get => nombreDocente; set => nombreDocente = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionDB = new clsConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    string sql = "SELECT D.claveDocente AS Clave, " +
                                 "D.nombreDocente AS Docente, " +
                                 "D.puesto AS Puesto, " +
                                 "D.telefono AS Telefono, " +
                                 "D.correo AS Correo, " +
                                 "D.idUsuario, " + 
                                 "U.vchnombreUsuario AS Usuario, " + 
                                 "U.vchpassword AS Password, " +    
                                 "U.vchperfil AS Perfil " +        
                                 "FROM tbldocentes D " +
                                 "INNER JOIN tblusuarios U ON D.idUsuario = U.intidUsuario; ";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la tabla " + ex.Message);
            }
            return tabla;
        }
       
        
    }
}

