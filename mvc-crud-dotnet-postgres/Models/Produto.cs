using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace mvc_crud_dotnet_postgres.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
    }
}
