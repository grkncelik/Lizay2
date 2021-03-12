using MobileBarkodOkuma.Models;
using System;
using System.Drawing;
using System.IO;
using System.Web.Mvc;

namespace MobileBarkodOkuma.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            if (TempData["Barcode"] != null)
            {
                var data = TempData["Barcode"] as BarcodeViewModel;

                return View(data);
            }

            //if (data != null)
            //{
            //    return View(data);
            //}



            return RedirectToAction("Index", "ReadBarcode");
        }


    }
}