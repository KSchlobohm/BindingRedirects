using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BindingRedirects.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index(CancellationToken token)
        {
            ViewBag.Title = "Home Page";

            var secretService = new SecretServices.SecretService();
            var connectionString = await secretService.GetSecretForFileServiceAsync(token);

            ViewBag.ConnectionString = connectionString;

            return View();
        }
    }
}
