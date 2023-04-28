using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunShooterDetector.View
{
    public partial class Uc_PortaSerial : UserControl
    {
        Frm_Menu menu;
        public Uc_PortaSerial(SerialPort serialPort, Frm_Menu frmMenu)
        {
            menu = frmMenu;

            InitializeComponent();
            GetAllSerialPorts();
                       
        }

         
        public void GetAllSerialPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                Cbx_NomePorta.Items.Add(port); 
            }
        }        

        
        private void Txt_BaudRate_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
               
            }
        }

        private void Txt_Parity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string _parity = Txt_Parity.Text;
             
            }
            catch { }
        }

        private void txt_DataBits_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception Ex)
            {
                
            }
        }

        private void Txt_StopBits_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string _stopBits = Txt_StopBits.Text;
               
            }
            catch (Exception ex)
            {
                
            }
        }

        private void Txt_Handshake_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string _handshake = Txt_Handshake.Text;              
            }
            catch (Exception ex)
            {
                
            }
        }       

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if(Cbx_NomePorta.Text != string.Empty)
            {
                this.Cursor = Cursors.WaitCursor;
                int clickCounter = 0;
                clickCounter++;

                //bool success = false;
                CommunicationController.Instance.actualSerialPort.Parity = (Parity)Enum.Parse(typeof(Parity), Txt_Parity.Text);
                CommunicationController.Instance.actualSerialPort.DataBits = int.Parse(txt_DataBits.Text);
                CommunicationController.Instance.actualSerialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Txt_StopBits.Text);
                CommunicationController.Instance.actualSerialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), Txt_Handshake.Text);
                CommunicationController.Instance.actualSerialPort.BaudRate = int.Parse(Txt_BaudRate.Text);

                //if(CommunicationController.Instance.actualSerialPort != null)
                //{
                //    success = true;
                //}          

                CommunicationController.Instance.Start(menu);

                while (CommunicationController.Instance.tryingToConnect)
                {
                    int tryingToConnect = 0;
                    while (CommunicationController.Instance.waitStatusMessage == false)
                    {
                        tryingToConnect++;
                        if (tryingToConnect == 15)
                        {
                            CommunicationController.Instance.tryingToConnect = false;    
                            break;
                        }
                    };
                    Lbl_Mensagens.Text = CommunicationController.Instance.statusMessage;
                    Lbl_MsgNovoSerialNumber.Text = CommunicationController.Instance.newSerialNumberMsg;
                }
                this.Cursor = Cursors.Default;
            }                        
        }

        private void Cbx_NomePorta_TextChanged(object sender, EventArgs e)
        {
            CommunicationController.Instance.actualSerialPort.PortName = Cbx_NomePorta.Text;
        }

 
    }
}
