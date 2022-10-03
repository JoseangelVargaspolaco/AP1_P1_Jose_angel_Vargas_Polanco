using AP1_P1_Jose_angel_Vargas_Polanco.Models;
using Microsoft.EntityFrameworkCore;

namespace AP1_P1_Jose_angel_Vargas_Polanco.DAL
{

    public class Contexto : DbContext 
    {
       public DbSet<Registros> Registros { get; set; } 

       public Contexto(DbContextOptions<Contexto> options) : base(options)
       {
                              
       }
    }
}
