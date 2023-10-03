using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Vertiv.eCommerce.DbFirst;

[Index("CategoryId", Name = "IX_Products_CategoryId")]
public partial class Product
{
    [Key]
    public int ProductId { get; set; }

    [StringLength(100)]
    public string ProductName { get; set; } = null!;

    public double UnitPrice { get; set; }

    [StringLength(500)]
    public string Description { get; set; } = null!;

    public DateTime ManufacturingDate { get; set; }

    [StringLength(100)]
    public string MadeIn { get; set; } = null!;

    [StringLength(50)]
    public string ShoeType { get; set; } = null!;

    [StringLength(15)]
    public string Gender { get; set; } = null!;

    [StringLength(50)]
    public string WarrantyPeriod { get; set; } = null!;

    [StringLength(100)]
    public string ReturnPolicy { get; set; } = null!;

    public int Quantity { get; set; }

    public int Discount { get; set; }

    [StringLength(500)]
    public string? Picture { get; set; }

    public int CategoryId { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

    [ForeignKey("CategoryId")]
    [InverseProperty("Products")]
    public virtual Category Category { get; set; } = null!;
}
