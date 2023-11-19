namespace HardwareStore.Infrastructure.Configurations
{
    using HardwareStore.Infrastructure.DTOs;
    using HardwareStore.Infrastructure.Models;
    using HardwareStore.Infrastructure.Seed;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CharacteristicNameConfiguration : IEntityTypeConfiguration<CharacteristicName>
    {
        public void Configure(EntityTypeBuilder<CharacteristicName> builder)
        {
            builder.HasData(GetCharacteristicNames());
        }

        private IEnumerable<CharacteristicName> GetCharacteristicNames()
        {
            var characteristicsNamesFiles = FileReader.GetFilesNames("characteristics-names.json");
            var data = new List<CharacteristicName>();

            foreach (var file in characteristicsNamesFiles)
            {
                var characteristicsNamesDtos = FileReader.LoadJson<CharacteristicNameDto>(file);

                var characteristicsNames = characteristicsNamesDtos
                    .Select((chn, i) => new CharacteristicName
                    {
                        Id = i + 1,
                        Name = chn.Name
                    });

                data.AddRange(characteristicsNames);
            }

            return data;
        }
    }
}
