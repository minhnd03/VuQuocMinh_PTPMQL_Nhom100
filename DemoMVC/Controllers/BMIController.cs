using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double canNang, double chieuCao)
        {
            if (chieuCao > 0)
            {
                double bmi = canNang / (chieuCao * chieuCao);
                ViewBag.BMI = bmi;

                // Phân loại
                string ketQua;
                if (bmi < 18.5) ketQua = "Gầy";
                else if (bmi < 24.9) ketQua = "Bình thường";
                else if (bmi < 29.9) ketQua = "Thừa cân";
                else ketQua = "Béo phì";

                ViewBag.KetQua = ketQua;
            }
            return View();
        }
    }
}
