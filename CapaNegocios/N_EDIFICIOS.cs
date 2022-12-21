using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class N_EDIFICIOS
    {
        D_EDIFICIOS objtDato = new D_EDIFICIOS();

        public List<E_EDIFICIOS> ListarEdificios(string buscar)
        {
            return objtDato.ListarEdificios(buscar);
        }

        public void InsertandoEdificios(E_EDIFICIOS e_EDIFICIOS)
        {
            objtDato.InsertarEdificios(e_EDIFICIOS);
        }

        public void EditandoEdificios(E_EDIFICIOS e_EDIFICIOS)
        {
            objtDato.EditarEdificios(e_EDIFICIOS);
        }

        public void eliminandoEdificios(E_EDIFICIOS e_EDIFICIOS)
        {
            objtDato.EliminarEdificios(e_EDIFICIOS);
        }
    }
}
