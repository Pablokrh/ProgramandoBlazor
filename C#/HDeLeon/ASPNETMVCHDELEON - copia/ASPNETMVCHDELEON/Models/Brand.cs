using MVC.Models;
using System;
using System.Collections.Generic;

namespace ASPNETMVCHDELEON.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Cerveza> Cervezas { get; set; } = new List<Cerveza>();
}
