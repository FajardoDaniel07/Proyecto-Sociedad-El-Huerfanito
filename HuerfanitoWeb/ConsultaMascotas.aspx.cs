using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace HuerfanitoWeb
{
    public class MascotaWeb
    {
        public int id_mascota { get; set; }
        public string nombre { get; set; }
        public int id_tipo { get; set; }
        public string raza { get; set; }
        public int? edad_meses { get; set; }
        public string sexo { get; set; }
        public string estado { get; set; }
        public List<object> Adopcion { get; set; }
        public object TipoMascota { get; set; }
    }

    public partial class ConsultaMascotas : System.Web.UI.Page
    {
        string urlAPI = "http://localhost:51813/api/";

        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            using (HttpClient client = new HttpClient())
            {
                string url = urlAPI + "Mascota";
                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    //lblError.Text = json;

                    var lista = JsonConvert.DeserializeObject<List<MascotaWeb>>(json);

                    if (!string.IsNullOrEmpty(nombre))
                        lista = lista.FindAll(m => m.nombre.ToLower().Contains(nombre.ToLower()));

                    gvMascotas.DataSource = lista;
                    gvMascotas.DataBind();
                }
                else
                {
                    lblError.Text = "Error: " + response.StatusCode;
                }
            }
        }
    }
}