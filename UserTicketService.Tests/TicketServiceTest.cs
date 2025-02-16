using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GetTicketPriceMustReturnExistingPrice()
        {
            var ticketServiceTest = new TicketService();
            //Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
            Assert.That(ticketServiceTest.GetTicketPrice(1) != 0);
        }

        [Test]
        public void GetTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }

        [Test]
        public void GetTicketMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            //Assert.IsNotNull(ticketServiceTest.GetTicket(1));
            Assert.That(ticketServiceTest.GetTicketPrice(1) != 0);
        }
    }
}
