using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        Axe axe;
        Dummy dummy;

        [SetUp]
        public void SetUp()
        {
            axe = new Axe(10, 5);
            dummy = new Dummy(100, 5);
        }

        [Test]
        public void WeaponLossingDurablityWhenAttacking()
        {
            axe.Attack(dummy);

            Assert.AreEqual(4, axe.DurabilityPoints);
        }

        [Test]
        public void WeaponCannotAttackWhenBroken()
        {
            axe = new Axe(0, 0);

            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            }
            );
        }


    }
}