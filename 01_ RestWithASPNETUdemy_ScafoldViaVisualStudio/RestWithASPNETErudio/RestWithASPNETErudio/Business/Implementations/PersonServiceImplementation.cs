using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using RestWithASPNETErudio.Controllers.Model;
using RestWithASPNETErudio.Controllers.Model.Context;
using RestWithASPNETErudio.Repository;
using System;

namespace RestWithASPNETErudio.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;
       

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
           return _repository.Create(person);
            
        }

        public void Delete(long id)
        {
           _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            
            return _repository.FindAll();
        }

        

        public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Person Update(Person person)
        {


             return _repository.Update(person);


            
            
        }



    }
}
