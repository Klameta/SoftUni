using NUnit.Framework;
using System;

namespace FootballTeam.Tests
{
    public class Tests
    {
        FootballTeam ft;
        FootballPlayer footballPlayer;

        [SetUp]
        public void Setup()
        {
             ft = new FootballTeam("ab", 20);
            footballPlayer = new FootballPlayer("ad", 1, "Goalkeeper");
        }

        [Test]
        public void Test1()
        {
            FootballTeam ft = new FootballTeam("ab", 20);

            Assert.AreEqual("ab", ft.Name);

            Assert.AreEqual(20, ft.Capacity);
        }

        [Test]
        public void NameShouldNotWOrk()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FootballTeam ft = new FootballTeam("", 20);
            });
        }

        [Test]
        public void CapacityShouldNotWork()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FootballTeam ft = new FootballTeam("", 10);
            });
        }

        [Test]
        public void AddingShouldWork()
        {
            FootballPlayer footballPlayer = new FootballPlayer("ad", 1, "Goalkeeper");
            ft.AddNewPlayer(footballPlayer);

            Assert.AreEqual(1, ft.Players.Count);
        }
        [Test]
        public void AddingSHouldNotWork()
        {
           
            for (int i = 0; i < 25; i++)
            {
                ft.AddNewPlayer(footballPlayer);

            }

            Assert.AreEqual(20, ft.Players.Count);
        }

        [Test]
        public void Picking()
        {
            ft.AddNewPlayer(footballPlayer);
            var curr =ft.PickPlayer("ad");

            Assert.AreEqual(curr.Name, "ad");
        }


    }
}