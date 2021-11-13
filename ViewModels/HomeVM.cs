using Level.DbContexts;
using Level.Migrations;
using Level.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact = Level.Models.Contact;

namespace Level.ViewModels
{

    public class HomeVM
    {
        public IEnumerable<Tour> Tours { get; set; }
        public IEnumerable<Models.Country> Countries { get; set; }
        public IEnumerable<Models.News> News { get; set; }
        public Contact Contact { get; set; }
    }
}
