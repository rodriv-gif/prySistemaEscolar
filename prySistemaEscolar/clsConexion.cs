using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySqlConnector;

namespace prySistemaEscolar
{
    internal class clsConexion
    {
        //Conexion con la BD
        private string host = "189.240.192.140";
        private string bd = "bdescuelagbequipo5";
        private string usuario = "gbEquipo5";
        private string password = "grupo5";
        private string puerto = "3306";

        private string cadenaConexion => $"server = {host};database ={bd};user = {usuario};password = {password};port = {puerto};";

        //Abre la conexion con la BD
        public MySqlConnection AbrirConexion()
        {
            var conexion = new MySqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectarse a la base de datos" + ex.Message, ex);
            }
        }
        //Cierra la conexion con la BD
        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexion con la bse de datos: " + ex.Message, ex);
            }

        }
 
    }
}
