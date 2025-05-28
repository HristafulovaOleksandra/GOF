using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.IteratorExample
{
    public class Library //collection
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public IBookIterator CreateIterator()
        {
            return new BookIterator(books);
        }
    }

}
