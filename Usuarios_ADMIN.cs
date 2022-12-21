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
    public partial class Usuarios_ADMIN : Form
    {
        private string idAdmin;
        private bool editarse = false;


        N_ADMIN objnegocioAd = new N_ADMIN();
        E_ADMIN objEntidadAd = new E_ADMIN();

        public Usuarios_ADMIN()
        {
            InitializeComponent();
        }

        private void Usuarios_ADMIN_Load(object sender, EventArgs e)
        {
            mostrarBUscarTabla("");
            accionesTabla();
        }


        private void accionesTabla()
        {
            tablaA.Columns[0].Visible = false;
            tablaA.ClearSelection();
        }

        public void mostrarBUscarTabla(string buscar)
        {
            N_ADMIN objnegocioAd = new N_ADMIN();
            tablaA.DataSource = objnegocioAd.listarUsuariosA(buscar);
        }



        private void limpiarCaja()
        {
            editarse = false;
            cod_input.Text = "";
            nombre_input.Text = "";
            Apellido_input.Text = "";
            date.Text.Replace("12/18/2022", "");
            Tipo_usuario_input.Text = "";
            Usuario_input.Text = "ADMINISTRADOR";
            Contra_input.Text = "";
            nombre_input.Focus();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiarCaja();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (tablaA.SelectedRows.Count > 0)
            {
                idAdmin = tablaA.CurrentRow.Cells[0].Value.ToString();
                cod_input.Text = tablaA.CurrentRow.Cells[1].Value.ToString();
                nombre_input.Text = tablaA.CurrentRow.Cells[2].Value.ToString();
                Apellido_input.Text = tablaA.CurrentRow.Cells[3].Value.ToString();
                Tipo_usuario_input.Text = tablaA.CurrentRow.Cells[5].Value.ToString();
                Usuario_input.Text = tablaA.CurrentRow.Cells[6].Value.ToString();
                Contra_input.Text = tablaA.CurrentRow.Cells[7].Value.ToString();
                date.Text = tablaA.CurrentRow.Cells[4].Value.ToString();

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
                    objEntidadAd.NombreAdmin = nombre_input.Text.ToUpper();
                    objEntidadAd.ApellidoAdmin = Apellido_input.Text.ToUpper();
                    objEntidadAd.Fecha_nacimientoA = date.Value;
                    objEntidadAd.TipoUsuarioA = Tipo_usuario_input.Text.ToUpper();
                    objEntidadAd.UsuarioA = Usuario_input.Text.ToUpper();
                    objEntidadAd.ContraA = Contra_input.Text.ToUpper();

                    objnegocioAd.InsertandoUsuariosA(objEntidadAd);
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
                    objEntidadAd.IdAdmin = Convert.ToInt32(idAdmin);
                    objEntidadAd.NombreAdmin = nombre_input.Text.ToUpper();
                    objEntidadAd.ApellidoAdmin = Apellido_input.Text.ToUpper();
                    objEntidadAd.Fecha_nacimientoA = date.Value;
                    objEntidadAd.TipoUsuarioA = Tipo_usuario_input.Text.ToUpper();
                    objEntidadAd.UsuarioA = Usuario_input.Text.ToUpper();
                    objEntidadAd.ContraA = Contra_input.Text.ToUpper();

                    objnegocioAd.InsertandoUsuariosA(objEntidadAd);
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
            if (tablaA.SelectedRows.Count > 0)
            {
                objEntidadAd.IdAdmin = Convert.ToInt32(tablaA.CurrentRow.Cells[0].Value.ToString());
                objnegocioAd.elimanandoUsuariosA(objEntidadAd);

                MessageBox.Show("Se elimino el registro");
                mostrarBUscarTabla("");

            }
            else
            {
                MessageBox.Show("Selecciona la fila que deseas eliminar");
            }

        }

        private void buscar_TextChanged_1(object sender, EventArgs e)
        {
            mostrarBUscarTabla(buscar.Text);
        }
    }
}
