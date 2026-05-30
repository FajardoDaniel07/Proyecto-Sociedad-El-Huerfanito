using Conector;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HuerfanitoAPI.Controllers
{
    public class TipoMascotaController : ApiController
    {
        // GET: api/TipoMascota
        public IEnumerable<TipoMascota> Get()
        {
            using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                return db.TipoMascota.ToList();
            }
        }

        // GET: api/TipoMascota/5 (mascotas de ese tipo)
        public IEnumerable<Mascota> Get(int id)
        {
            using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                return db.Mascota.Where(m => m.id_tipo == id).ToList();
            }
        }
    }
}