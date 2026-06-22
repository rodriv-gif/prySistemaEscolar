using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySqlConnector;

namespace prySistemaEscolar
{
    internal class clscarreras
    {
        private string nombreCarrera;
        //Usar un adaptador
        private MySqlDataAdapter consulta;
        //Usamos una tabla temporal
        private DataTable tabla;
        //propiedad para el atributo nombre carrera
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }

        //metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idCarrera AS Clave, nombreCarrera AS Carrera, descripcion AS Descripción FROM tblcarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion)) 
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta

                }//liberar la conexion
            }
            catch (Exception ex)
            {

                throw new Exception("error en la conexion " + ex.Message);
            }
            return tabla;
        }

        //Metodo para consultar por coincidencias
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idcarrera AS Clave,nombreCarrera AS Carrera,descripcion AS Descripcion\r\nFROM tblCarreras WHERE nombreCarrera LIKE @carrera; ";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@carrera", "%" + nombreCarrera + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//Liberara el adaptador
                    }//Liberar la consulta
                }//Libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos" + ex.Message);
            }
            return tabla;
        }
    }
}
