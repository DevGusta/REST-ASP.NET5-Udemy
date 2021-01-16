using REST_ASP.NET5_Udemy.Model;
using System.Collections.Generic;

namespace REST_ASP.NET5_Udemy.Business
{
    public interface IPersonBusiness
    {
        Person Criar(Person pessoa);
        Person AcharId(long id);
        List<Person> ListaPessoas();
        Person Atualizar(Person pessoa);
        void Deletar(long id);

    }
}
