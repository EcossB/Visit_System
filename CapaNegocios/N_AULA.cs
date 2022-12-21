using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocios
{
    public class N_AULA
    {
        D_AULA objtDato = new D_AULA();
        public List<E_AULA> listarAulas(string buscar)
        {
            return objtDato.ListarAulas(buscar);
        }

        public void InsertandoAulas (E_AULA e_AULA)
        {
            objtDato.InsertarAulas(e_AULA);
        }
        public void editandoAulas(E_AULA e_AULA)
        {
            objtDato.EditarAulas(e_AULA);
        }
        public void elimanandoAulas(E_AULA e_AULA)

        {
            objtDato.EliminarAulas(e_AULA);
        }


    }
}
