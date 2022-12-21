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
    public partial class USER_FORM : Form
    {
        private string iduser;
        private bool editarse = false;


        N_USER objnegocioUs = new N_USER();
        E_USER objEntidadUs = new E_USER();
        public USER_FORM()
        {
            InitializeComponent();
        }

        private void USER_FORM_Load(object sender, EventArgs e)
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
            N_USER objnegocioUs = new N_USER();
            tabla.DataSource = objnegocioUs.listarUsuariosG(buscar);
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBUscarTabla(buscar.Text);
        }

        private void limpiarCaja()
        {
            editarse = false;
            cod_input.Text = "";
            nombre_input.Text = "";
            Apellido_input.Text = "";
            date.Text.Replace("12/18/2022","");
            Tipo_usuario_input.Text = "";
            Usuario_input.Text = "GENERAL";
            Contra_input.Text = "";
            nombre_input.Focus();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiarCaja();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                iduser = tabla.CurrentRow.Cells[0].Value.ToString();
                cod_input.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                nombre_input.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                Apellido_input.Text = tabla.CurrentRow.Cells[3].Value.ToString();
                Tipo_usuario_input.Text = tabla.CurrentRow.Cells[5].Value.ToString();
                Usuario_input.Text = tabla.CurrentRow.Cells[6].Value.ToString();
                Contra_input.Text = tabla.CurrentRow.Cells[7].Value.ToString();
                date.Text = tabla.CurrentRow.Cells[4].Value.ToString();

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
                    objEntidadUs.NombreUser = nombre_input.Text.ToUpper();
                    objEntidadUs.ApellidoUser = Apellido_input.Text.ToUpper();
                    objEntidadUs.Fecha_nacimientoG = date.Value;
                    objEntidadUs.TipoUsuarioG = Tipo_usuario_input.Text.ToUpper();
                    objEntidadUs.UsuarioG = Usuario_input.Text.ToUpper();
                    objEntidadUs.ContraG = Contra_input.Text.ToUpper();

                    objnegocioUs.InsertandoUsuariosG(objEntidadUs);
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
                    objEntidadUs.Iduser = Convert.ToInt32(iduser);
                    objEntidadUs.NombreUser = nombre_input.Text.ToUpper();
                    objEntidadUs.ApellidoUser = Apellido_input.Text.ToUpper();
                    objEntidadUs.Fecha_nacimientoG = date.Value;
                    objEntidadUs.TipoUsuarioG = Tipo_usuario_input.Text.ToUpper();
                    objEntidadUs.UsuarioG = Usuario_input.Text.ToUpper();
                    objEntidadUs.ContraG = Contra_input.Text.ToUpper();

                    objnegocioUs.InsertandoUsuariosG(objEntidadUs);
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
                objEntidadUs.Iduser = Convert.ToInt32(tabla.CurrentRow.Cells[0].Value.ToString());
                objnegocioUs.elimanandoUsuarios(objEntidadUs);

                MessageBox.Show("Se elimino el registro");
                mostrarBUscarTabla("");

            }
            else
            {
                MessageBox.Show("Selecciona la fila que deseas eliminar");
            }

        }

        private void Tipo_usuario_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
