using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Vertiv.eCommerce.DbFirst;

[Keyless]
public partial class CategoryWiseProduct
{
    [StringLength(100)]
    public string ProductName { get; set; } = null!;

    public double UnitPrice { get; set; }

    public double TotalPrice { get; set; }

    [StringLength(100)]
    public string CategoryName { get; set; } = null!;
}
