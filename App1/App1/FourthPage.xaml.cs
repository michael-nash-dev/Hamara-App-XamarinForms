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
    public partial class FourthPage : ContentPage
    {
        public FourthPage()
        {
            InitializeComponent();
        }

        private async void GoToFifthPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FifthPageSasso());
        }
    }
}