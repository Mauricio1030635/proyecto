using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using educationProject.Models;

#nullable disable

namespace educationProject.Data
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acudiente> Acudientes { get; set; }
        public virtual DbSet<Docente> Docentes { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Grupo> Grupos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-6LFP0N1;User ID=sa;Password=12345;Initial Catalog=proyectoeducacion;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Acudiente>(entity =>
            {
                entity.HasKey(e => e.IdAcudiente)
                    .HasName("PK__acudient__8F89A4F54D0660EB");

                entity.ToTable("acudiente");

                entity.Property(e => e.IdAcudiente).HasColumnName("id_acudiente");

                entity.Property(e => e.ApellidoAcudiente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("apellido_acudiente");

                entity.Property(e => e.DireccionAcudiente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion_acudiente");

                entity.Property(e => e.NombreAcudiente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_acudiente");

                entity.Property(e => e.TelefonoAcudiente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("telefono_acudiente");
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasKey(e => e.IdDocente)
                    .HasName("PK__docente__300DB211B0F82DA8");

                entity.ToTable("docente");

                entity.Property(e => e.IdDocente).HasColumnName("id_docente");

                entity.Property(e => e.ApellidoDocente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("apellido_docente");

                entity.Property(e => e.CedulaDocente).HasColumnName("cedula_docente");

                entity.Property(e => e.DireccionDocente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion_docente");

                entity.Property(e => e.NivelEducativo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nivel_educativo");

                entity.Property(e => e.NombreDocente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_docente");

                entity.Property(e => e.TelefonoDocente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("telefono_docente");
            });

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.IdEstudiante)
                    .HasName("PK__estudian__E0B2763C0D69F402");

                entity.ToTable("estudiante");

                entity.Property(e => e.IdEstudiante).HasColumnName("id_estudiante");

                entity.Property(e => e.ApellidoEstudiante)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("apellido_estudiante");

                entity.Property(e => e.DireccionEstudiante)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion_estudiante");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.IdAcudiente).HasColumnName("id_acudiente");

                entity.Property(e => e.NombreEstudiante)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_estudiante");

                entity.Property(e => e.TelefonoEstudiante)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("telefono_estudiante");

                entity.Property(e => e.TiEstudiante).HasColumnName("ti_estudiante");

                entity.HasOne(d => d.IdAcudienteNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IdAcudiente)
                    .HasConstraintName("FK__estudiant__id_ac__286302EC");
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.IdGrupo)
                    .HasName("PK__grupo__8B68D688C9F20839");

                entity.ToTable("grupo");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.IdDocente).HasColumnName("id_docente");

                entity.Property(e => e.IdEstudiante).HasColumnName("id_estudiante");

                entity.Property(e => e.NombreGrupo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_grupo");

                entity.HasOne(d => d.IdDocenteNavigation)
                    .WithMany(p => p.Grupos)
                    .HasForeignKey(d => d.IdDocente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__grupo__id_docent__2C3393D0");

                entity.HasOne(d => d.IdEstudianteNavigation)
                    .WithMany(p => p.Grupos)
                    .HasForeignKey(d => d.IdEstudiante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__grupo__id_estudi__2B3F6F97");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
