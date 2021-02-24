using System;
namespace AulaTDD.interfaces
{
    public interface ILibrary
    {
        IBook[] Books { get; }
        void AddBook(IBook book);
        void RemoveBook(string title);
        void BorrowBook(string title);
    }
}
