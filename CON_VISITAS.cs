using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;
using CapaDatos;


namespace Final_project
{
    public partial class CON_VISITAS : Form
    {

        E_VISITAS objEntidadV = new E_VISITAS();
        N_VISITAS objNegocioV = new N_VISITAS();

        public CON_VISITAS()
        {
            InitializeComponent();
        }

        private void CON_VISITAS_Load(object sender, EventArgs e)
        {
            ComboEdificio();
        }

        private void combo_edificio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        D_AULA data = new D_AULA();

        private void ComboEdificio()
        {
            DataTable dt = data.llenarComo("Ed", null);
            if (dt.Rows.Count > 0)
            {
                c_edificio.DisplayMember = "Edificio";
                c_edificio.ValueMember = "id";
                c_edificio.DataSource = dt;
            }

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            MostrarTabla(c_edificio.Text);
        }

        private void MostrarTabla(string edificio)
        {
            tabla.DataSource = objNegocioV.listarVisitasPorEdificio(edificio);
        }
    }
}
