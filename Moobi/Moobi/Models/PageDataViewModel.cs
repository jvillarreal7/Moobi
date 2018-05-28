using Moobi.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moobi
{
    public class PageDataViewModel
    {
        public PageDataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
        {
            // Part 1. Getting Started with XAML
            new PageDataViewModel(typeof(MovieListPage), "Hello, XAML",
                                  "Display a Label with many properties set"),

            new PageDataViewModel(typeof(EditMoviePage), "XAML + Code",
                                  "Interact with a Slider and Button"),
        };
        }

        public static IList<PageDataViewModel> All { private set; get; }
    }
}
