using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Form_VISITANTES : Form
    {
        public Form_VISITANTES()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            MOD_VISITAS mod = new MOD_VISITAS();
            mod.TopLevel = false;
            panel_visualizacion.Controls.Add(mod);
            mod.BringToFront();
            mod.Show();

        }

        private void button_reg_visit_Click(object sender, EventArgs e)
        {
            form_ADD_VISITAS v = new form_ADD_VISITAS();
            v.TopLevel = false;
            panel_visualizacion.Controls.Add(v);
            v.BringToFront();
            v.Show();
        }

        private void button_del_vivit_Click(object sender, EventArgs e)
        {
            DEL_VISITAS del = new DEL_VISITAS();
            del.TopLevel = false;
            panel_visualizacion.Controls.Add(del);
            del.BringToFront();
            del.Show();

        }

        private void Consult_visit_Click(object sender, EventArgs e)
        {
            CON_VISITAS con = new CON_VISITAS();
            con.TopLevel = false;
            panel_visualizacion.Controls.Add(con);
            con.BringToFront();
            con.Show();

        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
