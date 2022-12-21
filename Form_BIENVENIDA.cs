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
    public partial class Form_BIENVENIDA : Form
    {
        Form_LOGIN_USER Fu = new Form_LOGIN_USER();
        Form_LOGIN_ADMIN Fa = new Form_LOGIN_ADMIN();

        public Form_BIENVENIDA()
        {
            InitializeComponent();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form_BIENVENIDA_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LOGIN_ADMIN Fa = new Form_LOGIN_ADMIN();
            Fa.Show();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LOGIN_USER Fu = new Form_LOGIN_USER();
            Fu.Show();
        }
    }
}
