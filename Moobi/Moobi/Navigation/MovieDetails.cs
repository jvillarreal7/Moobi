using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Moobi
{
    public class MovieDetails : ContentPage
    {
        public MovieDetails()
        { 
            var previousPageButton = new Button { Text = "Previous Page", VerticalOptions = LayoutOptions.CenterAndExpand };
            previousPageButton.Clicked += OnPreviousPageButtonClicked;

            Title = "Movie Details";
            Content = new StackLayout
            {
                Children = {
                    previousPageButton
                }
            };
        }


        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
