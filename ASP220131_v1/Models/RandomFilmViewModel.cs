using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP220131_v1.Models
{
    public class RandomFilmViewModel
    {
        public Film Film { get; set; }
        public List<Ugyfel> Kolcsonzok { get; set; }
    }
}