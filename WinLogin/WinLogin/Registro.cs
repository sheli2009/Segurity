using BL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLogin
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
        private bool ValidarInsertar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text)) 
            {
                MessageBox.Show("Ingresar Nombre");
                return false;
            }
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Ingresar Correo");
                return false;
            }
            if (string.IsNullOrEmpty(txtLogin.Text)) 
            {
                MessageBox.Show("Ingresar Nombre de Usuario");
                return false;
            }
            if (string.IsNullOrEmpty (txtPassword.Text)) 
            {
                MessageBox.Show("Ingresar Contraseña");
                return false;
            }
            if (string.IsNullOrEmpty(txtPasswordAgain.Text)) 
            {
                MessageBox.Show("Confirmar Contraseña");
                return false;
            }
            if (!(txtPassword.Text == txtPasswordAgain.Text))
            {
                MessageBox.Show("La contraseña no coincide");
                return false;
            }
            return true;
        }
        private bool ContraseñaSegura(string contraseña)
        {
            if (contraseña.Length < 8)
            {
                return false;
            }

            Regex letrasMayusculas = new Regex(@"[A-Z]");
            Regex letrasMinusculas = new Regex(@"[a-z]");
            Regex numeros = new Regex(@"[0-9]");
            Regex caracteresEspeciales = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");

            return letrasMayusculas.IsMatch(contraseña) &&
                   letrasMinusculas.IsMatch(contraseña) &&
                   numeros.IsMatch(contraseña) &&
                   caracteresEspeciales.IsMatch(contraseña);
        }

        private void Guardar()
        {
            try
            {
                string contraseña = txtPassword.Text;

                if (ContraseñaSegura(contraseña))
                {
                    Usuarios usuario = new Usuarios();

                    if (ValidarInsertar())
                    {
                        usuario.Nombre = txtNombre.Text;
                        usuario.Correo = txtCorreo.Text;
                        usuario.Login = txtLogin.Text;
                        usuario.Password = BL_Usuarios.Sha256(contraseña);
                        usuario.Bloqueado = false;
                        usuario.Contador = 0;
                        usuario.UsuarioRegistro = 1;
                        usuario.CambiarPassword = false;

                        var resultado = (BL_Usuarios.Insert(usuario).ID_Usuario > 0)
                            ? "Guardado Correctamente"
                            : "No se pudo guardar";

                        MessageBox.Show(resultado, "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña no cumple con los requisitos mínimos", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
