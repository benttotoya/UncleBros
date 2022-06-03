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
            //MainPage = new TableViewPage();
            //MainPage = new LablePage();
            //MainPage = new LableCSPage();
            //MainPage = new ButtonPage();
            //MainPage = new EditorPage();
            //MainPage = new ImagePage();
            //MainPage = new SliderPage();
            //MainPage = new CheckBoxPage();
            //MainPage = new SwitchPage();
            //MainPage = new PopupPromptPage();
            //MainPage = new DateTimePickerPage();
            //MainPage = new NavigationPage(new NavigationMainPage());
            //MainPage = new DataBinding01();
            //MainPage = new DataBinding02();
            //MainPage = new DataBinding03();
            //MainPage = new DataBinding04();
            //MainPage = new DataBinding05();
            //MainPage = new DataBinding06();
            //MainPage = new DataBinding07();
            //MainPage = new DataBinding11();
            //MainPage = new WebViewPage();
            //MainPage = new StaticResourceDictionaryPage();
            //MainPage = new DynamicResourceDictionaryPage();
            //MainPage = new StaticResourceDictionaryCSharpPage();
            //MainPage = new StylePage();
            //MainPage = new StylePage2();
            //MainPage = new StyleCSharpPage();
            //MainPage = new StyleInheritancePage();
            //MainPage = new StyleInheritanceCSharpPage();
            //MainPage = new ImplicitStylePage();
            //MainPage = new DynamicStylePage();
            //MainPage = new MVVM_DateTime01();
            //MainPage = new MVVM_DateTime02();
            //MainPage = new MVVM_DateTime03();
            //MainPage = new MVVM_DateTime04();
            //MainPage = new MVVM_InteractivePage();
            //MainPage = new MVVM_Interactive2Page();
            //MainPage = new MVVM_ICommandPage();
            //MainPage = new MVVM_ICommandPage2();
            //MainPage = new MVVM_IConverterPage();
            //MainPage = new MVVM_IConverter2Page();
            //MainPage = new MVVM_IConverter3Page();
            //MainPage = new ListView01Page();
            MainPage = new ListView02Page();
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
