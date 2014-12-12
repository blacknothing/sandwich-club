using System;
using Xamarin.Forms;

namespace SandwichClubApp
{
    public class App
    {
        public static Page GetMainPage()
        {	
            return new ContentPage
            { 
                Content = new Label
                {
                    Text = "Hello, Sandwich Club!",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }
    }
}

