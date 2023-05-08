using System;
using System.Collections.Generic;

namespace CodeFirst.Tabele;

public partial class Spotkanium
{
    public int IdSpotkan { get; set; }

    public int IdNieruchomosci { get; set; }

    public int IdAgenta { get; set; }

    public int IdKlienta { get; set; }

    public int IdSpotkania { get; set; }

    public virtual Nieruchomosci IdNieruchomosciNavigation { get; set; } = null!;
}
