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
    public partial class EDIFICIOSFORM : Form
    {
        private string idEdificio;
        private bool editarse = false;

        E_EDIFICIOS objtEntidadED = new E_EDIFICIOS();
        N_EDIFICIOS objnegocioED = new N_EDIFICIOS();

        public EDIFICIOSFORM()
        {
            InitializeComponent();
        }

        private void EDIFICIOSFORM_Load(object sender, EventArgs e)
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
            N_EDIFICIOS objNegocioED = new N_EDIFICIOS();
            tabla.DataSource = objNegocioED.ListarEdificios(buscar);
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBUscarTabla(buscar.Text);
        }
        private void limpiarCaja()
        {
            editarse = false;
            buscarcod.Text = "";
            buscaredificio.Text = "";
            buscaredificio.Focus();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiarCaja();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                idEdificio = tabla.CurrentRow.Cells[0].Value.ToString();
                buscarcod.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                buscaredificio.Text = tabla.CurrentRow.Cells[2].Value.ToString();
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

                    objtEntidadED.Edificio = buscaredificio.Text.ToUpper();

                    objnegocioED.InsertandoEdificios(objtEntidadED);
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
                    objtEntidadED.IdEdificios = Convert.ToInt32(idEdificio);
                    objtEntidadED.Edificio = buscaredificio.Text.ToUpper();

                    objnegocioED.InsertandoEdificios(objtEntidadED);
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
                objtEntidadED.IdEdificios = Convert.ToInt32(tabla.CurrentRow.Cells[0].Value.ToString());
                objnegocioED.eliminandoEdificios(objtEntidadED);

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

