using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UncleBros.Page;

namespace UncleBros
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new ItemListPage();
            //MainPage = new AbsoluteLayoutPage();
            MainPage = new TableViewPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
