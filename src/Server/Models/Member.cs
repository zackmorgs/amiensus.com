using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

    }
}
