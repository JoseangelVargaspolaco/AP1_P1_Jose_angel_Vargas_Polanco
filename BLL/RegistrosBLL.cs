using Microsoft.EntityFrameworkCore;
using AP1_P1_Jose_angel_Vargas_Polanco.Models;
using AP1_P1_Jose_angel_Vargas_Polanco.DAL;
using System.Linq.Expressions;

namespace AP1_P1_Jose_angel_Vargas_Polanco.BLL
{
    public class RegistrosBLL
    {
        private Contexto _contexto;
        public RegistrosBLL(Contexto contexto){
            _contexto = contexto;
        }

        public bool Existe(int registrosId){
            return _contexto.Registros.Any(o => o.RegistroId == registrosId);
        }

        private bool Insertar(Registros registros){
            _contexto.Registros.Add(registros);
            return _contexto.SaveChanges()> 0;
        }

        public bool Modificar(Registros registros){
            _contexto.Entry(registros).State = EntityState.Modified;
            return _contexto.SaveChanges()> 0;
        }

        public bool Guardar(Registros registros){
            if (!Existe(registros.RegistroId))
                return this.Insertar(registros);
            else
                return this.Modificar(registros);
        }

        public bool Editar(Registros registros){
            if (!Existe(registros.RegistroId))
                return this.Insertar(registros);
            else
                return this.Modificar(registros);
        }

        public bool Eliminar(Registros registros){
            _contexto.Entry(registros).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }

        public Registros? Buscar(int registroId){
            return _contexto.Registros
                    .Where(o=> o.RegistroId== registroId)
                    .AsNoTracking()
                    .SingleOrDefault();       
        }
        public List<Registros> GetRegistros(Expression<Func<Registros, bool>> Criterio){
            return _contexto.Registros
                .AsNoTracking()
                .Where(Criterio)
                .ToList();
        }
    }
}