using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Design;
using System.Net;
using System.Xml.Linq;
using System.IO;

namespace Tris_Multiplayer_U
{
    public class Client
    {
        private static readonly int serverAccount = 1024;
        private static readonly int serverGame = 53000;

        private TcpClient client;

        private readonly string serverIp;
        private int serverPort;

        public Client(string serverIp, bool serverPort)
        {
            this.serverIp = serverIp;
            this.serverPort = serverPort ? serverAccount : serverGame;
            client = new TcpClient(this.serverIp, this.serverPort);
        }

        public bool SwitchPort()
        {
            serverPort = serverPort == serverAccount ? serverGame : serverAccount;
            client = new TcpClient(this.serverIp, this.serverPort);
            return serverPort == serverAccount;
        }

        public void Access(string name, string password)
        {
            if (serverPort != serverAccount)
                return;

            string jsonString = JsonSerializer.Serialize(new string[] { name, password });
            byte[] data = Encoding.UTF8.GetBytes(jsonString);
            client.GetStream().Write(data, 0, data.Length);

            byte[] buffer = new byte[1024];
            int bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
            string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Form1.userAccess = new User(JsonSerializer.Deserialize<string[]>(receivedMessage));
        }
        public void Registration(string name, string password, string confirm)
        {
            if (serverPort != serverAccount)
                return;

            string jsonString = JsonSerializer.Serialize(new string[] { name, password, confirm });
            byte[] data = Encoding.UTF8.GetBytes(jsonString);
            client.GetStream().Write(data, 0, data.Length);

            byte[] buffer = new byte[1024];
            int bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
            string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Form1.userAccess = new User(JsonSerializer.Deserialize<string[]>(receivedMessage));
        }

        public int[] Move(int x, int y)
        {
            if (serverPort != serverGame)
                return null;

            string jsonString = JsonSerializer.Serialize(new int[] { x, y });
            byte[] data = Encoding.UTF8.GetBytes(jsonString);
            client.GetStream().Write(data, 0, data.Length);

            byte[] buffer = new byte[1024];
            int bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
            string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            return JsonSerializer.Deserialize<int[]>(receivedMessage);
        }
    }
}
