using System;
using System.Collections.Generic;

namespace GestaoPI.Models;

public partial class Revistum
{
    public int Codigo { get; set; }

    public DateOnly Data { get; set; }

    public string DespachoPatentePatenteCodigo { get; set; } = null!;
}
