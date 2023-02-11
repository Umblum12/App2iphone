using App2iphone.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App2iphone.Views
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