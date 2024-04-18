using Microsoft.AspNetCore.Mvc;
using PortafolioCursoDef.Models;
using System.Diagnostics;

namespace PortafolioCursoDef.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private new List<Proyecto> ObtenerProyectos()
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
