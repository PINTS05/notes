using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrakenNotes.Models
{
    public class Note
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
        public ICollection<NoteTag> NoteTags { get; set; }
    }
}
