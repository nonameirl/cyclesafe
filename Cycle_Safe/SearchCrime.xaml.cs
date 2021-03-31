using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using static Cycle_Safe.Globalclass;

namespace Cycle_Safe
{
    public sealed partial class SearchCrime : Page
    {
        public SearchCrime()
        {
            this.InitializeComponent();
        }

        private void Search_Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CrimeReport));
        }
    }
}