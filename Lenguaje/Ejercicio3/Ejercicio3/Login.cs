using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;



namespace Ejercicio3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Entrar_Button_Click(object sender, EventArgs e)
        {

            BaseUsuario baseUsuario = new BaseUsuario();
            Usuario usuario = new Usuario();

            usuario = baseUsuario.Login(Usuario_textBox.Text, Clave_textBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Los datos son incorrectos");

            }

        }

       


        private void Cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
