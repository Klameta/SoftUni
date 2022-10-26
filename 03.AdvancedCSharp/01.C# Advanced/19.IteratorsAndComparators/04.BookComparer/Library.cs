using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
            Books.Sort(new BookComparator());
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       public class LibraryIterator : IEnumerator<Book>
        {
            public List<Book> Books { get; set; }

            public int currentIndex { get; set; }

            public Book Current => this.Books[currentIndex];

            object IEnumerator.Current => this.Current;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.Books = new List<Book>(books);
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                return ++this.currentIndex < this.Books.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }

    }
}
