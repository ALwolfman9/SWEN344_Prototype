using System;
using Xamarin.Forms;

namespace SWEN344_Prototype
{
	public partial class App : Application
	{
		public App()
		{

			MainPage = new SWEN344_PrototypePage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}