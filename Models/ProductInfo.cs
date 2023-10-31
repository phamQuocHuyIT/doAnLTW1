    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace doAnLTW01.Models
{
    public class ProductInfo
    {
        public int proId {  get; set; }
        public string proName { get; set; }
        public float proPrice { get; set; }
        public string cardID { get; set; }
        public string style { get; set; }
    }
}