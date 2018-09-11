using System.ComponentModel.DataAnnotations;

namespace AppCgvf.Models
{
    public class Pessoas
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}