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
	/// Логика взаимодействия для Profile.xaml
	/// </summary>
	public partial class Profile : Window
	{
		public Profile()
		{
			InitializeComponent();

			

			//client.Sername = "new surname";
			//client.Name = "new name";

			//Label1.Content = "Фамилия: " + client.Sername;
			//Label2.Content = "Имя: " + client.Name;

		}

		public void metod(object label, object value)
		{
			if (label == null)
			{
				Models.Clients.Equals(label, value);
			}
			else 
			{
			Models.Clients.Equals(label, value);
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			BonusCard bonusCard = new BonusCard();
			bonusCard.Show();
			Close();
        }

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Close();
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			Setings setings = new Setings();
			setings.Show();
			Close();
		}
	}
}
