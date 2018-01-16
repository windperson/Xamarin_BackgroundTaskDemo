using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormBGdemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		    MessagingCenter.Subscribe<object, string>(this, "UpdateLabel", (s, e) =>
		    {
		        Device.BeginInvokeOnMainThread(() =>
		        {
		            BackgroundServiceLabel.Text = e;
		        });
		    });
        }
	}
}
