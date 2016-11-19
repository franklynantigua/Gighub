using Gighub.Models;
using System.Collections.Generic;

namespace Gighub.ViewModel
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; } 
        public string Time { get; set; }
        public byte  Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}