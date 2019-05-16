using KrakenNotes.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KrakenNotes.Services.Interfaces
{
    public interface INotesRepository : IRepository<Note>
    {
        IEnumerable<Note> GetNotesByUserId(int id);
    }
}
