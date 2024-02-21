using DataFarmacia.Entidades;
using FarmaciaPantallas;
using Newtonsoft.Json;
using PantallaFarmacia.HTTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaFarmacia
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private async void btn_Entrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txt_usuario.Text;
            string contraseña = txt_xontraseña.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese nombre de usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await RevisarCredencialesAsync(nombreUsuario, contraseña);
        }

        private async Task RevisarCredencialesAsync(string nombre, string contraseña)
        {
            string url = string.Format("https://localhost:7050/api/Usuario");
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Usuario>>(result);

            foreach (Usuario usuario in lst)
            {
                if (usuario.Nombre == nombre && usuario.Contraseña == contraseña)
                {

                    Form1 formPrincipal = new Form1();  // Reemplaza Form1 con el nombre correcto de tu formulario principal                    
                    formPrincipal.Show();  // O formPrincipal.Show() si no quieres que sea modal
                    this.Hide();
                    return;
                }
            }

            // Si llega aquí, las credenciales no son válidas
            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
