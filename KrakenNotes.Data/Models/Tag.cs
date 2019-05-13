using System.Collections.Generic;

namespace KrakenNotes.Data.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        
        public ICollection<NoteTag> NoteTags { get; set; }

        public User User { get; set; }
    }
}
