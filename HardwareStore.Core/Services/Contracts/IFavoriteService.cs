namespace HardwareStore.Core.Services.Contracts
{
    using HardwareStore.Core.ViewModels.Favorite;

    public interface IFavoriteService
    {
        Task<ICollection<FavoriteExportModel>> GetDatabaseFavoriteAsync(string userId);

        Task<ICollection<FavoriteExportModel>> GetSessionFavoriteAsync(ICollection<string> favorites);

        Task<ICollection<string>> AddToSessionFavoriteAsync(string productId, ICollection<string> favorites);

        Task AddToDatabaseFavoriteAsync(string productId, string userId);

        Task<ICollection<string>> RemoveFromSessionFavoriteAsync(string productId, ICollection<string> favorites);

        Task RemoveFromDatabaseFavoriteAsync(string productId, string userId);
    }
}
