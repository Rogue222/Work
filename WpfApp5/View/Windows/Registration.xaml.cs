﻿using System;
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
	/// Логика взаимодействия для Registration.xaml
	/// </summary>
	public partial class Registration : Window
	{
		public Registration()
		{
			InitializeComponent();
		}

		private void Registaration()
		{
			if (!(string.IsNullOrEmpty(EmailTextBox.Text) || string.IsNullOrEmpty(PasswordBox.Password) || string.IsNullOrEmpty(ConfirmPasswordBox.Password)))
			{
				var logPass = App.context.Clients.FirstOrDefault(i => i.Email == EmailTextBox.Text);
				if (logPass != null)
				{
					MessageBox.Show("Пользователь с такой почтой уже существует");
				}
				else
				{
					bool resp = false;
					resp = PasswordCheck(resp);
					if (resp == true)
					{
						AddUser();
						MainWindow authentification = new MainWindow();
						authentification.Show();
						Close();
					}
				}
			}
			else
			{
				MessageBox.Show("Все поля должны быть заполнены");
				//MessageBox.Show("Неверный логин или пароль");
			}
		}
		private bool PasswordCheck(bool resp)
		{
			if (PasswordBox.Password == ConfirmPasswordBox.Password)
			{
				resp = true;
			}
			else
			{
				MessageBox.Show("Пароли должны совпадать");
			}
			return resp;
		}
		private void AddUser()
		{
			Clients clients = new Clients()
			{
				Email = EmailTextBox.Text,
				Password = ConfirmPasswordBox.Password,
				Name = NameTextBox.Text,
				Sername = SernameTextBox.Text,
				PhoneNumber = PhoneNumber.Text,

			
				
				
			};
			App.context.Clients.Add(clients);
			App.context.SaveChanges();
			MessageBox.Show("Вы успешно зарегистрированы");
		}
		private void BackBtn_Click(object sender, RoutedEventArgs e)
		{
			MainWindow authentificationWindow = new MainWindow();
			authentificationWindow.Show();
			Close();
		}

		

		private void RegisterButton_Click(object sender, RoutedEventArgs e)
		{
			Registaration();
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			this.Close();
		}
	}
}
