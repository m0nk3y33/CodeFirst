using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Tabele;

public partial class NieruchomosciContext : DbContext
{
    public NieruchomosciContext()
    {
    }

    public NieruchomosciContext(DbContextOptions<NieruchomosciContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<AgentNieruchomosc> AgentNieruchomoscs { get; set; }

    public virtual DbSet<Historium> Historia { get; set; }

    public virtual DbSet<Klient> Klients { get; set; }

    public virtual DbSet<KlientNieruchomosc> KlientNieruchomoscs { get; set; }

    public virtual DbSet<Nieruchomosci> Nieruchomoscis { get; set; }

    public virtual DbSet<Opinie> Opinies { get; set; }

    public virtual DbSet<Spotkanie> Spotkanies { get; set; }

    public virtual DbSet<Spotkanium> Spotkania { get; set; }

    public virtual DbSet<Transakcje> Transakcjes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-FCJ16QR;Database=Nieruchomosci;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.IdAgenta);

        });

        modelBuilder.Entity<AgentNieruchomosc>(entity =>
        {
            entity.HasKey(e => e.IdAgentnier);

            entity.HasOne(d => d.IdAgentaNavigation).WithMany(p => p.AgentNieruchomoscs)
                .HasForeignKey(d => d.IdAgenta);


            entity.HasOne(d => d.IdNieruchomosciNavigation).WithMany(p => p.AgentNieruchomoscs)
                .HasForeignKey(d => d.IdNieruchomosci);
                
        });

        modelBuilder.Entity<Historium>(entity =>
        {
            entity.HasKey(e => e.IdHistorii);

            entity.HasOne(d => d.IdNieruchomosciNavigation).WithMany(p => p.Historia)
                .HasForeignKey(d => d.IdNieruchomosci);
             
        });

        modelBuilder.Entity<Klient>(entity =>
        {
            entity.HasKey(e => e.IdKlienta);

        });

        modelBuilder.Entity<KlientNieruchomosc>(entity =>
        {
            entity.HasKey(e => e.IdKlientnier);


            entity.HasOne(d => d.IdKlientaNavigation).WithMany(p => p.KlientNieruchomoscs)
                .HasForeignKey(d => d.IdKlienta);

            entity.HasOne(d => d.IdNieruchomosciNavigation).WithMany(p => p.KlientNieruchomoscs)
                .HasForeignKey(d => d.IdNieruchomosci);
        });

        modelBuilder.Entity<Nieruchomosci>(entity =>
        {
            entity.HasKey(e => e.IdNieruchomosci);

        });

        modelBuilder.Entity<Opinie>(entity =>
        {
            entity.HasKey(e => e.IdOpinii);



            entity.HasOne(d => d.IdAgentaNavigation).WithMany(p => p.Opinies)
                .HasForeignKey(d => d.IdAgenta);

            entity.HasOne(d => d.IdNieruchomosciNavigation).WithMany(p => p.Opinies)
                .HasForeignKey(d => d.IdNieruchomosci);

        });

        modelBuilder.Entity<Spotkanie>(entity =>
        {
            entity.HasKey(e => e.IdSpotkania);
        });

        modelBuilder.Entity<Spotkanium>(entity =>
        {
            entity.HasKey(e => e.IdSpotkan);

            entity.HasOne(d => d.IdNieruchomosciNavigation).WithMany(p => p.Spotkania)
                .HasForeignKey(d => d.IdNieruchomosci);
        });

        modelBuilder.Entity<Transakcje>(entity =>
        {
            entity.HasKey(e => e.IdTransakcji);


            entity.HasOne(d => d.IdAgentaNavigation).WithMany(p => p.Transakcjes)
                .HasForeignKey(d => d.IdAgenta);


            entity.HasOne(d => d.IdKlientaNavigation).WithMany(p => p.Transakcjes)
                .HasForeignKey(d => d.IdKlienta);


            entity.HasOne(d => d.IdNieruchomosciNavigation).WithMany(p => p.Transakcjes)
                .HasForeignKey(d => d.IdNieruchomosci);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
