using Do_An_KDCLPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Do_An_KDCLPM.Models
{
    public class CartItem
    {
        public products Product { get; set; }
        public int Quantity { get; set; }
    }
}