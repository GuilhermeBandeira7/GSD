using GunShooterDetector.Models.ModelCalibracao;
using Newtonsoft.Json;
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
    public partial class Frm_OffsetConfig : Form
    {
        public SerialPort actualSerialPort = new SerialPort();

        public Frm_OffsetConfig()
        {
            InitializeComponent();

            Txb_SerialNumber.Text = CommunicationController.Instance.selectedSerialNumber;           
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            CalibrationRequestModel calibrationRequest = new CalibrationRequestModel();
            calibrationRequest.SN = CommunicationController.Instance.selectedSerialNumber;
            calibrationRequest.TOF1 = Convert.ToInt32(Nud_TempoOffset.Value); 
            calibrationRequest.TOF2 = Convert.ToInt32(Nud_TempoOffset2.Value);
 
            CommunicationController.Instance.CalibrateRequest(calibrationRequest);
            this.Cursor = Cursors.Default;
        }
    }
}
