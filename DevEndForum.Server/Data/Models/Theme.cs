namespace DevEndForum.Server.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Theme
    {
        [Key]
        public int Id { get; set; }

        public virtual Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}