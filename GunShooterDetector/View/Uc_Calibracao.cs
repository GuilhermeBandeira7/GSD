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
    public partial class Uc_Calibracao : UserControl
    {
        public delegate void RefreshValues();
        public RefreshValues refreshValues;
        Thread refreshThread;
        bool refresh = false;

        public Uc_Calibracao()
        {
            InitializeComponent();
            refreshValues = new RefreshValues(RefreshValuesCallBack);
            refreshThread = new Thread(RefreshThread);
            refreshThread.IsBackground = true;
            refreshThread.Name = "CalibrationRefreshThread";
            refresh = true;
            refreshThread.Start();
        }

        private void Btn_AlterarOffset_Click(object sender, EventArgs e)
        {
            Frm_OffsetConfig offsetConfig = new Frm_OffsetConfig();
            offsetConfig.Show();
        }

        private void Btn_Canal1Calibracao_Click(object sender, EventArgs e)
        {
            Frm_Canal1Config canal1Config = new Frm_Canal1Config();
            canal1Config.Show();
        }

        private void Btn_CalibracaoConfig_Click(object sender, EventArgs e)
        {
            Frm_Canal2Config canal2Config = new Frm_Canal2Config();
            canal2Config.Show();
        }

        private void RefreshThread()
        {
            while (refresh)
            {
                if(CommunicationController.Instance.newData == true)
                {
                    Thread.Sleep(500);

                    if (IsHandleCreated)
                        BeginInvoke(refreshValues);
                }
               
            }
        }

        private void RefreshValuesCallBack()
        {
            var gainChannel1 = CommunicationController.Instance.currentGainCalibration01 / 10;
            var voltageCalibration = CommunicationController.Instance.currentVoltageCalibration01;
            var timeOutChannel1 = CommunicationController.Instance.currentTimeoutCalibration01;
            var equivalentResistence1 = CommunicationController.Instance.currentEquivalentResistence01;
            var gainChannel2 = CommunicationController.Instance.currentGainCalibration02 / 10;
            var voltageChannel2 = CommunicationController.Instance.currentVoltageCalibration02;
            var timeOutChannel2 = CommunicationController.Instance.currentTimeoutCalibration02;
            var equivalentResistence2 = CommunicationController.Instance.currentEquivalentResistence02;
            var voltageOffset1 = CommunicationController.Instance.currentVoltageOffset01;
            var timeoutOffset1 = CommunicationController.Instance.currentTimeoutOffset01;
            var voltageOffset2 = CommunicationController.Instance.currentVoltageOffset02;
            var timeoutOffset2 = CommunicationController.Instance.currentTimeoutOffset02;
            

            Lbl_ValueGCL1.Text = gainChannel1.ToString();
            Lbl_ValueVCL1.Text = voltageCalibration.ToString();
            Lbl_ValueTCL1.Text = timeOutChannel1.ToString();
            Lbl_ValueREQ1.Text = equivalentResistence1.ToString();
            Lbl_ValueGCL2.Text = gainChannel2.ToString();
            Lbl_ValueVCL2.Text = voltageChannel2.ToString();
            Lbl_ValueTCL2.Text = timeOutChannel2.ToString();
            Lbl_ValueREQ2.Text = equivalentResistence2.ToString();
            Lbl_RefreshTOF1.Text = timeoutOffset1.ToString();
            Lbl_RefreshTOF2.Text = timeoutOffset2.ToString();
            Lbl_RefreshVOF1.Text = voltageOffset1.ToString();
            Lbl_RefreshVOF2.Text = voltageOffset2.ToString();

        }

        private void Btn_RefreshV_Click(object sender, EventArgs e)
        {
            CommunicationController.Instance.newData = true;
        }

    }
}
