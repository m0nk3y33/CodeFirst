using System;
using System.Collections.Generic;

namespace CodeFirst.Tabele;

public partial class Nieruchomosci
{
    public int IdNieruchomosci { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Opis { get; set; } = null!;

    public int Typ { get; set; }

    public string Adres { get; set; } = null!;

    public virtual ICollection<AgentNieruchomosc> AgentNieruchomoscs { get; set; } = new List<AgentNieruchomosc>();

    public virtual ICollection<Historium> Historia { get; set; } = new List<Historium>();

    public virtual ICollection<KlientNieruchomosc> KlientNieruchomoscs { get; set; } = new List<KlientNieruchomosc>();

    public virtual ICollection<Opinie> Opinies { get; set; } = new List<Opinie>();

    public virtual ICollection<Spotkanium> Spotkania { get; set; } = new List<Spotkanium>();

    public virtual ICollection<Transakcje> Transakcjes { get; set; } = new List<Transakcje>();
}
