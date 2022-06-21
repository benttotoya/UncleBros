using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace UncleBros.Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Essential4Page : ContentPage
	{
		Entry entryCelsiusToFahrenheit;
		Button btnCelsiusToFahrenheit;

		Entry entryFahrenheitToCelsius;
		Button btnFahrenheitToCelsius;

		Entry entryMilesToMeters;
		Button btnMilesToMeters;

		Entry entryMilesToKilometers;
		Button btnMilesToKilometers;

		Label lblResult;


		public Essential4Page ()
		{
			InitializeComponent ();

			ScrollView scrollView = new ScrollView
			{

			};

			StackLayout stackLayout = new StackLayout
			{
				Padding = 20,
				Spacing = 0,
			};

			// Celsius, Fahrenheit
			entryCelsiusToFahrenheit = new Entry
			{
				Placeholder = "Input Celsius"
			};

			btnCelsiusToFahrenheit = new Button
			{
				Text = "CelsiusToFahrenheit",
			};
            btnCelsiusToFahrenheit.Clicked += OnBtnCelsiusToFahrenheit_Clicked;

			entryFahrenheitToCelsius = new Entry
			{
				Placeholder = "Input Fahrenheit"
			};

			btnFahrenheitToCelsius = new Button
			{
				Text = "FahrenheitToCelsius",
			};
            btnFahrenheitToCelsius.Clicked += OnBtnFahrenheitToCelsius_Clicked;

			// Miles, Meters
			entryMilesToMeters = new Entry
			{
				Placeholder = "Input Miles"
			};

			btnMilesToMeters = new Button
			{
				Text = "MilesToMeters",
			};
            btnMilesToMeters.Clicked += OnBtnMilesToMeters_Clicked;

			entryMilesToKilometers = new Entry
			{
				Placeholder = "Input Meters"
			};

			btnMilesToKilometers = new Button
			{
				Text = "MilesToKilometers",
			};
			btnMilesToKilometers.Clicked += OnBtnMilesToKilometers_Clicked; ;

			lblResult = new Label
			{
				FontAttributes = FontAttributes.Bold,
				Padding = new Thickness(0, 0, 0, 20),
			};

			stackLayout.Children.Add(entryCelsiusToFahrenheit);
			stackLayout.Children.Add(btnCelsiusToFahrenheit);
			stackLayout.Children.Add(entryFahrenheitToCelsius);
			stackLayout.Children.Add(btnFahrenheitToCelsius);
			stackLayout.Children.Add(entryMilesToMeters);
			stackLayout.Children.Add(btnMilesToMeters);
			stackLayout.Children.Add(entryMilesToKilometers);
			stackLayout.Children.Add(btnMilesToKilometers);
			stackLayout.Children.Add(lblResult);

			scrollView.Content = stackLayout;
			this.Content = scrollView;
		}
        
		private void OnBtnCelsiusToFahrenheit_Clicked(object sender, EventArgs e)
		{
			try
            {
				var result = UnitConverters.CelsiusToFahrenheit(Convert.ToDouble(entryCelsiusToFahrenheit.Text));
				lblResult.Text = result.ToString();
			}
			catch(Exception ex)
            {
				lblResult.Text = ex.Message;
            }
		}

		private void OnBtnFahrenheitToCelsius_Clicked(object sender, EventArgs e)
        {
            var result = UnitConverters.FahrenheitToCelsius(Convert.ToDouble(entryFahrenheitToCelsius.Text));
			lblResult.Text = result.ToString();
		}

		private void OnBtnMilesToMeters_Clicked(object sender, EventArgs e)
		{
			var result = UnitConverters.MilesToMeters(Convert.ToDouble(entryMilesToMeters.Text));
			lblResult.Text = result.ToString();
		}

		private async void OnBtnMilesToKilometers_Clicked(object sender, EventArgs e)
		{
			var result = UnitConverters.MilesToKilometers(Convert.ToDouble(entryMilesToKilometers.Text));
			lblResult.Text = result.ToString();

			try
			{
				//PhoneDialer.Open("010-9267-2663");
				await Sms.ComposeAsync(new SmsMessage("Hi. Who are you", new List<string>()
				{
					"010-9267-2663",
					"011-9267-2663",
				}));
			}
			catch (ArgumentNullException anEx)
			{
				lblResult.Text = anEx.Message;
			}
			catch (FeatureNotSupportedException ex)
			{
				lblResult.Text = ex.Message;
			}
			catch (Exception ex)
			{
				lblResult.Text = ex.Message;
			}
		}
	}
}
