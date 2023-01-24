using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SocketListener
{
	public class CoreTcpListener
	{
		public CoreTcpListener()
		{
			TcpListener server = null;
			try
			{
				// Set the TcpListener on port 80.
				Int32 port = 80;
				IPAddress localAddr = IPAddress.Parse("192.168.0.2");

				//TcpListener server = new TcpListener(port);
				server = new TcpListener(localAddr, port);

				// Start listening for client requests.
				server.Start();

				// Buffer for reading data
				Byte[] bytes = new Byte[256];
				String data = null;
				// Enter the listening loop.
				while (true)
				{
					MessageBox.Show("Waiting for a connection... ", "알림", MessageBoxButton.OK, MessageBoxImage.Information);

					// Perform a blocking call to accept requests.
					// You could also use server.AcceptSocket() here.
					using TcpClient client = server.AcceptTcpClient();
					MessageBox.Show("Connected!!! ", "알림", MessageBoxButton.OK, MessageBoxImage.Information);

					data = null;

					// Get a stream object for reading and writing
					NetworkStream stream = client.GetStream();

					int i;

					// Loop to receive all the data sent by the client.
					while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
					{
						// Translate data bytes to a ASCII string.
						data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
						Console.WriteLine("Received: {0}", data);
						MessageBox.Show(data.ToString(), "알림", MessageBoxButton.OK, MessageBoxImage.Information);
						// Process the data sent by the client.
						data = data.ToUpper();

						byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

						// Send back a response.
						stream.Write(msg, 0, msg.Length);
						Console.WriteLine("Sent: {0}", data);
						MessageBox.Show(data.ToString(), "알림", MessageBoxButton.OK, MessageBoxImage.Information);
					}
				}
			}
			catch (SocketException e)
			{
				Console.WriteLine("SocketException: {0}", e);
				MessageBox.Show($"SocketException: {e}", "알림", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			finally
			{
				server.Stop();
			}

			//Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			////IPAddress hostIP = (Dns.Resolve(IPAddress.Any.ToString())).AddressList[0];
			//IPAddress hostIP = IPAddress.Loopback;

			////long testIP = 2130706433;
			//IPEndPoint remoteIP = new IPEndPoint(hostIP, 80);
			//listenSocket.Bind(remoteIP);

			//listenSocket.Listen();
			//if(listenSocket.Available == 1)
			//{

			//}

		}
		public static async void TcpAsync()
		{
			await Task.Delay(1000);
			TcpListener server = null;
			try
			{
				// Set the TcpListener on port 80.
				Int32 port = 80;
				IPAddress localAddr = IPAddress.Parse("192.168.0.2");

				//TcpListener server = new TcpListener(port);
				server = new TcpListener(localAddr, port);

				// Start listening for client requests.
				server.Start();

				// Buffer for reading data
				Byte[] bytes = new Byte[256];
				String data = null;
				// Enter the listening loop.
				while (true)
				{
					MessageBox.Show("Waiting for a connection... ", "알림", MessageBoxButton.OK, MessageBoxImage.Information);

					// Perform a blocking call to accept requests.
					// You could also use server.AcceptSocket() here.
					using TcpClient client = server.AcceptTcpClient();
					MessageBox.Show("Connected!!! ", "알림", MessageBoxButton.OK, MessageBoxImage.Information);

					data = null;

					// Get a stream object for reading and writing
					NetworkStream stream = client.GetStream();

					int i;

					// Loop to receive all the data sent by the client.
					while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
					{
						// Translate data bytes to a ASCII string.
						data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
						Console.WriteLine("Received: {0}", data);
						MessageBox.Show(data.ToString(), "알림", MessageBoxButton.OK, MessageBoxImage.Information);
						// Process the data sent by the client.
						data = data.ToUpper();

						byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

						// Send back a response.
						stream.Write(msg, 0, msg.Length);
						Console.WriteLine("Sent: {0}", data);
						MessageBox.Show(data.ToString(), "알림", MessageBoxButton.OK, MessageBoxImage.Information);
					}
				}
			}
			catch (SocketException e)
			{
				Console.WriteLine("SocketException: {0}", e);
				MessageBox.Show($"SocketException: {e}", "알림", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			finally
			{
				server.Stop();
			}
		}
	}
}
