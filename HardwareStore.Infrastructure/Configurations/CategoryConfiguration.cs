namespace HardwareStore.Infrastructure.Configurations
{
    using HardwareStore.Infrastructure.DTOs;
    using HardwareStore.Infrastructure.Models;
    using HardwareStore.Infrastructure.Seed;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GetCategories());
        }

        public IEnumerable<Category> GetCategories()
        {
            var categoriesFiles = FileReader.GetFilesNames("categories.json");
            var data = new List<Category>();

            foreach (var file in categoriesFiles)
            {
                var categoriesDtos = FileReader.LoadJson<CategoryDto>(file);

                var categories = categoriesDtos
                    .Select((c, i) => new Category
                    {
                        Id = i + 1,
                        Name = c.Name
                    });

                data.AddRange(categories);
            }

            return data;
        }
    }
}
