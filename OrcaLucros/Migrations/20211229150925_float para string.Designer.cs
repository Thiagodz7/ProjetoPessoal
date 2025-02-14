﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrcaLucros.Data;

namespace OrcaLucros.Migrations
{
    [DbContext(typeof(orcamentoContext))]
    [Migration("20211229150925_float para string")]
    partial class floatparastring
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrcaLucros.Models.Orcamentos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("DtEntrada")
                        .HasColumnType("datetime2")
                        .HasColumnName("DtEntrada");

                    b.Property<DateTime>("DtSaida")
                        .HasColumnType("datetime2")
                        .HasColumnName("DtSaida");

                    b.Property<string>("Entrada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Entrada");

                    b.Property<string>("Saida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Saida");

                    b.Property<string>("SaldoInicial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SaldoInicial");

                    b.Property<string>("ValorFinal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ValorFinal");

                    b.HasKey("Id");

                    b.ToTable("Orcamentos", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
