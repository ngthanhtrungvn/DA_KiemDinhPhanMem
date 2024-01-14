using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Do_An_KDCLPM.Models
{
    public class productdetail
    {
        public products product { get; set; }
        public List<products> lstProducts_Categories { get; set; }
    }
}