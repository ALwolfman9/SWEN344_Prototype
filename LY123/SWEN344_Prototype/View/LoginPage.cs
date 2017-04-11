using System;

using Xamarin.Forms;

namespace SWEN344_Prototype
{
	public class LoginPage : ContentPage
	{
		public LoginPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

