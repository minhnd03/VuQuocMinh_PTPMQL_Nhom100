using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class BMIModel
    {
        [Required(ErrorMessage = "Vui lòng nhập cân nặng")]
        [Range(1, 500, ErrorMessage = "Cân nặng phải hợp lý")]
        public double CanNang { get; set; } 

        [Required(ErrorMessage = "Vui lòng nhập chiều cao")]
        [Range(0.5, 3, ErrorMessage = "Chiều cao phải hợp lý (m)")]
        public double ChieuCao { get; set; } 

        public double KetQua { get; set; } 
        public string DanhGia { get; set; } 
    }
}
