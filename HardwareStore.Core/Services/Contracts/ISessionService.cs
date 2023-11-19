﻿namespace HardwareStore.Core.Services.Contracts
{
    using HardwareStore.Core.ViewModels.ShoppingCart;

    public interface ISessionService
    {
        Task AddToDatabase(string userId, ICollection<string> favorites, ICollection<ShoppingCartExportModel> cart);
    }
}
