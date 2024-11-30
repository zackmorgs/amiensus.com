using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        public string HTMLContent { get; set; } // HTML string for the blog content
    }
}
