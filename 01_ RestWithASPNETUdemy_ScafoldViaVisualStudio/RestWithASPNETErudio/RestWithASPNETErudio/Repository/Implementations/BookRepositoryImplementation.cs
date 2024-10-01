using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using RestWithASPNETErudio.Controllers.Model;
using RestWithASPNETErudio.Controllers.Model.Context;
using RestWithASPNETErudio.Repository;
using System;

namespace RestWithASPNETErudio.Repository.Implementations
{
    public class BooksRepositoryImplementation : IBooksRepository
    {
        private MySqlContext _context;
       

        public BooksRepositoryImplementation(MySqlContext context)
        {
            _context = context;
        }

        public Books Create(Books books)
        {
            try
            {
                _context.Add(books);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return books;
        }

        public void Delete(long id)
        {
            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Books.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public List<Books> FindAll()
        {
            
            return _context.Books.ToList();
        }

        

        public Books FindByID(long id)
        {
            return _context.Books.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Books Update(Books books)
        {

          
            if (!Exists(books.Id)) return null;
            
            
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(books.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(books);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }

                
            return books;
            
        }
        public bool Exists(long id)
        {
            return _context.Books.Any(p => p.Id.Equals(id));
        }



    }
}
