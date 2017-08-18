using System.Net;
using System.Net.Sockets;

namespace NET.Class.Socks
{
    class SocketFOSC
    {
        #region Vars
        private Socket _Socket;
        private NetworkStream _NetStream;
        private IPEndPoint _IPEP;
        private EndPoint _EP;
        private int _PORT = 0;
        private byte[] _ByteData;
        #endregion

        #region Public Methods
        /// <summary>
        /// Constructor - make the Socket
        /// </summary>
        /// <param name="usedSck"> receive the socket that you want to use</param>
        /// <param name="usedPort">receive the port that you want to use</param>
        public SocketFOSC(Socket usedSck, int usedPort)
        {
            _PORT = usedPort;
            try
            {
                _Socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                _IPEP = new IPEndPoint(IPAddress.Any, _PORT);
                _Socket.Bind(_IPEP);
                _EP = (EndPoint)_IPEP;


            }
            catch (SocketException scke)
            {
                System.Console.WriteLine("[ERRO]" + scke.Message);
                //throw scke;
            }
            finally
            {
                _PORT = 0;
            }
        }

        /// <summary>
        /// Start to listen the network
        /// </summary>
        public void SocketFOSC_Start()
        {
            try
            {
                //_Socket.BeginReceiveFrom();
            }
            catch(Exception e)
            {

            }
        }
        #endregion
    }
}
