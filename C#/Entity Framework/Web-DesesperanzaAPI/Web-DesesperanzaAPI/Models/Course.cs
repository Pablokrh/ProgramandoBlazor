using System.ComponentModel.DataAnnotations;

namespace Web_DesesperanzaAPI.Models

{

    public enum Level
    {
        Basic,
        Advanced,
        Medium,
        Expert
    }

    public class Course:BaseEntity
    {
        [Required,StringLength(50)]

        public string Name { get; set; }=String.Empty;

        [Required, StringLength(250)]
        public string ShortDescription { get; set; } = String.Empty;

        [Required]
        public string FullDescription { get; set; } = String.Empty;

        public Level Level { get; set; } = Level.Basic;

        [Required]
        public ICollection<Category> Categories { get; set; }=new List<Category>();


        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();

        [Required]
        public ICollection<Chapter> Chapters { get; set; }=new List<Chapter>();
    }
}
