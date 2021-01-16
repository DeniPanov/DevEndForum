namespace DevEndForum.Server.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category : BaseInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Img { get; set; }

        [Required]
        public int ThemesCount { get; set; } = 0;

        [Required]
        public int OpinionsCount { get; set; } = 0;

        public ICollection<Theme> Themes { get; set; } = new List<Theme>();
    }
}
