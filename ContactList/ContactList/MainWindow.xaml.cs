using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ContactList
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly string PATH = $"{Environment.CurrentDirectory}\\contactList.Json";
		private ContactStorage _contactStorage;
		private FileIOService _fileIOService;
		private readonly Binding _binding;

		public MainWindow()
		{
			InitializeComponent();

			_binding = new Binding("SelectedItem");
			_binding.ElementName = "lb_listContacts";
			ug_InputInfo.SetBinding(DataContextProperty, _binding);
		}

		private void btn_Back_Click(object sender, RoutedEventArgs e)
		{
			grid_AddEditContact.Visibility = Visibility.Collapsed;
			ug_Buttons.Visibility = Visibility.Visible;
			ug_ButtonOk.Visibility = Visibility.Visible;

			ug_InputInfo.SetBinding(DataContextProperty, _binding);
		}

		private void btn_Ok_Click(object sender, RoutedEventArgs e)
		{
			if (txtBox_Name.Text == "" || txtBox_Number.Text == "")
			{
				MessageBox.Show("Поля імені та номеру контакту повинні бути заповненні!");
			}
			else
			{
				Contact contact = new Contact
				{
					Name = txtBox_Name.Text,
					Number = txtBox_Number.Text,
					TelegramNick = txtBox_TelegramNick.Text
				};

				_contactStorage.GetContacts().Add(contact);
			}
		}

		private void btn_Add_Click(object sender, RoutedEventArgs e)
		{
			grid_AddEditContact.Visibility = Visibility.Visible;
			ug_Buttons.Visibility = Visibility.Collapsed;

			ug_InputInfo.DataContext = null;

			txtBox_Name.Text = "";
			txtBox_Number.Text = "";
			txtBox_TelegramNick.Text = "";
		}

		private void btn_Edit_Click(object sender, RoutedEventArgs e)
		{
			grid_AddEditContact.Visibility = Visibility.Visible;
			ug_Buttons.Visibility = Visibility.Collapsed;
			ug_ButtonOk.Visibility = Visibility.Collapsed;

			ug_InputInfo.SetBinding(DataContextProperty, _binding);
		}

		private void btn_Del_Click(object sender, RoutedEventArgs e)
		{
			if (lb_listContacts.SelectedItem == null)
				return;

			int id = lb_listContacts.SelectedIndex;
			_contactStorage.GetContacts().Remove(lb_listContacts.SelectedItem as Contact);
			if (id > 0)
				lb_listContacts.SelectedIndex = id - 1;

		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			_fileIOService = new FileIOService(PATH);

			LoadData();

			BindingProvider();
		}

		private void LoadData()
		{
			try
			{
				_contactStorage = new ContactStorage(_fileIOService.LoadData());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Close();
			}
		}

		private void BindingProvider()
		{
			ObjectDataProvider provider = new ObjectDataProvider
			{
				ObjectInstance = _contactStorage,
				MethodName = "GetContacts"
			};
			Binding binding = new Binding()
			{
				Source = provider,
				UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
			};

			lb_listContacts.SetBinding(ListBox.ItemsSourceProperty, binding);
			_contactStorage.GetContacts().ListChanged += ListOfContacts_ListChanged;
		}

		private void ListOfContacts_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged || e.ListChangedType == ListChangedType.ItemMoved)
			{
				try
				{
					_fileIOService.SaveData(sender);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					Close();
				}
			}
		}

		private void lb_listContacts_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			if (_contactStorage != null)
			{
				LoadData();

				BindingProvider();
			}
		}
	}
}