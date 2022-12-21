using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class N_ADMIN
    {
        D_ADMIN objtDato = new D_ADMIN();
        public List<E_ADMIN> listarUsuariosA(string buscar)
        {
            return objtDato.ListarUsuariosA(buscar);
        }

        public void InsertandoUsuariosA(E_ADMIN e_ADMIN)
        {
            objtDato.insertarUsuariosA(e_ADMIN);
        }
        public void editandoUsuariosA(E_ADMIN e_ADMIN)
        {
            objtDato.EditarUsuariosA(e_ADMIN);
        }
        public void elimanandoUsuariosA(E_ADMIN e_ADMIN)

        {
            objtDato.EliminarUsuariosA(e_ADMIN);

        }
    }
 }
