using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_ATM.Library;
using NUnit.Framework;

namespace E_ATM.Tests
{
    [TestFixture]
    public class CardVerificationTests
    {
        private ICard card;
        private IATM atm;

        [SetUp]
        public void Init()
        {
            card = new Card();
            atm = new ATM();
        }

        [Test]
        public void CardVerificationFailsIfEmptyBIN()
        {
            card.BIN = String.Empty;
            Assert.AreEqual(false,atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationFailsIfBINLengthInvalid()
        {
            card.BIN = "123212315454552";
            Assert.AreEqual(false, atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationFailsIfDefaultBIN()
        {
            card.BIN = "0000000000000000";
            Assert.AreEqual(false, atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationSucceedsIfNotEmptyGuid()
        {
            card.BIN = "1234123412341234";
            Assert.AreEqual(true, atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationSucceedsIfActive()
        {
            card.BIN = "1234123412341234";
            Assert.AreEqual(true, atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationFailsIfBlocked()
        {
            card.BIN = "1234123412341235";
            Assert.AreEqual(false, atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationFailsIfCancelled()
        {
            card.BIN = "1234123412341236";
            Assert.AreEqual(false, atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationFailsIfExpired()
        {
            card.BIN = "1234123412341237";
            Assert.AreEqual(false, atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationFailsIfCardIsNull()
        {
            card = null;
            Assert.AreEqual(false, atm.ValidateCard(card));
        }

        [Test]
        public void CardAuthorizationFailsIfInvalidPIN()
        {
            int pin = 1111;
            card.BIN = "1234123412341234";
            Assert.AreEqual(false, atm.AuthorizeLogin(card, pin));
        }

        [Test]
        public void CardAuthorizationSucceedsIfValidPIN()
        {
            int pin = 1234;
            card.BIN = "1234123412341234";
            Assert.AreEqual(true, atm.AuthorizeLogin(card, pin));
        }

        [Test]
        public void ChangePINSuccess()
        {
            int pin = 1111;
            card.BIN = "1111111111111111";
            Assert.AreEqual(true, atm.ChangePin(card, pin));
        }
    }
}
