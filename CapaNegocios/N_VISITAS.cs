using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocios
{
    public class N_VISITAS
    {
        /// <summary>
        /// 
        /// se instancian los metodos de la capa de datos, basicamente la capa negocios es un puente 
        /// entre la capa de presentacion y la capa de datos, pues basicamente en esta capa se aplica
        /// lo que es la logica de negocios 
        ///
        /// En esta clase lo que estoy haciendo es que primero instancio lo que viene siendo mi clase D_VISITAS
        /// que contiene los metodos que corren los SP en mi base de datos. entonces necesito mi capa entidad debido 
        /// a que ella es la que contiene los atributos de la tabla VISITOR que son los datos que van a la misma tabla.
        /// por eso pueden ver el porque dentro de mi lista instancio mi capa entidad (clase entidad que contiene los atributos),
        /// y dentro de ese metodo lo que tengo es el metodo de mi capa datos que recorre el store procedure en mi base de datos.
        ///
        /// </summary>
        D_VISITAS objtDato = new D_VISITAS();

        public List<E_VISITAS> listarVisitasPorEdificio(string edificio)
        {
            return objtDato.listarVisitasEdificio(edificio);
        }
        public List<E_VISITAS> listarVisitantes (string buscar)
        {
            return objtDato.ListarVisitantes(buscar);
        }

        public void InsertandoVisitas(E_VISITAS _VISITAS)
        {
            objtDato.insertarVisitantes(_VISITAS);
        }
        public void editandoVisitantes(E_VISITAS _VISITAS)
        {
            objtDato.EditarVisitantes(_VISITAS);
        }
        public void elimanandoVisitantes(E_VISITAS _VISITAS)

        {
            objtDato.EliminarVisitas(_VISITAS);
        }

    }
}
