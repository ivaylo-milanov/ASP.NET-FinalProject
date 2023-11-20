namespace HardwareStore.Infrastructure.Configurations
{
    using HardwareStore.Infrastructure.Models;
    using HardwareStore.Infrastructure.Seed;
    using HardwareStore.Infrastructure.Seed.DTOs;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CharacteristicConfiguraion : IEntityTypeConfiguration<Characteristic>
    {
        public void Configure(EntityTypeBuilder<Characteristic> builder)
        {
            builder.ToTable("Characteristics");

            builder
                .HasKey(c => new { c.ProductId, c.CharacteristicNameId });

            builder
                .HasOne(f => f.Product)
                .WithMany(p => p.Characteristics)
                .HasForeignKey(f => f.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(f => f.CharacteristicName)
                .WithMany(p => p.Characteristics)
                .HasForeignKey(f => f.CharacteristicNameId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(GetCharacteristics());
        }

        public IEnumerable<Characteristic> GetCharacteristics()
        {
            var productFiles = FileReader.GetFilesNames("*-products.json");
            var data = new List<Characteristic>();

            foreach (var file in productFiles)
            {
                var productDtos = FileReader.LoadJson<ProductCharacteristicDto>(file);
                var characteristics = GetProductCharacteristics(productDtos);

                data.AddRange(characteristics);
            }

            return data;
        }

        private IEnumerable<Characteristic> GetProductCharacteristics(IEnumerable<ProductCharacteristicDto> productCharacteristicsDtos)
        {
            var data = new List<Characteristic>();

            foreach (var dto in productCharacteristicsDtos)
            {
                var characteristics = dto.Characteristics
                    .Select(chr => new Characteristic
                    {
                        ProductId = Guid.Parse(dto.ProductId),
                        Value = chr.Value,
                        CharacteristicNameId = chr.CharacteristicNameId
                    });

                data.AddRange(characteristics);
            }

            return data;
        }
    }
}
