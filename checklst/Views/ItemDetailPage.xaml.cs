using System.ComponentModel;
using Xamarin.Forms;
using checklst.ViewModels;

namespace checklst.Views
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