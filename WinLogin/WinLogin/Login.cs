using BL;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }
        private void validarCampos()
        {
            try
            {
                if (string.IsNullOrEmpty(txtUser.Text))
                {
                    MessageBox.Show("Ingresar Usuario");
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Ingresar Contraseña");
                    return;
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                validarCampos();
                var Password = BL_Usuarios.Sha256(txtPassword.Text);
                var Login = BL_Usuarios.Login(txtUser.Text, Password);
                if (Login)
                {
                    Menu menuform = new Menu();
                    menuform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Registro registroform = new Registro();

            registroform.Show();
            this.Hide();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDesbloquearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Desbloquear debl= new Desbloquear();
            debl.ShowDialog();
        }
    }
}
