using System.ComponentModel.DataAnnotations;

namespace University_API.Models
{
    public class Chapter : BaseEntity
    {
        [Required]
        public int CourseId { get; set; }

        [Required]
        public virtual Course Course { get; set; } = new Course();

        [Required]
        public string Chapters = string.Empty;
    }
}
