using MicroService_NaceTuIdea.Modells;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Users> Users { get; set; }
    public DbSet<ServicioAdicionalLocal> ServiciosAdicionalesLocales { get; set; }
    public DbSet<RespuestaReseña> RespuestasReseñas { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<Reseña> Reseñas { get; set; }
    public DbSet<ReglaLocal> ReglasLocales { get; set; }
    public DbSet<Notificacion> Notificaciones { get; set; }
    public DbSet<Local> Locales { get; set; }
    public DbSet<DisponibilidadLocal> DisponibilidadesLocales { get; set; }
    public DbSet<ComodidadLocal> ComodidadesLocales { get; set; }
    public DbSet<CategoriaLocal> CategoriasLocales { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        
         modelBuilder.Entity<Reseña>()
             .HasOne<Users>()
             .WithMany()
             .HasForeignKey(r => r.UsuarioId);

         modelBuilder.Entity<Reserva>()
             .HasOne<Users>()
             .WithMany()
             .HasForeignKey(r => r.UsuarioId);

         modelBuilder.Entity<Reserva>()
             .HasOne<Local>()
             .WithMany()
             .HasForeignKey(r => r.LocalId);

         modelBuilder.Entity<Reseña>()
             .HasOne<Local>()
               .WithMany()
             .HasForeignKey(r => r.LocalId);

        modelBuilder.Entity<RespuestaReseña>()
            .HasOne<Reseña>()
            .WithOne()
            .HasForeignKey<RespuestaReseña>(rr => rr.ResenaId);

        modelBuilder.Entity<RespuestaReseña>()
            .HasOne<Users>()
            .WithMany()
            .HasForeignKey(rr => rr.PropietarioId);

        modelBuilder.Entity<Local>()
            .HasOne<Users>()
            .WithMany()
            .HasForeignKey(l => l.PropietarioId);

        modelBuilder.Entity<Notificacion>()
            .HasOne<Users>()
            .WithMany()
            .HasForeignKey(n => n.UsuarioId);
    }
    public async Task<bool> SaveAsync()
    {
        return await SaveChangesAsync() > 0;
    }
}
