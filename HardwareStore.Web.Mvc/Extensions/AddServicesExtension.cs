namespace HardwareStore.Extensions
{
    using Core.Services;
    using HardwareStore.Core.Contracts;
    using HardwareStore.Infrastructure.Common;

    public static class AddServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IFavoriteService, FavoriteService>();
            services.AddScoped<IShoppingCartService, ShoppingCartService>();
            services.AddScoped<ISessionService, SessionService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IDetailsService, DetailsService>();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(IAuthenticationService).Assembly));

            services.AddControllers();
            services.AddHttpContextAccessor();

            return services;
        }
    }
}
