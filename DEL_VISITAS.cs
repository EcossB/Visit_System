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
    public partial class DEL_VISITAS : Form
    {

        //instanciando nuestra capa entidad y negocios

        N_VISITAS objNeocioV = new N_VISITAS();
        E_VISITAS objEntidadV = new E_VISITAS();

        public DEL_VISITAS()
        {
            InitializeComponent();
        }

        private void DEL_VISITAS_Load(object sender, EventArgs e)
        {
            MostrarTabla("");
            accionestabla();

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            MostrarTabla(search.Text);

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                objEntidadV.Idvisita = Convert.ToInt32(tabla.CurrentRow.Cells[0].Value.ToString());
                objNeocioV.elimanandoVisitantes(objEntidadV);

                MessageBox.Show("Se elimino el registro");
                MostrarTabla("");

            }
            else
            {
                MessageBox.Show("Selecciona la fila que deseas eliminar");
            }


        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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

        private void button_search_Click(object sender, EventArgs e)
        {
            MostrarTabla(search.Text);
        }
    }
}
