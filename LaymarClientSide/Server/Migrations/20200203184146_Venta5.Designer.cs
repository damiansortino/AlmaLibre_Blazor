﻿// <auto-generated />
using System;
using LaymarClientSide.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LaymarClientSide.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200203184146_Venta5")]
    partial class Venta5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.Caja", b =>
                {
                    b.Property<int>("CajaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaCaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaCierreCaja")
                        .HasColumnType("datetime2");

                    b.Property<double>("montoCaja")
                        .HasColumnType("float");

                    b.HasKey("CajaId");

                    b.HasIndex("SucursalId");

                    b.ToTable("caja");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.Comprobante", b =>
                {
                    b.Property<int>("ComprobanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstadoComprobanteId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaJuridicaId")
                        .HasColumnType("int");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.Property<int>("TipoComprobanteId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("bonificacion")
                        .HasColumnType("float");

                    b.Property<string>("codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("efectivo")
                        .HasColumnType("float");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaComprobante")
                        .HasColumnType("datetime2");

                    b.Property<double>("importe")
                        .HasColumnType("float");

                    b.Property<double?>("tarjeta")
                        .HasColumnType("float");

                    b.HasKey("ComprobanteId");

                    b.HasIndex("EstadoComprobanteId");

                    b.HasIndex("PersonaJuridicaId");

                    b.HasIndex("SucursalId");

                    b.HasIndex("TipoComprobanteId");

                    b.ToTable("comprobante");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.DetalleFactura", b =>
                {
                    b.Property<int>("DetalleFacturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComprobanteId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<double>("bonificacion")
                        .HasColumnType("float");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<double>("subtotal")
                        .HasColumnType("float");

                    b.HasKey("DetalleFacturaId");

                    b.HasIndex("ComprobanteId");

                    b.HasIndex("ProductoId");

                    b.ToTable("detalleFactura");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.EstadoComprobante", b =>
                {
                    b.Property<int>("EstadoComprobanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreEstadoComprobante")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoComprobanteId");

                    b.ToTable("estadoComprobante");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.MovimientoCaja", b =>
                {
                    b.Property<int>("MovimientoCajaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CajaId")
                        .HasColumnType("int");

                    b.Property<bool>("entra")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<double>("importe")
                        .HasColumnType("float");

                    b.Property<string>("observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("sale")
                        .HasColumnType("bit");

                    b.Property<int>("tipoMovimientoCajaId")
                        .HasColumnType("int");

                    b.HasKey("MovimientoCajaId");

                    b.HasIndex("CajaId");

                    b.HasIndex("tipoMovimientoCajaId");

                    b.ToTable("movimientoCaja");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.MovimientoStock", b =>
                {
                    b.Property<int>("MovimientoStockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ComprobanteId")
                        .HasColumnType("int");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.Property<int>("TipoMovimientoStockId")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("entra")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<bool>("sale")
                        .HasColumnType("bit");

                    b.HasKey("MovimientoStockId");

                    b.HasIndex("ComprobanteId");

                    b.HasIndex("StockId");

                    b.HasIndex("TipoMovimientoStockId");

                    b.ToTable("movimientoStock");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.PersonaJuridica", b =>
                {
                    b.Property<int>("PersonaJuridicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cuit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreFantasia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroTelefono1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroTelefono2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("razonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonaJuridicaId");

                    b.ToTable("personaJuridica");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PersonaJuridica");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("porcentajeRentabilidad")
                        .HasColumnType("float");

                    b.Property<double>("precioUnitario")
                        .HasColumnType("float");

                    b.Property<string>("talle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductoId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("producto");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.HasKey("StockId");

                    b.HasIndex("ProductoId");

                    b.HasIndex("SucursalId");

                    b.ToTable("stock");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.Sucursal", b =>
                {
                    b.Property<int>("SucursalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreSucursal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SucursalId");

                    b.ToTable("sucursal");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.TipoComprobante", b =>
                {
                    b.Property<int>("TipoComprobanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreTipoComprobante")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoComprobanteId");

                    b.ToTable("tipoComprobante");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.TipoMovimientoCaja", b =>
                {
                    b.Property<int>("TipoMovimientoCajaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreTipoMovimientoCaja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoMovimientoCajaId");

                    b.ToTable("tipoMovimientoCaja");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.TipoMovimientoStock", b =>
                {
                    b.Property<int>("TipoMovimientoStockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreTipoMovimientoStock")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoMovimientoStockId");

                    b.ToTable("tipoMovimientoStock");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.Cliente", b =>
                {
                    b.HasBaseType("LaymarClientSide.Shared.Entidades.PersonaJuridica");

                    b.Property<string>("ClienteId")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.Proveedor", b =>
                {
                    b.HasBaseType("LaymarClientSide.Shared.Entidades.PersonaJuridica");

                    b.Property<string>("ProveedorId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("porcentajeRentabilidad")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Proveedor");
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.Caja", b =>
                {
                    b.HasOne("LaymarClientSide.Shared.Entidades.Sucursal", "sucursal")
                        .WithMany()
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.Comprobante", b =>
                {
                    b.HasOne("LaymarClientSide.Shared.Entidades.EstadoComprobante", "estadoComprobante")
                        .WithMany()
                        .HasForeignKey("EstadoComprobanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaymarClientSide.Shared.Entidades.PersonaJuridica", "personaJuridica")
                        .WithMany()
                        .HasForeignKey("PersonaJuridicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaymarClientSide.Shared.Entidades.Sucursal", "sucursal")
                        .WithMany()
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaymarClientSide.Shared.Entidades.TipoComprobante", "tipoComprobante")
                        .WithMany()
                        .HasForeignKey("TipoComprobanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.DetalleFactura", b =>
                {
                    b.HasOne("LaymarClientSide.Shared.Entidades.Comprobante", "comprobante")
                        .WithMany()
                        .HasForeignKey("ComprobanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaymarClientSide.Shared.Entidades.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.MovimientoCaja", b =>
                {
                    b.HasOne("LaymarClientSide.Shared.Entidades.Caja", "caja")
                        .WithMany()
                        .HasForeignKey("CajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaymarClientSide.Shared.Entidades.TipoMovimientoCaja", "tipoMovimientoCaja")
                        .WithMany()
                        .HasForeignKey("tipoMovimientoCajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.MovimientoStock", b =>
                {
                    b.HasOne("LaymarClientSide.Shared.Entidades.Comprobante", "comprobante")
                        .WithMany()
                        .HasForeignKey("ComprobanteId");

                    b.HasOne("LaymarClientSide.Shared.Entidades.Stock", "stock")
                        .WithMany()
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaymarClientSide.Shared.Entidades.TipoMovimientoStock", "tipoMovimientoStock")
                        .WithMany()
                        .HasForeignKey("TipoMovimientoStockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.Producto", b =>
                {
                    b.HasOne("LaymarClientSide.Shared.Entidades.Proveedor", "proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LaymarClientSide.Shared.Entidades.Stock", b =>
                {
                    b.HasOne("LaymarClientSide.Shared.Entidades.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaymarClientSide.Shared.Entidades.Sucursal", "sucursal")
                        .WithMany()
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
