using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AP1_P1_Jose_angel_Vargas_Polanco.Models
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }
        public DateTime fecha { get; set; }
        public string? Persona { get; set; }
        public string? Observaciones { get; set; }
        public double Monto { get; set; }
    }
}