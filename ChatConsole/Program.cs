using ChatApp.Net.IO;
using ChatConsole;
using ChatApp;
using System.Collections.ObjectModel;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using ChatConsole.ViewModel;
using ChatConsole.Model;

class Program
{
    //public ObservableCollection<string> Messages { get; set; }


    static void Main()
    {
        Console.WriteLine("Enter name to connect");
        var name = Console.ReadLine();
        var message = string.Empty;
        var input = new MainViewModel(name);


        while (true)
        {
            message = Console.ReadLine();
            input.SendMessage(message);
        }

        //DisplayCommands();

        //Server server = new Server();


        //    while (true)
        //    {
        //        server.connectedEvent += () => Console.WriteLine("User " + name + " connected to the server");
        //        server.userDisconnectedEvent += () => Console.WriteLine("User " + name + " disconnected to the server");

        //        input = Console.ReadLine();

        //        if (input.Equals("login", StringComparison.OrdinalIgnoreCase))
        //        {
        //            Console.Write("Enter your name: ");
        //            name = Console.ReadLine();

        //            if (server.ConnectToServer(name))
        //            {
        //                Console.WriteLine("User logged in as: " + name);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Failed to log in to the server. Please try again.");
        //            }
        //        }
        //        else if (input.Equals("message", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(name))
        //        {
        //            Console.WriteLine("Message: ");
        //            message = Console.ReadLine();
        //            server.SendMessageToServer(message);
        //            var msg = server.PacketReader.ReadMessage();
        //            //Messages.Add(msg);
        //            server.msgReceivedEvent += () => Console.WriteLine(msg);
        //            //Console.WriteLine($"{name} sent message: {message}");
        //        }
        //        else if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
        //        {
        //            Console.WriteLine("Exiting the application...");
        //            break; 
        //        }
        //        else if (string.IsNullOrEmpty(name))
        //        {
        //            Console.WriteLine("You need to log in first by typing 'log in'.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Unknown command. Please try again.");
        //        }
        //    }

        //    Console.WriteLine("Press any key to exit...");
        //    Console.ReadKey();
        //}

        //static void DisplayCommands()
        //{
        //    Console.WriteLine("Command list:");
        //    Console.WriteLine("To log in, type 'login'.");
        //    Console.WriteLine("To send a message, type 'message'.");
        //    Console.WriteLine("To exit, type 'exit'.");
        //}
    }
}
