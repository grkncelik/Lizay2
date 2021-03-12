using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Lizay.dll.entity
{

    //public class CategoryViewModel
    //{
    //    [JsonProperty("ROW")]
    //    public List<RowCategories> Category { get; set; }
        
    //}

    public class CategoryViewModel
    {
        [JsonProperty("MATTYPE")]
        public string Value { get; set; }

        [JsonProperty("STEXT")]
        public string Description { get; set; }
    }


    public class DropViewModel
    {
        [JsonProperty("DEGER")]
        public string Value { get; set; }

        [JsonProperty("ACIKLAMASI")]
        public string Description { get; set; }
    }

}
