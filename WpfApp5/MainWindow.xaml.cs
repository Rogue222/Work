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
using WpfApp5.View.Windows;


namespace WpfApp5
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Auth()
		{
			if (!(string.IsNullOrEmpty(EmailTextBox.Text) || string.IsNullOrEmpty(PasswordBox.Password)))
			{
				if (App.context.Clients.First(i => i.Email == EmailTextBox.Text && i.Password == PasswordBox.Password) != null)
				{
					Profile profile = new Profile();
					MessageBox.Show("Вы вошли");
					profile.Show();
					Close();
				}
				else
				{
					MessageBox.Show("Неверный логин или пароль");
				}
			}
			else
			{
				MessageBox.Show("Все поля должны быть заполнены");
			}
		}

		

		private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			Registration registration = new Registration();
			registration.Show();
			this.Close();
		}

		private void ForgotPasswordText_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{

		}

		private void LoginButton_Click_1(object sender, RoutedEventArgs e)
		{
			Auth();
		}

		private void ForgotPasswordText_Click(object sender, RoutedEventArgs e)
		{
			PasswordRecoveryWindow passwordRecoveryWindow = new PasswordRecoveryWindow();
			passwordRecoveryWindow.Show();
			this.Close();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Registration registration = new Registration();
			registration.Show();
			this.Close();
		}
	}
}
