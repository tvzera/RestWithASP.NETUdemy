using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETErudio.Controllers.Model
{
    [Table("books")]
    public class Books
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("author")]
        public string Autor { get; set; }

        [Column("launch_date")]
        public DateTime Data { get; set; }

        [Column("price")]
        public decimal Preco { get; set; }

        [Column("title")]
        public string Titulo { get; set; }
    }
}
