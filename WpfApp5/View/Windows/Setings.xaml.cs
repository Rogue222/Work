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
	/// Логика взаимодействия для Setings.xaml
	/// </summary>
	public partial class Setings : Window
	{
		public Setings()
		{
			InitializeComponent();
		}



		private void Back_Click(object sender, RoutedEventArgs e)
		{
			Profile profile = new Profile();
			profile.Show();
			Close();
		}

		private void Save_Click(object sender, RoutedEventArgs e)
		{
			Clients clients = new Clients();
			{
				if (clients != null)
				{

					clients.Password = ConfirmPasswordBox.Password;
					clients.Name = NameTextBox.Text;
					clients.Sername = SernameTextBox.Text;
					clients.PhoneNumber = PhoneNumber.Text;

					App.context.Clients.Add(clients);
					App.context.SaveChanges();

					MessageBox.Show("Вы успешно изменили данные");
				}
				else
				{
					MessageBox.Show("Клиент с указанным email не найден");
				}
			}
			Profile profile = new Profile();
			profile.Show();
			Close();
		}
	}
}

