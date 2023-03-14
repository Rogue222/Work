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
using System.Windows.Shapes;
using WpfApp5.Models;

namespace WpfApp5.View.Windows
{
	/// <summary>
	/// Логика взаимодействия для NavigationWindow.xaml
	/// </summary>
	public partial class NavigationWindow : Window
	{
		public NavigationWindow()
		{
			InitializeComponent();
			RecordDg.ItemsSource = App.context.Records.ToList();
		}

		private void BackBtn_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Close();
		}

		

		private void AddRecordBtn_Click(object sender, RoutedEventArgs e)
		{
			AddBaseWindow addBaseWindow = new AddBaseWindow();
			addBaseWindow.ShowDialog();
			Close();
		}

		private void SearchBtn_Click(object sender, RoutedEventArgs e)
		{
			//Фильтр данных
			RecordDg.ItemsSource = App.context.Records.Where(i => i.Clients.SNM == SearchTb.Text || i.Tables.Number == SearchTb.Text || i.Statuses.Name == SearchTb.Text).ToList();
		}

		private void UpdateBtn_Click(object sender, RoutedEventArgs e)
		{
			RecordDg.ItemsSource = App.context.Records.ToList();
		}
	}
}
