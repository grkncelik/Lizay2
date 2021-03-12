using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lizay.dll.entity
{
    public class BarcodeViewModel
    {
        [JsonProperty("BARKOD")]
        public string Barcode { get; set; }

        [JsonProperty("PICTURE")]
        public string Picture { get; set; }

        [JsonProperty("LASTPRICE")]
        public string Lastprice { get; set; }

        [JsonProperty("SPRICECURRENCY")]
        public string Spricecurrency { get; set; }

        [JsonProperty("MAMETI")]
        public string Mameti { get; set; }

        [JsonProperty("ORAN")]
        public string Oran { get; set; }

        [JsonProperty("COSTCURRENCY")]
        public string Costcurrency { get; set; }

        [JsonProperty("QUANTITYX")]
        public string QuantityX { get; set; }

        [JsonProperty("ISTP")]
        public string IsTp { get; set; }

        [JsonProperty("ISSTCK")]
        public string IsStck { get; set; }

        [JsonProperty("ISWARE")]
        public string IsWare { get; set; }

        [JsonProperty("ISMATTEXT")]
        public string IsMatText { get; set; }

        [JsonProperty("ISMATGRP")]
        public string IsMatGrp { get; set; }

        [JsonProperty("ISTASDET")]
        public string IsTasDet { get; set; }

        [JsonProperty("DETCOLOR")]
        public string DetColor { get; set; }


        [JsonProperty("CAMPAING")]
        public string Campaing { get; set; }

        [JsonProperty("SPRICE")]
        public string Sprice { get; set; }


        
    }
}
