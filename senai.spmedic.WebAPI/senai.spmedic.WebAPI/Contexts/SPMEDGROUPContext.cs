using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai.spmedic.WebAPI.Domains;

#nullable disable

namespace senai.spmedic.WebAPI.Contexts
{
    public partial class SPMEDGROUPContext : DbContext
    {
        public SPMEDGROUPContext()
        {
        }

        public SPMEDGROUPContext(DbContextOptions<SPMEDGROUPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clinica> Clinicas { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
        public virtual DbSet<Especialidade> Especialidades { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<Situacao> Situacaos { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=NOTE0113I3\\SQLEXPRESS; initial catalog=SPMEDGROUP_A; user Id=sa; pwd=Senai@132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Clinica>(entity =>
            {
                entity.HasKey(e => e.IdClinica)
                    .HasName("PK__clinica__C73A6055866853B7");

                entity.ToTable("clinica");

                entity.HasIndex(e => e.Cnpj, "UQ__clinica__35BD3E4862820806")
                    .IsUnique();

                entity.HasIndex(e => e.Endereco, "UQ__clinica__9456D406BCE71233")
                    .IsUnique();

                entity.Property(e => e.IdClinica).HasColumnName("idClinica");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("cnpj");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Funcionamento).HasColumnName("funcionamento");

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeFantasia");

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("razaoSocial");
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.HasKey(e => e.IdConsulta)
                    .HasName("PK__consulta__CA9C61F5FCF2C2CC");

                entity.ToTable("consulta");

                entity.Property(e => e.IdConsulta).HasColumnName("idConsulta");

                entity.Property(e => e.DataConsulta)
                    .HasColumnType("date")
                    .HasColumnName("dataConsulta");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Horario).HasColumnName("horario");

                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

                entity.Property(e => e.IdSituacao).HasColumnName("idSituacao");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK__consulta__idMedi__403A8C7D");

                entity.HasOne(d => d.IdSituacaoNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdSituacao)
                    .HasConstraintName("FK__consulta__idSitu__4222D4EF");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__consulta__idUsua__412EB0B6");
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidade)
                    .HasName("PK__especial__409698051E6E0810");

                entity.ToTable("especialidade");

                entity.HasIndex(e => e.NomeEspecialidade, "UQ__especial__EF876A5421FAB74E")
                    .IsUnique();

                entity.Property(e => e.IdEspecialidade).HasColumnName("idEspecialidade");

                entity.Property(e => e.NomeEspecialidade)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeEspecialidade");
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.HasKey(e => e.IdMedico)
                    .HasName("PK__medico__4E03DEBA515862AB");

                entity.ToTable("medico");

                entity.HasIndex(e => e.Crm, "UQ__medico__D836F7D18DDF36F0")
                    .IsUnique();

                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

                entity.Property(e => e.Crm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("crm");

                entity.Property(e => e.IdClinica).HasColumnName("idClinica");

                entity.Property(e => e.IdEspecialidade).HasColumnName("idEspecialidade");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdClinicaNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdClinica)
                    .HasConstraintName("FK__medico__idClinic__3A81B327");

                entity.HasOne(d => d.IdEspecialidadeNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdEspecialidade)
                    .HasConstraintName("FK__medico__idEspeci__3B75D760");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__medico__idUsuari__398D8EEE");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente)
                    .HasName("PK__paciente__F48A08F218D48288");

                entity.ToTable("paciente");

                entity.HasIndex(e => e.Telefone, "UQ__paciente__2A16D97F0B7A6206")
                    .IsUnique();

                entity.HasIndex(e => e.Rg, "UQ__paciente__32143310E564BD45")
                    .IsUnique();

                entity.HasIndex(e => e.Cpf, "UQ__paciente__D836E71FF21FC2B3")
                    .IsUnique();

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cpf");

                entity.Property(e => e.DataDeNascimento)
                    .HasColumnType("date")
                    .HasColumnName("dataDeNascimento");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("rg");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__paciente__idUsua__2F10007B");
            });

            modelBuilder.Entity<Situacao>(entity =>
            {
                entity.HasKey(e => e.IdSituacao)
                    .HasName("PK__situacao__12AFD1972DD1EBE6");

                entity.ToTable("situacao");

                entity.Property(e => e.IdSituacao).HasColumnName("idSituacao");

                entity.Property(e => e.DescSituacao)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("descSituacao");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__tipoUsua__03006BFF2B9C74F6");

                entity.ToTable("tipoUsuario");

                entity.HasIndex(e => e.TituloUsuario, "UQ__tipoUsua__12B8CE92AB8AE54F")
                    .IsUnique();

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.TituloUsuario)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("tituloUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__usuario__645723A61C48268A");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.NomeUsuario, "UQ__usuario__8C9D1DE500861467")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__usuario__AB6E6164E8F00164")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("nomeUsuario");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("senha")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__usuario__idTipoU__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
