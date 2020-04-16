namespace Web.Shop.Helpers
{
    
    using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Web.Shop.Data.Entities;

    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);

    }
}
