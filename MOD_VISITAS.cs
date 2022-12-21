using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocios;

namespace Final_project
{
    public partial class MOD_VISITAS : Form
    {
        private string Id_visitor;
        private bool editarse = false;

        //instanciando nuestra capa entidad y negocios

        N_VISITAS objNeocioV = new N_VISITAS();
        E_VISITAS objEntidadV = new E_VISITAS();


        public MOD_VISITAS()
        {
            InitializeComponent();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }



        private void button_search_Click(object sender, EventArgs e)
        {
            MostrarTabla(search.Text);
        }

        private void Mod_visitor_Click(object sender, EventArgs e)
        {
            // si la fila seleccionada es mayor a 0 pues insertamos los valores
            // si la fila seleccionada es mayor a 0 pues insertamos los valores
            if (tabla.SelectedRows.Count > 0)
            {
                Id_visitor = tabla.CurrentRow.Cells[0].Value.ToString();
                codigo.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                C_nombre.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                c_apellido.Text = tabla.CurrentRow.Cells[3].Value.ToString();
                c_correo.Text = tabla.CurrentRow.Cells[5].Value.ToString();
                carrera_TextBox1.Text = tabla.CurrentRow.Cells[4].Value.ToString();
                c_edificio.Text = tabla.CurrentRow.Cells[6].Value.ToString();
                c_aula.Text = tabla.CurrentRow.Cells[10].Value.ToString();
                Ent_DatePicker1.Text = tabla.CurrentRow.Cells[7].Value.ToString();
                Sal_DatePicker1.Text = tabla.CurrentRow.Cells[8].Value.ToString();
                mot_TextBox1.Text = tabla.CurrentRow.Cells[9].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selecciona la fila que desea editar");
            }

        }

        // metodos para insertarle los datos a nuestra tabla 

        private void MostrarTabla(string buscar)
        {
            tabla.DataSource = objNeocioV.listarVisitantes(buscar);
        }

        // metodo para no mostrar el ID en la tabla
        private void accionestabla()
        {
            tabla.Columns[0].Visible = false;
            tabla.ClearSelection();
        }

        private void MOD_VISITAS_Load(object sender, EventArgs e)
        {
            //llamamos nuestro metodo para mostrar la tabla desde que abra
            MostrarTabla("");
            accionestabla();
        }

        //metodo para limpiar los campos cuando se edite un usuario

        private void LimpiarCampos()
        {
            editarse = false;
            C_nombre.Text = "";
            c_apellido.Text = "";
            c_correo.Text = "";
            carrera_TextBox1.Text = "";
            c_edificio.Text = "";
            c_aula.Text = "";
            Ent_DatePicker1.Text = "";
            Sal_DatePicker1.Text = "";
            mot_TextBox1.Text = "";
        }

        private void Safe_Click(object sender, EventArgs e)
        {
            if (editarse == false)
                try
                {
                    objEntidadV.Nombre = C_nombre.Text.ToUpper();
                    objEntidadV.Apellido = c_apellido.Text.ToUpper();
                    objEntidadV.Carrera = carrera_TextBox1.Text.ToUpper();
                    objEntidadV.Correo = c_correo.Text.ToUpper();
                    objEntidadV.Edificio = c_edificio.Text.ToUpper();
                    objEntidadV.HoraEntrada = Ent_DatePicker1.Value;
                    objEntidadV.HoraSalida = Sal_DatePicker1.Value;
                    objEntidadV.Motivo = mot_TextBox1.Text.ToUpper();
                    objEntidadV.Aula = c_aula.Text.ToUpper();

                    objNeocioV.InsertandoVisitas(objEntidadV);
                    MessageBox.Show("registro insertado");
                    MostrarTabla("");
                    LimpiarCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro " + ex);

                }
            if (editarse == true)
            {
                try
                {
                    objEntidadV.Nombre = C_nombre.Text.ToUpper();
                    objEntidadV.Apellido = c_apellido.Text.ToUpper();
                    objEntidadV.Carrera = carrera_TextBox1.Text.ToUpper();
                    objEntidadV.Correo = c_correo.Text.ToUpper();
                    objEntidadV.Edificio = c_edificio.Text.ToUpper();
                    objEntidadV.HoraEntrada = Ent_DatePicker1.Value;
                    objEntidadV.HoraSalida = Sal_DatePicker1.Value;
                    objEntidadV.Motivo = mot_TextBox1.Text.ToUpper();
                    objEntidadV.Aula = c_aula.Text.ToUpper();

                    objNeocioV.InsertandoVisitas(objEntidadV);
                    MessageBox.Show("registro insertado");
                    MostrarTabla("");
                    LimpiarCampos();
                    editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro " + ex);
                }
            }
        }
     }
}
