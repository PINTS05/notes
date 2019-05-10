using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KrakenNotes.Models;

namespace KrakenNotes.Models
{
    public class KrakenNotesContext : DbContext
    {
        public KrakenNotesContext (DbContextOptions<KrakenNotesContext> options)
            : base(options)
        {
        }

        public DbSet<KrakenNotes.Models.Note> Note { get; set; }

        public DbSet<KrakenNotes.Models.Tag> Tag { get; set; }

        public DbSet<KrakenNotes.Models.User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NoteTag>()
                .HasKey(t => new { t.NoteId, t.TagId });

            modelBuilder.Entity<NoteTag>()
                .HasOne(nt => nt.Note)
                .WithMany(n => n.NoteTags)
                .HasForeignKey(nt => nt.NoteId);

            modelBuilder.Entity<NoteTag>()
                .HasOne(nt => nt.Tag)
                .WithMany(t => t.NoteTags)
                .HasForeignKey(nt => nt.TagId);
        }
    }
}
