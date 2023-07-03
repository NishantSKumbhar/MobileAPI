using Microsoft.EntityFrameworkCore;
using MobileAPI.Model.Domain;

namespace MobileAPI.Data
{
    public class MobileDbContext: DbContext
    {
        public MobileDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        // When we run entity core migrations, Below property will create tables in database.
        public DbSet<MobileModel> MobileT { get; set; }
    }
}
