﻿using OnineStore.Shared.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineStore.Shared.Models.OrderModels
{
    public class OrderProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        
        [ForeignKey("ProductId")]
        public virtual Product  Product { get; set; }
        
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}
