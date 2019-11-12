using Microsoft.EntityFrameworkCore;

namespace DojoMyPlaylist.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }
        public DbSet<PlaylistMusica> PlaylistMusicas { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaylistMusica>()
                .HasKey(pm => new { pm.PlaylistId, pm.MusicaId });
        }
    }
}