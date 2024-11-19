// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;
using System.Net;
using System;

class Server {
    public static void Main()
    {
        const string IP = "10.0.0.5";
        TcpListener server = new TcpListener(IPAddress.Parse(IP), 80);

        server.Start();
        Console.WriteLine("El server se ha iniciado en" + IP + " :80.{0}Esperando una conexión...", Environment.NewLine);

        TcpClient client = server.AcceptTcpClient();

        Console.WriteLine("Un cliente conectado.");
    }
}

