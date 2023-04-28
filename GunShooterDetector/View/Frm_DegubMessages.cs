using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunShooterDetector.View
{    
    public partial class Frm_DegubMessages : Form
    {
        bool debugRun = false;
        Thread debugThread;

        public delegate void DebugThreadCallback(string message);
        public DebugThreadCallback debugThreadCallback;

        public Frm_DegubMessages()
        {
            InitializeComponent();
            debugThread = new Thread(DebugThread);
            debugRun = true;
            debugThread.IsBackground = true;
            debugThread.Name = "DebugThread";
            debugThread.Start();
            debugThreadCallback = new DebugThreadCallback(DebugCallback);
        }

        private void DebugCallback(string message)
        {
            textBoxDebug.AppendText("\r\n");
            textBoxDebug.AppendText(message);
        }

        private void DebugThread()
        {
            while (debugRun)
            {
                if (CommunicationController.Instance.messageHistory.Count > 0)
                {
                    try
                    {
                        string message = string.Join("\r\n", CommunicationController.Instance.messageHistory.Select(x => x.Key.ToString() + "-" + x.Value).ToArray());
                        CommunicationController.Instance.messageHistory.Clear();
                        if (IsHandleCreated)
                            BeginInvoke(debugThreadCallback, new object[] { message });
                    }
                    catch (Exception ex)
                    {

                    }

                }

                Thread.Sleep(500);
            }
        }

        private void Frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (debugThread != null)
            {
                if (debugThread.IsAlive)
                {
                    debugRun = false;
                    debugThread.Join();
                }
            }

        }
    }
}
