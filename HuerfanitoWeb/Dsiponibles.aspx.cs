using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace HuerfanitoWeb
{
    public class MascotaDisponible
    {
        public int id_mascota { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string raza { get; set; }
        public int? edad_meses { get; set; }
        public string sexo { get; set; }
        public string estado { get; set; }
    }

    public partial class Dsiponibles : System.Web.UI.Page
    {
        string urlAPI = "http://localhost:51813/api/";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CargarDisponibles();
        }

        private void CargarDisponibles()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = urlAPI + "MascotasDisponibles";
                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    var lista = JsonConvert.DeserializeObject<List<MascotaDisponible>>(json);
                    gvDisponibles.DataSource = lista;
                    gvDisponibles.DataBind();
                }
            }
        }
    }
}