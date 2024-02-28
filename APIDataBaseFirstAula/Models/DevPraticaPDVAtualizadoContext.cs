using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIDataBaseFirstAula.Models
{
    public partial class DevPraticaPDVAtualizadoContext : DbContext
    {
        public DevPraticaPDVAtualizadoContext()
        {
        }

        public DevPraticaPDVAtualizadoContext(DbContextOptions<DevPraticaPDVAtualizadoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Fornecedore> Fornecedores { get; set; } = null!;
        public virtual DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=localhost,1433;user id=sa;password=senha@1234xxxy;initial catalog=DevPraticaPDVAtualizado;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Cpf)
                    .HasName("PK__Clientes__C1F89730D1FD8172");
            });

            modelBuilder.Entity<Fornecedore>(entity =>
            {
                entity.HasKey(e => e.Cnpj)
                    .HasName("PK__Forneced__AA57D6B5471795F3");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.Cpf)
                    .HasName("PK__Funciona__C1F897304D3F1676");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
