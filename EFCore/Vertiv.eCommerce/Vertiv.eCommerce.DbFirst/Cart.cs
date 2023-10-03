using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Vertiv.eCommerce.DbFirst;

[Index("CustomerId", Name = "IX_Carts_CustomerId")]
public partial class Cart
{
    [Key]
    public int CartId { get; set; }

    public int CustomerId { get; set; }

    public DateTime CartDate { get; set; }

    [InverseProperty("Cart")]
    public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

    [ForeignKey("CustomerId")]
    [InverseProperty("Carts")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("Cart")]
    public virtual Invoice? Invoice { get; set; }
}
