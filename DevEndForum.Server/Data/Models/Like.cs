namespace DevEndForum.Server.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Like
    {
        [Key]
        public int Id { get; set; }

        public int UpVote { get; set; }

        public int DownVote { get; set; }

        public Theme Theme { get; set; }

        public int ThemeId { get; set; }

        public Opinion Opinion { get; set; }

        public int OpinionId { get; set; }
    }
}
