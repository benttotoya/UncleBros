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
    public partial class EditorPage : ContentPage
    {
        public EditorPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await this.DisplayAlert("등록완료", "입력하신 내용\n" +  $"{editMessage.Text}" + "\n이 등록되었습니다.", "닫기");
            editSubject.Text = String.Empty;
            editMessage.Text = String.Empty;
        }
    }
}