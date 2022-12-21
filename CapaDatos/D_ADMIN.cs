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
    public class D_ADMIN
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_ADMIN> ListarUsuariosA(string buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_Consultar_G_ADMIN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar_u", buscar);
            leerfilas = cmd.ExecuteReader();

            List<E_ADMIN> listar = new List<E_ADMIN>();
            while (leerfilas.Read())
            {
                listar.Add(new E_ADMIN
                {
                    IdAdmin = leerfilas.GetInt32(0),
                    CodigoAdmin = leerfilas.GetString(1),
                    NombreAdmin = leerfilas.GetString(2),
                    ApellidoAdmin = leerfilas.GetString(3),
                    Fecha_nacimientoA = leerfilas.GetDateTime(4),
                    TipoUsuarioA = leerfilas.GetString(5),
                    UsuarioA = leerfilas.GetString(6),
                    ContraA = leerfilas.GetString(7)
                });
            }
            conexion.Close();
            leerfilas.Close();
            return listar;
        }

        public void insertarUsuariosA(E_ADMIN e_ADMIN)
        {
            SqlCommand cmd = new SqlCommand("SP_insertar_G_admin", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", e_ADMIN.NombreAdmin);
            cmd.Parameters.AddWithValue("@APELLIDO", e_ADMIN.ApellidoAdmin);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", e_ADMIN.Fecha_nacimientoA);
            cmd.Parameters.AddWithValue("@TIPO_USUARIO", e_ADMIN.TipoUsuarioA);
            cmd.Parameters.AddWithValue("@USUARIO", e_ADMIN.UsuarioA);
            cmd.Parameters.AddWithValue("@CONTRA", e_ADMIN.ContraA);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarUsuariosA(E_ADMIN e_ADMIN)
        {
            SqlCommand cmd = new SqlCommand("SP_Editar_G_ADMIN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_ADMIN", e_ADMIN.IdAdmin);
            cmd.Parameters.AddWithValue("@NOMBRE", e_ADMIN.NombreAdmin);
            cmd.Parameters.AddWithValue("@APELLIDO", e_ADMIN.ApellidoAdmin);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", e_ADMIN.Fecha_nacimientoA);
            cmd.Parameters.AddWithValue("@TIPO_USUARIO", e_ADMIN.TipoUsuarioA);
            cmd.Parameters.AddWithValue("@USUARIO", e_ADMIN.UsuarioA);
            cmd.Parameters.AddWithValue("@CONTRA", e_ADMIN.ContraA);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarUsuariosA(E_ADMIN e_ADMIN)
        {
            SqlCommand cmd = new SqlCommand("SP_Eliminar_G_ADMIN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@id_admin", e_ADMIN.IdAdmin);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
