using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_USER
    {
        private int _iduser;
        private string _codigouser;
        private string _nombreUser;
        private string _apellidoUser;
        private DateTime _fecha_nacimientoG;
        private string _tipoUsuarioG;
        private string _usuarioG;
        private string _contraG;

        public int Iduser { get => _iduser; set => _iduser = value; }
        public string Codigouser { get => _codigouser; set => _codigouser = value; }
        public string NombreUser { get => _nombreUser; set => _nombreUser = value; }
        public string ApellidoUser { get => _apellidoUser; set => _apellidoUser = value; }
        public DateTime Fecha_nacimientoG { get => _fecha_nacimientoG; set => _fecha_nacimientoG = value; }
        public string TipoUsuarioG { get => _tipoUsuarioG; set => _tipoUsuarioG = value; }
        public string UsuarioG { get => _usuarioG; set => _usuarioG = value; }
        public string ContraG { get => _contraG; set => _contraG = value; }
    }
}
