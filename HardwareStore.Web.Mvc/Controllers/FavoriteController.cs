namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Services.Contracts;
    using HardwareStore.Core.ViewModels.Favorite;
    using HardwareStore.Extensions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    public class FavoriteController : Controller
    {
        private readonly IFavoriteService favoriteService;
        private readonly ILogger<FavoriteController> logger;

        public FavoriteController(IFavoriteService favoriteService, ILogger<FavoriteController> logger)
        {
            this.favoriteService = favoriteService;
            this.logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            ICollection<FavoriteExportModel> favorites;
            try
            {
                if (User?.Identity?.IsAuthenticated ?? false)
                {
                    favorites = await this.favoriteService.GetDatabaseFavoriteAsync(User.GetUserId());
                }
                else
                {
                    favorites = await this.favoriteService.GetSessionFavoriteAsync(GetFavorites());
                }
            }
            catch (ArgumentNullException ex)
            {
                this.logger.LogError(ex, ex.Message);
                return RedirectToAction("Error", "Home", new { message = ex.Message });
            }

            return View(favorites);
        }

        public async Task<IActionResult> AddToFavorite([FromBody] string productId)
        {
            try
            {
                if (User?.Identity?.IsAuthenticated ?? false)
                {
                    await this.favoriteService.AddToDatabaseFavoriteAsync(productId, User.GetUserId());
                }
                else
                {
                    var favorites = await this.favoriteService.AddToSessionFavoriteAsync(productId, GetFavorites());
                    SetFavorites(favorites);
                }
            }
            catch (ArgumentNullException ex)
            {
                this.logger.LogError(ex, ex.Message);
                return RedirectToAction("Error", "Home", new { message = ex.Message });
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> RemoveFromFavorite([FromBody] string productId)
        {
            try
            {
                if (User?.Identity?.IsAuthenticated ?? false)
                {
                    await this.favoriteService.RemoveFromDatabaseFavoriteAsync(productId, User.GetUserId());
                }
                else
                {
                    var favorites = await this.favoriteService.RemoveFromSessionFavoriteAsync(productId, GetFavorites());
                    SetFavorites(favorites);
                }
            }
            catch (ArgumentNullException ex)
            {
                this.logger.LogError(ex, ex.Message);
                return RedirectToAction("Error", "Home", new { message = ex.Message });
            }
            return RedirectToAction(nameof(Index));
        }

        private void SetFavorites(ICollection<string> favorites)
            => HttpContext.Session.Set("Favorite", favorites);

        private ICollection<string> GetFavorites()
            => HttpContext.Session.Get<ICollection<string>>("Favorite") ?? new List<string>();
    }
}