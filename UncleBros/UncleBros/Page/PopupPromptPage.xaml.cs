using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UncleBros.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupPromptPage : ContentPage
    {
        public PopupPromptPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var id = ((Button)sender).Id;

            if (id == btnAlert.Id)
            {
                await DisplayAlert("Alert", "Alert Button Clicked.", "Go Away!");
            }

            if (id == btnYesOrNo.Id)
            {
                bool bYapNop = await DisplayAlert("YesOrNo", "나갈래말래", "얍", "놉");
                //await DisplayPromptAsync("YesOrNo", "Do you want to exit the app?", "당장끔", "좀더있을랭", "나가고싶을때 선택하는것임", -1, Keyboard.Text, "initialValue");
            }

            if (id == btnSelect.Id)
            {
                string strNation = await DisplayActionSheet("국가선택", "니나라선택", null, "Korea", "Japan", "China", "America", "Etc");

                if (strNation == "Etc")
                {
                    btnPrompt.IsEnabled = true;
                    lblPrompt.IsEnabled = true;
                }
                else
                {
                    btnPrompt.IsEnabled = false;
                    lblPrompt.IsEnabled = false;
                    lblPrompt.Text = String.Empty;
                }
            }

            if (id == btnPrompt.Id)
            {
                lblPrompt.Text = await DisplayPromptAsync("나라이름 직접 입력", "Etc로 선택하셨을 경우 나라이름을 직접 입력하세요.", "입력완료", "입력취소", "Etc를 선택하셨으면 직접 입력하세요.", 20, Keyboard.Chat, "");
            }
        }
    }
}