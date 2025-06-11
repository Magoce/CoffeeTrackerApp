using CoffeeTrackerApp.Models;
using CoffeeTrackerApp.PageModels;

namespace CoffeeTrackerApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}