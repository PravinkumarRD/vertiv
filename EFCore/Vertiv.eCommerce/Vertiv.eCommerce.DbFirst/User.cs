using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Vertiv.eCommerce.DbFirst;

public partial class User
{
    [Key]
    public int UserId { get; set; }

    [StringLength(100)]
    public string Email { get; set; } = null!;

    [StringLength(20)]
    public string Password { get; set; } = null!;

    [StringLength(20)]
    public string? Role { get; set; }
}
