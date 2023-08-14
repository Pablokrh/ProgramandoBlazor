using System;
using System.Collections.Generic;

namespace ASPNETMVCHDELEON.Models;

public partial class Cerveza
{
    public int CervezaId { get; set; }

    public string Name { get; set; } = null!;

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
