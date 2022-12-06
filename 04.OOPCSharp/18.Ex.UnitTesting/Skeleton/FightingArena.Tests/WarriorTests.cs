namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;


    [TestFixture]
    public class WarriorTests
    {
        Warrior warrior;
        Warrior warrior2;
        [SetUp]
        public void SetUp()
        {
            warrior = new Warrior("asd", 5, 50);
            warrior2 = new Warrior("asd", 5, 50);

        }

        [Test]
        [TestCase(new object[] { "smtg", 32, 12 })]
        [TestCase(new object[] { "a", 1, 1 })]
        public void ConstructorShouldAssignValuesCorrectly(object[] data)
        {
            string name = data[0].ToString();
            int dmg = int.Parse(data[1].ToString());
            int health = int.Parse(data[2].ToString());

            warrior = new Warrior(name, dmg, health);

            string actualName = warrior.Name;
            int actualDmg = warrior.Damage;
            int actualHealth = warrior.HP;

            Assert.IsTrue(name == actualName && dmg == actualDmg && health == actualHealth);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void UnvalidNameShouldNotWork(string data)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                warrior = new Warrior(data, 1, 1);
            });

        }

        [Test]
        [TestCase("asd")]
        [TestCase("a")]
        [TestCase("AAAAAAA")]
        public void ValidNameShouldWork(string data)
        {
            warrior = new Warrior(data, 1, 1);
            Assert.AreEqual(data, warrior.Name);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void UnvalidDamageShouldNotWork(int data)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                warrior = new Warrior("a", data, 1);
            });
        }

        [Test]
        [TestCase(1)]
        [TestCase(20)]
        public void ValidDamageShouldWord(int data)
        {
            warrior = new Warrior("a", data, 1);

            Assert.AreEqual(data, warrior.Damage);
        }

        [Test]
        [TestCase(-1)]
        public void UnvalidHealthShouldNotWork(int data)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                warrior = new Warrior("a", 1, data);
            });
        }

        [Test]
        [TestCase(1)]
        [TestCase(20)]
        public void ValidHealthShouldWord(int data)
        {
            warrior = new Warrior("a", 1, data);

            Assert.AreEqual(data, warrior.HP);
        }

        [Test]
        [TestCase(30)]
        [TestCase(20)]
        public void TooLittleHeathToAttackShouldNotWork(int data)
        {
            warrior = new Warrior("a", 5, data);

            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior.Attack(warrior2);
            });
        }

        [Test]
        [TestCase(30)]
        [TestCase(20)]
        public void TooLittleHeathOnEnemyToAttackShouldNotWork(int data)
        {
            warrior = new Warrior("a", 5, data);

            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior2.Attack(warrior);
            });
        }

        [Test]
        [TestCase(100)]
        [TestCase(51)]
        public void AttackingStrongEnemyShouldNotWork(int data)
        {
            warrior2 = new Warrior("asd", data, 50);

            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior.Attack(warrior2);
            });
        }

        [Test]
        [TestCase(20)]
        [TestCase(30)]
        [TestCase(10)]
        public void WarriorsHPShouldLowerWhenAttacking(int data)
        {
            warrior2 = new Warrior("asd", data, 50);
            int expected = warrior.HP - data;

            warrior.Attack(warrior2);

            Assert.AreEqual(expected, warrior.HP);
        }

        [Test]
        [TestCase(51)]
        [TestCase(100)]
        public void WhenDamageIsMoreThanEnemysHealthHPShouldBe0(int data)
        {
            warrior = new Warrior("asd", data, 50);

            warrior.Attack(warrior2);

            Assert.AreEqual(0, warrior2.HP);
        }

        [Test]
        [TestCase(50)]
        [TestCase(10)]
        public void AttackingShouldLowerEnemyHP(int data)
        {
            int expected = warrior2.HP - data;

            warrior = new Warrior("asd", data, 50);
            warrior.Attack(warrior2);

            Assert.AreEqual(expected, warrior2.HP);
        }
    }
}