using Microsoft.EntityFrameworkCore;
using AP1_P1_Jose_angel_Vargas_Polanco.Models;
using AP1_P1_Jose_angel_Vargas_Polanco.DAL;
using System.Linq.Expressions;

namespace AP1_P1_Jose_angel_Vargas_Polanco.BLL
{
    public class AportesBLL
    {
        private Contexto _contexto;
        public AportesBLL(Contexto contexto){
            _contexto = contexto;
        }

        public bool Existe(int aporteId){
            return _contexto.Aportes.Any(o => o.AporteId == aporteId);
        }

        private bool Insertar(Aportes aportes){
            _contexto.Aportes.Add(aportes);
            return _contexto.SaveChanges()> 0;
        }

        public bool Modificar(Aportes aportes){
            _contexto.Entry(aportes).State = EntityState.Modified;
            return _contexto.SaveChanges()> 0;
        }

        public bool Guardar(Aportes aportes){
            if (!Existe(aportes.AporteId))
                return this.Insertar(aportes);
            else
                return this.Modificar(aportes);
        }

        public bool Editar(Aportes aportes){
            if (!Existe(aportes.AporteId))
                return this.Insertar(aportes);
            else
                return this.Modificar(aportes);
        }

        public bool Eliminar(Aportes aportes){
            _contexto.Entry(aportes).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }

        public Aportes? Buscar(int aportesId){
            return _contexto.Aportes
                    .Where(o=> o.AporteId == aportesId)
                    .AsNoTracking()
                    .SingleOrDefault();       
        }
        public List<Aportes> GetAportes(Expression<Func<Aportes, bool>> Criterio){
            return _contexto.Aportes
                .AsNoTracking()
                .Where(Criterio)
                .ToList();
        }
    }
}