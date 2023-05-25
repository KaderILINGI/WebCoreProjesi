using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCoreProjesi.Models.Entitys
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid ID { get; set; }

        [StringLength(30)]
        public string? Name { get; set; }


        [StringLength(30)]
        public string? Surname { get; set; } = null;


        [Required]
        [StringLength(50)]
        public string Email { get; set; }


        [Required]
        [StringLength(30)]
        public string? UserName { get; set; }


        [Required]
        [StringLength(250)]
        public string Password { get; set; }    

        public bool Activate { get; set; }
        public DateTime Tarih { get; set; }

    }
}
