using System;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        public string HTMLContent { get; set; } // HTML string for the blog content

        [Required]
        public DateTime PublishDate { get; set; } = DateTime.UtcNow;

        [StringLength(100)]
        public string Author { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; } // Optional: URL to a featured image

        public string Tags { get; set; } // Comma-separated tags

        public bool IsPublished { get; set; } = false; // Draft or Published
    }
}
