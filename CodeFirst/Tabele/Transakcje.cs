using System;
using System.Collections.Generic;

namespace CodeFirst.Tabele;

public partial class Transakcje
{
    public int IdTransakcji { get; set; }

    public int IdNieruchomosci { get; set; }

    public int IdAgenta { get; set; }

    public int IdKlienta { get; set; }

    public int Typ { get; set; }

    public string Opis { get; set; } = null!;

    public string? DodatkoweInfo { get; set; }

    public virtual Agent IdAgentaNavigation { get; set; } = null!;

    public virtual Klient IdKlientaNavigation { get; set; } = null!;

    public virtual Nieruchomosci IdNieruchomosciNavigation { get; set; } = null!;
}
