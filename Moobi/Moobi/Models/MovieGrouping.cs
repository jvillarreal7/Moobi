using System;
using System.Collections.Generic;
using System.Text;

namespace Moobi
{
    public class RecipeGrouping : List<Pelicula>
    {
        public string Title { get; set; }
        public string ShortName { get; set; }

        public RecipeGrouping(string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }
    }

    public class MovieGrouping : List<Pelicula>
    {
        public string Title { get; set; }
        public string ShortName { get; set; }

        public MovieGrouping(string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }
    }
}
