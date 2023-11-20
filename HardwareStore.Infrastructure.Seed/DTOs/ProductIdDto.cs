namespace HardwareStore.Infrastructure.Seed.DTOs
{
    using Newtonsoft.Json;

    public class ProductIdDto
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; } = null!;
    }
}
