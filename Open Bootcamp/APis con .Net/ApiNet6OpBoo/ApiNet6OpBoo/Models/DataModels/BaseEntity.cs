namespace ApiNet6OpBoo.Models.DataModels
{

    using System.ComponentModel.DataAnnotations;

    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; }=string.Empty;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }
        //Con el ? se hace opcional
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
