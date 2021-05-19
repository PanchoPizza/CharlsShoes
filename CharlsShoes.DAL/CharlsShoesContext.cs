using CharlsShoes.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharlsShoes.DAL
{
    public class CharlsShoesContext : DbContext

    {

        public const string ConnectionString = "Server=LAPTOP-4T0FBODR\\JASI;Database=charlssdb;Trusted_Connection=True;";
        public const string conString ="Data Source=LAPTOP-4T0FBODR\\JASI;Initial Catalog=charlssdb;Integrated Security=True;User ID=;Password=";
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Color> Colores { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        public DbSet<VentaDetalle> VentaDetalles { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Folio> Folios { get; set; }

        public DbSet<Reporte> Reportes { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(U =>
            {
                U.HasKey(u => u.idUsuario);
                U.Property(u => u.nombre).HasMaxLength(50).IsRequired();
                U.Property(u => u.usuario).HasMaxLength(20).IsRequired();
                U.Property(u => u.password).HasMaxLength(int.MaxValue).IsRequired();
                U.Property(u => u.activo).HasDefaultValue(true).IsRequired();

            });

            modelBuilder.Entity<Marca>(M =>
            {
                M.HasKey(m => m.idMarca);
                M.Property(m => m.descripcion).HasMaxLength(50).IsRequired();
                M.Property(m => m.activo).HasDefaultValue(true).IsRequired();


            });

            modelBuilder.Entity<Color>(C => {
                C.HasKey(c => c.idColor);
                C.Property(c => c.descripcion).HasMaxLength(50).IsRequired();
                C.Property(c => c.activo).HasDefaultValue(true).IsRequired();
            
            
            });


            modelBuilder.Entity<Categoria>(C => {
                C.HasKey(c => c.idCategoria);
                C.Property(c => c.descripcion).HasMaxLength(50).IsRequired();
                C.Property(c => c.activo).HasDefaultValue(true).IsRequired();

            });

            modelBuilder.Entity<Producto>(
                P =>
                {
                    P.HasKey(p => p.idProducto);
                    P.Property(p => p.codigo).HasMaxLength(50).IsRequired();
                    P.Property(p => p.descripcion).HasMaxLength(100).IsRequired();
                    P.Property(p => p.costo).IsRequired();
                    P.Property(p => p.precio).IsRequired();
                    P.Property(p => p.idCategoria).IsRequired();
                    P.Property(p => p.idColor).IsRequired();
                    P.Property(p => p.idMarca).IsRequired();
                    P.Property(p => p.stock).IsRequired();
                    P.Property(p => p.activo).HasDefaultValue(true).IsRequired();
                });

            modelBuilder.Entity<Venta>(V =>
            {
                V.HasKey(v => v.idVenta);
                V.Property(v => v.idCliente).IsRequired();
                V.Property(v => v.fecha).HasColumnType("datetime").IsRequired();
                V.Property(v => v.cantidad).IsRequired();
                V.Property(v => v.importe).HasColumnType("decimal(8,2)").IsRequired();
                V.Property(v => v.descuento).HasColumnType("decimal(8,2)").IsRequired();
                V.Property(v => v.total).HasColumnType("decimal(8,2)").IsRequired();
                V.Property(v => v.pago).HasColumnType("decimal(8,2)").IsRequired();
                V.Property(v => v.status).HasMaxLength(1).HasDefaultValue("A").IsRequired();
                V.Property(v => v.idUsuario).IsRequired();
                V.HasMany(v=>v.ventasDetalle).WithOne(vd=>vd.venta);
            });

            modelBuilder.Entity<VentaDetalle>(
                VD =>
                {
                    VD.HasKey(v => v.idVentaDetalle);
                    VD.Property(vd => vd.idVenta).IsRequired();
                    VD.Property(vd => vd.idProducto).IsRequired();
                    VD.Property(vd => vd.cantidad).IsRequired();
                    VD.Property(vd => vd.precio).HasColumnType("decimal(8,2)").IsRequired();
                    VD.Property(vd => vd.importe).HasColumnType("decimal(8,2)").IsRequired();
                    VD.Property(vd => vd.dc).HasColumnType("decimal(8,2)").IsRequired();
                    VD.Property(vd=>vd.dv).HasColumnType("decimal(8,2)").IsRequired();
                    VD.Property(vd=>vd.dv2).HasColumnType("decimal(8,2)").IsRequired();
                    VD.Property(vd => vd.descuento).HasColumnType("decimal(8,2)").IsRequired();
                    VD.Property(vd => vd.total).HasColumnType("decimal(8,2)").IsRequired();
                    VD.HasOne(vd => vd.venta).WithMany(vd => vd.ventasDetalle).HasForeignKey(vd => vd.idVenta);
                });

            modelBuilder.Entity<Cliente>(
                C =>
                {
                    C.HasKey(c => c.idCliente);
                    C.Property(c => c.nombre).HasMaxLength(50).IsRequired();
                    C.Property(c => c.apellidoP).HasMaxLength(50).IsRequired(false);
                    C.Property(c => c.apellidoM).HasMaxLength(50).IsRequired(false);
                    C.Property(c => c.direccion).HasMaxLength(50).IsRequired(false);
                    C.Property(c => c.telefono).HasMaxLength(50).IsRequired(false);
                    C.Property(c => c.descuento).HasColumnType("decimal(5,3)").IsRequired();
                    C.Property(c => c.activo).HasDefaultValue(true).IsRequired();
                });


            modelBuilder.Entity<Folio>(
                F =>
                {
                    F.HasKey(f => f.idFolio);
                    F.Property(f => f.descripcion).HasMaxLength(50).IsRequired();
                });

            modelBuilder.Entity<Reporte>(
                R =>
                {
                    R.HasKey(r => r.idReporte);
                    R.Property(r => r.nombre).HasMaxLength(50).IsRequired();
                    R.Property(r => r.xml).HasMaxLength(int.MaxValue).IsRequired();
                    R.Property(r => r.directo).IsRequired();
                    R.Property(r => r.activo).HasDefaultValue(true).IsRequired();
                });




        }
    }
}
