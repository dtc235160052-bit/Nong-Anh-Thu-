using System.ComponentModel.DataAnnotations;

namespace D3NongAnhThu.Models

{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm là bắt buộc ")]
        [StringLength(100, ErrorMessage = "Tên sản phẩm không được vượt quá 100 ký tự")]
        [Display(Name = "Tên sản phẩm ")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mô tả không được vượt quá 500 ký tự")]
        [StringLength(500, ErrorMessage = "Mô tả danh mục không vượt quá 600 kí tự")]
        [Display(Name = "Mô tả")]
        public string Description { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
