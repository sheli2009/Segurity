using BL;
using EL;
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
    public partial class Desbloquear : Form
    {
        public Desbloquear()
        {
            InitializeComponent();
        }

        private void DesbloquearUsuario()
        {
            try
            {
               if(!string.IsNullOrEmpty(textBox1.Text)  && !string.IsNullOrEmpty(textBox2.Text))
                {
                    var resultado = (BL_Usuarios.UnlockUser(new Usuarios { Correo = textBox1.Text, Password = BL_Usuarios.Sha256(textBox2.Text) })
                        .ID_Usuario>0) ? "Desbloqueado Correctamente":"No se pudo desbloquear";
                    MessageBox.Show(resultado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo desbloquear","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DesbloquearUsuario();
        }
    }
}
