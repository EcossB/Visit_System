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
    public class D_AULA
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_AULA> ListarAulas(string buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_Consultar_aulas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", buscar);
            leerfilas = cmd.ExecuteReader();

            List<E_AULA> listar = new List<E_AULA>();
            while (leerfilas.Read())
            {
                listar.Add(new E_AULA
                {
                    IdAula = leerfilas.GetInt32(0),
                    CodigoAula = leerfilas.GetString(1),
                    Aula = leerfilas.GetString(2),
                    Edificio = leerfilas.GetInt32(3),
                });
            }
            conexion.Close();
            leerfilas.Close();
            return listar;
        }

        public void InsertarAulas(E_AULA e_AULA)
        {
            SqlCommand cmd = new SqlCommand("SP_insertar_aulas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@aula", e_AULA.Aula);
            cmd.Parameters.AddWithValue("@edificio", e_AULA.Edificio);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarAulas(E_AULA e_AULA)
        {
            SqlCommand cmd = new SqlCommand("SP_editar_aulas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Id_AULAS", e_AULA.IdAula);
            cmd.Parameters.AddWithValue("@aula", e_AULA.Aula);
            cmd.Parameters.AddWithValue("@edificio", e_AULA.Edificio);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarAulas(E_AULA e_AULA)
        {
            SqlCommand cmd = new SqlCommand("SP_eliminar_aula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@idaula", e_AULA.IdAula);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable llenarComo(string action, int? Id = null)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_combo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cmd.Parameters.Add("@action", action);
            
            if (action == "Ed")
            {
            }
            else if (action == "Au")
            {
                cmd.Parameters.Add("@Id", Id);
            }
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

    }
}
