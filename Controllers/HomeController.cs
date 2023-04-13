using Microsoft.AspNetCore.Mvc;
using RenderViewToStringSample.Models;
using RenderViewToStringSample.Services;

namespace RenderViewToStringSample.Controllers
{
    public class HomeController : Controller
    {
        #region Ctor

        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> RenderView()
        {
            var emailModel = new EmailViewModel
            {
                Title = "Email template title",
                Content = "Email template main content"
            };

            var result = await _userService.SendEmail(emailModel);

            return Content(result);
        }
    }
}