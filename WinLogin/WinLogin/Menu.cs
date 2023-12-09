
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLogin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmiUser_Click(object sender, EventArgs e)
        {
            AdmiUsuario admiUsuario = new AdmiUsuario();
            admiUsuario.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpermisos_Click(object sender, EventArgs e)
        {
            AdmiPermisos admiPermisos = new AdmiPermisos();
            admiPermisos.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
