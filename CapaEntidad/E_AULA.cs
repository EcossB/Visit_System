using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_AULA
    {
        private int _idAula;
        private string _CodigoAula;
        private string _aula;
        private int _edificio;

        public int IdAula { get => _idAula; set => _idAula = value; }
        public string CodigoAula { get => _CodigoAula; set => _CodigoAula = value; }
        public string Aula { get => _aula; set => _aula = value; }
        public int Edificio { get => _edificio; set => _edificio = value; }
    }
}
