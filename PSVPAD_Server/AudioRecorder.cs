// Decompiled with JetBrains decompiler
// Type: PSV_Server.AudioRecorder
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace PSV_Server
{
    internal class AudioRecorder
    {
        private byte[] audioBuffer = new byte[0];
        public Queue<byte[]> audioQueue = new Queue<byte[]>();
        private Stopwatch delay = new Stopwatch();
        private Stopwatch timer = new Stopwatch();
        private uint duration = 30;
        private WaveIn waveIn;
        public bool isRecording;
        public int byteCount;
        private int bytesRecorded;
        private bool testMode;
        private int byteC;
        private uint ChunkSize;
        private uint SubChunk1Size;
        private short AudioFormat;
        private short NumChannels;
        private uint SampleRate;
        private uint ByteRate;
        private short BlockAlign;
        private short BitsPerSample;

        public byte[] getAudioBuffer()
        {
            return this.audioBuffer;
        }

        public AudioRecorder()
        {
            this.initialise();
        }

        public void startRecording()
        {
        }

        public void stopRecording()
        {
            this.waveIn.StopRecording();
        }

        private void initialise()
        {
            this.createWaveInDevice();
            this.audioBuffer = new byte[19200];
            if (!this.testMode)
                return;
            this.initHeader();
            this.writeHeader();
            this.startRecording();
        }

        private void createWaveInDevice()
        {
            this.waveIn = new WaveIn();
            MMDeviceEnumerator deviceEnumerator = new MMDeviceEnumerator();
            int deviceNumber = this.waveIn.DeviceNumber;
            foreach (MMDevice enumerateAudioEndPoint in deviceEnumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
                Console.WriteLine("{0}, {1}", (object)enumerateAudioEndPoint.FriendlyName, (object)enumerateAudioEndPoint.State);
            this.waveIn.DeviceNumber = 1;
            this.waveIn.WaveFormat = new WaveFormat(22050, 8, 1);
            this.waveIn.BufferMilliseconds = 300;
            this.waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(this.onWaveIn_Event);
            this.waveIn.RecordingStopped += new EventHandler<StoppedEventArgs>(this.onRecordingStoped_Event);
        }

        private void onWaveIn_Event(object sender, WaveInEventArgs e)
        {
            if (!this.timer.IsRunning)
            {
                this.timer.Reset();
                this.timer.Start();
                this.delay.Start();
            }
            this.byteCount = 0;
            this.audioQueue.Enqueue(e.Buffer);
            if (!this.testMode)
                return;
            FileStream fileStream = new FileStream("Test1.wav", FileMode.Append);
            BinaryWriter binaryWriter = new BinaryWriter((Stream)fileStream, Encoding.ASCII);
            binaryWriter.Write(e.Buffer);
            binaryWriter.Close();
            fileStream.Close();
            if (this.timer.ElapsedMilliseconds < (long)(this.duration * 1000U))
                return;
            Console.WriteLine("Test Rec Done");
            this.stopRecording();
        }

        private void onRecordingStoped_Event(object sender, StoppedEventArgs e)
        {
            this.isRecording = false;
            this.createWaveInDevice();
        }

        private void initHeader()
        {
            this.NumChannels = (short)2;
            this.SampleRate = 22050U;
            this.BitsPerSample = (short)16;
            this.SubChunk1Size = 16U;
            this.AudioFormat = (short)1;
            this.ByteRate = (uint)((ulong)this.SampleRate * (ulong)this.NumChannels * (ulong)this.BitsPerSample / 8UL);
            this.ChunkSize = (uint)(36 + (int)this.duration * (int)this.ByteRate);
            this.BlockAlign = (short)((int)this.NumChannels * (int)this.BitsPerSample / 8);
        }

        private void writeHeader()
        {
            FileStream fileStream = new FileStream("Test1.wav", FileMode.Create);
            BinaryWriter binaryWriter = new BinaryWriter((Stream)fileStream, Encoding.ASCII);
            binaryWriter.Write(Encoding.ASCII.GetBytes("RIFF"));
            binaryWriter.Write(this.ChunkSize);
            binaryWriter.Write(Encoding.ASCII.GetBytes("WAVE"));
            binaryWriter.Write(Encoding.ASCII.GetBytes("fmt "));
            binaryWriter.Write((int)this.SubChunk1Size);
            binaryWriter.Write(this.AudioFormat);
            binaryWriter.Write(this.NumChannels);
            binaryWriter.Write((int)this.SampleRate);
            binaryWriter.Write((int)this.ByteRate);
            binaryWriter.Write(this.BlockAlign);
            binaryWriter.Write(this.BitsPerSample);
            binaryWriter.Write(Encoding.ASCII.GetBytes("data"));
            binaryWriter.Write((long)(int)this.ByteRate * (long)this.duration);
            binaryWriter.Close();
            fileStream.Close();
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct ByteFloatUnion
        {
            [FieldOffset(0)]
            public float f;
            [FieldOffset(0)]
            public int b;
        }
    }
}
