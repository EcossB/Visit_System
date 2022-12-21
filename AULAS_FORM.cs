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
    public partial class AULAS_FORM : Form
    {
        private string idAula;
        private bool editarse = false;

        E_AULA objEntidadAu = new E_AULA();
        N_AULA objNegocio = new N_AULA();

        public AULAS_FORM()
        {
            InitializeComponent();
        }

        private void AULAS_FORM_Load(object sender, EventArgs e)
        {
            mostrarBUscarTabla("");
            accionesTabla();
        }

        private void accionesTabla()
        {   
            tabla.Columns[0].Visible = false;
            tabla.ClearSelection();
        }

        public void mostrarBUscarTabla(string buscar)
        {
            N_AULA objNegocio = new N_AULA();
            tabla.DataSource = objNegocio.listarAulas(buscar);
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBUscarTabla(buscar.Text);
        }

        private void limpiarCaja()
        {
            editarse = false;
            buscarcod.Text = "";
            buscaraula.Text = "";
            buscaredificio.Text = "";
            buscaraula.Focus();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiarCaja();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                idAula = tabla.CurrentRow.Cells[0].Value.ToString();
                buscarcod.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                buscaraula.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                buscaredificio.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona la fila que desea editar");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    
                    objEntidadAu.Aula = buscaraula.Text.ToUpper();
                    objEntidadAu.Edificio = Int32.Parse(buscaredificio.Text);

                    objNegocio.InsertandoAulas(objEntidadAu);
                    MessageBox.Show("registro insertado");
                    mostrarBUscarTabla("");
                    limpiarCaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo guardar" + ex);
                }
            }
            if (editarse == true)
            {
                try
                {
                    objEntidadAu.IdAula = Convert.ToInt32(idAula);
                    objEntidadAu.Aula = buscaraula.Text.ToUpper();
                    objEntidadAu.Edificio = Int32.Parse(buscaredificio.Text);

                    objNegocio.InsertandoAulas(objEntidadAu);
                    MessageBox.Show("registro Editado");
                    mostrarBUscarTabla("");
                    limpiarCaja();
                    editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar" + ex);
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                objEntidadAu.IdAula = Convert.ToInt32(tabla.CurrentRow.Cells[0].Value.ToString());
                objNegocio.elimanandoAulas(objEntidadAu);

                MessageBox.Show("Se elimino el registro");
                mostrarBUscarTabla("");
                
            }
            else
            {
                MessageBox.Show("Selecciona la fila que deseas eliminar");
            }
        }
    }
}
