using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace HuerfanitoWeb
{
    public class TipoMascota
    {
        public int id_tipo { get; set; }
        public string nombre { get; set; }
    }

    public partial class MaestroDetal : System.Web.UI.Page
    {
        string urlAPI = "http://localhost:51813/api/";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CargarTipos();
        }

        private void CargarTipos()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(urlAPI + "TipoMascota").Result;
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    var lista = JsonConvert.DeserializeObject<List<TipoMascota>>(json);
                    lbTipos.DataSource = lista;
                    lbTipos.DataTextField = "nombre";
                    lbTipos.DataValueField = "id_tipo";
                    lbTipos.DataBind();
                }
            }
        }

        protected void lbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idTipo = int.Parse(lbTipos.SelectedValue);

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(urlAPI + "TipoMascota/" + idTipo).Result;
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    var lista = JsonConvert.DeserializeObject<List<MascotaWeb>>(json);
                    gvDetalle.DataSource = lista;
                    gvDetalle.DataBind();
                }
            }
        }
    }
}