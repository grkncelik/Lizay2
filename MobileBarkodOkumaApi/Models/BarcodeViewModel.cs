using System.ComponentModel;
using Newtonsoft.Json;

namespace MobileBarkodOkuma.Models
{

    public class BarcodeViewModel
    {
        [JsonProperty("ROW")]
        public Row Row { get; set; }
    }

    public class Row
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
    }
}