using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrakenNotes.Models
{
    public class Tag
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public ICollection<NoteTag> NoteTags { get; set; }
    }
}
