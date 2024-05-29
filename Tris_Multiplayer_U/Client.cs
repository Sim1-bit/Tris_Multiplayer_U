using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tris_Multiplayer_U
{
    public class Client
    {
        private TcpListener listener;
        private TcpClient client;
        private bool aux = true;
        NetworkStream stream = null;
        NetworkStream Stream
        {
            get
            {
                return stream;
            }
            set
            {
                if (stream == null)
                {
                    stream = value;
                }
            }
        }

        public Client()
        {
            string ipAddress = "127.0.0.1";

            client = new TcpClient(ipAddress, 53000);

            Thread clientThread = new Thread(HandleCommunication);
            clientThread.Start(client);
        }
        private void HandleCommunication(object obj)
        {
            TcpClient peer = (TcpClient)obj;
            Stream = peer.GetStream();

            while (true)
            {
                // Ricevi dati
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                try
                {
                    bool aux = Convert.ToBoolean(receivedMessage);
                }
                catch (InvalidCastException)
                {
                    
                }

                    // Invia dati
                    Console.Write("Inserisci il messaggio da inviare: ");
                string messageToSend = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(messageToSend);
                stream.Write(data, 0, data.Length);
            }
        }

        public void Access(string username, string password)
        {
            NetworkStream stream = client.GetStream();
            byte[] data = Encoding.UTF8.GetBytes(CreateHeader(username) + username + CreateHeader(password) + password);
            stream.Write(data, 0, data.Length);
        }
        public void SendMessage(string name, string password)
        {
            // Invia un messaggio a tutti i peer connessi
            
        }

        //Fa capire la lunghezza del messaghio per facilitare la lettura
        private string CreateHeader(string message)
        {
            string header = "00000";
            while (header.Length + message.Length > 5)
                header.Remove(0);
            return header + message.Length.ToString();
        }
        private string DestroyHeader(ref string message)
        {
            string aux = message;
            //tolgo tutti i valori affinchè mi rimanga solo l'header
            while (aux.Length > 5)
                aux.Remove(message.Length - 1);
            int lenght = Convert.ToInt32(aux);
            //Seleziono la parte di messaggio che mi interessa
            aux = message.Substring(5, lenght + 4);
            
            //modifico il messaggio affinchè non ci sia più la parte che ho letto
            message = message.Substring(lenght + 4);

            //Restituisco ciò che ho letto
            return aux;
        }
    }
}
