using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace navigationpanchenko
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            string[] tasks = new string[] { "Завтрак", "Дорога в уч.заведение", "Учеба", "Обед", "Свободное время", "Ужин", "Своб.время", "Сон" };
            ListView list = new ListView();
            // определяем источник данных
            list.ItemsSource = tasks;
            Content = new StackLayout { Children = { list } };
        }
        string kell;
        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)
                {
                    kell = "7:00-7:30";
                }
                else if (e.SelectedItemIndex == 1)
                {
                    kell = "8:00-8:30";
                }
                else if (e.SelectedItemIndex == 2)
                {
                    kell = "8:30-15:00";
                }
                else if (e.SelectedItemIndex == 3)
                {
                    kell = "17:00";
                }
                else if (e.SelectedItemIndex == 4)
                {
                    kell = "19:15-20:30";
                }
                else if (e.SelectedItemIndex == 5)
                {
                    kell = "21:00";
                }
                else if (e.SelectedItemIndex == 6)
                {
                    kell = "21:00-23:00";
                }
                else if (e.SelectedItemIndex == 7)
                {
                    kell = "23:00-7:00";
                }
                await DisplayAlert(kell, text, "Ok");
            }
        }
    }
}