using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace navigationpanchenko
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button tbl_btn1 = new Button { Text = "Esmaspaev" };
            Button tbl_btn2 = new Button { Text = "Teisispaev" };
            Button tbl_btn3 = new Button { Text = "Kolmapaev" };
            Button tbl_btn4 = new Button { Text = "Neljapaev" };
            Button tbl_btn5 = new Button { Text = "Reede" };
            Button tbl_btn6 = new Button { Text = "Laupaev" };
            Button tbl_btn7 = new Button { Text = "Puhapaev" };
            StackLayout st = new StackLayout();
            st.Children.Add(tbl_btn1);
            st.Children.Add(tbl_btn2);
            st.Children.Add(tbl_btn3);
            st.Children.Add(tbl_btn4);
            st.Children.Add(tbl_btn5);
            st.Children.Add(tbl_btn6);
            st.Children.Add(tbl_btn7);
            Content = st;
            tbl_btn1.Clicked += tbl_btn_Clicked;
            tbl_btn2.Clicked += tbl_btn2_Clicked;
            tbl_btn3.Clicked += tbl_btn3_Clicked;
            tbl_btn4.Clicked += tbl_btn4_Clicked;
            tbl_btn5.Clicked += tbl_btn5_Clicked;
            tbl_btn6.Clicked += tbl_btn6_Clicked;
            tbl_btn7.Clicked += tbl_btn7_Clicked;
        }
        private async void tbl_btn7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page7());
        }
        private async void tbl_btn6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page6());
        }
        private async void tbl_btn5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
        private async void tbl_btn4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
        private async void tbl_btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
        private async void tbl_btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
