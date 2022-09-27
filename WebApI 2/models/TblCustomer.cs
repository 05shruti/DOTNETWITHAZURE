using System;
using System.Collections.Generic;

#nullable disable

namespace WebApI_2.models
{
    public partial class TblCustomer
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public decimal? CustomerAmount { get; set; }
    }
}
