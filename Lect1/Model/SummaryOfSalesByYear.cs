﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lect1.Model;

[Keyless]
public partial class SummaryOfSalesByYear
{
    [Column(TypeName = "datetime")]
    public DateTime? ShippedDate { get; set; }

    [Column("OrderID")]
    public int OrderId { get; set; }

    [Column(TypeName = "money")]
    public decimal? Subtotal { get; set; }
}
