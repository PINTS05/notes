using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrakenNotes.Web.Services
{
    public static class NotesServicesExtensions
    {
        public static IServiceCollection AddNotes(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddScoped<INotesServices, NotesServices>();
        }
    }
}
