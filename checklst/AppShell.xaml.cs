using System;
using System.Collections.Generic;
using checklst.ViewModels;
using checklst.Views;
using Xamarin.Forms;

namespace checklst
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//LoginPage");
        }
        private async void OnCreateClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//ChecklistsPage");
        }
    }
}
