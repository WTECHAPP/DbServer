﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using contaCorrente.Persistence.Contexts;

namespace contaCorrente.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("contaCorrente.Domain.Models.ContaCorrente", b =>
                {
                    b.Property<int>("IdContaCorrente")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Agencia");

                    b.Property<long>("CpfCliente");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("NumContaCorrente");

                    b.HasKey("IdContaCorrente");

                    b.ToTable("ContaCorrente");
                });

            modelBuilder.Entity("contaCorrente.Domain.Models.Lancamento", b =>
                {
                    b.Property<int>("IdLancamento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataLacamento");

                    b.Property<int>("NumContaCorrenteDestino");

                    b.Property<int>("NumContaCorrenteOrigem");

                    b.Property<decimal>("Valor");

                    b.HasKey("IdLancamento");

                    b.ToTable("Lancamento");
                });
#pragma warning restore 612, 618
        }
    }
}
