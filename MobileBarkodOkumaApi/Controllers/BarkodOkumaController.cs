using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lizay.dll.CaniasWS;
using MobileBarkodOkuma.Models;
using Newtonsoft.Json;

namespace MobileBarkodOkumaApi.Controllers
{
    public class BarkodOkumaController : ApiController
    {
        // GET api/barkodokuma/5
        //http://localhost:58442/Api/barkodokuma/N075086
        //http://178.18.196.230:2020/api/barkodokuma/N075086
        public BarcodeViewModel Get(string id)
        {
            var barcodeModel = new BarcodeViewModel();
            if (string.IsNullOrEmpty(id)) return barcodeModel;

            var sessionId = "";

            var caniasWebService = new iasWebServiceImplService();

            try
            {
                var arg = "IYILMAZ," + id;

                sessionId = caniasWebService.login("00", "T", "NEW", "CANIAS", "LOCALHOST/PR", "WSLIZAY", "ws123lizay");
                var resp = caniasWebService.callIASService(sessionId, "RetailBatchCheck", arg, "STRING", true);

                var json = resp.ToString();
                barcodeModel = JsonConvert.DeserializeObject<BarcodeViewModel>(json);
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



            return barcodeModel;
        }
    }
}
