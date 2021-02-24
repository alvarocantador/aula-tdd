using System;
using AulaTDD.interfaces;

namespace AulaTDD.model
{
    public class Library : ILibrary
    {
        private IBook[] _books;

        public IBook[] Books => _books;

        public void AddBook(IBook book)
        {
            throw new NotImplementedException();
        }

        public void BorrowBook(string title)
        {
            throw new NotImplementedException();
        }

        public void RemoveBook(string title)
        {
            throw new NotImplementedException();
        }

        public Library()
        {
            _books = new IBook[] { };
        }

        public Library(IBook[] books)
        {
            _books = books;
        }
    }
}
