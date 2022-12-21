using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class N_USER
    {
        D_USER objtDato = new D_USER();
        public List<E_USER> listarUsuariosG(string buscar)
        {
            return objtDato.ListarUsuariosG(buscar);
        }

        public void InsertandoUsuariosG(E_USER _USER)
        {
            objtDato.insertarUsuariosG(_USER);
        }
        public void editandoUsuarios(E_USER _USER)
        {
            objtDato.EditarUsuariosG(_USER);
        }
        public void elimanandoUsuarios(E_USER _USER)

        {
            objtDato.EliminarUsuariosG(_USER);
        }

        public bool Logendo(string user, string pass)
        {
            
         return objtDato.Login(user, pass);
             
        }

    }
}
