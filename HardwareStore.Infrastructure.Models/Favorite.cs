namespace HardwareStore.Infrastructure.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    [Comment("favorite table")]
    public class Favorite
    {
        [Comment("favorite user id")]
        [Required]
        public Guid CustomerId { get; set; }

        [Comment("favorite user")]
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; } = null!;

        [Comment("favorite product id")]
        [Required]
        public Guid ProductId { get; set; }

        [Comment("favorite product")]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}
