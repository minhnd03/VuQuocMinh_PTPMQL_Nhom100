using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class CalcViewModel
    {
        [Display(Name = "Số thứ nhất")]
        [Required(ErrorMessage = "Nhập số thứ nhất")]
        public double? A { get; set; }

        [Display(Name = "Số thứ hai")]
        [Required(ErrorMessage = "Nhập số thứ hai")]
        public double? B { get; set; }

        [Display(Name = "Phép toán")]
        public string Operation { get; set; } = "sum"; 
        public double? Result { get; set; }
        public string? Message { get; set; }
    }
}
