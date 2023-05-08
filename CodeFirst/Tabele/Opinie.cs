using System;
using System.Collections.Generic;

namespace CodeFirst.Tabele;

public partial class Opinie
{
    public int IdOpinii { get; set; }

    public int IdAgenta { get; set; }

    public int IdNieruchomosci { get; set; }

    public virtual Agent IdAgentaNavigation { get; set; } = null!;

    public virtual Nieruchomosci IdNieruchomosciNavigation { get; set; } = null!;
}
