using REST_ASP.NET5_Udemy.Model;
using REST_ASP.NET5_Udemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace REST_ASP.NET5_Udemy.Repository.Implementations
{
    public class PersonRepositoryImplementation : IPersonRepository
    { 
        private MySQLContext _context;

        public PersonRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }
        
        public List<Person> ListaPessoas()
        {
            return _context.Pessoas.ToList();
        }
        
        public Person AcharId(long id)
        {
            return _context.Pessoas.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Criar(Person pessoa)
        {
            try
            {
                _context.Add(pessoa);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return pessoa;        
        }

        public Person Atualizar(Person pessoa)
        {
            if (!Existe(pessoa.Id)) return new Person();   
            
            var resultado = _context.Pessoas.SingleOrDefault(p => p.Id.Equals(pessoa.Id));

            if (resultado != null)
            {
                try
                {
                    _context.Entry(resultado).CurrentValues.SetValues(pessoa);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            
            return pessoa;
        }
        
        public void Deletar(long id)
        {
            var resultado = _context.Pessoas.SingleOrDefault(p => p.Id.Equals(id));

            if (resultado != null)
            {
                try
                {
                    _context.Pessoas.Remove(resultado);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }


        }
        public bool Existe(long id)
        {
            return _context.Pessoas.Any(p => p.Id.Equals(id));
        }        
    }
}
