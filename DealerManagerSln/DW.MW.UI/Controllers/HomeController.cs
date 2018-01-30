using DW.MW.DAL;
using System.Web.Mvc;

namespace DW.MW.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DealerDAL dealerDal = new DealerDAL();
            return View(dealerDal.GetDealers());
        }
    }
}