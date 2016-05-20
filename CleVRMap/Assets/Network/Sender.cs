using UnityEngine;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Net.NetworkInformation;
using Assets.Model;

namespace Assets.Network
{
    public class Sender : MonoBehaviour
    {

        #region Fields

        UdpClient sender;
        private int localPort = 0;  //random port > 1023
        private int remotePort = 25000;  
        private int seqNum = 0;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="Sender"/> class.
        /// Establishes endpoint to LAN and connects. 
        /// </summary>
        public Sender()
        {
            sender = new UdpClient(localPort, AddressFamily.InterNetwork);  
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Broadcast, remotePort);
            sender.Connect(groupEP);
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        void Start()
        { 
        }

        /// <summary>
        /// Sends the XML.
        /// </summary>
        /// <param name="bm">The bm.</param>
        public void sendXml(BaseModel bm, bool createOrUpdate)
        {

            if(bm != null)
            {
                string data = bm.toXML(createOrUpdate);
                sender.Send(Encoding.ASCII.GetBytes(data), data.Length);
                Debug.Log(data);
            }
        }

        /// <summary>
        /// Sends the ip adress.
        /// </summary>
        void SendIPAdress()
        {
            string host = Dns.GetHostName();
            string myIP = GetIP();
            string ipMessage = host + " - " + myIP;

            if (ipMessage != "")
            {
                sender.Send(Encoding.ASCII.GetBytes(ipMessage), ipMessage.Length);
                Debug.Log("IPAdress#: " + seqNum + ": " + ipMessage + "\n");
                seqNum++;
            }
        }

        /// <summary>
        /// Gets the ip.
        /// </summary>
        /// <returns></returns>
        public string GetIP()
        {
            string host = Dns.GetHostName();
            string ip = Dns.GetHostEntry(host).AddressList[0].ToString();
            return ip;
        }

        /// <summary>
        /// Gets the ether ip.
        /// </summary>
        /// <returns></returns>
        public string GetEtherIP()
        {
            string ipStr = "";

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipStr = ip.Address.ToString();
                        }
                    }
                }
            }

            return ipStr;
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        void Update()
        {
        }

        #endregion Methods
    }
}