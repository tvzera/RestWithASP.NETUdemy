using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using RestWithASPNETErudio.Controllers.Model;
using RestWithASPNETErudio.Controllers.Model.Context;
using RestWithASPNETErudio.Repository;
using System;

namespace RestWithASPNETErudio.Business.Implementations
{
    public class BooksBusinessImplementation : IBooksBusiness
    {
        private readonly IBooksRepository _repositorys;
       

        public BooksBusinessImplementation(IBooksRepository repositorys)
        {
            _repositorys = repositorys;
        }

        public Books Create(Books books)
        {
           return _repositorys.Create(books);
            
        }

        public void Delete(long id)
        {
           _repositorys.Delete(id);
        }

        public List<Books> FindAll()
        {
            
            return _repositorys.FindAll();
        }

        

        public Books FindByID(long id)
        {
            return _repositorys.FindByID(id);
        }

        public Books Update(Books person)
        {


             return _repositorys.Update(person);


            
            
        }



    }
}
