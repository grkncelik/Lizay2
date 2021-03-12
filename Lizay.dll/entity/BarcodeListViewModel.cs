using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lizay.dll.entity
{
    public class BarcodeListViewModel
    {
        [JsonProperty("ROW_NO")]
        public string RowNo { get; set; }

        [JsonProperty("CLIENT")]
        public string Client { get; set; }

        [JsonProperty("COMPANY")]
        public string Company { get; set; }

        [JsonProperty("PLANT")]
        public string Plant { get; set; }

        [JsonProperty("MATTYPE")]
        public string MatType { get; set; }

        [JsonProperty("MATERIAL")]
        public string Material { get; set; }

        [JsonProperty("SCMADEN")]
        public string ScMaden { get; set; }

        [JsonProperty("SCGRUP")]
        public string ScGrup { get; set; }

        [JsonProperty("SCTEMEL")]
        public string ScTemel { get; set; }

        [JsonProperty("SCDETAY")]
        public string ScDetay { get; set; }

        [JsonProperty("SCURETICI")]
        public string ScUretici { get; set; }

        [JsonProperty("SCAYAR")]
        public string ScAyar { get; set; }

        [JsonProperty("SCRENK")]
        public string ScRenk { get; set; }

        [JsonProperty("WARETEXT")]
        public string WareText { get; set; }

        [JsonProperty("WAREHOUSE")]
        public string WareHouse { get; set; }

        [JsonProperty("STOCKPLACE")]
        public string StockPlace { get; set; }

        [JsonProperty("SPECIALSTOCK")]
        public string SpecialStock { get; set; }

        [JsonProperty("QTY")]
        public string Qty { get; set; }

        [JsonProperty("QTYX")]
        public string QtyX { get; set; }

        [JsonProperty("QUNITX")]
        public string Qunitx { get; set; }

        [JsonProperty("CNT")]
        public string Cnt { get; set; }

        [JsonProperty("SCMADENT")]
        public string ScMadenT { get; set; }

        [JsonProperty("SCTEMELT")]
        public string ScTemelT { get; set; }

        [JsonProperty("SCDETAYT")]
        public string ScDetayT { get; set; }

        [JsonProperty("SCGRUPT")]
        public string ScGrupT { get; set; }

        [JsonProperty("SCAYART")]
        public string ScAyarT { get; set; }

        [JsonProperty("BATCH")]
        public string Batch { get; set; }

        [JsonProperty("PICT")]
        public string Pict { get; set; }

        [JsonProperty("ISTP")]
        public string Istp { get; set; }

        [JsonProperty("ISSTCK")]
        public string Isstck { get; set; }

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

        [JsonProperty("QUANTITYX")]
        public string QuantityX { get; set; }

        [JsonProperty("LASTPRICE")]
        public string Lastprice { get; set; }

        [JsonProperty("SPRICECURRENCY")]
        public string Spricecurrency { get; set; }

        [JsonProperty("MAMETI")]
        public string Mameti { get; set; }

        [JsonProperty("COSTCURRENCY")]
        public string Costcurrency { get; set; }
    }
}
