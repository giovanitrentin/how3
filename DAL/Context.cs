using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Model;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<PessoaContato> PessoaContatos { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "HoW");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>().HasKey(I => I.Id);
            modelBuilder.Entity<Cliente>().HasKey(I => I.Id);
            modelBuilder.Entity<PessoaContato>().HasKey(I => I.Id);
            modelBuilder.Entity<Login>().HasKey(I => I.Id);
            modelBuilder.Entity<Tarefa>().Ignore(I => I.Cliente);
        }
    }
}
