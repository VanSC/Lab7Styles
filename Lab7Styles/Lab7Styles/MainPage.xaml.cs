using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab7Styles
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ExplicitDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitDemo());
            };

            ExplicitControlDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitControlDemo());
            };
            ImplicitDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitDemo());
            };

            ImplicitControlDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitControlDemo());
            };
            GlobalDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GlobalDemo());
            };

            DynamicDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicDemo());
            };
            InheritanceDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InheritanceDemo());
            };

            StyleWithCSS.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new StyleWithCSS());
            };

        }
    }
}
