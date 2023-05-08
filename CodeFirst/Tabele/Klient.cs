using System;
using System.Collections.Generic;

namespace CodeFirst.Tabele;

public partial class Klient
{
    public int IdKlienta { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string? Email { get; set; }

    public string Telefon { get; set; } = null!;

    public DateTime DataUr { get; set; }

    public string Pesel { get; set; } = null!;

    public virtual ICollection<KlientNieruchomosc> KlientNieruchomoscs { get; set; } = new List<KlientNieruchomosc>();

    public virtual ICollection<Transakcje> Transakcjes { get; set; } = new List<Transakcje>();
}
