using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace PhoneWord.Test
{
    [TestFixture]
    public class AccountTest
    {
        Account source;
        Account destination;

        [SetUp]
        public void init()
        {
            source = new Account();
            source.Deposit(200.00F);
            destination = new Account();
            destination.Deposit(150.00F);
        }
       

        [Test]
        public void TransferFounds()
        {
            

            source.TransferFunds(destination, 100.00F);
            NUnit.Framework.Assert.AreEqual(250.00F, destination.Balance);
            NUnit.Framework.Assert.AreEqual(100.00F, source.Balance);
        }


        [Test]
        public void TransferFounds1()
        {
            Account source = new Account();
            source.Deposit(200.00F);
            Account destination = new Account();
            destination.Deposit(150.00F);

            source.TransferFunds(destination, 100.00F);
            Assert.AreEqual(250.00F, destination.Balance);
            Assert.AreEqual(200.00F, source.Balance);
        }
    }
}
