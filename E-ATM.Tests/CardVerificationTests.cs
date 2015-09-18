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
        public void CardVerificationFailsIfEmptyGuid()
        {
            card.Id = Guid.Empty;
            Assert.AreEqual(false,atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationSucceedsIfNotEmptyGuid()
        {
            card.Id = Guid.NewGuid();
            card.Bin = "1234567890987654";
            Assert.AreEqual(true, atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationSucceedsIfActive()
        {
            card.Id = Guid.NewGuid();
            card.Status = CardStatus.Active;
            card.Bin = "1234567890987654";
            Assert.AreEqual(true, atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationFailsIfBlocked()
        {
            card.Id = Guid.NewGuid();
            card.Status = CardStatus.Blocked;
            Assert.AreEqual(false, atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationFailsIfCancelled()
        {
            card.Id = Guid.NewGuid();
            card.Status = CardStatus.Cancelled;
            Assert.AreEqual(false, atm.ValidateCard(card));
        }

        [Test]
        public void CardVerificationFailsIfExpired()
        {
            card.Id = Guid.NewGuid();
            card.Status = CardStatus.Expired;
            Assert.AreEqual(false, atm.ValidateCard(card));
        }
    }
}
