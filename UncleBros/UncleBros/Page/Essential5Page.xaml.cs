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
	public partial class Essential5Page : ContentPage
	{
		StackLayout stackLayout;
		Entry entryClipboard;
		Button btnClipboard;
		Label lblClipboard;
		Button btnVibrate;
		Button btnFlashlightTurnOn;
		Button btnFlashlightTurnOff;



		public Essential5Page ()
		{
			InitializeComponent ();
			InitializeComponentAtCSCode();

			ComposeComponent();
		}

		private void InitializeComponentAtCSCode()
        {
			stackLayout = new StackLayout
			{
				Padding = 20,
			};

			entryClipboard = new Entry
			{
				Placeholder = "Save Text to Clipboard",
			};

			btnClipboard = new Button
			{
				Text = "Clipboard",
			};
            btnClipboard.Clicked += OnBtnClipboard_Clicked;

			lblClipboard = new Label
			{
				Padding = new Thickness(0, 0, 0, 10),
			};

			btnVibrate = new Button
            {
				Text = "Vibrate",
            };
            btnVibrate.Clicked += OnBtnVibrate_Clicked;

			btnFlashlightTurnOn = new Button
			{
				Text = "FlashLight On",
			};
			btnFlashlightTurnOn.Clicked += OnBtnFlashlightTurnOn_Clicked;

			btnFlashlightTurnOff = new Button
			{
				Text = "FlashLight Off",
			};
            btnFlashlightTurnOff.Clicked += OnBtnFlashlightTurnOff_Clicked;
        }

		private async void OnBtnFlashlightTurnOn_Clicked(object sender, EventArgs e)
		{
			await Flashlight.TurnOnAsync();
		}

		private async void OnBtnFlashlightTurnOff_Clicked(object sender, EventArgs e)
        {
            await Flashlight.TurnOffAsync();
        }

        private void OnBtnVibrate_Clicked(object sender, EventArgs e)
        {
			Vibration.Vibrate(TimeSpan.FromSeconds(5));
        }

        private async void OnBtnClipboard_Clicked(object sender, EventArgs e)
        {
			if (MainThread.IsMainThread)
			{
				Clipboard.ClipboardContentChanged += OnClipboard_ClipboardContentChanged;
				await Clipboard.SetTextAsync(entryClipboard.Text);

				//lblClipboard.Text = await Clipboard.GetTextAsync();

				// TODO: Code to run if this is the main thread
			}
			else
			{
				// TODO: Code to run if this is the secondary thread
			}
		}

        private async void OnClipboard_ClipboardContentChanged(object sender, EventArgs e)
        {
			lblClipboard.Text = await Clipboard.GetTextAsync();
		}

		private void ComposeComponent()
        {
			stackLayout.Children.Add(entryClipboard);
			stackLayout.Children.Add(btnClipboard);
			stackLayout.Children.Add(lblClipboard);
			stackLayout.Children.Add(btnVibrate);
			stackLayout.Children.Add(btnFlashlightTurnOn);
			stackLayout.Children.Add(btnFlashlightTurnOff);
			this.Content = stackLayout;
        }

		private void runMainThread()
        {

        }
	}
}