﻿// <auto-generated />
using System;
using CharlsShoes.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CharlsShoes.DAL.Migrations
{
    [DbContext(typeof(CharlsShoesContext))]
    partial class CharlsShoesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CharlsShoes.Entities.Categoria", b =>
                {
                    b.Property<int>("idCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("idCategoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("CharlsShoes.Entities.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("apellidoM")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("apellidoP")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("descuento")
                        .HasColumnType("decimal(5,3)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("idCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CharlsShoes.Entities.Color", b =>
                {
                    b.Property<int>("idColor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("idColor");

                    b.ToTable("Colores");
                });

            modelBuilder.Entity("CharlsShoes.Entities.Folio", b =>
                {
                    b.Property<int>("idFolio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("valor")
                        .HasColumnType("int");

                    b.HasKey("idFolio");

                    b.ToTable("Folios");
                });

            modelBuilder.Entity("CharlsShoes.Entities.Marca", b =>
                {
                    b.Property<int>("idMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("idMarca");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("CharlsShoes.Entities.Producto", b =>
                {
                    b.Property<int>("idProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("idCategoria")
                        .HasColumnType("int");

                    b.Property<int>("idColor")
                        .HasColumnType("int");

                    b.Property<int>("idMarca")
                        .HasColumnType("int");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("idProducto");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("CharlsShoes.Entities.Reporte", b =>
                {
                    b.Property<int>("idReporte")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("directo")
                        .HasColumnType("bit");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("xml")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.HasKey("idReporte");

                    b.ToTable("Reportes");
                });

            modelBuilder.Entity("CharlsShoes.Entities.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CharlsShoes.Entities.Venta", b =>
                {
                    b.Property<int>("idVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("descuento")
                        .HasColumnType("decimal(8,2)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime");

                    b.Property<int>("folio")
                        .HasColumnType("int");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<decimal>("importe")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("pago")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1)
                        .HasDefaultValue("A");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("idVenta");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("CharlsShoes.Entities.VentaDetalle", b =>
                {
                    b.Property<int>("idVentaDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("dc")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("descuento")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("dv")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("dv2")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("idProducto")
                        .HasColumnType("int");

                    b.Property<int>("idVenta")
                        .HasColumnType("int");

                    b.Property<decimal>("importe")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("idVentaDetalle");

                    b.HasIndex("idVenta");

                    b.ToTable("VentaDetalles");
                });

            modelBuilder.Entity("CharlsShoes.Entities.VentaDetalle", b =>
                {
                    b.HasOne("CharlsShoes.Entities.Venta", "venta")
                        .WithMany("ventasDetalle")
                        .HasForeignKey("idVenta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
