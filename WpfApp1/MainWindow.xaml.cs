using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfApp1.CustomStyle;
using WpfApp1.ViewModel;

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private const string m_BasePath = "https://exam-engineer-information-default-rtdb.asia-southeast1.firebasedatabase.app/"; //본인의 Firebase Database URL
		private const string m_FirebaseSecret = "xgwXwqZIOLsWUJmtsLhiXbI9yhPns3Jklhuybs2s"; //본인의 Firebase Database 비밀번호
		private static FirebaseClient m_Client;
		public MainWindow()
		{
			InitializeComponent();
			//MainViewModel mainViewmodelContext = new MainViewModel(10);
			MainViewModel mainViewSocketContext = new MainViewModel();
			//DataContext = mainViewmodelContext;
			DataContext = mainViewSocketContext;

			IFirebaseConfig config = new FirebaseConfig { AuthSecret = m_FirebaseSecret, BasePath = m_BasePath };

			m_Client = new FirebaseClient(config);
		}

		private void chkSave_Click(object sender, RoutedEventArgs e)
		{
			if (chkSave.IsChecked == true)
			{
				Border pbBox = (Border)pbPW.Template.FindName("pwBorder", pbPW);
				pbBox.Background = new SolidColorBrush(Color.FromArgb(100, 171, 173, 179));
			}
			else
			{
				Border pbBox = (Border)pbPW.Template.FindName("pwBorder", pbPW);
				pbBox.Background = Brushes.White;
			}
		}

		private async void btnFireTest_Click(object sender, RoutedEventArgs e)
		{
			FirebaseResponse response = await m_Client.GetAsync("Value001");
			string value = response.ResultAs<string>();
			txtFire.Text = value;
			MessageBox.Show(value, "알림", MessageBoxButton.OK, MessageBoxImage.Information);
		}
	}
}
