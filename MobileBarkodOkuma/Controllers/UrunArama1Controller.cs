using System.Collections.Generic;
using MobileBarkodOkuma.Models;
using System.Web.Mvc;

namespace MobileBarkodOkuma.Controllers
{
    public class UrunArama1Controller : Controller
    {
        // GET: UrunArama1
        public ActionResult Index()
        {
            switch (TempData["BarcodeList"])
            {
                case null:
                    return RedirectToAction("Index", "UrunArama");
                case List<BarcodeViewModel> data:
                    return View(data);
                default:
                    return null;
            }
        }
    }
}