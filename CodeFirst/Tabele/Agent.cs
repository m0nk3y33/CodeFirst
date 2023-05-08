using System;
using System.Collections.Generic;

namespace CodeFirst.Tabele;

public partial class Agent
{
    public int IdAgenta { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public int? Doswiadczenie { get; set; }

    public string Jezyki { get; set; } = null!;

    public virtual ICollection<AgentNieruchomosc> AgentNieruchomoscs { get; set; } = new List<AgentNieruchomosc>();

    public virtual ICollection<Opinie> Opinies { get; set; } = new List<Opinie>();

    public virtual ICollection<Transakcje> Transakcjes { get; set; } = new List<Transakcje>();
}
