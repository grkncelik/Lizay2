using System;
using System.Web.Mvc;
using Lizay.dll.CaniasWS;
using MobileBarkodOkuma.Models;
using Newtonsoft.Json;

namespace MobileBarkodOkuma.Controllers
{
    public class ReadBarcodeController : Controller
    {
        // GET: ReadBarcode
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
            var barcode = new BarcodeViewModel();
            var caniasWebService = new iasWebServiceImplService();

            try
            {
                var arg = "IYILMAZ," + barcodeData;
                //DR18141
                //N075086

                sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");
                var resp = caniasWebService.callIASService(sessionId, "RetailBatchCheck", arg, "STRING", true);

                var json = resp.ToString();
                barcode = JsonConvert.DeserializeObject<BarcodeViewModel>(json);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (!string.IsNullOrEmpty(sessionId))
                    caniasWebService.logout(sessionId);
            }

            if (barcode == null) return View("Index");

            TempData["Barcode"] = barcode;

            return RedirectToAction("Index", "Product");



        }

        //public JsonResult Scan(HttpPostedFileBase file)
        //{
        //    string barcode = "";
        //    try
        //    {
        //        string path = "";
        //        if (file.ContentLength > 0)
        //        {
        //            var fileName = Path.GetFileName(file.FileName);
        //            path = Path.Combine(Server.MapPath("~/App_Data"), fileName);
        //            file.SaveAs(path);
        //        }

        //        // Now we try to read the barcode
        //        // Instantiate BarCodeReader object
        //        BarCodeReader reader = new BarCodeReader(path, DecodeType.Code39Standard);
        //        System.Drawing.Image img = System.Drawing.Image.FromFile(path);
        //        System.Diagnostics.Debug.WriteLine("Width:" + img.Width + " - Height:" + img.Height);

        //        try
        //        {
        //            // read Code39 bar code
        //            while (reader.Read())
        //            {

        //                // detect bar code orientation
        //                ViewBag.Title = reader.GetCodeText();
        //                barcode = reader.GetCodeText();
        //            }
        //            reader.Close();
        //        }

        //        catch (Exception exp)
        //        {

        //            System.Console.Write(exp.Message);
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Title = ex.Message;
        //    }
        //    return Json(barcode);


        //}
    }
}