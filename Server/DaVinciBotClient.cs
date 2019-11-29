using System;
using System.IO;
using System.IO.File;
using System.Net.Sockets;

/// <summary>
/// Client class for the DaVinci Bot.  Loads commands from gcode file and passes them one by one to the esp32 access point.
/// </summary>
public class DaVinciBotClient
{
	public static void Main()
    {
        TcpClient client = new TcpClient();
        Console.WriteLine("Connecting...");

        client.Connect("192.168.4.1", 80);

        Console.WriteLine("Connected");

        string[] commands = System.IO.File.ReadAllLines(@".\commands.ncc");

        int numCommands = commands.Length;

        Stream stream = client.GetStream();

        int count = 0;
        int index = 0;

        foreach(string line in lines)
        {
            byte[] command = line;

            if (count == 0)
            {
                byte[] request = new byte[5];

                while (request == null) { request = stream.Read(request, 0, 5); }

                count = BitConverter.ToInt32(request, 0);
            }

            stream.Write(command, 0, command.Length);

            count--;
            index++;

            Console.WriteLine(index / numCommands);
        }

        client.Close();
    }
}
