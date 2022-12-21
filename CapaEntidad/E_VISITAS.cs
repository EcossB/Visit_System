using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_VISITAS
    {
        private int _idvisita;
        private string _codigoVisita;
        private string _nombre;
        private string _apellido;
        private string _carrera;
        private string _correo;
        private string _edificio;
        private DateTime _horaEntrada;
        private DateTime _horaSalida;
        private string _motivo;
        private string _aula;

        public int Idvisita { get => _idvisita; set => _idvisita = value; }
        public string CodigoVisita { get => _codigoVisita; set => _codigoVisita = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Carrera { get => _carrera; set => _carrera = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Edificio { get => _edificio; set => _edificio = value; }
        public DateTime HoraEntrada { get => _horaEntrada; set => _horaEntrada = value; }
        public DateTime HoraSalida { get => _horaSalida; set => _horaSalida = value; }
        public string Motivo { get => _motivo; set => _motivo = value; }
        public string Aula { get => _aula; set => _aula = value; }
    }
}
