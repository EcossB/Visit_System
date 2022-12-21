using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_EDIFICIOS
    {
        private int _IdEdificios;
        private string _codigo;
        private string _Edificio;

        public int IdEdificios { get => _IdEdificios; set => _IdEdificios = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Edificio { get => _Edificio; set => _Edificio = value; }
    }
}
