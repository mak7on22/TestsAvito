using System.ComponentModel.DataAnnotations;

namespace test.Models.Categors
{
    public class Module
    {
        public int Id { get; set; }
        [Display(Name = "Модуль Категории")]
        [StringLength(25, ErrorMessage = "Название должно быть не более 25 букв")]
        public string? ModuleName { get; set; }
        public int SubcategoryId { get; set; }
        public Subcategory? Subcategories { get; set; }
    }
}
