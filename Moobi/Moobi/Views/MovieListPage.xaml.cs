using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Moobi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieListPage : ContentPage
    {
        public MovieListPage()
        {
            InitializeComponent();
        }

        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                //Page page = new EditMoviePage();

                //PageDataViewModel pageData = args.SelectedItem as PageDataViewModel;
                //Page page = (Page)Activator.CreateInstance(pageData.Type);
                //await Navigation.PushAsync(page);
            }
        }

    }
}