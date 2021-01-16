namespace DevEndForum.Server.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category : BaseInfo
    {
        public Category()
        {
            this.Themes = new HashSet<Theme>();

            this.ThemesCount = 0;
            this.OpinionsCount = 0;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Img { get; set; }

        public int ThemesCount { get; set; }

        public int OpinionsCount { get; set; }

        public virtual ICollection<Theme> Themes { get; set; }
    }
}
