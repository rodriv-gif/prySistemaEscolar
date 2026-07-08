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
        private string apellidoP;
        private string apellidoM;
        private string direccion;
        private string telefono;
        private string correo;
        private decimal promedioBachillerato;
        private int idTutor;//foraneo
        private int idCarrera;//foraneo
        private int idUsuario;
        //Estos atributos agregamos para registrar el usuario
        private string nombreUsuario;
        private string password;
        private string perfil;

        //adaptador y  tabla virtuales de la clase
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;
        private string msg;

        //propiedades
        public int Matricula { get => matricula; set => matricula = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public decimal PromedioBachillerato { get => promedioBachillerato; set => promedioBachillerato = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, A.nombreAlumno AS Nombre,\r\nA.apellidoP AS 'A. Paterno', A.apellidoM AS 'A. Materno',\r\nC.nombreCarrera AS Carrera,\r\nT.nombreTutor AS Tutor,\r\nU.vchnombreUsuario AS Usuario, U.vchpassword, U.vchperfil AS Perfil,A.direccion,\r\nA.telefono, A.correo, A.promedioBachillerato, A.idTutor, A.idCarrera, A.idUsuario\r\nFROM tblalumnos A\r\nINNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera\r\nINNER JOIN tbltutores T ON A.idTutor = T.idTutor\r\nINNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario;";
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

        //Para el combo de carreras
        public DataTable ObtenerCarreras()
        {
            tabla=new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion=conexionBD.AbrirConexion())
                {
                    //Valuemember es el idcarrera y el display member el nombre de la carrera
                    string sql = "SELECT idCarrera, nombreCarrera FROM tblcarreras;";
                    using (consulta=new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("error al obtener el catalogo de carreras " + ex.Message);
            }
            return tabla;
        }
        //Metodo para el combo tutores
        public DataTable ObtenerTutores()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    //Valuemember es el idTutor y el display member el nombre del tutor
                    string sql = "SELECT idTutor, nombreTutor FROM tbltutores;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("error al obtener el catalogo de tutores " + ex.Message);
            }
            return tabla;
        }
        
        public void LimpiarPanel(Panel panelDestino)
        {

            foreach (Control control in panelDestino.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }


                else if(control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;

                }
            }
        }
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, A.nombreAlumno AS Nombre,\r\nA.apellidoP AS 'A. Paterno', A.apellidoM AS 'A. Materno',\r\nC.nombreCarrera AS Carrera,\r\nT.nombreTutor AS Tutor,\r\nU.vchnombreUsuario AS Usuario,U.vchpassword, U.vchperfil AS Perfil, A.direccion,\r\nA.telefono, A.correo, A.promedioBachillerato, A.idTutor, A.idCarrera, A.idUsuario\r\nFROM tblalumnos A\r\nINNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera\r\nINNER JOIN tbltutores T ON A.idTutor = T.idTutor\r\nINNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario WHERE A.matricula LIKE @matricula; ";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@matricula", "%" + matricula + "%");
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
        public string GuardarActualizar(int tipoOperacion)
        {
            string msj = "";
            clsConexion conexionBD = new clsConexion();
            try
            {
                using (var conexion=conexionBD.AbrirConexion())
                {
                    using (var transaccion=conexion.BeginTransaction())
                    {
                        try
                        {
                            switch (tipoOperacion)
                            {
                                case 0://insertar uno
                                    //1. insertamos en la tabla tblusuarios
                                    string sqlInsUser = "INSERT INTO tblusuarios(vchnombreUsuario, vchpassword, vchperfil, vchestado) VALUES(@nomUser, MD5(@pass), @perfil, 'Activo');SELECT LAST_INSERT_ID();";

                                    int nuevoIdUsuario = 0;
                                    using (comando = new MySqlCommand(sqlInsUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar()); //2.recuperamos el id de usuario
                                    }

                                    //Paso 3: Insertar el alumno en tblalumnos vinculando el ID de usuario obtenido
                                    string sqlInsAlumno = "INSERT INTO tblalumnos(matricula, idUsuario, nombreAlumno, apellidoP, apellidoM, direccion, telefono, correo, promedioBachillerato, idTutor, idCarrera)\r\nVALUES(@matricula, @idUsuario, @nombre, @apP, @apM, @dir, @tel, @correo, @prom, @idTutor,@idCarrera);";

                                    using (comando = new MySqlCommand(sqlInsAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario);
                                        comando.Parameters.AddWithValue("@nombre", nombreAlumno);
                                        comando.Parameters.AddWithValue("@apP", apellidoP);
                                        comando.Parameters.AddWithValue("@apM", apellidoM);
                                        comando.Parameters.AddWithValue("@dir", direccion);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@prom", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);

                                        comando.ExecuteNonQuery();  //paso 4
                                    }

                                    msg = "El alumno y sus credenciales se guardaron correctamente.";
                                    break;

                                case 1:  //ACTUALIZAR
                                    //PASO A:Actualizar la tabla de usuarios utilizando el ID que recuperamos en el clic
                                    string sqlupdUser = "UPDATE tblusuarios SET vchnombreUsuario = @nomUser,vchperfil = @perfil" + " WHERE intidUsuario = @idUsuario;";
                                    using (comando = new MySqlCommand(sqlupdUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@perfil", perfil);

                                        comando.ExecuteNonQuery();
                                    }
                                    //PASO B: Actualizar los datos del expediente en tblalumnos mediante su matricula
                                    string sqlUpdAlumno = "UPDATE tblalumnos SET nombreAlumno=@nombre,apellidoP=@apP,apellidoM=@apM," + "direccion=@dir,telefono =@tel,correo=@correo,promedioBachillerato=@prom," + "idTutor=@idTutor,idCarrera=@idCarrera WHERE matricula=@matricula";

                                    using(comando=new MySqlCommand(sqlUpdAlumno,conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);
                                        comando.Parameters.AddWithValue("@nombre",nombreAlumno);
                                        comando.Parameters.AddWithValue("@apP", apellidoP);
                                        comando.Parameters.AddWithValue("@apM", apellidoM);
                                        comando.Parameters.AddWithValue("@dir", direccion);
                                        comando.Parameters.AddWithValue("@tel",telefono );
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@prom", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "Los datos del alumno se actuaqlizaron correctamente.";
                                    break;
                            }
                            //si todo se ejecuto sin errores en el switch, confirmamos los cambios en le BD 
                            //5. se valida que todo haya sido correcto
                            transaccion.Commit(); //6. se confirma el guardado en las dos tablas
                        }
                        catch (Exception ex)
                        {
                            //si algo fallo (en el usuario o en el alumno), deshasemos todo para evitar inconsistencias
                            transaccion.Rollback();
                            throw new Exception("Error en la operacion. se cancelaron los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error de conexion: " + ex.Message);
            }
            return msg;
        }//finaliza el metodo

        public string Eliminar()
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            //eliminamos alumnos
                            string sqlDelAlumno = "DELETE FROM tblAlumnos WHERE matricula = @matricula;";
                            using (comando = new MySqlCommand(sqlDelAlumno, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@matricula", matricula);
                                comando.ExecuteNonQuery();
                            }

                            //eliminamos usuario
                            string sqlDelUsuario = "DELETE FROM tblusuarios WHERE intidUsuario = @idUsuario;";
                            using (comando = new MySqlCommand(sqlDelUsuario, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                comando.ExecuteNonQuery();
                            }

                            //si en ambas se eliminan correctamente
                            transaccion.Commit();
                            msg = "El alumno y sus credenciales de usuario han sido eliminados del sistema.";
                        }
                        catch (Exception ex)
                        {
                            //si algo falla, deshacemos la operacion para no dejar datos huérfanos
                            transaccion.Rollback();
                            throw new Exception("No se pudo completar la eliminación. Cambios revertidos: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión al eliminar: " + ex.Message);
            }
            return msg;
        }
    }
}
