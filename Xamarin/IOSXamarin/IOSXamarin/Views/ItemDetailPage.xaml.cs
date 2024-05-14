using IOSXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace IOSXamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}