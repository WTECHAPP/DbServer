using System;
using System.IO;
using contaCorrente.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace contaCorrente.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<ContaCorrente> ContaCorrente { get; set; }
        public DbSet<Lancamento> Lancamento { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            IConfiguration cb = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(String.Format(@"Server={0};Database={1};User Id={2};Password={3};", cb["sqlIp"], cb["sqlDb"], cb["sqlUser"], cb["sqlPass"]));
        }
        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);

            builder.Entity<ContaCorrente>().ToTable("ContaCorrente");

            builder.Entity<ContaCorrente>().HasKey(p => p.IdContaCorrente);
            builder.Entity<ContaCorrente>().Property(p => p.IdContaCorrente).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<ContaCorrente>().Property(p => p.CpfCliente).IsRequired();
            builder.Entity<ContaCorrente>().Property(p => p.NomeCliente).IsRequired().HasMaxLength(250);
            builder.Entity<ContaCorrente>().Property(p => p.Agencia).IsRequired();
            builder.Entity<ContaCorrente>().Property(p => p.NumContaCorrente).IsRequired();

            builder.Entity<Lancamento>().ToTable("Lancamento");

            builder.Entity<Lancamento>().HasKey(p => p.IdLancamento);
            builder.Entity<Lancamento>().Property(p => p.IdLancamento).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Lancamento>().Property(p => p.DataLacamento).IsRequired();
            builder.Entity<Lancamento>().Property(p => p.NumContaCorrenteOrigem).IsRequired();
            builder.Entity<Lancamento>().Property(p => p.NumContaCorrenteDestino).IsRequired();
            builder.Entity<Lancamento>().Property(p => p.Valor).IsRequired();
        }
    }
}