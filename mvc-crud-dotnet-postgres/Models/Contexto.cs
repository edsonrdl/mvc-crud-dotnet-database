using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace mvc_crud_dotnet_postgres.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
