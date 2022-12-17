using System.Windows;
using System.Windows.Controls;

namespace IntToDateTime
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Date date = new Date();
		public MainWindow()
		{
			InitializeComponent();
			ug_info.DataContext = date;
		}

		private void textBoxYear_TextChanged(object sender, TextChangedEventArgs e)
		{
			Dummy.Year = date.Year;
		}

		private void textBoxMonth_TextChanged(object sender, TextChangedEventArgs e)
		{
			Dummy.Month = date.Month;
		}
	}
}
