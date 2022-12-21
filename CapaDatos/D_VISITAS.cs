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

    public class D_VISITAS
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        /// <summary>
        /// metodo para consultar la tabla VISITOR, 
        /// </summary>
        /// 


        public List<E_VISITAS> listarVisitasEdificio(string edificio)
        {
            SqlDataReader leerfilasEd;
            SqlCommand cmd = new SqlCommand("SP_listar_por_edificios", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@edificio", edificio);
            leerfilasEd = cmd.ExecuteReader();

            List<E_VISITAS> listar = new List<E_VISITAS>();
            while (leerfilasEd.Read())
            {
                listar.Add(new E_VISITAS
                {
                    Idvisita = leerfilasEd.GetInt32(0),
                    CodigoVisita = leerfilasEd.GetString(1),
                    Nombre = leerfilasEd.GetString(2),
                    Apellido = leerfilasEd.GetString(3),
                    Carrera = leerfilasEd.GetString(4),
                    Correo = leerfilasEd.GetString(5),
                    Edificio = leerfilasEd.GetString(6),
                    HoraEntrada = leerfilasEd.GetDateTime(7),
                    HoraSalida = leerfilasEd.GetDateTime(8),
                    Motivo = leerfilasEd.GetString(9),
                    Aula = leerfilasEd.GetString(10)
                });
            }
            conexion.Close();
            leerfilasEd.Close();
            return listar;


        }

        public List<E_VISITAS> ListarVisitantes(string buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_consultar_visitas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", buscar);
            leerfilas = cmd.ExecuteReader();

            List<E_VISITAS> listar = new List<E_VISITAS>();
            while(leerfilas.Read())
            {
                listar.Add(new E_VISITAS
                    {
                     Idvisita = leerfilas.GetInt32(0),
                     CodigoVisita = leerfilas.GetString(1),
                     Nombre = leerfilas.GetString(2),
                     Apellido = leerfilas.GetString(3),
                     Carrera =  leerfilas.GetString(4),
                     Correo = leerfilas.GetString(5),
                     Edificio = leerfilas.GetString(6),
                     HoraEntrada = leerfilas.GetDateTime(7),
                     HoraSalida = leerfilas.GetDateTime(8),
                     Motivo = leerfilas.GetString(9),
                     Aula = leerfilas.GetString(10)
                });
            }
            conexion.Close();
            leerfilas.Close();
            return listar;           
        }

        /// metodo para poder insertar datos dentro de la tabla visitor
        /// 
        public void insertarVisitantes(E_VISITAS _VISITAS)
        {
            SqlCommand cmd = new SqlCommand("SP_Insertar_Visitos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", _VISITAS.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", _VISITAS.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", _VISITAS.Carrera);
            cmd.Parameters.AddWithValue("@CORREO", _VISITAS.Correo);
            cmd.Parameters.AddWithValue("@EDIFICIO", _VISITAS.Edificio);
            cmd.Parameters.AddWithValue("@HORA_ENT", _VISITAS.HoraEntrada);
            cmd.Parameters.AddWithValue("@HORA_SALIDA", _VISITAS.HoraSalida);
            cmd.Parameters.AddWithValue("@MOTIVO", _VISITAS.Motivo);
            cmd.Parameters.AddWithValue("@AULA", _VISITAS.Aula);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        /// <summary>
        /// metodo para editar las visitas de la tabla VISITOR
        /// </summary>
        
        public void EditarVisitantes(E_VISITAS _VISITAS)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARVISITANTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDVISITOR", _VISITAS.Idvisita);
            cmd.Parameters.AddWithValue("@NOMBRE", _VISITAS.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", _VISITAS.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", _VISITAS.Carrera);
            cmd.Parameters.AddWithValue("@CORREO", _VISITAS.Correo);
            cmd.Parameters.AddWithValue("@EDIFICIO", _VISITAS.Edificio);
            cmd.Parameters.AddWithValue("@HORA_ENT", _VISITAS.HoraEntrada);
            cmd.Parameters.AddWithValue("@HORA_SALIDA", _VISITAS.HoraSalida);
            cmd.Parameters.AddWithValue("@MOTIVO", _VISITAS.Motivo);
            cmd.Parameters.AddWithValue("@AULA", _VISITAS.Aula);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarVisitas(E_VISITAS _VISITAS)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARVISITANTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDVISITOR", _VISITAS.Idvisita);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
