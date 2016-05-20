using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class Client2
{
    static UdpClient udp;
    static IPEndPoint udp_ep;

    public Client2() {
       
        int localPort = 25000;  //Anything above standard ports ( > 1024)

        Console.Write("Welcome to the UDP Client\n Press any to terminate...\n");

        try
        {

            while (udp == null)
            {
                //Initialize UdpClient
                udp = new UdpClient(localPort);
                Console.Write("UDP Client Initialized...\n");

                //Begin waiting for a response asynchronously
                Console.Write("Starting to receive..\n");
                //ConsoleKeyInfo key = new ConsoleKeyInfo((char)ConsoleKey.Z, ConsoleKey.Z, false, false, false);
            }
            while (true)
            {

                udp.BeginReceive(new AsyncCallback(UDP_IncomingData), udp_ep);
                //key = Console.ReadKey();
            }

        }
        catch (SocketException e)
        {
            Console.Write(e.StackTrace.ToString());
            Console.Write("Failed to establish connection");
        }
        //Prevent the console from closing automatically
        Console.ReadKey();
        udp.Close();
        }

    static void UDP_IncomingData(IAsyncResult ar)
    {
        int remotePort = 25000;

        //Create endpoint
        udp_ep = new IPEndPoint(IPAddress.Any, remotePort);

        Console.Write("Waiting for incoming data...");
        //Get the data from the response
        try
        {
            byte[] bResp = udp.EndReceive(ar, ref udp_ep);
            string sResponse = Encoding.ASCII.GetString(bResp);
            Console.Write("Packet#: Received String: " + sResponse + "\n");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        //Convert the data to a string


        //Close the UDP connection
        //udp.Close();
    }
}

