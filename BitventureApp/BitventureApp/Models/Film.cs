using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitventureApp.Models
{
   public class Film
    {
        public string Title { get; set; }
        public int Episode_id { get; set; }
        public string Opening_crawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Release_date { get; set; }
        public string[] Characters { get; set; }
        public string[] Planets { get; set; }
        public string[] Starships { get; set; }
        public string[] Vehicles { get; set; }
        public string[] Species { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}
