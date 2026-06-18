using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySqlConnector;

namespace prySistemaEscolar
{
    internal class clscarreras
    {
        //Usar un adaptador
        private MySqlDataAdapter consulta;
        //Usamos una tabla temporal
        private DataTable tabla;

        //metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            clsConexion conexionBD = new clsConexion();
            var conexion = conexionBD.AbrirConexion();
            string sql = "SELECT idCarrera AS Clave, nombreCarrera AS Carrera, descripcion AS Descripción FROM tblcarreras;";
            consulta = new MySqlDataAdapter(sql, conexion);
            consulta.Fill(tabla);
            return tabla;
        }
    }
}
