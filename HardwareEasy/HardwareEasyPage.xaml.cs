using System;
using Xamarin.Forms;

namespace HardwareEasy
{
	public partial class HardwareEasyPage : ContentPage
	{
		ApiManager apimngr;
		public HardwareEasyPage()
		{
			InitializeComponent();
			apimngr = ApiManager.DefaultManager;

			FillData();


		}

		async void FillData()
		{
			var result = await apimngr.getAllList();
			lstView.BindingContext = result;
		}
	}
}
