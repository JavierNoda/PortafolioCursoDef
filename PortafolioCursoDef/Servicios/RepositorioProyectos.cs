using PortafolioCursoDef.Models;

namespace PortafolioCursoDef.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto()
                {
                    Titulo = "Bienes Raíces",
                    Descripcion = "Página de bienes raices con HTML y css",
                    Link = "https://bienes-raices-progcurso.netlify.app",
                    ImagenURL = "/imagenes/proyectosBienesraicesPage.png"
                },

                new Proyecto()
                {
                    Titulo = "Freelancer",
                    Descripcion = "Página de freenlancer con HTML y CSS",
                    Link = "https://freelancer-progcurso.netlify.app",
                    ImagenURL = "/imagenes/proyectosServicioFreelancerPage.png"
                },

                new Proyecto()
                {
                    Titulo = "Blog de Café",
                    Descripcion = "Página Blog de café con HTML y CSS",
                    Link = "https://blog-cafe-progcurso.netlify.app",
                    ImagenURL = "/imagenes/proyectoVentaCafePage.png"
                },

                new Proyecto()
                {
                    Titulo = "GDLCAMP",
                    Descripcion = "Web para evento de desarrollares con HTML y CSS",
                    Link = "https://gdlwebcamp-progcurso.netlify.app",
                    ImagenURL = "/imagenes/proyectoWebCampPage.png"
                }

            };
        }
    }
}
