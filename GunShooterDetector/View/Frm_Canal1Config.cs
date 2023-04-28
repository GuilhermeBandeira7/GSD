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
using GunShooterDetector.Models.ModelCalibracao;
using Newtonsoft.Json;

namespace GunShooterDetector.View
{
    public partial class Frm_Canal1Config : Form
    {
        SerialPort actualSerialPort = new SerialPort();
        public Frm_Canal1Config()
        {
            InitializeComponent();
            this.Text = "GSD";
            Txb_SerialNumber.Text = CommunicationController.Instance.selectedSerialNumber;
        }

        private void Btn_Canal1Alterar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            CalibrationChanel1ReqModel calibrationChanel1 = new CalibrationChanel1ReqModel();
            calibrationChanel1.GCL1 = Convert.ToInt32(Nud_Ganho.Value) * 10; //int.Parse(Txb_Canal1Ganho.Text) * 10;
            calibrationChanel1.VCL1 = Convert.ToInt32(Nud_VCL1.Value);
            calibrationChanel1.TCL1 = Convert.ToInt32(Nud_TCL1.Value);

            CommunicationController.Instance.CalibrateChannell1Request(calibrationChanel1);
            this.Cursor = Cursors.Default;
        }
    }
}
