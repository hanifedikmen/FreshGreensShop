using System.Web.Mvc;

namespace FreshGreensShop.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductDetail()
        {
            return View();
        }
    }
}