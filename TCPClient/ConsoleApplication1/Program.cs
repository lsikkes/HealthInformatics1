using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TCPReceiver
{
    class Client
    {

        public static void Main()
        {
            try
            {

                IPAddress ipAd = IPAddress.Parse(GetIP());                                           
                TcpListener myList = new TcpListener(ipAd, 25000);
                myList.Start();

                Console.WriteLine("The server is running at port 25000...");
                Console.WriteLine("The local End point is :" + myList.LocalEndpoint);
                Console.WriteLine("Waiting for a connection.....");
                Socket s = myList.AcceptSocket();
                Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);

                byte[] b = new byte[100];
                int k = s.Receive(b);
                Console.WriteLine("Recieved...");
                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(b[i]));

                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes("The string was recieved by the server."));
                Console.WriteLine("\nSent Acknowledgement");

                /* clean up */
                s.Close();
                myList.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
        }

        public static string GetIP()
        {
            string host = Dns.GetHostName();
            string ip = Dns.GetHostEntry(host).AddressList[0].ToString();
            return ip;
        }
    }
    
}
