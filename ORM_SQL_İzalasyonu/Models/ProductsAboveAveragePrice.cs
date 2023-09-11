using System;
using System.Collections.Generic;

namespace EF2_ORM_SQL_İzalasyonu.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
