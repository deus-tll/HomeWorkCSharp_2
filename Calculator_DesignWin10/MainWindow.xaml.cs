using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_DesignWin10
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			RightPanel.Visibility = (Width > 577) ? Visibility.Visible : Visibility.Collapsed;

			if (Width < 800 && Width > 577)
			{
				RightPanel.Width = (41.7677642980936 / 100) * Width;
			}

		}
	}
}
