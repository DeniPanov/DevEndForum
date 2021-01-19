namespace DevEndForum.Server.Data.Models
{
    using System;

    public abstract class BaseInfo 
    {
        public BaseInfo()
        {
            this.CreatedOn = DateTime.UtcNow;

            this.IsDeleted = false;
            this.IsModified = false;
        }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsModified { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime CreatedOn { get; set; } 
    }
}
