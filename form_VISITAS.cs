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
    public partial class form_ADD_VISITAS : Form
    {

        E_VISITAS objEntidadV = new E_VISITAS();
        N_VISITAS objNegocioV = new N_VISITAS();
        public form_ADD_VISITAS()
        {
            InitializeComponent();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_visitor_Click(object sender, EventArgs e)
        {
            try
            {
                objEntidadV.Nombre = C_nombre.Text.ToUpper();
                objEntidadV.Apellido = c_apellido.Text.ToUpper();
                objEntidadV.Carrera = carrera_TextBox1.Text.ToUpper();
                objEntidadV.Correo = c_correo.Text.ToUpper();
                objEntidadV.Edificio = c_edificio.Text.ToUpper();
                objEntidadV.Aula = c_aula.Text.ToUpper();
                objEntidadV.HoraEntrada = Ent_DatePicker1.Value;
                objEntidadV.HoraSalida = Sal_DatePicker1.Value;
                objEntidadV.Motivo = mot_TextBox1.Text.ToUpper();
                

                objNegocioV.InsertandoVisitas(objEntidadV);
                MessageBox.Show("registro insertado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo guardar el registro" + ex);
            }
        }

        private void c_edificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c_edificio.SelectedIndex != 1)
            {
                comboAula();
            }
        }

        private void c_aula_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void form_ADD_VISITAS_Load(object sender, EventArgs e)
        {
            //rellenar_combobox_aula("");
            // rellenar_combobox_edificio("");
            ComboEdificio();
            comboAula();
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

        private void comboAula()
        {
            int id = c_edificio.SelectedIndex;
            DataTable dt = data.llenarComo("Au", id);
            if (dt.Rows.Count > 0)
            {
                c_aula.DisplayMember = "AULA";
                c_aula.ValueMember = "IDAULA";
                c_aula.DataSource = dt;
            }

        }

    }
}
