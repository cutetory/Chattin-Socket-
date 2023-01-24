using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.ViewModel;

namespace WpfApp1
{
	public class TestClickCommand : ICommand
	{
		private bool m_canexecute = true;
		public event EventHandler? CanExecuteChanged;
		private MainViewModel m_mainViewModel;

		public TestClickCommand(MainViewModel _mainVeiwModel)
		{
			m_mainViewModel = null;
			m_mainViewModel = _mainVeiwModel;
		}

		public bool CanExecute(object? parameter)
		{
			return m_canexecute;
		}

		public void Execute(object? parameter)
		{
			m_mainViewModel.M_ProgressValue = 50;
			MessageBox.Show(m_mainViewModel.M_ProgressValue.ToString(), "알림",MessageBoxButton.OK, MessageBoxImage.Information);
		}
	}
}
