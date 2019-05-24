using KrakenNotes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrakenNotes.Web.Services
{
    public interface INotesServices
    {
        IEnumerable<Note> GetNotesByUserId(string id);

        Task CreateAsync(Note note);

        Note GetNoteById(int id);

        Task UpdateAsync(Note note);

        Task DeleteAsync(int id);
    }
}
