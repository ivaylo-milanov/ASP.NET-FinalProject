namespace HardwareStore.Infrastructure.DTOs
{
    using Newtonsoft.Json;

    public class CharacteristicDto
    {
        [JsonProperty("characteristicNameId")]
        public int CharacteristicNameId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; } = null!;
    }
}
