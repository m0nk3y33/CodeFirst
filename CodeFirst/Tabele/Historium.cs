using System;
using System.Collections.Generic;

namespace CodeFirst.Tabele;

public partial class Historium
{
    public int IdHistorii { get; set; }

    public int IdNieruchomosci { get; set; }

    public DateTime Data { get; set; }

    public string AdresIp { get; set; } = null!;

    public virtual Nieruchomosci IdNieruchomosciNavigation { get; set; } = null!;
}
