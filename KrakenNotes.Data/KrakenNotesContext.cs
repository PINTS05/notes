using Microsoft.EntityFrameworkCore;

namespace KrakenNotes.Data
{
    public class KrakenNotesContext : DbContext
    {
        public KrakenNotesContext(DbContextOptions options) : base(options) { }


    }
}
