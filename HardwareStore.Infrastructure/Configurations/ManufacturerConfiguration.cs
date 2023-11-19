namespace HardwareStore.Infrastructure.Configurations
{
    using HardwareStore.Infrastructure.DTOs;
    using HardwareStore.Infrastructure.Models;
    using HardwareStore.Infrastructure.Seed;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.HasData(GetManufacturers());
        }

        private IEnumerable<Manufacturer> GetManufacturers()
        {
            var manufacturersFiles = FileReader.GetFilesNames("manufacturers.json");
            var data = new List<Manufacturer>();

            foreach (var file in manufacturersFiles)
            {
                var manufacturersDtos = FileReader.LoadJson<ManufacturerDto>(file);

                var manufacturers = manufacturersDtos
                    .Select((m, i) => new Manufacturer
                    {
                        Id = i + 1,
                        Name = m.Name
                    });

                data.AddRange(manufacturers);
            }

            return data;
        }
    }
}
