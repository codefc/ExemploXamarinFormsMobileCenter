using System;

using ExemploAplicacaoMobileCenter.Models;
using ExemploAplicacaoMobileCenter.ViewModels;

using Xamarin.Forms;

namespace ExemploAplicacaoMobileCenter.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

    }
}
