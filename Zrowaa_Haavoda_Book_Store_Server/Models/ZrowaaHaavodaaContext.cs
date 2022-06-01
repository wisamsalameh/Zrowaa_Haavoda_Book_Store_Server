using Microsoft.EntityFrameworkCore;

namespace Zrowaa_Haavoda_Book_Store_Server.Models
{
    public class ZrowaaHaavodaaContext : DbContext
    {
        public ZrowaaHaavodaaContext(DbContextOptions<ZrowaaHaavodaaContext> options) : base(options)
        {

        }
        public virtual DbSet<BookData> bookData { get; set; }
    }
}


