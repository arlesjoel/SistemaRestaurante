using DAL;
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

namespace SistemaRestaurante
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void IniciarSesion()
        {
            if (Validate())
            {
                Usuarios User = DAL_LoginUsuario.Login(TxtUsername.Text, DAL_LoginUsuario.Sha256(TxtPassword.Text));
                if (User != null && User.IdUsuario > 0)
                {
                    DAL_LoginUsuario.UserID = User.IdUsuario;
                    FRM_Menu menu = new();
                    menu.Show();
                    this.Hide();
                    return;
                }
                MessageBox.Show("Credenciales Incorrectas");
            }
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(TxtUsername.Text) || string.IsNullOrWhiteSpace(TxtUsername.Text))
            {
                MessageBox.Show("Ingrese el Usuario");
                return false;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text) || string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                MessageBox.Show("Ingrese la contraseña");
                return false;
            }
            return true;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                
                TxtPassword.PasswordChar = '*';
            }
        
        }
    }
}
