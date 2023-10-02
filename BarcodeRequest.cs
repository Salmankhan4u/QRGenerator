using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZatcaApi
{
    public class BarcodeRequest
    {
        public string SellerName { get; set; }
        public string TaxNo { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal TaxAmount { get; set; }
    }
}
