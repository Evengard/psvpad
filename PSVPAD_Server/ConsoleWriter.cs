// Decompiled with JetBrains decompiler
// Type: PSV_Server.ConsoleWriter
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PSV_Server
{
    internal class ConsoleWriter : TextWriter
    {
        private ReaderWriterLock rwl = new ReaderWriterLock();
        private RichTextBox _output;

        public ConsoleWriter(RichTextBox output)
        {
            this._output = output;
        }

        public override void Write(char value)
        {
            this.rwl.AcquireWriterLock(-1);
            try
            {
                base.Write(value);
                this._output.Text += value.ToString();
            }
            finally
            {
                this.rwl.ReleaseWriterLock();
            }
        }

        public override Encoding Encoding
        {
            get
            {
                return Encoding.UTF8;
            }
        }
    }
}
