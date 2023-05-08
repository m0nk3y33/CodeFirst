using System;
using System.Collections.Generic;

namespace CodeFirst.Tabele;

public partial class KlientNieruchomosc
{
    public int IdKlientnier { get; set; }

    public int IdNieruchomosci { get; set; }

    public int IdKlienta { get; set; }

    public int Typ { get; set; }

    public virtual Klient IdKlientaNavigation { get; set; } = null!;

    public virtual Nieruchomosci IdNieruchomosciNavigation { get; set; } = null!;
}
