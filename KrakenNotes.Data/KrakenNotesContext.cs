using KrakenNotes.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KrakenNotes.Data
{
    public class KrakenNotesContext : DbContext
    {
        public KrakenNotesContext(DbContextOptions options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<NoteTag> NoteTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<NoteTag>(entity =>
            {
                entity.HasKey(nt => new { nt.NoteId, nt.TagId });

                entity.Property(e => e.NoteId)
                    .HasColumnName("note_id");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id");

                entity.HasOne(nt => nt.Note)
                    .WithMany(n => n.NoteTags)
                    .HasForeignKey(nt => nt.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Note_NoteTag");

                entity.HasOne(nt => nt.Tag)
                    .WithMany(t => t.NoteTags)
                    .HasForeignKey(nt => nt.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tag_NoteTag");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(n => n.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title")
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id");

                entity.HasOne(e => e.User)
                    .WithMany(u => u.Notes)
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Note_User");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id");

                entity.HasOne(e => e.User)
                    .WithMany(u => u.Tags)
                    .HasForeignKey(e => e.UserId)
                    .HasConstraintName("FK_Tag_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Image)
                    .HasColumnName("image");

                entity.Property(e => e.ColorMode)
                    .IsRequired()
                    .HasColumnName("color_mode");
            });
        }
    }
}
