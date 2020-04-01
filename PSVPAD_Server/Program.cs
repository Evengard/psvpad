// Decompiled with JetBrains decompiler
// Type: PSV_Server.Program
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PSV_Server
{
    internal class Program
    {
        public static PSV_Server.PSVServer serverForm = (PSV_Server.PSVServer)null;
        public static Server PSVServer = (Server)null;
        public static bool isRunning = true;

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private static void Main(string[] args)
        {
            Console.Title = "PSVS_CONSOLE";
            //Program.ShowWindow(Program.FindWindow((string) null, "PSVS_CONSOLE"), 0);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.serverForm = new PSV_Server.PSVServer();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("PSV Pad Server");
            Console.WriteLine("Developed by AJ Moore");
            Console.WriteLine("Unorthodox Game Studios");
            Console.WriteLine("www.unorthodoxgamestudios.co.uk");
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.WriteLine("Enter the IP below on the PSVPAD vita app and press connect");

            List<IPAddress> localBroadcasts = new List<IPAddress>();

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                foreach (UnicastIPAddressInformation address in properties.UnicastAddresses)
                {
                    if (address.Address.AddressFamily == AddressFamily.InterNetwork && adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        uint ipAddress = BitConverter.ToUInt32(address.Address.GetAddressBytes(), 0);
                        uint ipMaskV4 = BitConverter.ToUInt32(address.IPv4Mask.GetAddressBytes(), 0);
                        uint broadCastIpAddress = ipAddress | ~ipMaskV4;

                        var localBroadcast = new IPAddress(BitConverter.GetBytes(broadCastIpAddress));
                        localBroadcasts.Add(localBroadcast);

                        Console.WriteLine("Your IP: " + address.Address.ToString());
                        Console.WriteLine("Your broadcast: " + localBroadcast);
                        Program.serverForm.ipAddress = address.Address.ToString();
                    }
                }
            }

            Program.PSVServer = new Server();
            Program.PSVServer.localBroadcasts = localBroadcasts;
            Application.Run((Form)Program.serverForm);
            Environment.Exit(0);
        }

        public static void CloseApplication()
        {
            Program.serverForm.Close();
        }
    }
}
