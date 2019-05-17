using Microsoft.AspNetCore.Mvc;
using KrakenNotes.Services.Interfaces;
using KrakenNotes.Services;

namespace KrakenNotes.Web.Controllers
{
    public class NotesController : Controller
    {
        private readonly INotesRepository _repository;

        public NotesController(INotesRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(int id)
        {
            return View(_repository.GetNotesByUserId(id));
        }
    }
}