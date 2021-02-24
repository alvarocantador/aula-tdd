using System;
using AulaTDD.interfaces;

namespace AulaTDD.model
{
    public class Library : ILibrary
    {
        public IBook[] Books => throw new NotImplementedException();

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

        }

        public Library(IBook[] books)
        {

        }
    }
}
