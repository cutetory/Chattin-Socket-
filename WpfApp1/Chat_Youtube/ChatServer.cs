using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Chat_Youtube
{
	/// <summary>
	/// 채팅서버 셋팅
	/// </summary>
	public class ChatServer
	{
		public static Socket ConnectSocket(string fu_server, int fu_port)
		{
			Socket m_socket = null;
			IPHostEntry m_hostEntry = null;

			// Get host related information.
			//m_hostEntry = Dns.GetHostEntry(fu_server);

			// Loop through the AddressList to obtain the supported AddressFamily. This is to avoid
			// an exception that occurs when the host IP Address is not compatible with the address family
			// (typical in the IPv6 case).
			//foreach(IPAddress address in m_hostEntry.AddressList)
			//{
				//if(address.AddressFamily != AddressFamily.InterNetworkV6)
				//{
					//IPEndPoint ipe = new IPEndPoint(IPAddress.Loopback, fu_port); //테스트용으로 루프백
					IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("192.168.0.2"), fu_port); //테스트용으로 루프백
					Socket tempSocket = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

					//tempSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true); 이거는 그냥 자동으로 나온건데 지금은 필요없음

					tempSocket.Connect(ipe);

					if(tempSocket.Connected)
					{
						m_socket = tempSocket;
						//break;
					}
					else
					{
						//continue;
					}
				//}
			//}
			return m_socket;
		}

		// This method requests the home page content for the specified server.
		private static string SocketSendReceive(string fu_server, int fu_port)
		{
			string request = "GET / HTTP/1.1\r\nHost: " + fu_server + "\r\nConnection: Close\r\n\r\n";
			Byte[] bytesSent = Encoding.ASCII.GetBytes(request);
			Byte[] bytesRecevied = new byte[256];
			string page = string.Empty;

			using(Socket s = ConnectSocket(fu_server, fu_port))
			{
				if (s == null)
					return ("Connection failed");

				//Send request to the server.
				s.Send(bytesSent, bytesSent.Length, SocketFlags.None);

				//Receive the server home page content.
				int bytes = 0;
				page = "Default HTML page on " + fu_server + ":\r\n";

				//The following will block until the page is transmitted
				//do
				//{
				bytes = s.Receive(bytesRecevied, bytesRecevied.Length, SocketFlags.None);
				page = page + Encoding.ASCII.GetString(bytesRecevied, 0, bytes);
				//}
				//while (bytes > 0);

			}
			MessageBox.Show(page.ToString(), "알림", MessageBoxButton.OK, MessageBoxImage.Information);
			return page;
		}

		public static void ChatMain(string[] args)
		{
			string host;
			int port = 80;

			if(args.Length == 0)
			{
				// If no server name is passed as argument to this program,
				// use the current host name as the default.
				host = Dns.GetHostName();
			}
			else
			{
				host = args[0];
			}

			string result = SocketSendReceive(host, port);
			Console.WriteLine(result);
		}
	}
}
