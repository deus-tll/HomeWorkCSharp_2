using System.Windows.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls;
using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Documents;
using System.Reflection;
using System.Windows.Data;

namespace KeyboardTrainer
{
	internal sealed partial class MainWindow : Window
	{
		private Keyboard_Trainer _keyboardTrainer = new Keyboard_Trainer();
		private DispatcherTimer dispatcherTimer = new DispatcherTimer();
		private int _amountOfElapsedTime;
		private bool inProcess = false;

		public MainWindow()
		{
			InitializeComponent();
			dispatcherTimer.Tick += DispatcherTimer_Tick;
			dispatcherTimer.Interval = new System.TimeSpan(0,0,1);
		}

		private void DispatcherTimer_Tick(object sender, System.EventArgs e)
		{
			++_amountOfElapsedTime;
			_keyboardTrainer.UpdateSpeedOfTyping(_amountOfElapsedTime);
			txtBlock_Speed.Text = _keyboardTrainer.SpeedOfTyping.ToString();
		}

		private void Window_KeyDown(object sender, KeyEventArgs e)
		{
			string charEntered = null;

			IsShift_AdditionalSymbol(ref charEntered, e);

			if (e.Key == Key.Enter || 
				e.Key == Key.Back || 
				e.Key == Key.F1 || 
				e.Key == Key.F2 || 
				e.Key == Key.F3 || 
				e.Key == Key.F4 || 
				e.Key == Key.F5 ||
				e.Key == Key.F6 ||
				e.Key == Key.F7 ||
				e.Key == Key.F7 ||
				e.Key == Key.F8 ||
				e.Key == Key.F9 ||
				e.Key == Key.F10 ||
				e.Key == Key.F11 ||
				e.Key == Key.F12 ||
				e.Key == Key.Escape ||
				e.Key == Key.PageDown ||
				e.Key == Key.PageUp ||
				e.Key == Key.Home ||
				e.Key == Key.End ||
				e.Key == Key.Delete ||
				e.Key == Key.Up ||
				e.Key == Key.Left ||
				e.Key == Key.Right ||
				e.Key == Key.Down ||
				e.Key == Key.LeftAlt ||
				e.Key == Key.RightAlt ||
				e.Key == Key.LeftCtrl ||
				e.Key == Key.RightCtrl ||
				e.Key == Key.Tab ||
				e.Key == Key.Scroll ||
				e.Key == Key.PrintScreen ||
				e.Key == Key.Insert ||
				e.Key == Key.LWin ||
				e.Key == Key.RWin ||
				e.Key == Key.Apps ||
				e.Key == Key.System ||
				e.Key == Key.Pause)
			{
				return;
			}


			if (e.Key == Key.CapsLock)
				return;


			if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
			{
				UpperCase();

				if (e.KeyboardDevice.GetKeyStates(Key.CapsLock) == KeyStates.Toggled)
					LowerCase();
				else if (e.KeyboardDevice.GetKeyStates(Key.CapsLock) == KeyStates.None)
					UpperCase();

				return;
			}
			else
			{
				if (_keyboardTrainer.SourceString == null || !inProcess)
					return;

				if (charEntered != null)
				{
					SymbolIsRight(Convert.ToChar(charEntered));
				}
				else
				{
					charEntered = e.Key.ToString();
					IsCapsAndShift_Letter(charEntered, e);
				}
			}	
		}


		private void IsShift_AdditionalSymbol(ref string charEntered, KeyEventArgs e)
		{
			if ((e.KeyboardDevice.Modifiers & ModifierKeys.Shift) != ModifierKeys.Shift)
			{
				switch (e.Key)
				{
					case Key.Space:
						charEntered = " ";
						break;
					case Key.D0:
						charEntered = "0";
						break;
					case Key.D1:
						charEntered = "1";
						break;
					case Key.D2:
						charEntered = "2";
						break;
					case Key.D3:
						charEntered = "3";
						break;
					case Key.D4:
						charEntered = "4";
						break;
					case Key.D5:
						charEntered = "5";
						break;
					case Key.D6:
						charEntered = "6";
						break;
					case Key.D7:
						charEntered = "7";
						break;
					case Key.D8:
						charEntered = "8";
						break;
					case Key.D9:
						charEntered = "9";
						break;
					case Key.Oem3:
						charEntered = "`";
						break;
					case Key.OemMinus:
						charEntered = "-";
						break;
					case Key.OemPlus:
						charEntered = "=";
						break;
					case Key.OemOpenBrackets:
						charEntered = "[";
						break;
					case Key.Oem6:
						charEntered = "]";
						break;
					case Key.Oem5:
						charEntered = "\\";
						break;
					case Key.Oem1:
						charEntered = ";";
						break;
					case Key.OemQuotes:
						charEntered = "'";
						break;
					case Key.OemComma:
						charEntered = ",";
						break;
					case Key.OemPeriod:
						charEntered = ".";
						break;
					case Key.OemQuestion:
						charEntered = "/";
						break;
				}
			}
			else
			{
				switch (e.Key)
				{
					case Key.Space:
						charEntered = " ";
						break;
					case Key.D0:
						charEntered = ")";
						break;
					case Key.D1:
						charEntered = "!";
						break;
					case Key.D2:
						charEntered = "@";
						break;
					case Key.D3:
						charEntered = "#";
						break;
					case Key.D4:
						charEntered = "$";
						break;
					case Key.D5:
						charEntered = "%";
						break;
					case Key.D6:
						charEntered = "^";
						break;
					case Key.D7:
						charEntered = "&";
						break;
					case Key.D8:
						charEntered = "*";
						break;
					case Key.D9:
						charEntered = "(";
						break;
					case Key.Oem3:
						charEntered = "~";
						break;
					case Key.OemMinus:
						charEntered = "_";
						break;
					case Key.OemPlus:
						charEntered = "+";
						break;
					case Key.OemOpenBrackets:
						charEntered = "{";
						break;
					case Key.Oem6:
						charEntered = "}";
						break;
					case Key.Oem5:
						charEntered = "|";
						break;
					case Key.Oem1:
						charEntered = ":";
						break;
					case Key.OemQuotes:
						charEntered = "\"";
						break;
					case Key.OemComma:
						charEntered = "<";
						break;
					case Key.OemPeriod:
						charEntered = ">";
						break;
					case Key.OemQuestion:
						charEntered = "?";
						break;
				}
			}
		}


		private void IsCapsAndShift_Letter(string charEntered, KeyEventArgs e)
		{
			KeyStates capsLock = e.KeyboardDevice.GetKeyStates(Key.CapsLock);

			if (capsLock != KeyStates.Toggled)
			{
				if ((e.KeyboardDevice.Modifiers & ModifierKeys.Shift) != ModifierKeys.Shift)
					charEntered = charEntered.ToLower();
			}
			else
			{
				if ((e.KeyboardDevice.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
					charEntered = charEntered.ToLower();
			}

			SymbolIsRight(Convert.ToChar(charEntered));
		}


		private void SymbolIsRight(char ch)
		{
			if (ch == _keyboardTrainer.SourceString[0])
			{
				_keyboardTrainer.UpdateString();
				_keyboardTrainer.UpdateCountOfCorrectChars();

				if (_keyboardTrainer.SourceString.Length == 0)
					_keyboardTrainer.GenerateString(Convert.ToInt32(slider_Difficulty.Value), chekBox_CaseSens.IsChecked, chekBox_AdditionalSymbols.IsChecked);


				RefreshString();
			}
			else
			{
				_keyboardTrainer.UpdateCountOfFails();
				txtBlock_Fails.Text = _keyboardTrainer.CountOfFails.ToString();
			}
		}


		private void Window_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
				LowerCase();

			if (e.KeyboardDevice.GetKeyStates(Key.CapsLock) == KeyStates.Toggled)
				UpperCase();
			else if (e.KeyboardDevice.GetKeyStates(Key.CapsLock) == KeyStates.None)
				LowerCase();
		}


		private void RefreshString()
		{
			txtBlock_SourceText.Text = _keyboardTrainer.SourceString;
			txtBlock_CorrectSourceText.Text = _keyboardTrainer.SourceCorrectString;
			txtBlock_CorrectInputText.Text = _keyboardTrainer.InputCorrectString;
		}


		private void UpperCase()
		{
			stackPanel_UpperCaseAndAdditionalSymbols.Visibility = Visibility.Visible;
			stackPanel_LowerCaseAndAdditionalSymbols.Visibility = Visibility.Collapsed;
		}
		private void LowerCase()
		{
			stackPanel_UpperCaseAndAdditionalSymbols.Visibility = Visibility.Collapsed;
			stackPanel_LowerCaseAndAdditionalSymbols.Visibility = Visibility.Visible;
		}

		private void btn_Start_Click(object sender, RoutedEventArgs e)
		{
			_keyboardTrainer.Reset();
			txtBlock_Fails.Text = "0";
			txtBlock_Speed.Text = "0";

			_keyboardTrainer.GenerateString(Convert.ToInt32(slider_Difficulty.Value), chekBox_CaseSens.IsChecked, chekBox_AdditionalSymbols.IsChecked);
			RefreshString();

			dispatcherTimer.Start();

			btn_Stop.IsEnabled = true;
			btn_Start.IsEnabled = false;
			inProcess = true;
		}

		private void btn_Stop_Click(object sender, RoutedEventArgs e)
		{
			dispatcherTimer.Stop();
			btn_Stop.IsEnabled = false;
			btn_Start.IsEnabled = true;
			inProcess = false;
		}

		private void slider_Difficulty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			int i = Convert.ToInt32(slider_Difficulty.Value);
			txtBlock_Difficulty.Text = i.ToString();
		}
    }
}