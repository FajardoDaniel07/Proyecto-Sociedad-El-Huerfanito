using Conector;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HuerfanitoAPI.Controllers
{
    public class LoginController : ApiController
    {
        // POST: api/Login
        public HttpResponseMessage Post([FromBody] Usuario obj)
        {
            using (SociedadElHuerfanitoEntities db = new SociedadElHuerfanitoEntities())
            {
                var usuario = db.Usuario
                    .Where(u => u.username == obj.username
                             && u.password_hash == obj.password_hash)
                    .Select(u => new {
                        u.id_usuario,
                        u.username,
                        u.id_rol,
                        nombreRol = u.Rol.nombre
                    })
                    .FirstOrDefault();

                if (usuario == null)
                    return Request.CreateResponse(HttpStatusCode.Unauthorized,
                        "Usuario o contraseña incorrectos.");

                return Request.CreateResponse(HttpStatusCode.OK, usuario);
            }
        }
    }
}
