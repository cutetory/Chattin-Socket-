using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Command;

namespace WpfApp1.ViewModel
{
	public class MainViewModel : INotifyPropertyChanged
	{
		private int m_progressValue = 0;
		public ICommand TestClick { get; set; }
		public ICommand TestSocketClick { get; set; }

		//ctor단축키
		public MainViewModel()
		{
			TestSocketClick = new SocketClickCommand();
		}

		public MainViewModel(int _progressValue)
		{
			TestClick = new TestClickCommand(this);
			M_ProgressValue = _progressValue;
		}

		public int M_ProgressValue
		{
			get { return m_progressValue; }
			set
			{
				m_progressValue = value;
				NotifyPropertyChanged(nameof(M_ProgressValue));
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		// This method is called by the Set accessor of each property.  
		// The CallerMemberName attribute that is applied to the optional propertyName  
		// parameter causes the property name of the caller to be substituted as an argument.  
		private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
