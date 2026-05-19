using ApiAwsPersonajes.Data;
using ApiAwsPersonajes.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAwsPersonajes.Repositories
{
    public class RepositoryTelevision
    {
        private TelevisioContext context;
        public RepositoryTelevision(TelevisioContext context)
        {
            this.context = context;

        }
        public async Task<List<Personaje>> GetPersonajesAsync()
        {
            return await this.context.Personajes.ToListAsync();

        }
        private async Task<int> GetMaxIdPersonajeAsync()
        {
            return await this.context.Personajes.MaxAsync(x => x.Id) + 1;
        }
        public async Task CreatePersonajeAsync(string nombre,string imagen)
        {
            Personaje p = new Personaje();
            p.Id = await this.GetMaxIdPersonajeAsync();
            p.Nombre = nombre;
            p.Imagen = imagen;
            await this.context.Personajes.AddAsync(p);
            await this.context.SaveChangesAsync();
        }


    }
}
