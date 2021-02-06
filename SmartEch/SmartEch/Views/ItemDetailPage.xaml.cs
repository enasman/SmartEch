using SmartEch.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SmartEch.Views
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