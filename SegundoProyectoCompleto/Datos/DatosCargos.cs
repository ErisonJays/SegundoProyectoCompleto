using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoProyectoCompleto.Logica;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SegundoProyectoCompleto.Datos
{
    public class DatosCargos
    {
        public bool InsertarCargo(LogicaCargos parametros)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("insertar_Cargo", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cargo", parametros.Cargo);
                cmd.Parameters.AddWithValue("@Sueldo_por_hora", parametros.SueldoCargo);
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

        public bool editar_Cargo(LogicaCargos parametros)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("editar_Cargo", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@Cargo", parametros.Cargo);
                cmd.Parameters.AddWithValue("@Sueldo", parametros.SueldoCargo);
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

       public void buscar_Cargos(ref DataTable dt,  string buscador)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscar_Cargos", CONEXIONMAESTRA.conectar); // usamos sqlDataAdapter ya que no vamos a moficiar los datos de la BD, solo los mostraremos
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscardor", buscador);
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

    }
}
