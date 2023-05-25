using Microsoft.EntityFrameworkCore;

namespace mvc_crud_dotnet_sql.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public  DbSet<Produto> Produto { get; set; }
    }
}
