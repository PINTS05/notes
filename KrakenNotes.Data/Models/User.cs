using System.Collections.Generic;

namespace KrakenNotes.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public int ColorMode { get; set; }

        public ICollection<Note> Notes { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
