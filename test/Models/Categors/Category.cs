using System.ComponentModel.DataAnnotations;

namespace test.Models.Categors
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Категория")]
        [StringLength(25, ErrorMessage = "Название должно быть не более 25 букв")]
        public string? CategoryName { get; set; }
        public List<Subcategory>? Subcategories { get; set; }
    }
}
