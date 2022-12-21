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
    public class D_USER
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_USER> ListarUsuariosG(string buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_Consultar_G_USER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar_u", buscar);
            leerfilas = cmd.ExecuteReader();

            List<E_USER> listar = new List<E_USER>();
            while (leerfilas.Read())
            {
                listar.Add(new E_USER
                {
                    Iduser = leerfilas.GetInt32(0),
                    Codigouser = leerfilas.GetString(1),
                    NombreUser = leerfilas.GetString(2),
                    ApellidoUser = leerfilas.GetString(3),
                    Fecha_nacimientoG = leerfilas.GetDateTime(4),
                    TipoUsuarioG = leerfilas.GetString(5),
                    UsuarioG = leerfilas.GetString(6),
                    ContraG = leerfilas.GetString(7)
                });
            }
            conexion.Close();
            leerfilas.Close();
            return listar;
        }

        public void insertarUsuariosG(E_USER _USER)
        {
            SqlCommand cmd = new SqlCommand("SP_insertar_G_USER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", _USER.NombreUser);
            cmd.Parameters.AddWithValue("@APELLIDO", _USER.ApellidoUser);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", _USER.Fecha_nacimientoG);
            cmd.Parameters.AddWithValue("@TIPO_USUARIO", _USER.TipoUsuarioG);
            cmd.Parameters.AddWithValue("@USUARIO", _USER.UsuarioG);
            cmd.Parameters.AddWithValue("@CONTRA", _USER.ContraG);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarUsuariosG(E_USER _USER)
        {
            SqlCommand cmd = new SqlCommand("SP_Editar_G_USER", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_USER", _USER.Iduser);
            cmd.Parameters.AddWithValue("@NOMBRE", _USER.NombreUser);
            cmd.Parameters.AddWithValue("@APELLIDO", _USER.ApellidoUser);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", _USER.Fecha_nacimientoG);
            cmd.Parameters.AddWithValue("@TIPO_USUARIO", _USER.TipoUsuarioG);
            cmd.Parameters.AddWithValue("@USUARIO", _USER.UsuarioG);
            cmd.Parameters.AddWithValue("@CONTRA", _USER.ContraG);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarUsuariosG(E_USER _USER)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_Eliminar_G_User", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
       

            cmd.Parameters.AddWithValue("@id_user", _USER.Iduser);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public bool Login(string user, string pass)
        {

            conexion.Open();
            SqlCommand cmd = new SqlCommand("sp_login", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            

            cmd.Parameters.AddWithValue("@usarioU", user);
            cmd.Parameters.AddWithValue("contraU", pass);

            SqlDataReader dr = cmd.ExecuteReader();
            bool r = dr.Read();
            conexion.Close();
            return r;

            
        }

    }
    }
