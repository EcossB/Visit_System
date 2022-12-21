using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_ADMIN
    {
        private int _idAdmin;
        private string _codigoAdmin;
        private string _nombreAdmin;
        private string _apellidoAdmin;
        private DateTime _fecha_nacimientoA;
        private string _tipoUsuarioA;
        private string _usuarioA;
        private string _contraA;

        public int IdAdmin { get => _idAdmin; set => _idAdmin = value; }
        public string CodigoAdmin { get => _codigoAdmin; set => _codigoAdmin = value; }
        public string NombreAdmin { get => _nombreAdmin; set => _nombreAdmin = value; }
        public string ApellidoAdmin { get => _apellidoAdmin; set => _apellidoAdmin = value; }
        public DateTime Fecha_nacimientoA { get => _fecha_nacimientoA; set => _fecha_nacimientoA = value; }
        public string TipoUsuarioA { get => _tipoUsuarioA; set => _tipoUsuarioA = value; }
        public string UsuarioA { get => _usuarioA; set => _usuarioA = value; }
        public string ContraA { get => _contraA; set => _contraA = value; }
    }
}
