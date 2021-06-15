using System.Threading.Tasks;
using BlazorWithIdentity.Shared;
using BlazorWithIdentity.Shared.Models;


namespace BlazorWithIdentity.Client.Services
{
    public interface IAuthServices
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
