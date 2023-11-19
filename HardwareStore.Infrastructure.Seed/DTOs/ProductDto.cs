namespace HardwareStore.Infrastructure.DTOs
{
    using Newtonsoft.Json;

    public class ProductDto
    {
        [JsonProperty("name")]
        public string Name { get; set; } = null!;

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; } = null!;

        [JsonProperty("warranty")]
        public int Warranty { get; set; }

        [JsonProperty("manufacturerId")]
        public int ManufacturerId { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; } = null!;

        [JsonProperty("referenceNumber")]
        public string ReferenceNumber { get; set; } = null!;

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("characteristics")]
        public IEnumerable<CharacteristicDto> Characteristics { get; set; } = null!;
    }
}
