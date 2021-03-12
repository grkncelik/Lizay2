using Lizay.dll.CaniasWS;
using MobileBarkodOkuma.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MobileBarkodOkuma.Controllers
{
    public class UrunAramaController : Controller
    {
        // GET: UrunArama
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ReadBarcode(string barcodeData)
        {
            if (string.IsNullOrEmpty(barcodeData)) return View("Index");
            if (!ModelState.IsValid) return View("Index");

            var sessionId = "";
            List<BarcodeViewModel> barcode;
            var caniasWebService = new iasWebServiceImplService();

            try
            {
                var arg = "IYILMAZ," + barcodeData;

                sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");
                var resp = caniasWebService.callIASService(sessionId, "RetailBatchCheck", arg, "STRING", true);

                var json = resp.ToString().Replace("[]", "''");
                barcode = JsonConvert.DeserializeObject<List<BarcodeViewModel>>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);

                return View("Index");
            }
            finally
            {
                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }

            if (barcode == null) return View("Index");

            TempData["BarcodeList"] = barcode;


            //return RedirectToAction("Index", "UrunArama1");
            return Json(Url.Action("Index", "UrunArama1"));

        }

        //[HttpPost]
        //public JsonResult AjaxMethod(PersonModel person)
        //{
        //    int personId = person.PersonId;
        //    string name = person.Name;
        //    string gender = person.Gender;
        //    string city = person.City;
        //    return Json(person);
        //}
    }
}