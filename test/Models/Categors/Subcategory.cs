using System.ComponentModel.DataAnnotations;

namespace test.Models.Categors
{
    public class Subcategory
    {
        public int Id { get; set; }
        [Display(Name = "Под-Категория")]
        [StringLength(25, ErrorMessage = "Название должно быть не более 25 букв")]
        public string? SubcategoryName { get; set; }
        public int СategoryId { get; set; }
        public Category? Categorys { get; set; }
        public List<Module>? Moduls { get; set; }
    }
}
