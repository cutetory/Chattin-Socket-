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
		//MainViewModel m_mainViewModel = new MainViewModel();
		public MainWindow()
		{
			InitializeComponent();
			MainViewModel mainViewmodelContext = new MainViewModel(10);
			MainViewModel mainViewSocketContext = new MainViewModel();
			DataContext = mainViewmodelContext;
			DataContext = mainViewSocketContext;
		}

		private void chkSave_Click(object sender, RoutedEventArgs e)
		{
			if(chkSave.IsChecked == true)
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
	}
}
