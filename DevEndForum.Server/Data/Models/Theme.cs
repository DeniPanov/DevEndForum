namespace DevEndForum.Server.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Theme : BaseInfo
    {
        public Theme()
        {
            this.Opinions = new HashSet<Opinion>();
            this.ReviewCount = 0;
            this.Likes = new HashSet<Like>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ReviewCount { get; set; }

        public int Page { get; set; }

        public User Author { get; set; }

        public int UserId { get; set; }

        public virtual Category Category { get; set; }

        public int CategoryId { get; set; }

        public ICollection<Opinion> Opinions { get; set; }

        public ICollection<Like> Likes { get; set; }
    }
}