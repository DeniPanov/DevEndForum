namespace DevEndForum.Server.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public abstract class BaseInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool IsDelete { get; set; } = false;

        [Required]
        public DateTime DeleteOn { get; set; } = DateTime.UtcNow;

        [Required]
        public bool IsModifait { get; set; } = false;

        [Required]
        public DateTime ModifaitOn { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime CreateOn { get; set; } = DateTime.UtcNow;
    }
}
