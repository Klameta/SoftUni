namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        Database database;

        [SetUp]
        public void SetUp()
        {
            database = new Database();
        }


        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        [TestCase(new int[] { })]
        public void InitilizingTheDatabaseShouldWork(int[] data)
        {
            database = new Database(data);
            Assert.AreEqual(data.Length, database.Count);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        public void InitilizingTheDatabaseShouldNotWork(int[] data)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database = new Database(data);
            }
            );
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })]

        public void AddingElementsShouldWork(int[] data)
        {
            database = new Database(data);

            database.Add(1);

            Assert.AreEqual(data.Length + 1, database.Count);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void AddingElementsShouldNotWork(int[] data)
        {
            database = new Database(data);
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(1);

            });
        }

        [Test]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 })]

        public void RemovingElementsShouldWork(int[] data)
        {
            database = new Database(data);
            database.Remove();

            List<int> dataList = new List<int>(data);
            dataList.RemoveAt(dataList.Count - 1);

            CollectionAssert.AreEqual(dataList, database.Fetch());
        }

        [Test]
        public void RemovingElementsShouldNotWork()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });
        }

        /*        [Test]
                [TestCase(new char[] {'a'})]
                [TestCase(new double[] {1.4})]
                public void InitilizingShouldNotWork(object[] data)
                {
                    Assert.Catch(() =>
                    {
                        database = new Database(data);
                    });
                }*/

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void FetchingShouldWork(int[] data)
        {
            database = new Database(data);
            CollectionAssert.AreEqual(data, database.Fetch());
        }
    }
}
