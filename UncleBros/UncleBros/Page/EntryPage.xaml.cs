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
    public partial class EntryPage : ContentPage
    {
        public EntryPage()
        {
            InitializeComponent();
        }

        private void btnName_Clicked(object sender, EventArgs e)
        {
            string strSaveString = $"Name : {eName.Text}" + " " +
                $"ID : {eID.Text}" + " " +
                $"EMail : {eEMail.Text}" + " " +
                $"TelePhone : {ePhone.Text}" + " " +
                $"Chat : {eChat.Text}" + " " +
                $"Numeric : {eNumeric.Text}" + " " +
                $"Plain : {ePlain.Text}" + " " +
                $"HomePage : {eHomePage.Text}";

            this.DisplayAlert("User Input Info", strSaveString, "나가기");
        }
    }
}