using ChatApp.Net.IO;
using ChatConsole;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;




Server server = new Server();
server.ConnectToServer("name");
server.SendMessageToServer("aaaa");
