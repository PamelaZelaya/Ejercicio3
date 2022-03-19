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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        BaseUsuario baseUsuario = new BaseUsuario();
        string operacion = string.Empty;
        Usuario User = new Usuario();


        private void ListarUsuario()
        {
            dataGridView1.DataSource = baseUsuario.Listado();
         }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void HabilitarControles()
        {
           Nombre_textBox.Enabled = true;
           Contra_textBox.Enabled = true;


           Nuevo_button.Enabled = false;
           Añadir_button.Enabled = true;
            Eliminar_button.Enabled = true;
           Sal_button.Enabled = true;

        }

        private void DesabilitarControles()
        {
            Nombre_textBox.Enabled = false;
            Contra_textBox.Enabled = false;


            Nuevo_button.Enabled = true;
            Añadir_button.Enabled = false;
            Eliminar_button.Enabled = false;
            Sal_button.Enabled = false;


        }

        private void LimpiarControles()
        {
            Nombre_textBox.Clear();
            Contra_textBox.Text = string.Empty;

        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           dataGridView1.DataSource =baseUsuario.Listado();

        }

        private void Añadir_button_Click(object sender, EventArgs e)
        {
            User.NombreUsuario = Nombre_textBox.Text;
            User.Clave = Contra_textBox.Text;

            if (operacion == "Nuevo")
            {
                bool inserto = BaseUsuario.Nuevo(User);

                if (inserto)
                {
                    MessageBox.Show("Usuario Creado");
                    ListarUsuario();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Crear");
                }
            }
          
        }

        private void Sal_button_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = baseUsuario.EliminarUsuario(dataGridView1.CurrentRow.Cells["NombreUsuario"].Value.ToString());
                if (elimino)
                {
                    MessageBox.Show("Usuario Eliminado");
                    ListarUsuario();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Eliminar");
                }

            }
        }
    }
}



