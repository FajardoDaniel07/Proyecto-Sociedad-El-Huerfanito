using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ElHUerfanitoEscritorio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            string usuario = txUsuario.Text.Trim();
            string clave = txClave.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "http://localhost:51813/api/Login";

                    var body = new
                    {
                        username = usuario,
                        password_hash = clave
                    };

                    string json = JsonConvert.SerializeObject(body);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string resultado = await response.Content.ReadAsStringAsync();
                        dynamic datos = JsonConvert.DeserializeObject(resultado);

                        int idRol = (int)datos.id_rol;
                        string nombreRol = (string)datos.nombreRol;

                        Menu menu = new Menu(idRol, nombreRol);
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la API: " + ex.Message);
            }
        }
    }
}