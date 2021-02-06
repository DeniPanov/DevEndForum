namespace DevEndForum.Server.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;

    public class User : IdentityUser
    {
        public User()
        {
            this.CreatedOn = DateTime.UtcNow;

            this.IsDeleted = false;
            this.IsModified = false;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsModified { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
