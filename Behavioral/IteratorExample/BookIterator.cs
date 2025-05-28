using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.IteratorExample
{
    public class BookIterator : IBookIterator
    {
        private List<Book> _books;
        private int _position = 0;

        public BookIterator(List<Book> books)
        {
            _books = books;
        }

        public bool HasNext()
        {
            return _position < _books.Count;
        }

        public Book Next()
        {
            return _books[_position++];
        }
    }

}
