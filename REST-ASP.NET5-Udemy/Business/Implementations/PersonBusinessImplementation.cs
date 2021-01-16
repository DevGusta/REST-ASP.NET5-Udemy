using REST_ASP.NET5_Udemy.Model;
using REST_ASP.NET5_Udemy.Model.Context;
using REST_ASP.NET5_Udemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace REST_ASP.NET5_Udemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }
        
        public List<Person> ListaPessoas()
        {
            return _repository.ListaPessoas();
        }
        
        public Person AcharId(long id)
        {
            return _repository.AcharId(id);
        }

        public Person Criar(Person pessoa)
        {
            
            return _repository.Criar(pessoa);        
        }

        public Person Atualizar(Person pessoa)
        {
            return _repository.Atualizar(pessoa);
        }
        
        public void Deletar(long id)
        {
            _repository.Deletar(id);
        }     
    }
}
