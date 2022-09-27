using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AP1_P1_Jose_angel_Vargas_Polanco.Models
{
    public class Registros
    {
        [Key]
        public int RegistroId { get; set; }
    }
}