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
        public SemaphoreSlim accessRegistration = new SemaphoreSlim(0);
        public SemaphoreSlim move = new SemaphoreSlim(0);
        private TcpClient client;

        private readonly string serverIp;
        private readonly int serverPort;

        public Client(string serverIp, int serverPort)
        {
            this.serverIp = serverIp;
            this.serverPort = serverPort;
            client = new TcpClient(this.serverIp, this.serverPort);
        }

        public void Access(string name, string password)
        {
            string jsonString = JsonSerializer.Serialize(new string[] { name, password });
            byte[] data = Encoding.UTF8.GetBytes(jsonString);
            client.GetStream().Write(data, 0, data.Length);

            byte[] buffer = new byte[1024];
            int bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
            string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Form1.userAccess = JsonSerializer.Deserialize<User>(receivedMessage);
        }
        public void Registration(string name, string password, string confirm)
        {
            string jsonString = JsonSerializer.Serialize(new string[] { name, password, confirm });
            byte[] data = Encoding.UTF8.GetBytes(jsonString);
            client.GetStream().Write(data, 0, data.Length);

            byte[] buffer = new byte[1024];
            int bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
            string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Form1.userAccess = JsonSerializer.Deserialize<User>(receivedMessage);
        }

        /*public async Task StartAsync()
        {
            TcpClient client = new TcpClient();
            await client.ConnectAsync(serverIp, serverPort);

            var stream = client.GetStream();

            while (true)
            {
                Send();
                Receive();
            }
        }

        public async Task Send()
        {
            ready.Wait();
            byte[] data =Encoding.UTF8.GetBytes(jsonString);
            await stream.WriteAsync(data, 0, data.Length);
        }

        public async Task Receive()
        {
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            receivedJson = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            try
            {
                Form1.userAccess = JsonSerializer.Deserialize<User>(receivedJson);
            }
            catch
            {

            }
            
        }

        public void Access(string name, string password)
        {
            jsonString = JsonSerializer.Serialize(new string[] { name, password });
            ready.Release();
        }

        public void Registration(string name, string password, string confirm)
        {
            jsonString = JsonSerializer.Serialize(new string[] { name, password, confirm });
            ready.Release();
        }*/
    }
}
