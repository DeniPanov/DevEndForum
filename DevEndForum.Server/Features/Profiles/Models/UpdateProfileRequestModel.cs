namespace DevEndForum.Server.Features.Profiles.Models
{
    using System.ComponentModel.DataAnnotations;
    using DevEndForum.Server.Data.Models;


    public class UpdateProfileRequestModel
    {
        [EmailAddress]
        public string Email { get; set; }

        public string UserName { get; set; }

        public string FurstName { get; set; }

        public string LastName { get; set; }

        public string MainPhotoUrl { get; set; }

        public bool IsPrivate { get; set; }
    }
}