using GunShooterDetector.Models.ModelReset;
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
    public partial class Frm_Reset : Form
    {
        SerialPort actualSerialPort = new SerialPort();
        public Frm_Reset()
        {
            InitializeComponent();
        }

        private void Btn_AlterarOffset_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem certeza que desejar resetar as configurações?", "Resetar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.Yes)
            {
                if (Rb_AtivaAlarme.Checked)
                {                   
                    ResetRequestModel resetRequest = new ResetRequestModel();
                    resetRequest.MRL1 = 1;
                    CommunicationController.Instance.ResetRequest(resetRequest);
                }
                else if (Rb_DesativaAlarme.Checked)
                {
                    ResetRequestModel resetRequest = new ResetRequestModel();
                    resetRequest.MRL1 = 0;
                    CommunicationController.Instance.ResetRequest(resetRequest);
                }
                else if(Rb_ResetAll.Checked)
                {
                    FullResetModel resetAllModel = new FullResetModel();
                    CommunicationController.Instance.FullResetRequest(resetAllModel);
                }
            }
            else
            {
                this.Close();
            }
        }

       

      
    }
}
