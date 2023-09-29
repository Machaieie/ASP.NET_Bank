using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Models.Pessoa
{
    [Table("Person")]
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string titular { get; set; }
        public string email { get; set; }
        public int numeroDaCOnta { get; set; }

    }
}
