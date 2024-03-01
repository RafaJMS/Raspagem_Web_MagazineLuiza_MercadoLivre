﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RaspagemMagMer.Models;

#nullable disable

namespace RaspagemMagMer.Migrations
{
    [DbContext(typeof(LogContext))]
    [Migration("20240228165658_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Log", b =>
                {
                    b.Property<int>("IdLog")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLog"), 1L, 1);

                    b.Property<string>("CodRob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateLog")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProd")
                        .HasColumnType("int");

                    b.Property<string>("InfLog")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuRob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLog");

                    b.ToTable("Logs");
                });
#pragma warning restore 612, 618
        }
    }
}
