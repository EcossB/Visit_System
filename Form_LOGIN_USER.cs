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

namespace Final_project
{
    public partial class Form_LOGIN_USER : Form
    {
        N_USER objtUser = new N_USER();

        public Form_LOGIN_USER()
        {
            InitializeComponent();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BIENVENIDA Fb = new Form_BIENVENIDA();
            Fb.Show();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bool n = objtUser.Logendo(Userinput.Text, passInput.Text);
             
            if (n)
            {
                Form_VISITANTES visit = new Form_VISITANTES();
                this.Hide();
                visit.Show();
            }
            else
            {
                MessageBox.Show("usuario o contra incorrecta");

            }
        }
    }
}
