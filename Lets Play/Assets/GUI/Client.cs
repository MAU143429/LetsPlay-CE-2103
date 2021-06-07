using UnityEngine;
using System.Net.Sockets;
using System;
using System.Text;
using System.IO;
using System.Threading;
using System.Net;
using Newtonsoft.Json;

public class Client : MonoBehaviour
{
    
    private static readonly Socket ClientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

    private const int PORT = 54000;

    public static void Init()
    {
        new Thread(() =>
        {
        Console.Title = "Client";
        ConnectToServer();
        RequestLoop();
        Exit();

        }).Start();
    }

    private static void ConnectToServer()
    {
        int attempts = 0;

        while (!ClientSocket.Connected)
        {
            try
            {
                attempts++;
                Console.WriteLine("Connection attempt " + attempts);
                // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                ClientSocket.Connect(IPAddress.Loopback, PORT);
            }
            catch (SocketException)
            {
                Console.Clear();
            }
        }

        Console.Clear();
        Console.WriteLine("Connected");
    }

    private static void RequestLoop()
    {
       
        while (true)
        {
            ReceiveResponse();
        }
    }

    /// <summary>
    /// Close socket and exit program.
    /// </summary>
    private static void Exit()
    {
        SendString("exit"); // Tell the server we are exiting
        ClientSocket.Shutdown(SocketShutdown.Both);
        ClientSocket.Close();
        Environment.Exit(0);
    }
    /// <summary>
    /// Sends a string to the server with ASCII encoding.
    /// </summary>
    public static void SendString(string text)
    {
        byte[] buffer = Encoding.ASCII.GetBytes(text);
        ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
    }

    private static void ReceiveResponse()
    {
        TypeMessage typeMessageIn = new TypeMessage();
        var buffer = new byte[2048];
        int received = ClientSocket.Receive(buffer, SocketFlags.None);
        if (received == 0) return;
        var data = new byte[received];
        Array.Copy(buffer, data, received);
        string text = Encoding.ASCII.GetString(data);
        Debug.Log(text);
        if (!string.IsNullOrEmpty(text))
        {
            typeMessageIn = JsonConvert.DeserializeObject<TypeMessage>(text);
            Select_Game.Select_Type_Game(typeMessageIn);

        }

    }

}









