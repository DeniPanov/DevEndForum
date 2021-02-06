namespace DevEndForum.Server.Features.Profiles
{
    using System.Linq;
    using System.Threading.Tasks;
    using DevEndForum.Server.Data;
    using DevEndForum.Server.Data.Models;
    using Infrastructure.Services;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class ProfileService : IProfileService
    {
        private readonly DevEndDbContext data;

        public ProfileService(DevEndDbContext data) => this.data = data;

        public async Task<ProfileServiceModel> ByUser(string userId, bool allInformation = false)
            => await this.data
                .Users
                .Where(u => u.Id == userId)
                .Select(u => allInformation
                    ? new PublicProfileServiceModel
                    {
                        FurstName = u.FirstName,
                        LastName = u.LastName,
                        IsDeleted = u.IsDeleted
                    }
                    : new ProfileServiceModel
                    {
                        FurstName = u.FirstName,
                        LastName = u.LastName,
                        IsDeleted = u.IsDeleted
                    })
                .FirstOrDefaultAsync();

        public async Task<Result> Update(
            string userId,
            string email,
            string userName,
            string furstName,
            string lastName,
            string mainPhotoUrl,
            bool isPrivate)
        {
            var user = await this.data
                .Users
                .FirstOrDefaultAsync(p => p.Id == userId);

            if (user == null)
            {
                return "User does not exist.";
            }


            var result = await this.ChangeEmail(user, userId, email);
            if (result.Failure)
            {
                return result;
            }

            result = await this.ChangeUserName(user, userId, email);
            if (result.Failure)
            {
                return result;
            }

            await this.data.SaveChangesAsync();

            return true;
        }

        public async Task<bool> IsDeleted(string userId)
            => await this.data
                .Users
                .Where(p => p.Id == userId)
                .Select(p => !p.IsDeleted)
                .FirstOrDefaultAsync();

        private async Task<Result> ChangeEmail(User user, string userId, string email)
        {
            if (!string.IsNullOrWhiteSpace(email) && user.Email != email)
            {
                var emailExists = await this.data
                    .Users
                    .AnyAsync(u => u.Id != userId && u.Email == email);

                if (emailExists)
                {
                    return "The provided e-mail is already taken.";
                }

                user.Email = email;
            }

            return true;
        }

        private async Task<Result> ChangeUserName(User user, string userId, string userName)
        {
            if (!string.IsNullOrWhiteSpace(userName) && user.UserName != userName)
            {
                var userNameExists = await this.data
                    .Users
                    .AnyAsync(u => u.Id != userId && u.UserName == userName);

                if (userNameExists)
                {
                    return "The provided user name is already taken.";
                }

                user.UserName = userName;
            }

            return true;
        }

    }
}