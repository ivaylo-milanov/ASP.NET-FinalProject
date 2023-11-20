namespace HardwareStore.Core.Contracts
{
    using HardwareStore.Core.ViewModels.User;
    using Microsoft.AspNetCore.Identity;

    public interface IAuthenticationService
    {
        Task<SignInResult> LoginAsync(LoginFormModel model);

        Task<IdentityResult> RegisterAsync(RegisterFormModel model);

        Task LogoutAsync();
    }
}
