using REST_ASP.NET5_Udemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace REST_ASP.NET5_Udemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person AcharId(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                PrimeiroNome = "Gustavo",
                Sobrenome = "Nascimento",
                Endereco = "São Paulo-SP",
                Genero = "Masculino"
            };
        }

        public Person Atualizar(Person pessoa)
        {

            return pessoa;
        }

        public Person Criar(Person pessoa)
        {
            return pessoa;
        }

        public void Deletar(long id)
        {
            
        }

        public List<Person> ListaPessoas()
        {
            List<Person> pessoas = new List<Person>();
            for(int i = 0; i < 8; i++) 
            {
                Person pessoa = MockPessoa(i);
                pessoas.Add(pessoa);
            }
   
            return pessoas;
        }

        private Person MockPessoa(int i)
        {
            return new Person
            {
                Id = IncrementAndGet() ,
                PrimeiroNome = "Nome da Pessoa" + i,
                Sobrenome = "Sobrenome da Pessoa" + i,
                Endereco = "Endereço da Pessoa" + i,
                Genero = "Masculino"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count) ;
        }
    }
}
