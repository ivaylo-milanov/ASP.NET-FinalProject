namespace HardwareStore.Core.ViewModels.Favorite
{
    public class FavoriteExportModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
