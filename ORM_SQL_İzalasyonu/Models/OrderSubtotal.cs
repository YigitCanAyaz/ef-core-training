using System;
using System.Collections.Generic;

namespace EF2_ORM_SQL_İzalasyonu.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
