namespace Book.Tests
{
    using System;

    using NUnit.Framework;

    public class Tests
    {
        Book book;
        [SetUp]
        public void SetUp()
        {
            book = new Book("a", "b");
        }

        [Test]
        public void ConstructorShouldWork()
        {
            Book book = new Book("a", "b");

            Assert.AreEqual("a", book.BookName);
            Assert.AreEqual("b", book.Author);
            Assert.AreEqual(0, book.FootnoteCount);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ConstructorBookNameShouldNotWork(string bookName)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Book book = new Book(bookName, "b");
            });

        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ConstructorAuthorShouldNotWork(string author)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Book book = new Book("a", author);
            });

        }

        [Test]
        public void AddFootNoteShouldWork()
        {
            book.AddFootnote(1, "a");
            Assert.AreEqual(book.FootnoteCount, 1);
        }

        [Test]
        public void AddingFootNoteShouldNotWork()
        {
            book.AddFootnote(1, "a");
            Assert.Throws<InvalidOperationException>(() =>
            {
                book.AddFootnote(1, "b");
            });
        }

        [Test]
        public void FindingFootnoteShouldWork()
        {
            book.AddFootnote(1, "a");
            Assert.AreEqual("Footnote #1: a", book.FindFootnote(1));
        }

        [Test]
        public void FindingFootnoteShouldNotWork()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                book.FindFootnote(1);
            });
        }

        [Test]
        public void AlteringFootnoteShouldNotWork()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                book.AlterFootnote(1, "a");
            });
        }

        [Test]
        public void AlteringFootnoteShouldWork()
        {
            book.AddFootnote(1, "a");
            book.AlterFootnote(1, "b");

            Assert.AreEqual("Footnote #1: b", book.FindFootnote(1));
        }
    }
}