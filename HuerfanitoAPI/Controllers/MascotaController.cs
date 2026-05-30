using Conector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HuerfanitoAPI.Controllers
{
    public class MascotaController : ApiController
    {
        // GET: api/Mascota
        public IEnumerable<Mascota> Get()
        {
            using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                return db.Mascota.ToList();
            }
        }

        // GET: api/Mascota/5
        public HttpResponseMessage Get(int id)
        {
            using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                Mascota m = db.Mascota.Find(id);
                if (m == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Mascota no encontrada");
                return Request.CreateResponse(HttpStatusCode.OK, m);
            }
        }

        // POST: api/Mascota
        public HttpResponseMessage Post([FromBody] Mascota obj)
        {
            int resp = 0;
            try
            {
                using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
                {
                    db.Entry(obj).State = EntityState.Added;
                    resp = db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, resp);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // PUT: api/Mascota/5
        public HttpResponseMessage Put([FromBody] Mascota obj)
        {
            int resp = 0;
            try
            {
                using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
                {
                    db.Entry(obj).State = EntityState.Modified;
                    resp = db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, resp);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        // GET: api/MascotasDisponibles
        [HttpGet]
        [Route("api/MascotasDisponibles")]
        public IEnumerable<vw_MascotasDisponibles> GetDisponibles()
        {
            using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                return db.vw_MascotasDisponibles.ToList();
            }
        }

        // DELETE: api/Mascota/5
        public HttpResponseMessage Delete([FromBody] Mascota obj)
        {
            int resp = 0;
            try
            {
                using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
                {
                    db.Entry(obj).State = EntityState.Deleted;
                    resp = db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, resp);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}