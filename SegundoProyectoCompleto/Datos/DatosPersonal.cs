using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SegundoProyectoCompleto.Logica;
using System.Windows.Forms;


namespace SegundoProyectoCompleto.Datos
{
    public class DatosPersonal
    {
        public bool InsertarPersonal(LogicaPersonal parametros)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("InsertarPersonal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
                cmd.ExecuteNonQuery(); //ejecutar el query
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }

        public bool editarPersonal(LogicaPersonal parametros)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("editarPersonal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_Personal);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@Sueldo_por_hora", parametros.SueldoPorHora);
                cmd.ExecuteNonQuery(); //ejecutar el query
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }

        public bool eliminarPersonal(LogicaPersonal parametros)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("eliminarPersonal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idpersonal", parametros.Id_Personal);
                cmd.ExecuteNonQuery(); //ejecutar el query
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }

        public void MostrarPersona(ref DataTable dt, int desde, int hasta)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarPersonal",CONEXIONMAESTRA.conectar); // usamos sqlDataAdapter ya que no vamos a moficiar los datos de la BD, solo los mostraremos
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde",desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta",hasta);
                da.Fill(dt); // pasamos los datos a la variables dt

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace); // usamos StackTrace ya que en la base de datos no colocamos un raiserror para ese StoreProcedure

            }
            finally
            {
                CONEXIONMAESTRA.Abrir();
            }
        }

        public void BuscarPersonal(ref DataTable dt, int desde, int hasta, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarPersonal", CONEXIONMAESTRA.conectar); // usamos sqlDataAdapter ya que no vamos a moficiar los datos de la BD, solo los mostraremos
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                da.Fill(dt); // pasamos los datos a la variables dt

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace); // usamos StackTrace ya que en la base de datos no colocamos un raiserror para ese StoreProcedure

            }
            finally
            {
                CONEXIONMAESTRA.Abrir();
            }
        }

        public bool RestaurarPersonal(LogicaPersonal parametros)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("restaurar_personal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idpersonal", parametros.Id_Personal);
                cmd.ExecuteNonQuery(); //ejecutar el query
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }

        public void ContarPersonal(ref int Contador)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("select COUNT (Id_Personal) from Personal", CONEXIONMAESTRA.conectar);
                Contador = Convert.ToInt32(cmd.ExecuteScalar()); // hace que se muestre solo el primer resultado de la tabla e ignora los demas
            }
            catch (Exception)
            {

                Contador = 0;
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        
        }




    }
}
