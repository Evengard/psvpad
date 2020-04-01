﻿// Decompiled with JetBrains decompiler
// Type: PSV_Server.Server
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PSV_Server
{
    internal class Server
    {
        private Dictionary<uint, string> keyboardBinds = new Dictionary<uint, string>();
        private Dictionary<uint, string> mouseBinds = new Dictionary<uint, string>();
        private string[] clientIP = new string[2];
        private bool[] activeClient = new bool[2];
        private TcpClient[] tcpClients = new TcpClient[2];
        private Stopwatch[] clientTimeOutSW = new Stopwatch[2];
        private InputEmulation Input = new InputEmulation();
        public Configuration config = new Configuration();
        private ASCIIEncoding encoder = new ASCIIEncoding();
        private Stopwatch keyRepeatTimer = new Stopwatch();
        private int timeout = 10;
        private AudioRecorder recorder = new AudioRecorder();
        private TcpListener tcpListener;
        private Thread listenThread;
        private int clientNum;
        public InputData data;
        public InputData previousInput;
        private Stopwatch psvpadsw;
        private bool keyRepeat;

        public List<IPAddress> localBroadcasts = null;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetActiveWindow();

        [DllImport("user32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public void addBind(uint keyType, string keys)
        {
            if (this.keyboardBinds.ContainsKey(keyType))
                this.keyboardBinds[keyType] = keys;
            else
                this.keyboardBinds.Add(keyType, keys);
        }

        public void removeBind(uint keyType)
        {
            if (this.keyboardBinds.ContainsKey(keyType))
            {
                this.keyboardBinds.Remove(keyType);
            }
            else
            {
                if (!this.mouseBinds.ContainsKey(keyType))
                    return;
                this.mouseBinds.Remove(keyType);
            }
        }

        public void clearAllBinds()
        {
            this.keyboardBinds.Clear();
            this.mouseBinds.Clear();
            foreach (KeyValuePair<uint, Button> keyValuePair in PSVServer.buttonDict)
                keyValuePair.Value.Text = "";
        }

        public void addMouseBind(uint keyType, string keys)
        {
            if (this.mouseBinds.ContainsKey(keyType))
                this.mouseBinds[keyType] = keys;
            else
                this.mouseBinds.Add(keyType, keys);
        }

        private void updateButton(uint ButtonKey, bool Pressed, float ButtonValue)
        {
            if (PSVServer.buttonDict.ContainsKey(ButtonKey))
            {
                Button button = PSVServer.buttonDict[ButtonKey];
                if (Pressed)
                {
                    if (button.BackColor != Color.Green)
                        button.BackColor = Color.Green;
                }
                else if (button.BackColor != Color.Transparent)
                    button.BackColor = Color.Transparent;
            }
            if (this.keyboardBinds.ContainsKey(ButtonKey))
                this.Input.sendInput(this.keyboardBinds[ButtonKey], Pressed);
            if (!this.mouseBinds.ContainsKey(ButtonKey))
                return;
            this.Input.sendMouseInput(this.mouseBinds[ButtonKey], Pressed, ButtonValue);
        }

        public void checkBinds(InputData Data)
        {
            if (this.previousInput == null)
                this.previousInput = Data;
            this.keyRepeat = false;
            if (!this.keyRepeatTimer.IsRunning)
                this.keyRepeatTimer.Start();
            if (this.keyRepeatTimer.ElapsedMilliseconds >= (long)this.config.keyRepeatDelayMS)
            {
                this.keyRepeat = true;
                this.keyRepeatTimer.Reset();
            }
            Server.SetForegroundWindow(Server.GetActiveWindow());
            for (int index = 0; index < 32; ++index)
            {
                if (((int)Data.keyData & 1 << index) != 0)
                {
                    if (PSVServer.buttonDict.ContainsKey((uint)(1 << index)))
                    {
                        Button button = PSVServer.buttonDict[(uint)(1 << index)];
                        if (button.BackColor != Color.Green)
                            button.BackColor = Color.Green;
                    }
                    if (this.keyboardBinds.ContainsKey((uint)(1 << index)) && (this.keyRepeat || ((int)this.previousInput.keyData & 1 << index) == 0))
                        this.Input.sendInput(this.keyboardBinds[(uint)(1 << index)], true);
                    if (this.mouseBinds.ContainsKey((uint)(1 << index)))
                        this.Input.sendMouseInput(this.mouseBinds[(uint)(1 << index)], true, 1f);
                }
                else
                {
                    if (PSVServer.buttonDict.ContainsKey((uint)(1 << index)))
                    {
                        Button button = PSVServer.buttonDict[(uint)(1 << index)];
                        if (button.BackColor != Color.Transparent)
                            button.BackColor = Color.Transparent;
                    }
                    if (this.previousInput != null && ((int)this.previousInput.keyData & 1 << index) != 0)
                    {
                        if (this.keyboardBinds.ContainsKey((uint)(1 << index)))
                            this.Input.sendInput(this.keyboardBinds[(uint)(1 << index)], false);
                        if (this.mouseBinds.ContainsKey((uint)(1 << index)))
                            this.Input.sendMouseInput(this.mouseBinds[(uint)(1 << index)], false, 1f);
                    }
                }
            }
            if ((double)Data.lx > (double)this.config.LSDeadZone)
                this.updateButton(6U, true, Data.lx);
            else if ((double)this.previousInput.lx > (double)this.config.LSDeadZone)
                this.updateButton(6U, false, Data.lx);
            if ((double)Data.lx < -(double)this.config.LSDeadZone)
                this.updateButton(7U, true, Data.lx);
            else if ((double)this.previousInput.lx < -(double)this.config.LSDeadZone)
                this.updateButton(7U, false, Data.lx);
            if ((double)Data.ly > (double)this.config.LSDeadZone)
                this.updateButton(5U, true, Data.ly);
            else if ((double)this.previousInput.ly > (double)this.config.LSDeadZone)
                this.updateButton(5U, false, Data.ly);
            if ((double)Data.ly < -(double)this.config.LSDeadZone)
                this.updateButton(3U, true, Data.ly);
            else if ((double)this.previousInput.ly < -(double)this.config.LSDeadZone)
                this.updateButton(3U, false, Data.ly);
            if ((double)Data.rx > (double)this.config.RSDeadZone)
                this.updateButton(11U, true, Data.rx);
            else if ((double)this.previousInput.rx > (double)this.config.RSDeadZone)
                this.updateButton(11U, false, Data.rx);
            if ((double)Data.rx < -(double)this.config.RSDeadZone)
                this.updateButton(12U, true, Data.rx);
            else if ((double)this.previousInput.rx < -(double)this.config.RSDeadZone)
                this.updateButton(12U, false, Data.rx);
            if ((double)Data.ry > (double)this.config.RSDeadZone)
                this.updateButton(10U, true, Data.ry);
            else if ((double)this.previousInput.ry > (double)this.config.RSDeadZone)
                this.updateButton(10U, false, Data.ry);
            if ((double)Data.ry < -(double)this.config.RSDeadZone)
                this.updateButton(9U, true, Data.ry);
            else if ((double)this.previousInput.ry < -(double)this.config.RSDeadZone)
                this.updateButton(9U, false, Data.ry);
            if (this.config.gyroXEnabled)
            {
                if ((double)Data.motionX > (double)this.config.gyroXDeadZone)
                    this.updateButton(33U, true, Data.motionX);
                else if ((double)this.previousInput.motionX > (double)this.config.gyroXDeadZone)
                    this.updateButton(33U, false, Data.motionX);
                if ((double)Data.motionX < -(double)this.config.gyroXDeadZone)
                    this.updateButton(34U, true, Data.motionX);
                else if ((double)this.previousInput.motionX < -(double)this.config.gyroXDeadZone)
                    this.updateButton(34U, false, Data.motionX);
            }
            else
            {
                this.updateButton(33U, false, 0.0f);
                this.updateButton(34U, false, 0.0f);
            }
            if (this.config.gyroYEnabled)
            {
                if ((double)Data.motionY > (double)this.config.gyroYDeadZone)
                    this.updateButton(35U, true, Data.motionY);
                else if ((double)this.previousInput.motionY > (double)this.config.gyroYDeadZone)
                    this.updateButton(35U, false, Data.motionY);
                if ((double)Data.motionY < -(double)this.config.gyroYDeadZone)
                    this.updateButton(36U, true, Data.motionY);
                else if ((double)this.previousInput.motionY < -(double)this.config.gyroYDeadZone)
                    this.updateButton(36U, false, Data.motionY);
            }
            else
            {
                this.updateButton(35U, false, 0.0f);
                this.updateButton(36U, false, 0.0f);
            }
            if (this.config.gyroZEnabled)
            {
                if ((double)Data.motionZ > (double)this.config.gyroZDeadZone)
                    this.updateButton(37U, true, Data.motionZ);
                else if ((double)this.previousInput.motionZ > (double)this.config.gyroZDeadZone)
                    this.updateButton(37U, false, Data.motionZ);
                if ((double)Data.motionZ < -(double)this.config.gyroZDeadZone)
                    this.updateButton(38U, true, Data.motionZ);
                else if ((double)this.previousInput.motionZ < -(double)this.config.gyroZDeadZone)
                    this.updateButton(38U, false, Data.motionZ);
            }
            else
            {
                this.updateButton(37U, false, 0.0f);
                this.updateButton(38U, false, 0.0f);
            }
            for (int index = 0; index < 4; ++index)
            {
                if (((int)Data.rearTouch & 1 << index) != 0)
                    this.updateButton((uint)((1 << index) + 18), true, 1f);
                else if (this.previousInput != null && ((int)this.previousInput.rearTouch & 1 << index) != 0)
                    this.updateButton((uint)((1 << index) + 18), false, 1f);
            }
            this.previousInput = Data;
        }

        public Server()
        {
            this.config.clientTimeOut = 300U;
            this.config.keyRepeatDelayMS = 200U;
            this.config.LSDeadZone = 0.0f;
            this.config.RSDeadZone = 0.0f;
            this.config.gyroXDeadZone = 0.0f;
            this.config.gyroYDeadZone = 0.0f;
            this.config.gyroZDeadZone = 0.0f;
            this.config.gyroXEnabled = false;
            this.config.gyroYEnabled = false;
            this.config.gyroZEnabled = false;
            this.psvpadsw = new Stopwatch();
            this.psvpadsw.Start();
            Console.WriteLine("PSV Pad Server Started");
            this.tcpListener = new TcpListener(IPAddress.Any, 3000);
            this.listenThread = new Thread(new ThreadStart(this.ListenForClients));
            this.listenThread.Start();
        }

        private void ListenForClients()
        {
            Console.WriteLine("Listening for Clients");
            this.tcpListener.Start();
            while (Program.isRunning)
            {
                var sockl = new ArrayList { this.tcpListener.Server };
                Socket.Select(sockl, null, null, 1000000);
                if (sockl.Contains(this.tcpListener.Server))
                {
                    TcpClient tcpClient = this.tcpListener.AcceptTcpClient();
                    string str = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
                    Console.WriteLine("PsVita IP: " + str);
                    string localIP = ((IPEndPoint)tcpClient.Client.LocalEndPoint).Address.ToString();
                    Console.WriteLine("Your IP: " + localIP);
                    Program.serverForm.ipAddress = localIP;
                    PSVServer.isConnected = true;
                    PSVServer.refresh();
                    if (this.clientIP[0] == str || this.clientIP[1] == str)
                    {
                        Console.WriteLine("Error: Client already connected");
                        Console.WriteLine("This is all a bit buggy... If your having problems restart app (:");
                        tcpClient.Close();
                    }
                    else
                    {
                        if (this.clientIP[0] == "")
                            this.clientNum = 0;
                        this.clientIP[this.clientNum] = str;
                        this.tcpClients[this.clientNum] = tcpClient;
                        if (this.clientTimeOutSW[this.clientNum] == null)
                            this.clientTimeOutSW[this.clientNum] = new Stopwatch();
                        this.clientTimeOutSW[this.clientNum].Reset();
                        this.clientTimeOutSW[this.clientNum].Start();
                        ++this.clientNum;
                        if (this.clientNum > 1)
                            this.clientNum = 0;
                        new Thread(new ParameterizedThreadStart(this.HandleClientComm)).Start((object)tcpClient);
                    }
                }
                else
                {
                    UdpClient udpClient = new UdpClient();
                    //udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, 11111));
                    byte[] sendbuf = Encoding.ASCII.GetBytes("PSVPAD_1.5.1");
                    foreach (var localBroadcast in localBroadcasts)
                    {
                        udpClient.Send(sendbuf, sendbuf.Length, new IPEndPoint(localBroadcast, 11111));
                    }

                    /*
                    Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    byte[] sendbuf = Encoding.ASCII.GetBytes("PSVPAD_1.5.1");
                    IPEndPoint ep = new IPEndPoint(IPAddress.Broadcast, 11111);
                    s.SendTo(sendbuf, ep);*/
                }
            }
        }

        private void disconnectClient(int clientID, TcpClient client)
        {
            if (this.recorder.isRecording)
            {
                this.recorder.stopRecording();
                this.recorder.audioQueue.Clear();
            }
            PSVServer.isConnected = false;
            PSVServer.refresh();
            this.clientIP[clientID] = "";
            client.Close();
        }

        private void HandleClientComm(object client)
        {
            TcpClient client1 = (TcpClient)client;
            NetworkStream stream = client1.GetStream();
            string str = ((IPEndPoint)client1.Client.RemoteEndPoint).Address.ToString();
            stream.WriteTimeout = 200;
            int index = !(str == this.clientIP[0]) ? 1 : 0;
            byte[] numArray = new byte[256];
            Console.WriteLine("Connected to Client...");
            this.psvpadsw.Reset();
            this.psvpadsw.Start();
            while (Program.isRunning)
            {
                if (this.clientTimeOutSW[index].ElapsedMilliseconds > (long)this.config.clientTimeOut)
                {
                    Console.WriteLine("Connection to Client Timed Out");
                    this.disconnectClient(index, client1);
                    return;
                }
                int num = 0;
                try
                {
                    int offset = 0;
                    while (offset < 256)
                    {
                        num = stream.Read(numArray, offset, numArray.Length - offset);
                        offset += num;
                        if (num == 0)
                            break;
                    }
                }
                catch
                {
                    num = 0;
                }
                if (num != 0)
                {
                    this.clientTimeOutSW[index].Reset();
                    this.clientTimeOutSW[index].Start();
                    this.SendConfirmationToClient(stream);
                    this.data = this.toInputData(numArray);
                    if (this.data != null)
                    {
                        if (this.config.gyroXEnabled)
                        {
                        }
                        else
                        { }
                        if (this.config.gyroYEnabled)
                        { }
                        else
                        { }
                        if (this.config.gyroZEnabled)
                        { }
                        else
                        { }
                        if (this.data.keyboardDat != (byte)0)
                        {
                            this.Input.sendKeyDown((uint)this.data.keyboardDat);
                            this.Input.sendKeyUp((uint)this.data.keyboardDat);
                        }
                        this.checkBinds(this.data);
                    }
                    if (this.psvpadsw.ElapsedMilliseconds > 240000L)
                    {
                        this.psvpadsw.Reset();
                        this.psvpadsw.Start();
                    }
                }
            }
            this.disconnectClient(index, client1);
        }

        private bool bitAnd(uint one, uint two)
        {
            return ((int)one & (int)two) != 0;
        }

        private InputData WaitForData(NetworkStream clientStream)
        {
            byte[] numArray = new byte[256];
            InputData inputData = (InputData)null;
            bool flag = false;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (!flag)
            {
                if (stopwatch.ElapsedMilliseconds < (long)this.timeout)
                {
                    try
                    {
                        clientStream.Read(numArray, 0, 256);
                        flag = true;
                        inputData = this.toInputData(numArray);
                        this.SendConfirmationToClient(clientStream);
                    }
                    catch
                    {
                        flag = false;
                    }
                }
                else
                    break;
            }
            return inputData;
        }

        private void SendConfirmationToClient(NetworkStream clientStream)
        {
            if (!this.recorder.isRecording)
                this.recorder.startRecording();
            byte[] buffer = this.recorder.audioQueue.Count <= 0 ? this.encoder.GetBytes("OK") : this.recorder.audioQueue.Dequeue();
            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
        }

        public byte[] toByteArray(InputData data)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            binaryFormatter.Serialize((Stream)memoryStream, (object)data);
            byte[] buffer = memoryStream.GetBuffer();
            memoryStream.Close();
            return buffer;
        }

        public InputData toInputData(byte[] array)
        {
            IFormatter formatter = (IFormatter)new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream(array);
            formatter.Binder = (SerializationBinder)new vitaAssemblyBinder();
            memoryStream.Position = 0L;
            InputData inputData = (InputData)null;
            try
            {
                inputData = (InputData)formatter.Deserialize((Stream)memoryStream);
            }
            catch
            {
                Console.WriteLine("Error Deserializing");
            }
            memoryStream.Close();
            return inputData;
        }
    }
}