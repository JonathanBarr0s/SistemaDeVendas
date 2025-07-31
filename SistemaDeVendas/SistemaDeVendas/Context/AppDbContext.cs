using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Context;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ItensVenda> ItensVenda { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Vendedor> Vendedors { get; set; }

    public virtual DbSet<Venda> Venda { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-Q1U795P\\SQLEXPRESS;Database=SistemaDeVendas;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cliente__3214EC070733D395");

            entity.ToTable("Cliente");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CpfCnpj)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CPF_CNPJ");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Senha)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ItensVenda>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Itens_Venda");

            entity.Property(e => e.PrecoProduto)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("Preco_Produto");
            entity.Property(e => e.ProdutoId).HasColumnName("Produto_Id");
            entity.Property(e => e.QtdeProduto)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("Qtde_Produto");
            entity.Property(e => e.VendaId).HasColumnName("Venda_Id");

            entity.HasOne(d => d.Produto).WithMany()
                .HasForeignKey(d => d.ProdutoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Itens_Ven__Produ__412EB0B6");

            entity.HasOne(d => d.Venda).WithMany()
                .HasForeignKey(d => d.VendaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Itens_Ven__Venda__403A8C7D");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Produto__3214EC07E34C04DF");

            entity.ToTable("Produto");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LinkFoto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Link_Foto");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecoUnitario)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("Preco_Unitario");
            entity.Property(e => e.QuantidadeEstoque)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("Quantidade_Estoque");
            entity.Property(e => e.UnidadeMedida)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Unidade_Medida");
        });

        modelBuilder.Entity<Vendedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vendedor__3214EC077498A066");

            entity.ToTable("Vendedor");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Senha)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Venda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Venda__3214EC0782A647D2");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ClienteId).HasColumnName("Cliente_Id");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.VendedorId).HasColumnName("Vendedor_Id");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Venda)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Venda__Cliente_I__3E52440B");

            entity.HasOne(d => d.Vendedor).WithMany(p => p.Venda)
                .HasForeignKey(d => d.VendedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Venda__Vendedor___3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
