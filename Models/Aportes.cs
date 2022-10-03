using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AP1_P1_Jose_angel_Vargas_Polanco.Models
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }
        public DateTime Fecha { get; set; }
        public string? Persona { get; set; }
        public string? Observacion { get; set; }
        public double Monto { get; set; }
    }
}