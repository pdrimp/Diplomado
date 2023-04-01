using Diplomado.Shared.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Diplomado.Server.Data
{
	public class PersonasBDContext : DbContext
	{
		public PersonasBDContext(DbContextOptions<PersonasBDContext> options) : base(options)
		{

		}

		public DbSet<Persona> Personas { get; set; }
	}
}
