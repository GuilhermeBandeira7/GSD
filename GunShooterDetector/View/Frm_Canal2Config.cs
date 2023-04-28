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
    public partial class Frm_Canal2Config : Form
    {
        SerialPort actualSerialPort = new SerialPort();
        public Frm_Canal2Config()
        {
            InitializeComponent();
            Txb_SerialNumberCanal2.Text = CommunicationController.Instance.selectedSerialNumber;
        }

        private void Btn_Canal2Alterar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            CalibrationChanel2ReqModel calibrationChanel2 = new CalibrationChanel2ReqModel();
            calibrationChanel2.GCL2 = Convert.ToInt32(Nud_Ganho.Value) * 10; 
            calibrationChanel2.VCL2 = Convert.ToInt32(Nud_VCL2.Value);
            calibrationChanel2.TCL2 = Convert.ToInt32(Nud_TCL2.Value);

            CommunicationController.Instance.CalibrateChannel2Request(calibrationChanel2);

            this.Cursor = Cursors.Default;
        }
    }
}
