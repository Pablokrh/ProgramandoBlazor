using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Inmobiliaria.Modelo;

namespace Inmobiliaria.Repositorio.DbContexto;

public partial class InmobiliariaContext : DbContext
{
	public InmobiliariaContext()
	{
	}

	public InmobiliariaContext(DbContextOptions<InmobiliariaContext> options)
		: base(options)
	{
	}

	public virtual DbSet<Imagen> Imagens { get; set; }

	public virtual DbSet<Inmueble> Inmuebles { get; set; }

	public virtual DbSet<Usuario> Usuarios { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Imagen>(entity =>
		{
			entity.HasKey(e => e.IdImagen).HasName("PK__Imagen__B42D8F2AD627D491");

			entity.ToTable("Imagen");

			entity.HasOne(d => d.IdInmuebleNavigation).WithMany(p => p.ListaImagenes)
				.HasForeignKey(d => d.IdInmueble)
				.HasConstraintName("FK__Imagen__IdInmueb__49C3F6B7");
		});

		modelBuilder.Entity<Inmueble>(entity =>
		{
			entity.HasKey(e => e.IdInmueble).HasName("PK__Inmueble__6B8E7D3E16F8F6E1");

			entity.ToTable("Inmueble");

			entity.Property(e => e.Ciudad)
				.HasMaxLength(50)
				.IsUnicode(false);
			entity.Property(e => e.Detalles)
				.HasMaxLength(1000)
				.IsUnicode(false);
			entity.Property(e => e.Estado)
				.HasMaxLength(50)
				.IsUnicode(false);
			entity.Property(e => e.Expensas).HasColumnType("decimal(10, 2)");
			entity.Property(e => e.FechaCreacion)
				.HasDefaultValueSql("(getdate())")
				.HasColumnType("datetime");			
			entity.Property(e => e.Pais)
				.HasMaxLength(50)
				.IsUnicode(false);
			entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
			entity.Property(e => e.PublicadoPara)
				.HasMaxLength(50)
				.IsUnicode(false);
			entity.Property(e => e.TipoInmueble)
				.HasMaxLength(50)
				.IsUnicode(false);
			entity.Property(e => e.Titulo)
				.HasMaxLength(50)
				.IsUnicode(false);
		});

		modelBuilder.Entity<Usuario>(entity =>
		{
			entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF97C63A90CC");

			entity.ToTable("Usuario");

			entity.Property(e => e.Clave)
				.HasMaxLength(50)
				.IsUnicode(false);
			entity.Property(e => e.Correo)
				.HasMaxLength(50)
				.IsUnicode(false);
			entity.Property(e => e.FechaCreacion)
				.HasDefaultValueSql("(getdate())")
				.HasColumnType("datetime");
			entity.Property(e => e.NombreCompleto)
				.HasMaxLength(50)
				.IsUnicode(false);
			entity.Property(e => e.Rol)
				.HasMaxLength(50)
				.IsUnicode(false);
		});

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
