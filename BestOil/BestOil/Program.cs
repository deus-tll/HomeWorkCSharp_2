using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;

namespace BestOil
{
	internal static class Program
	{
		public static string Language { get; set; }
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Language = ConfigurationManager.AppSettings["language"];
			Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Language);
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Language);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
		}
	}
}
