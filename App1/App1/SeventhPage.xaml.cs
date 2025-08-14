using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeventhPage : ContentPage
    {
        public SeventhPage()
        {
            InitializeComponent();
        }

        private async void GoToPage8ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page8());
        }
    }
}