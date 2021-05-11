using NUnit.Framework;
using MovieTickets.CostAnalyzer.Service;

namespace MovieTickets.CostAnalyzer.Tests.Unit
{
    [TestFixture]
    public class Tests
    {
        private MovieTicketsService _movieTicketsService;
        [SetUp]
        public void Setup()
        {
            _movieTicketsService = new MovieTicketsService();
        }

        [Test]
        public void TestProcessTransaction()
        {
            var transaction1 = new Transaction();
            transaction1.transactionId = 1;
            transaction1.customers[0].age = 36;
            transaction1.customers[0].name = "Jesse James";

            transaction1.customers[1].age = 95;
            transaction1.customers[1].name = "Daniel Anderson";

            var result = _movieTicketsService.ProcessTransaction(transaction1);
            Assert.NotNull(result);
        }
    }
}