using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Moobi
{
    public class MovieList : ContentPage
    {
        public MovieList()
        {
            var nextPageButton = new Button { Text = "Next Page", VerticalOptions = LayoutOptions.CenterAndExpand };
            nextPageButton.Clicked += OnNextPageButtonClicked;

            Title = "Movie List";
            Content = new StackLayout
            {
                Children = {
                    nextPageButton
                }
            };
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Moobi.Views.MovieListPage());
        }
    }
}
