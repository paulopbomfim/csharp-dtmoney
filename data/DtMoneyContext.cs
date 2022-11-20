using Microsoft.EntityFrameworkCore;

namespace DtMoney.Data;

public class DtMoneyContext : DbContext
{
    public DtMoneyContext (DbContextOptions options): base(options) {}
    public DtMoneyContext () {}

    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=dtmoney;User=SA;Password=Password12!");
    }
}