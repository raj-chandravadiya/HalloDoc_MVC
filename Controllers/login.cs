using Microsoft.AspNetCore.Mvc;

namespace HalloDocMVC.Controllers
{
    public class login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login_page()
        {
            return View();
        }
        public IActionResult forgot_password()
        {
            return View();
        }
    }
}
