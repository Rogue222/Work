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
	/// Логика взаимодействия для AddBaseWindow.xaml
	/// </summary>
	public partial class AddBaseWindow : Window
	{
		public AddBaseWindow()
		{
			InitializeComponent();
			TableCmb.ItemsSource = App.context.Tables.Where(i => i.IsReserved == false).ToList();
			ClientCmb.ItemsSource = App.context.Clients.ToList();
		}
		private void AddRecord()
		{
			if (!(string.IsNullOrEmpty(TableCmb.Text)
				|| string.IsNullOrEmpty(ClientCmb.Text)
				|| string.IsNullOrEmpty(TimeTb.Text)))
			{
				Records records = new Records()
				{
					ClientId = ((Clients)ClientCmb.SelectedItem).Id,
					TableId = ((Tables)TableCmb.SelectedItem).Id,
					VisitTime = TimeSpan.Parse(TimeTb.Text),
					StatusId = 1
				};
				App.context.Records.Add(records);
				App.context.Tables.First(i => i.Id == ((Tables)TableCmb.SelectedItem).Id).IsReserved = true;
				App.context.SaveChanges();
				MessageBox.Show("Запись добавлена");
				NavigationWindow navigationWindow = new NavigationWindow();
				navigationWindow.Show();
				Close();
			}
			else
			{
				MessageBox.Show("Все поля должны быть заполнены");

				private void Button_Click(object sender, RoutedEventArgs e)
		{

        }
    }
}
