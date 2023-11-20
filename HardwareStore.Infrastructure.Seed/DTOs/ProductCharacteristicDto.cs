namespace HardwareStore.Infrastructure.Seed.DTOs
{
    using HardwareStore.Infrastructure.DTOs;
    using Newtonsoft.Json;

    public class ProductCharacteristicDto : ProductIdDto
    {
        [JsonProperty("characteristics")]
        public IEnumerable<CharacteristicDto> Characteristics { get; set; } = null!;
    }
}
