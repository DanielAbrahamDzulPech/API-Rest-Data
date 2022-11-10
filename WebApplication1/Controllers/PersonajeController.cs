using Domain.Modelos;
using WebApplication1.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonajeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonajeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<Response<PersonajeResponse>> CrearPersonaje([FromBody] PersonajeResponse i)
        {
            Personaje pers = new Personaje();

            pers.Nombre = i.Nombre;
            pers.Poder = i.Poder;
            pers.Color = i.Color;
            pers.FkGenero = i.FkGenero;

            var result = _context.personajes.Add(pers);
            await _context.SaveChangesAsync();
            return new Response<PersonajeResponse>(i, "agregado");
        }
    }
}
