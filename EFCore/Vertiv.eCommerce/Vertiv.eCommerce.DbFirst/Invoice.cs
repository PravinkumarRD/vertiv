using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Vertiv.eCommerce.DbFirst;

[Index("CartId", Name = "IX_Invoices_CartId", IsUnique = true)]
public partial class Invoice
{
    [Key]
    public int InvoiceId { get; set; }

    public int CartId { get; set; }

    public DateTime InvoiceDate { get; set; }

    [ForeignKey("CartId")]
    [InverseProperty("Invoice")]
    public virtual Cart Cart { get; set; } = null!;
}
