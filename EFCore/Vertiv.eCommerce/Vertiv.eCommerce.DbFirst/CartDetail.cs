using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Vertiv.eCommerce.DbFirst;

[Index("CartId", Name = "IX_CartDetails_CartId")]
[Index("ProductId", Name = "IX_CartDetails_ProductId")]
public partial class CartDetail
{
    [Key]
    public int CartDetailsId { get; set; }

    public int CartId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public int Size { get; set; }

    [ForeignKey("CartId")]
    [InverseProperty("CartDetails")]
    public virtual Cart Cart { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("CartDetails")]
    public virtual Product Product { get; set; } = null!;
}
