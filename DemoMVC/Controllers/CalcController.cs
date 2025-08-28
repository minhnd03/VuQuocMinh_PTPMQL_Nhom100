using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CalcViewModel());
        }

        [HttpPost]
        public IActionResult Index(CalcViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            switch (model.Operation)
            {
                case "sum":
                    model.Result = (model.A ?? 0) + (model.B ?? 0);
                    model.Message = "Tổng";
                    break;

                case "diff":
                    model.Result = (model.A ?? 0) - (model.B ?? 0);
                    model.Message = "Hiệu";
                    break;

                case "prod":
                    model.Result = (model.A ?? 0) * (model.B ?? 0);
                    model.Message = "Tích";
                    break;

                case "quot":
                    if (model.B == 0)
                    {
                        ModelState.AddModelError("B", "Không thể chia cho 0");
                        return View(model);
                    }
                    model.Result = (model.A ?? 0) / (model.B ?? 1);
                    model.Message = "Thương";
                    break;

                default:
                    ModelState.AddModelError("Operation", "Phép toán không hợp lệ");
                    break;
            }

            return View(model);
        }
    }
}
