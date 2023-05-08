using System;
using System.Collections.Generic;

namespace CodeFirst.Tabele;

public partial class Spotkanie
{
    public int IdSpotkania { get; set; }

    public string Tytuł { get; set; } = null!;

    public DateTime Data { get; set; }

    public string? Opis { get; set; }
}
