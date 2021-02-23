using System;
using AulaTDD.interfaces;

namespace AulaTDD.model
{
    public class Book : IBook
    {
        private bool _isAvailable { get; set; }

        public string Title { get; set; }

        public bool IsAvailable => _isAvailable;

        public void Borrow()
        {
            _isAvailable = false;
        }


        public Book()
        {
            _isAvailable = true;
        }
    }
}
