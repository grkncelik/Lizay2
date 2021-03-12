using System.ComponentModel;
using Newtonsoft.Json;

namespace MobileBarkodOkuma.Models
{

    //public class BarcodeViewModel
    //{
    //    [JsonProperty("ROW")]
    //    public Row Row { get; set; }
    //}

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

    }
}