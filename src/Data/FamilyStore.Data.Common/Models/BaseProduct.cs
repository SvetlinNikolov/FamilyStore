namespace FamilyStore.Data.Common.Models
{
    using System.ComponentModel.DataAnnotations;

    using FamilyStore.Data.Common.Enums;

    public class BaseProduct : BaseModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        public ProductCategory ProductCategory { get; set; }

        [Required]
        public decimal Price { get; set; }

        public bool InStock { get; set; }
    }
}
