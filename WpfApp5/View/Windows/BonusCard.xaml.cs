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

namespace WpfApp5.View.Windows
{
	/// <summary>
	/// Логика взаимодействия для BonusCard.xaml
	/// </summary>
	public partial class BonusCard : Window
	{
		public BonusCard()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{


			
			long min = 100000000000;
			long max = 999999999999;
			long randomNumber = (long)(new Random().NextDouble() * (max - min)) + min;

			
			NumberCard.Text = randomNumber.ToString();

			Label newLabel = new Label();
			newLabel.Content = randomNumber.ToString();

			
			labelContaind.Children.Add(newLabel);
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Profile profile = new Profile();
			profile.Show();
			Close();
		}
	}
}
