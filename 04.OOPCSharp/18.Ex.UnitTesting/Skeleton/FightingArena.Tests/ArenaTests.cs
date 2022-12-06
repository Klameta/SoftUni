namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ArenaTests
    {
        Arena arena;
        Warrior warrior;
        Warrior warrior2;

        [SetUp]
        public void SetUp()
        {
            arena = new Arena();
            warrior = new Warrior("a", 5, 50);
            warrior2 = new Warrior("b", 5, 50);
        }

        [Test]
        public void EnrollingShouldWork()
        {
            arena.Enroll(warrior);

            Assert.AreEqual(1, arena.Count);
        }

        [Test]
        public void EnrollingSameNamedWarriorsShouldNotWork()
        {
            warrior2 = new Warrior("a", 5, 50);

            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(warrior2);
            });
        }

        [Test]
        public void AttackerIsNullInFightShouldNotWork()
        {
            arena.Enroll(warrior2);
            
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight("a", "b");
            });
        }


        [Test]
        public void DefenderIsNullInFightShouldNotWork()
        {
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight("a", "b");
            });
        }


        [Test]
        public void FightShouldWork()
        {
            int expected = warrior2.HP - warrior.Damage;

            arena.Enroll(warrior);
            arena.Enroll(warrior2);
            arena.Fight("a", "b");

            Assert.AreEqual(expected, warrior2.HP);
        }

    }
}
