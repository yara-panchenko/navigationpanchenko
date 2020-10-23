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
    public partial class Page7 : ContentPage
    {
        public Page7()
        {
            string[] tasks = new string[] { "Завтрак", "Тренажерный зал", "Обед", "Соревнования", "Ужин", "Своб.время", "Сон" };
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
                    kell = "10:00-11:00";
                }
                else if (e.SelectedItemIndex == 2)
                {
                    kell = "12:00";
                }
                else if (e.SelectedItemIndex == 3)
                {
                    kell = "14:00-17:00";
                }
                else if (e.SelectedItemIndex == 4)
                {
                    kell = "18:00";
                }
                else if (e.SelectedItemIndex == 5)
                {
                    kell = "18:00-23:00";
                }
                else if (e.SelectedItemIndex == 6)
                {
                    kell = "23:00-8:00";
                }
                await DisplayAlert(kell, text, "Ok");
            }
        }
    }
}