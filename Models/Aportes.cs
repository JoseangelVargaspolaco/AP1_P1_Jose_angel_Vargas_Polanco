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

        [Required(ErrorMessage = "Favor de ingresar una observacion")]
        public string? Observacion { get; set; }

        [Range(1000, 20000000), Required(ErrorMessage = "Favor de ingresar un monto valido entre el rango (1000 hasta 20000000)")]
        public double Monto { get; set; }
    }
}