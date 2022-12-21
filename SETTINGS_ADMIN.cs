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
    public partial class SETTINGS_ADMIN : Form
    {
        public SETTINGS_ADMIN()
        {
            InitializeComponent();
        }

        private void button_user_Click(object sender, EventArgs e)
        {
            USER_FORM Us = new USER_FORM();
            Us.TopLevel = false;
            panel_visualizacion.Controls.Add(Us);
            Us.BringToFront();
            Us.Show();


        }

        private void Button_Edificios_Click(object sender, EventArgs e)
        {
            EDIFICIOSFORM ed = new EDIFICIOSFORM();
            ed.TopLevel = false;
            panel_visualizacion.Controls.Add(ed);
            ed.BringToFront();
            ed.Show();
        }

        private void button_aulas_Click(object sender, EventArgs e)
        {
            AULAS_FORM al = new AULAS_FORM();
            al.TopLevel = false;
            panel_visualizacion.Controls.Add(al);
            al.BringToFront();
            al.Show();

        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            Usuarios_ADMIN Ua = new Usuarios_ADMIN();
            Ua.TopLevel = false;
            panel_visualizacion.Controls.Add(Ua);
            Ua.BringToFront();
            Ua.Show();

        }
    }
}
