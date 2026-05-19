using ApiAwsPersonajes.Models;
using ApiAwsPersonajes.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAwsPersonajes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private RepositoryTelevision repo;
        public PersonajesController(RepositoryTelevision repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<Personaje>>> GetPersonajes()
        {
            return Ok(await this.repo.GetPersonajesAsync());
        }
        [HttpPost]
        public async Task<ActionResult> CreatePersonaje(Personaje personaje)
        {
            await this.repo.CreatePersonajeAsync(personaje.Nombre, personaje.Imagen);
           return Ok();
        }

    }
}
