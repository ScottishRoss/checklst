using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using checklst.Models;
using checklst.Views;
using checklst.ViewModels;

namespace checklst.Views
{
    public partial class ChecklistsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ChecklistsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}