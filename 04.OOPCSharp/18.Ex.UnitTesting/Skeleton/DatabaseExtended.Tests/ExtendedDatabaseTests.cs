namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        Database database;
        List<Person> persons;

        [SetUp]
        public void SetUp()
        {
            database = new Database();
            persons = new List<Person>();
        }

        [Test]
        public void InitilizingTheDatabaseShouldWork()
        {
            database = new Database(persons.ToArray());

            Assert.AreEqual(persons.Count, database.Count);
        }

        [Test]
        public void InitilizingTheDatabaseShouldNotWork()
        {
            for (int i = 0; i < 17; i++)
            {
                Person person = new Person(i, ((char)'A' + i).ToString());
                persons.Add(person);
            }

            Assert.Throws<ArgumentException>(() =>
            {
                database = new Database(persons.ToArray());
            }
            );
        }

        [Test]
        public void AddingElementShouldWork()
        {
            Person person = new Person(1, "a");
            persons.Add(person);

            database.Add(person);

            Assert.AreEqual(persons.Count, database.Count);
        }

        [Test]
        public void AddingTooManyPeopleShouldNotWork()
        {
            for (int i = 0; i < 16; i++)
            {
                Person person = new Person(i, ((char)'A' + i).ToString());
                database.Add(person);
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                Person person = new Person(231, "dsf");
                database.Add(person);
            }
            );
        }

        [Test]
        public void AddingSameNamedPeopleShouldNotWork()
        {
            Person person = new Person(1, "A");

            database.Add(person);

            Assert.Throws<InvalidOperationException>(() =>
            {
                person = new Person(2, "A");
                database.Add(person);
            });

        }

        [Test]
        public void AddingSameIdPeopleShouldNotWork()
        {
            Person person = new Person(1, "a");

            database.Add(person);

            Assert.Throws<InvalidOperationException>(() =>
            {
                person = new Person(1, "A");
                database.Add(person);
            });
        }

        [Test]
        public void RemovingPersonShouldWork()
        {
            Person person = new Person(1, "a");
            database.Add(person);

            database.Remove();

            Assert.AreEqual(0, database.Count);
        }

        [Test]
        public void RemovingPersonShouldNotWork()
        {
            Assert.Catch(() =>
            {
                database.Remove();
            });
        }

        [Test]
        public void FindingPersonIdShouldWork()
        {
            Person person = new Person(1, "a");
            database.Add(person);

            Person person1 = database.FindById(person.Id);

            Assert.IsTrue(person.Id == person1.Id && person.UserName == person1.UserName);
        }
        [Test]
        public void FindingPersonNegativeIdShouldNotWork()
        {
            Person person = new Person(-1, "a");
            database.Add(person);


            Assert.Catch(() =>
            {

                Person person1 = database.FindById(person.Id);
            });
        }

        [Test]
        public void FindingNonExistentPersonIdShouldNotWork()
        {
            Person person = new Person(1, "a");


            Assert.Catch(() =>
            {

                Person person1 = database.FindById(person.Id);
            });
        }
        [Test]
        public void FindingPersonNameShouldWork()
        {
            Person person = new Person(1, "a");
            database.Add(person);

            Person person1 = database.FindByUsername(person.UserName);

            Assert.IsTrue(person.Id == person1.Id && person.UserName == person1.UserName);
        }
        [Test]
        public void FindingPersonEmptyNameShouldNotWork()
        {
            Person person = new Person(1, "");
            database.Add(person);


            Assert.Catch(() =>
            {

                Person person1 = database.FindByUsername(person.UserName);
            });
        }

        [Test]
        public void FindingNonExistentPersonNameShouldNotWork()
        {
            Person person = new Person(1, "a");


            Assert.Catch(() =>
            {

                Person person1 = database.FindByUsername(person.UserName);
            });
        }


    }
}