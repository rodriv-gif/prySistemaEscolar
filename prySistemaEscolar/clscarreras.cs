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
        private string descripcion;
        private int idCarrera; //este atributo es para referencia en update y delete
        //Usar un adaptador
        private MySqlDataAdapter consulta;
        //usamos comandpara insertar o actualizar
        private MySqlCommand comando;
        //Usamos una tabla temporal
        private DataTable tabla;
        //propiedad para el atributo nombre carrera
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }

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
                    string sql = "SELECT idCarrera AS Clave,nombreCarrera AS Carrera,descripcion AS Descripcion\r\nFROM tblCarreras WHERE nombreCarrera LIKE @carrera; ";
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

        //Metodo para actualizar
        public string GuardarActualizar(int tipoOperacion)
        {
            string msj= "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    switch (tipoOperacion)
                    {
                        case 0://insertar new
                            string sqlN = "INSERT INTO tblcarreras (nombreCarrera, descripcion) VALUES (@nombreCarrera,@descripcion);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
                                comando.Parameters.AddWithValue("descripcion", descripcion);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msj = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msj = "Error, no se guardaron los datos...";
                                }
                            }//libera la operacion de insercion
                            break;
                        case 1://actualizar old
                            string sqlA = "UPDATE tblcarreras C SET C.nombreCarrera = @nombreCarrera, C.descripcion = @descripcion WHERE C.idCarrera = idCarrera;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("idCarrera", idCarrera);
                                comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
                                comando.Parameters.AddWithValue("descripcion", descripcion);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msj = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msj = "Error, no se guardaron los datos...";
                                }
                            }//libera la operacion de actualización
                            break;
                    }
                }//Libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("error"+ex.Message);
            }
            return msj;
        }
        public string Eliminar()
        {
            string msj = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tblcarreras C WHERE C.idCarrera= @idCarrera;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msj = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msj = "Los datos no se pudieron eliminar";
                        }
                    }//Libera la eliminacion
                }//Libera la conexion
            }catch(Exception ex)
            {
                throw new Exception("error"+ex.Message);
            }
            return msj;
        }
    }
}
