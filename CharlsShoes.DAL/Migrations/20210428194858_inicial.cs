using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharlsShoes.DAL.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    idCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    activo = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(maxLength: 50, nullable: false),
                    apellidoP = table.Column<string>(maxLength: 50, nullable: true),
                    apellidoM = table.Column<string>(maxLength: 50, nullable: true),
                    direccion = table.Column<string>(maxLength: 50, nullable: true),
                    telefono = table.Column<string>(maxLength: 50, nullable: true),
                    descuento = table.Column<decimal>(type: "decimal(5,3)", nullable: false),
                    activo = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "Colores",
                columns: table => new
                {
                    idColor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    activo = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colores", x => x.idColor);
                });

            migrationBuilder.CreateTable(
                name: "Folios",
                columns: table => new
                {
                    idFolio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    valor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folios", x => x.idFolio);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    idMarca = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    activo = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.idMarca);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    idProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(maxLength: 100, nullable: false),
                    costo = table.Column<decimal>(nullable: false),
                    precio = table.Column<decimal>(nullable: false),
                    idCategoria = table.Column<int>(nullable: false),
                    idColor = table.Column<int>(nullable: false),
                    idMarca = table.Column<int>(nullable: false),
                    stock = table.Column<int>(nullable: false),
                    activo = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.idProducto);
                });

            migrationBuilder.CreateTable(
                name: "Reportes",
                columns: table => new
                {
                    idReporte = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(maxLength: 50, nullable: false),
                    xml = table.Column<string>(maxLength: 2147483647, nullable: false),
                    directo = table.Column<bool>(nullable: false),
                    activo = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reportes", x => x.idReporte);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(maxLength: 50, nullable: false),
                    usuario = table.Column<string>(maxLength: 20, nullable: false),
                    password = table.Column<string>(maxLength: 2147483647, nullable: false),
                    activo = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    idVenta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    folio = table.Column<int>(nullable: false),
                    idCliente = table.Column<int>(nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    cantidad = table.Column<int>(nullable: false),
                    importe = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    descuento = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    total = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    pago = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    status = table.Column<string>(maxLength: 1, nullable: false, defaultValue: "A"),
                    idUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.idVenta);
                });

            migrationBuilder.CreateTable(
                name: "VentaDetalles",
                columns: table => new
                {
                    idVentaDetalle = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idVenta = table.Column<int>(nullable: false),
                    idProducto = table.Column<int>(nullable: false),
                    cantidad = table.Column<int>(nullable: false),
                    precio = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    importe = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    dc = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    dv = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    dv2 = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    descuento = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    total = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaDetalles", x => x.idVentaDetalle);
                    table.ForeignKey(
                        name: "FK_VentaDetalles_Ventas_idVenta",
                        column: x => x.idVenta,
                        principalTable: "Ventas",
                        principalColumn: "idVenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalles_idVenta",
                table: "VentaDetalles",
                column: "idVenta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Colores");

            migrationBuilder.DropTable(
                name: "Folios");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Reportes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "VentaDetalles");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
