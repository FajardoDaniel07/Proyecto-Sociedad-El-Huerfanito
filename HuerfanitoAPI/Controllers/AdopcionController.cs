using Conector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HuerfanitoAPI.Controllers
{
    public class AdopcionController : ApiController
    {
        // GET: api/Adopcion
        public IEnumerable<Adopcion> Get()
        {
            using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                return db.Adopcion.ToList();
            }
        }

        // GET: api/Adopcion/5 (adopciones de una mascota)
        public HttpResponseMessage Get(int id)
        {
            using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var lista = db.Adopcion
                    .Where(a => a.id_mascota == id)
                    .ToList();
                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
        }

        // POST: api/Adopcion (realizar adopcion)
        public HttpResponseMessage Post([FromBody] Adopcion obj)
        {
            try
            {
                using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    db.Configuration.ProxyCreationEnabled = false;
                    db.Adopcion.Add(obj);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Adopción registrada.");
                }
            }
            catch (System.Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // PUT: api/Adopcion (cancelar adopcion)
        public HttpResponseMessage Put([FromBody] Adopcion obj)
        {
            try
            {
                using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    db.Configuration.ProxyCreationEnabled = false;
                    var adopcion = db.Adopcion.Find(obj.id_adopcion);
                    if (adopcion == null)
                        return Request.CreateResponse(HttpStatusCode.NotFound, "Adopción no encontrada.");
                    adopcion.estado = "Cancelada";
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Adopción cancelada.");
                }
            }
            catch (System.Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}

