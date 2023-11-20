namespace HardwareStore.Core.Contracts
{
    using HardwareStore.Core.ViewModels.Order;

    public interface IOrderService
    {
        Task<IEnumerable<OrderViewModel>> GetUserOrders(string userId);

        Task<OrderFormModel> GetOrderModel(string userId);

        Task OrderAsync(OrderFormModel model, string userId);
    }
}
