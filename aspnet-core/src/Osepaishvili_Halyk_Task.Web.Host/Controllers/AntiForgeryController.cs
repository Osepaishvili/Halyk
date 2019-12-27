using Microsoft.AspNetCore.Antiforgery;
using Osepaishvili_Halyk_Task.Controllers;

namespace Osepaishvili_Halyk_Task.Web.Host.Controllers
{
    public class AntiForgeryController : Osepaishvili_Halyk_TaskControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
