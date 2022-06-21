using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UncleBros.Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Essential3Page : ContentPage
	{
		StackLayout stackLayout = new StackLayout();
		Button btnMap;
		Label lblMap;
		Button btnBrowser;

		// Email
		Entry entrySubject;
		Entry entryReceiver;
		Entry entryBody;
        Button btnEmailSend;

        public Essential3Page ()
		{
			InitializeComponent ();
			
			btnMap = new Button
            {
				Text = "Map",
            };
            btnMap.Clicked += OnBtnMap_Clicked;
			lblMap = new Label();

			btnBrowser = new Button
			{
				Text = "Browser",
				Padding = new Thickness(0, 0, 0, 20),
			};
            btnBrowser.Clicked += OnBtnBrowser_Clicked;

			// Email
			entrySubject = new Entry
			{
				Placeholder = "Subject"
			};

			entryReceiver = new Entry
			{
				Placeholder = "Receiver"
			};

			entryBody = new Entry
			{
				Placeholder = "Body"
			};

			btnEmailSend = new Button
			{
				Text = "Email Send",
			};
            btnEmailSend.Clicked += OnBtnEmailSend_Clicked;

			stackLayout.Children.Add(btnMap);
			stackLayout.Children.Add(lblMap);
			stackLayout.Children.Add(btnBrowser);
			stackLayout.Children.Add(entrySubject);
			stackLayout.Children.Add(entryReceiver);
			stackLayout.Children.Add(entryBody);
			stackLayout.Children.Add(btnEmailSend);
			this.Content = stackLayout;
		}

        private async void OnBtnMap_Clicked(object sender, EventArgs e)
        {
			// USA Whisman Park
			double latitude = 37.38959323230408;
			double longitude = -122.05856485594217;

			//await Map.OpenAsync(new Location(latitude, longitude));
			MapLaunchOptions launchOptions = new MapLaunchOptions();
			launchOptions.NavigationMode = NavigationMode.Bicycling;
			await Map.OpenAsync(new Location(latitude, longitude), launchOptions);
		}

		private async void OnBtnBrowser_Clicked(object sender, EventArgs e)
		{
			string strUrl = "https://www.naver.com";
			//await Browser.OpenAsync(strUrl, BrowserLaunchMode.SystemPreferred);
			await Browser.OpenAsync(strUrl, BrowserLaunchMode.SystemPreferred);
		}

		private async void OnBtnEmailSend_Clicked(object sender, EventArgs e)
		{
			try
            {
				var message = new EmailMessage
				{
					Subject = entrySubject.Text,
					To = new List<string>() { entryReceiver.Text },
					Body = entryBody.Text,
				};

				await Email.ComposeAsync(message);
			}
			catch (FeatureNotSupportedException fnsEx)
            {

            }
			catch(Exception ex)
            {

            }
		}
	}
}