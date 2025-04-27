using Microsoft.EntityFrameworkCore;
using WebApplicationTesteBackend.Models;

namespace WebApplicationTesteBackend.Db;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<People> Peoples => Set<People>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<People>()
            .HasData(
                    new People { Id = 1, Cpf = "25244965004", Name = "Beatriz", Genero = "Feminino", Endereco = "Av Carlos de Almeida", Idade = 25, Municipio = "São Paulo", Estado = "SP" },
                    new People { Id = 2, Cpf = "35567283080", Name = "Carlos", Genero = "Masculino", Endereco = "Rua das Flores", Idade = 30, Municipio = "Campinas", Estado = "SP" },
                    new People { Id = 3, Cpf = "46783491007", Name = "Ana", Genero = "Feminino", Endereco = "Av Brasil", Idade = 22, Municipio = "Santos", Estado = "SP" },
                    new People { Id = 4, Cpf = "59892830008", Name = "Roberto", Genero = "Masculino", Endereco = "Rua das Palmeiras", Idade = 45, Municipio = "Ribeirão Preto", Estado = "SP" },
                    new People { Id = 5, Cpf = "67941573023", Name = "Fernanda", Genero = "Feminino", Endereco = "Rua A", Idade = 28, Municipio = "Guarulhos", Estado = "SP" },
                    new People { Id = 6, Cpf = "70381664000", Name = "João", Genero = "Masculino", Endereco = "Rua B", Idade = 33, Municipio = "Osasco", Estado = "SP" },
                    new People { Id = 7, Cpf = "83270985050", Name = "Camila", Genero = "Feminino", Endereco = "Rua C", Idade = 19, Municipio = "Sorocaba", Estado = "SP" },
                    new People { Id = 8, Cpf = "95671248009", Name = "Marcos", Genero = "Masculino", Endereco = "Rua D", Idade = 41, Municipio = "Santo André", Estado = "SP" },
                    new People { Id = 9, Cpf = "10243798088", Name = "Patricia", Genero = "Feminino", Endereco = "Rua E", Idade = 29, Municipio = "São Bernardo", Estado = "SP" },
                    new People { Id = 10, Cpf = "21384956006", Name = "Eduardo", Genero = "Masculino", Endereco = "Rua F", Idade = 39, Municipio = "Diadema", Estado = "SP" },
                    new People { Id = 11, Cpf = "31902467021", Name = "Tatiane", Genero = "Feminino", Endereco = "Rua G", Idade = 27, Municipio = "Mauá", Estado = "SP" },
                    new People { Id = 12, Cpf = "42576891031", Name = "Bruno", Genero = "Masculino", Endereco = "Rua H", Idade = 23, Municipio = "Carapicuíba", Estado = "SP" },
                    new People { Id = 13, Cpf = "53490218002", Name = "Gabriela", Genero = "Feminino", Endereco = "Rua I", Idade = 35, Municipio = "Barueri", Estado = "SP" },
                    new People { Id = 14, Cpf = "64937521099", Name = "Renato", Genero = "Masculino", Endereco = "Rua J", Idade = 31, Municipio = "Jundiaí", Estado = "SP" },
                    new People { Id = 15, Cpf = "75092846044", Name = "Juliana", Genero = "Feminino", Endereco = "Rua K", Idade = 26, Municipio = "Piracicaba", Estado = "SP" },
                    new People { Id = 16, Cpf = "86741023030", Name = "Felipe", Genero = "Masculino", Endereco = "Rua L", Idade = 24, Municipio = "Bauru", Estado = "SP" },
                    new People { Id = 17, Cpf = "97085376055", Name = "Luciana", Genero = "Feminino", Endereco = "Rua M", Idade = 36, Municipio = "Taubaté", Estado = "SP" },
                    new People { Id = 18, Cpf = "08524769070", Name = "André", Genero = "Masculino", Endereco = "Rua N", Idade = 38, Municipio = "Suzano", Estado = "SP" },
                    new People { Id = 19, Cpf = "19060847041", Name = "Isabela", Genero = "Feminino", Endereco = "Rua O", Idade = 21, Municipio = "Itapevi", Estado = "SP" },
                    new People { Id = 20, Cpf = "30872654065", Name = "Diego", Genero = "Masculino", Endereco = "Rua P", Idade = 42, Municipio = "Itu", Estado = "SP" },
                    new People { Id = 21, Cpf = "41993862015", Name = "Aline", Genero = "Feminino", Endereco = "Rua Q", Idade = 34, Municipio = "Franca", Estado = "SP" },
                    new People { Id = 22, Cpf = "52841785022", Name = "Pedro", Genero = "Masculino", Endereco = "Rua R", Idade = 29, Municipio = "Limeira", Estado = "SP" },
                    new People { Id = 23, Cpf = "60319873003", Name = "Vanessa", Genero = "Feminino", Endereco = "Rua S", Idade = 32, Municipio = "Araraquara", Estado = "SP" },
                    new People { Id = 24, Cpf = "74182649077", Name = "Henrique", Genero = "Masculino", Endereco = "Rua T", Idade = 40, Municipio = "Catanduva", Estado = "SP" },
                    new People { Id = 25, Cpf = "85923416008", Name = "Laura", Genero = "Feminino", Endereco = "Rua U", Idade = 20, Municipio = "Bragança Paulista", Estado = "SP" },
                    new People { Id = 26, Cpf = "96441723095", Name = "Daniel", Genero = "Masculino", Endereco = "Rua V", Idade = 37, Municipio = "São Carlos", Estado = "SP" },
                    new People { Id = 27, Cpf = "07852648060", Name = "Mariana", Genero = "Feminino", Endereco = "Rua W", Idade = 33, Municipio = "Presidente Prudente", Estado = "SP" },
                    new People { Id = 28, Cpf = "18294057012", Name = "Tiago", Genero = "Masculino", Endereco = "Rua X", Idade = 26, Municipio = "Marília", Estado = "SP" },
                    new People { Id = 29, Cpf = "29731468045", Name = "Patrícia", Genero = "Feminino", Endereco = "Rua Y", Idade = 28, Municipio = "Araçatuba", Estado = "SP" },
                    new People { Id = 30, Cpf = "30542679097", Name = "Lucas", Genero = "Masculino", Endereco = "Rua Z", Idade = 35, Municipio = "Assis", Estado = "SP" }
            );
    }
}