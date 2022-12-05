using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {

        Dummy dummy;
        Axe axe;

        [SetUp]
        public void SetUp()
        {
            dummy = new Dummy(10, 5);
            axe = new Axe(5, 5);
        }
        [Test]
        public void DummyShouldLoseHealthWhenAttacked()
        {
            axe.Attack(dummy);

            Assert.AreEqual(5, dummy.Health);
        }

        [Test]
        public void DeadDummyShouldThrowExceptionWhenAttackedDead()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    axe.Attack(dummy);
                }

            });
        }

        [Test]
        public void DeadDummyShouldGiveXP()
        {
            axe.Attack(dummy);
            axe.Attack(dummy);

            int xp = dummy.GiveExperience();

            Assert.AreEqual(5, xp);
        }

        [Test]
        public void AliveDummyShouldNotGiveXP()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            });
        }
    }
}