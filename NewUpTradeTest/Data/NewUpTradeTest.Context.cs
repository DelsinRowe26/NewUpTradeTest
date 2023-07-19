using Microsoft.EntityFrameworkCore;

namespace NewUpTradeTest.Data
{
    public class NewUpTradeTest : DbContext
    {
        public NewUpTradeTest(DbContextOptions<NewUpTradeTest> options) : base(options) { }

        public DbSet<Wallets> Wallets { get; set; }

    }
}
