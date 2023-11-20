namespace HardwareStore.Core.Contracts
{
    using HardwareStore.Core.ViewModels.Home;

    public interface IHomeService
    {
        Task<HomeViewModel> GetHomeModel();
    }
}
