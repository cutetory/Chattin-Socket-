using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Chat_Youtube;
using WpfApp1.ViewModel;

namespace WpfApp1.Command
{
	public class SocketClickCommand : ICommand
	{
		private bool m_canexecute = true;
		public event EventHandler? CanExecuteChanged;
		private MainViewModel m_MainViewModel;

		public SocketClickCommand()
		{

		}

		public bool CanExecute(object? parameter)
		{
			return m_canexecute;
		}

		public void Execute(object? parameter)
		{
			string[] temp = new string[] {"192.168.0.2"};
			ChatServer.ChatMain(temp);
			MessageBox.Show("소켓연결 테스트 성공.", "알림", MessageBoxButton.OK, MessageBoxImage.Information);
		}
	}
}
