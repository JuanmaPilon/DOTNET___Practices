using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarea_01.Models;

namespace Tarea_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private static List<Tarea> tareas = new List<Tarea>
        {
            new Tarea { Id = 1, Nombre = "Tarea 1", Descripcion = "La tarea 1", DuracionHoras = 1, Responsable = "Juansito"},
            new Tarea { Id = 2, Nombre = "Tarea 2", Descripcion = "La tarea 2", DuracionHoras = 2, Responsable = "Pedrito"}
        };
    
    }
}
