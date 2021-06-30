using Android.Graphics;
using Demos.ViewModel;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DettaglioView : TabbedPage
    {
        public DettaglioView()
        {
            InitializeComponent();
            Title = Preferences.Get("percorso", "");
            BindingContext = new DettaglioModel();
            string t = "Demos.Programmi." + Title.Replace(" ", "_") + ".01.png";
            image1.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".01.png");
            image2.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".02.png");
            image3.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".03.png");
            image4.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".04.png");
            image5.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".05.png");
            image6.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".06.png");
            image7.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".07.png");
            image8.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".08.png");
            image9.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".09.png");
            image10.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".10.png");
            image11.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".11.png");
            image12.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".12.png");
            image13.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".13.png");
            image14.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".14.png");
            image15.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".15.png");
            image16.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".16.png");
            image17.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".17.png");
            image18.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".18.png");
            image19.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".19.png");
            image20.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".20.png");
            image21.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".21.png");
            image22.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".22.png");
            image23.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".23.png");
            image24.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".24.png");
            image25.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".25.png");
            image26.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".26.png");
            image27.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".27.png");
            image28.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".28.png");
            image29.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".29.png");
            image30.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".30.png");
            image31.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".31.png");
            image32.Source = ImageSource.FromResource("Demos.Programmi." + Title.Replace(" ", "_") + ".32.png");
        }



        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (Device.RuntimePlatform == Device.UWP)
            {
                image1.HeightRequest = Application.Current.MainPage.Height - 20 - (Application.Current.MainPage.Height / 100 * 25);
                rowImage2.Height = image1.HeightRequest;
            }
            else if(Device.RuntimePlatform == Device.Android)
            {
                image1.HeightRequest = Application.Current.MainPage.Height - 20 - (Application.Current.MainPage.Height / 100 * 25);
                rowImage2.Height = image1.HeightRequest;
            }
        }

        public async void OnButtonClicked(object sender, EventArgs e)
        {


            //if (Title == "AbsoluteLayout")
            //{
            //    await Navigation.PushAsync(new AbsoluteLayoutDemos.MainPage());
            //}
            //else if (Title == "Accessibility")
            //{
            //    await Navigation.PushAsync(new Accessibility.MainPage());
            //}
            //else if (Title == "ActivityIndicator")
            //{
            //    await Navigation.PushAsync(new ActivityIndicatorDemos.MainPage());
            //}
            //else if (Title == "Weather App")
            //{
            //    await Navigation.PushAsync(new WeatherApp.MainPage());
            //}
            //else if (Title == "Game of Life")
            //{   //NON FUNZIONA COME DOVREBBE
            //    //await Navigation.PushAsync(new GameOfLife.MainPage());
            //}
            //else if (Title == "XamFormsImageResize")
            //{   ///va in errore
            //    //await   Navigation.PushAsync(new HomePage(), true);
            //}   
            //else if (Title == "Xaminals")
            //{   // VA IN EXCEPTION
            //    //await Application.Current.MainPage.Navigation.PopAsync();   
            //    //                          Application.Current.MainPage = new AppShell();  
            //    //MainPage = new Xaminals.AppShell();
            //}
            //else if (Title == "XamlSamples")
            //{
            //    //await Navigation.PushAsync(new XamlSamples.MainPage(), true); 
            //}
            //else if (Title == "Xuzzle")
            //{
            //    await Navigation.PushAsync(new Xuzzle.XuzzlePage(), true);

            //}
        }
    }
}

