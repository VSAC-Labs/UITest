using System.ComponentModel;
using Xamarin.Forms;
using Sample.ViewModels;

namespace Sample.Views
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
