namespace DevEndForum.Server.Features.Profiles
{
    using System.Threading.Tasks;
    using Infrastructure.Services;
    using Models;

    public interface IProfileService
    {
        Task<ProfileServiceModel> ByUser(string userId, bool allInformation = false);

        Task<Result> Update(
            string userId,
            string email,
            string userName,
            string furstName,
            string lastName,
            string mainPhotoUrl,
            bool isPrivate);

        Task<bool> IsDeleted(string userId);
    }
}