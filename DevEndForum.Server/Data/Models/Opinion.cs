namespace DevEndForum.Server.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Opinion : BaseInfo
    {
        public Opinion()
        {
            this.Likes = new HashSet<Like>();
        }

        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public User Author { get; set; }

        public int UserId { get; set; }

        public Theme Theme { get; set; }

        public int ThemeId { get; set; }

        public ICollection<Like> Likes { get; set; }

    }
}