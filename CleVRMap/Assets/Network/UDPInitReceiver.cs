using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System;
using System.Net;
using System.Text;

namespace Assets.Network
{

    public class UDPInitReceiver : MonoBehaviour
    {

        UdpClient receiver;
        private int packetCount = 0;
        private int remotePort = 25000; //Catch exceptions

        public void receiveIP()
        {
            try
            {
                if (receiver == null)
                {
                    receiver = new UdpClient(remotePort);
                    receiver.BeginReceive(new AsyncCallback(ReceiveData), null);
                }
            }
            catch (SocketException e)
            {
                Debug.Log("ERROR: Cannot receive using specified port number");
                Debug.Log(e.Message);
            }
        }
        private void ReceiveData(IAsyncResult result)
        {
            IPEndPoint receiveIPGroup = new IPEndPoint(IPAddress.Any, remotePort);
            byte[] received;
            if (receiver != null)
            {
                received = receiver.EndReceive(result, ref receiveIPGroup);
            }
            else
            {
                return;
            }
            receiver.BeginReceive(new AsyncCallback(ReceiveData), null);
            string receivedString = Encoding.ASCII.GetString(received);
            Debug.Log("Packet#: " + packetCount + " - Received String: " + receivedString);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
