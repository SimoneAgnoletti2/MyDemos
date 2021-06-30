using Demos.Model;
using Demos.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;

namespace Demos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridProgrammi : ContentPage
    {
        private ToolbarItem toolbarItem;
        public GridProgrammi()
        {
            InitializeComponent();
            BindingContext = new GridProgrammiModel();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var programma = ((ListView)sender).SelectedItem as Programma;
            if (programma.Percorso != null)
            {
                Preferences.Set("percorso", programma.Percorso);
                Preferences.Set("id", programma.ID);
                await Navigation.PushAsync(new DettaglioView(), true);
            }
        }

        async void SearchClick(object sender, EventArgs e)
        {
            if (SearchEntry.IsVisible)
                SearchEntry.IsVisible = false;
            else
                SearchEntry.IsVisible = true;
        }

        async void OnListViewTapped(object sender, SelectedItemChangedEventArgs e)
        {
            var programma = ((ListView)sender).SelectedItem as Programma;
            if (programma.Percorso != null)
            {
                Preferences.Set("percorso", programma.Percorso);
                Preferences.Set("id", programma.ID);
                await Navigation.PushAsync(new DettaglioView(), true);
            }
        }

    }
}

