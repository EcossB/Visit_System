using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class D_EDIFICIOS
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_EDIFICIOS> ListarEdificios(string buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_Consultar_edificios", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", buscar);
            leerfilas = cmd.ExecuteReader();

            List<E_EDIFICIOS> listar = new List<E_EDIFICIOS>();
            while (leerfilas.Read())
            {
                listar.Add(new E_EDIFICIOS
                {
                    IdEdificios = leerfilas.GetInt32(0),
                    Codigo = leerfilas.GetString(1),
                    Edificio = leerfilas.GetString(2),
                });
            }
            conexion.Close();
            leerfilas.Close();
            return listar;
        }

        public void InsertarEdificios(E_EDIFICIOS e_EDIFICIOS)
        {
            SqlCommand cmd = new SqlCommand("SP_Insertar_edificios", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@edificio", e_EDIFICIOS.Edificio);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarEdificios (E_EDIFICIOS e_EDIFICIOS)
        {
            SqlCommand cmd = new SqlCommand("SP_Editar_Edificios", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_EDIFICIO", e_EDIFICIOS.IdEdificios);
            cmd.Parameters.AddWithValue("@edificio", e_EDIFICIOS.Edificio);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarEdificios (E_EDIFICIOS e_EDIFICIOS)
        {
            SqlCommand cmd = new SqlCommand("SP_eliminar_Edificios", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_EDIFICIOS", e_EDIFICIOS.IdEdificios);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
