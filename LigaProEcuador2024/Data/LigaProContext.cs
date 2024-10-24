namespace LigaProEcuador2024.Data;
using LigaProEcuador2024.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using LigaProEcuador2024.Models; 

public class LigaProContext : DbContext
{
    
    public LigaProContext(DbContextOptions<LigaProContext> options) : base(options) { }

    
    public DbSet<Equipo> Equipos { get; set; }
    public DbSet<Jugador> Jugadores { get; set; }
    public DbSet<Estadio> Estadios { get; set; }
}
