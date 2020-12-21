using NUnit.Framework;
using Moneybox.App;
using System;

namespace Moneybox.App.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void NegativeBalanceThrowsInvalidOperationException()
        {
            Account ac = new Account();
            Assert.Throws<InvalidOperationException>( () => ac.Balance = -5m);
        }

        [Test]
        public void PaidinBalanceGreaterThan4000ThrowsInvalidOperationException()
        {
            Account ac = new Account();
            Assert.Throws<InvalidOperationException>(() => ac.PaidIn = 4001m);
        }
    }
}
