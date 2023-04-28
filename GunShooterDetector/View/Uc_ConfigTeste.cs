using GunShooterDetector.Models.ModelConfiguracao;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunShooterDetector.View
{
    public partial class Uc_ConfigTeste : UserControl
    {
        public delegate void RefreshTextBox(string serialNumber);
        RefreshTextBox refreshTextBox;

        public delegate void RefreshValues();
        public RefreshValues refreshValues;

        public delegate void Disconnect();
        Disconnect disconnect;


        Thread refreshThread;
        bool refresh = false;
      
        public SerialPort actualSerialPort = new SerialPort();

        public Uc_ConfigTeste(SerialPort serialPort, Frm_Menu menu)
        {
            actualSerialPort = serialPort;
            InitializeComponent();
            refreshTextBox = new RefreshTextBox(RefreshTextBoxCallback);
            refreshValues = new RefreshValues(RefreshValuesCallback);
            CommunicationController.Instance.StartConnection();
            Txb_NumeroSerie.Text = CommunicationController.Instance.selectedSerialNumber.ToString();
            disconnect = new Disconnect(DisconnectCallback);
            refreshThread = new Thread(RefreshThread);
            refresh = true;
            refreshThread.Start();
            refreshThread.IsBackground = true;
   
        }

        private void RefreshThread()
        {
            while (refresh)
            {
                Thread.Sleep(500);
                if(CommunicationController.Instance.newData)
                {
                    if (IsHandleCreated)
                        BeginInvoke(refreshValues);
                }
                
            }
        }

        public void RefreshTextBoxCallback(string serialNumber)
        {
            if (!Txb_NumeroSerie.Text.Contains(serialNumber))
                Txb_NumeroSerie.Text = (serialNumber);
        }

        private void DisconnectCallback()
        {
            Lbl_OperationMode.Text = string.Empty;
            Lbl_OperationMode.Text = string.Empty;
            Lbl_Inference.Text = string.Empty;
            Lbl_RelayTimeOut1.Text = string.Empty;
            Lbl_RelayMode.Text = string.Empty;
            Lbl_RelayMode.Text = string.Empty;
            Lbl_RelayMode.Text = string.Empty;
            Lbl_RelayTimeOut2.Text = string.Empty;
            Lbl_LedOperation.Text = string.Empty;
            Lbl_LedOperation.Text = string.Empty;
            Lbl_GCH1.Text = string.Empty;
            Tlp_Container.Enabled = false;
            Tlp_Container.Visible = false;
        }

        private void RefreshValuesCallback()
        {
            try
            {
                var mode = CommunicationController.Instance.currentMode;
                var inf = CommunicationController.Instance.currentInf;
                var timeOut1 = CommunicationController.Instance.currentTimeOut1;
                var modeOut2 = CommunicationController.Instance.currentModeOut2;
                var timeOut2 = CommunicationController.Instance.currentTimeOut2;
                var ledMode = CommunicationController.Instance.currentLedMode;
                var gainChannel1 = CommunicationController.Instance.currentGainCh01;
                var gainSpeaker = CommunicationController.Instance.currentGainSpeaker;
                var gainChannel2 = CommunicationController.Instance.currentGainCh02;


                if (mode == 0) // if mode is 0 we use stand-alone mode
                {
                    Lbl_OperationMode.Text = "Stand-Alone";
                    Rb_StandAlone.Checked = true;
                }
                else
                {
                    Lbl_OperationMode.Text = "TelemetryHub";
                    Rb_TelemetryHub.Checked = true;
                }

                Lbl_Inference.Text = inf.ToString(); // propertie labelInf.text receives inf converted to string which contains inference value
                Nud_Inferencia.Value = inf;
                Lbl_RelayTimeOut1.Text = timeOut1.ToString(); // this propertie recieves the timeout value of the relay 
                Nud_TempoRele.Value = timeOut1;

                if (modeOut2 == 0) // if ralay mode is equals to 0 the modeOut2 is anactive 
                {
                    Lbl_RelayMode.Text = "Inativo";
                    Rb_Inativo.Checked = true;
                }
                else if (modeOut2 == 1)
                {
                    Lbl_RelayMode.Text = "Alarme";
                    Rb_Alarme.Checked = true;
                }
                else
                {
                    Lbl_RelayMode.Text = "WatchDog";
                    Rb_WatchDog.Checked = true;
                }

                Lbl_RelayTimeOut2.Text = timeOut2.ToString();
                Nud_TempRele2.Value = timeOut2;

                if (ledMode == 0)
                {
                    Lbl_LedOperation.Text = "Inativo";
                    Rb_LedInativo.Checked = true;
                }
                else
                {
                    Lbl_LedOperation.Text = "Ativo";
                    Rb_LedAtivo.Checked = true;
                }


                Nud_GCH1.Value = Convert.ToDecimal((double)gainChannel1/10);
                Nud_GCH2.Value = Convert.ToDecimal((double)gainChannel2/10);
                Nud_SPK.Value = Convert.ToDecimal((double)gainSpeaker / 10);
                Tlp_Container.Enabled = true;
                Tlp_Container.Visible = true;
                Lbl_GCH1.Text = Nud_GCH1.Value.ToString();
                Lbl_GCH2.Text = Nud_GCH2.Value.ToString();
                Lbl_GSPK.Text = Nud_SPK.Value.ToString();

                // Btn_Conectar.Text = "Desconectar";
            }
            catch(Exception ex)
            {

            }

        }

        private void Btn_AlterarModoOperacao_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommunicationController.Instance.State == State.KA)
                {

                    ConfigureRequestModel configureRequestModel = new ConfigureRequestModel();
                    configureRequestModel.SN = CommunicationController.Instance.selectedSerialNumber;
                    configureRequestModel.MODE = Rb_StandAlone.Checked ? 0 : 1;
                    configureRequestModel.INFE = CommunicationController.Instance.currentInf;
                    configureRequestModel.TRL1 = CommunicationController.Instance.currentTimeOut1;
                    configureRequestModel.MRL2 = CommunicationController.Instance.currentModeOut2;
                    configureRequestModel.TRL2 = CommunicationController.Instance.currentTimeOut2;
                    configureRequestModel.MLED = CommunicationController.Instance.currentLedMode;
                    configureRequestModel.GCH1 = CommunicationController.Instance.currentGainCh01;
                    configureRequestModel.GCH2 = CommunicationController.Instance.currentGainCh02;
                    configureRequestModel.GSPK = CommunicationController.Instance.currentGainSpeaker;

                    CommunicationController.Instance.SaveConfig(configureRequestModel);
                }
                else
                {
                    MessageBox.Show("Erro na comunicação, reinicie a aplicação.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void Btn_AlterarInferencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommunicationController.Instance.State == State.KA)
                {
                    ConfigureRequestModel configureRequestModel = new ConfigureRequestModel();
                    configureRequestModel.SN = CommunicationController.Instance.selectedSerialNumber;
                    configureRequestModel.MODE = CommunicationController.Instance.currentMode;
                    configureRequestModel.INFE = Convert.ToInt32(Nud_Inferencia.Value);
                    configureRequestModel.TRL1 = CommunicationController.Instance.currentTimeOut1;
                    configureRequestModel.MRL2 = CommunicationController.Instance.currentModeOut2;
                    configureRequestModel.TRL2 = CommunicationController.Instance.currentTimeOut2;
                    configureRequestModel.MLED = CommunicationController.Instance.currentLedMode;
                    configureRequestModel.GCH1 = CommunicationController.Instance.currentGainCh01;
                    configureRequestModel.GCH2 = CommunicationController.Instance.currentGainCh02;
                    configureRequestModel.GSPK = CommunicationController.Instance.currentGainSpeaker;

                    CommunicationController.Instance.SaveConfig(configureRequestModel);
                }
                else
                {
                    MessageBox.Show("Erro na comunicação, reinicie a aplicação.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void Btn_AlterarTempoRele_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommunicationController.Instance.State == State.KA)
                {

                    ConfigureRequestModel configureRequestModel = new ConfigureRequestModel();
                    configureRequestModel.SN = CommunicationController.Instance.selectedSerialNumber;
                    configureRequestModel.MODE = CommunicationController.Instance.currentMode;
                    configureRequestModel.INFE = CommunicationController.Instance.currentInf;
                    configureRequestModel.TRL1 = Convert.ToInt32(Nud_TempoRele.Value);
                    configureRequestModel.MRL2 = CommunicationController.Instance.currentModeOut2;
                    configureRequestModel.TRL2 = CommunicationController.Instance.currentTimeOut2;
                    configureRequestModel.MLED = CommunicationController.Instance.currentLedMode;
                    configureRequestModel.GCH1 = CommunicationController.Instance.currentGainCh01;
                    configureRequestModel.GCH2 = CommunicationController.Instance.currentGainCh02;
                    configureRequestModel.GSPK = CommunicationController.Instance.currentGainSpeaker;

                    CommunicationController.Instance.SaveConfig(configureRequestModel);
                }
                else
                {
                    MessageBox.Show("Erro na comunicação, reinicie a aplicação.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void Btn_AlterarModoRele_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommunicationController.Instance.State == State.KA)
                {


                    int value = 0;
                    if (Rb_Inativo.Checked)
                        value = 0;
                    if (Rb_Alarme.Checked)
                        value = 1;
                    if (Rb_WatchDog.Checked)
                        value = 2;
                    ConfigureRequestModel configureRequestModel = new ConfigureRequestModel();
                    configureRequestModel.SN = CommunicationController.Instance.selectedSerialNumber;
                    configureRequestModel.MODE = CommunicationController.Instance.currentMode;
                    configureRequestModel.INFE = CommunicationController.Instance.currentInf;
                    configureRequestModel.TRL1 = CommunicationController.Instance.currentTimeOut1;
                    configureRequestModel.MRL2 = value;
                    configureRequestModel.TRL2 = CommunicationController.Instance.currentTimeOut2;
                    configureRequestModel.MLED = CommunicationController.Instance.currentLedMode;
                    configureRequestModel.GCH1 = CommunicationController.Instance.currentGainCh01;
                    configureRequestModel.GCH2 = CommunicationController.Instance.currentGainCh02;
                    configureRequestModel.GSPK = CommunicationController.Instance.currentGainSpeaker;

                    CommunicationController.Instance.SaveConfig(configureRequestModel);
                }
                else
                {
                    MessageBox.Show("Erro na comunicação, reinicie a aplicação.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {

            }

        }

        private void Btn_AlterarTempoRele2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommunicationController.Instance.State == State.KA)
                {


                    ConfigureRequestModel configureRequestModel = new ConfigureRequestModel();
                    configureRequestModel.SN = CommunicationController.Instance.selectedSerialNumber;
                    configureRequestModel.MODE = CommunicationController.Instance.currentMode;
                    configureRequestModel.INFE = CommunicationController.Instance.currentInf;
                    configureRequestModel.TRL1 = CommunicationController.Instance.currentTimeOut1;
                    configureRequestModel.MRL2 = CommunicationController.Instance.currentModeOut2;
                    configureRequestModel.TRL2 = Convert.ToInt32(Nud_TempRele2.Value);
                    configureRequestModel.MLED = CommunicationController.Instance.currentLedMode;
                    configureRequestModel.GCH1 = CommunicationController.Instance.currentGainCh01;
                    configureRequestModel.GCH2 = CommunicationController.Instance.currentGainCh02;
                    configureRequestModel.GSPK = CommunicationController.Instance.currentGainSpeaker;

                    CommunicationController.Instance.SaveConfig(configureRequestModel);
                }
                else
                {
                    MessageBox.Show("Erro na comunicação, reinicie a aplicação.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void Btn_AlterarLedOperacao_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommunicationController.Instance.State == State.KA)
                {


                    ConfigureRequestModel configureRequestModel = new ConfigureRequestModel();
                    configureRequestModel.SN = CommunicationController.Instance.selectedSerialNumber;
                    configureRequestModel.MODE = CommunicationController.Instance.currentMode;
                    configureRequestModel.INFE = CommunicationController.Instance.currentInf;
                    configureRequestModel.TRL1 = CommunicationController.Instance.currentTimeOut1;
                    configureRequestModel.MRL2 = CommunicationController.Instance.currentModeOut2;
                    configureRequestModel.TRL2 = CommunicationController.Instance.currentTimeOut2;
                    configureRequestModel.MLED = Rb_LedAtivo.Checked ? 1 : 0;
                    configureRequestModel.GCH1 = CommunicationController.Instance.currentGainCh01;
                    configureRequestModel.GCH2 = CommunicationController.Instance.currentGainCh02;
                    configureRequestModel.GSPK = CommunicationController.Instance.currentGainSpeaker;
                    //configureRequestModel.GAIN = CommunicationController.Instance.currentGain;

                    CommunicationController.Instance.SaveConfig(configureRequestModel);
                }
                else
                {
                    MessageBox.Show("Erro na comunicação, reinicie a aplicação.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {

            }

        }

        private void Btn_AlterarGanho_Click(object sender, EventArgs e) //GCH1
        {
            try
            {
                if (CommunicationController.Instance.State == State.KA)
                {


                    ConfigureRequestModel configureRequestModel = new ConfigureRequestModel();
                    configureRequestModel.SN = CommunicationController.Instance.selectedSerialNumber;
                    configureRequestModel.MODE = CommunicationController.Instance.currentMode;
                    configureRequestModel.INFE = CommunicationController.Instance.currentInf;
                    configureRequestModel.TRL1 = CommunicationController.Instance.currentTimeOut1;
                    configureRequestModel.MRL2 = CommunicationController.Instance.currentModeOut2;
                    configureRequestModel.TRL2 = CommunicationController.Instance.currentTimeOut2;
                    configureRequestModel.MLED = CommunicationController.Instance.currentLedMode;
                    configureRequestModel.GCH1 = Convert.ToInt32(Nud_GCH1.Value) * 10;
                    configureRequestModel.GCH2 = CommunicationController.Instance.currentGainCh02;
                    configureRequestModel.GSPK = CommunicationController.Instance.currentGainSpeaker;

                    CommunicationController.Instance.SaveConfig(configureRequestModel);
                }
                else
                {
                    MessageBox.Show("Erro na comunicação, reinicie a aplicação.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {

            }

        }

        private void Btn_AlterarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommunicationController.Instance.State == State.KA)
                {


                    int value = 0;
                    if (Rb_Inativo.Checked)
                        value = 0;
                    if (Rb_Alarme.Checked)
                        value = 1;
                    if (Rb_WatchDog.Checked)
                        value = 2;

                    ConfigureRequestModel configureRequestModel = new ConfigureRequestModel();
                    configureRequestModel.SN = CommunicationController.Instance.selectedSerialNumber;
                    configureRequestModel.MODE = Rb_StandAlone.Checked ? 0 : 1;
                    configureRequestModel.INFE = Convert.ToInt32(Nud_Inferencia.Value);
                    configureRequestModel.TRL1 = Convert.ToInt32(Nud_TempoRele.Value);
                    configureRequestModel.MRL2 = value;
                    configureRequestModel.TRL2 = Convert.ToInt32(Nud_TempRele2.Value);
                    configureRequestModel.MLED = Rb_LedAtivo.Checked ? 1 : 0;
                    configureRequestModel.GCH1 = Convert.ToInt32(Nud_GCH1.Value) * 10;
                    configureRequestModel.GCH2 = Convert.ToInt32(Nud_GCH2.Value) * 10;
                    configureRequestModel.GSPK = Convert.ToInt32(Nud_SPK.Value) * 10;

                    CommunicationController.Instance.SaveConfig(configureRequestModel);
                }
                else
                {
                    MessageBox.Show("Erro na comunicação, reinicie a aplicação.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            CommunicationController.Instance.newData = true;
        }

        private void Btn_AlterarGCH2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommunicationController.Instance.State == State.KA)
                {
                    ConfigureRequestModel configureRequestModel = new ConfigureRequestModel();
                    configureRequestModel.SN = CommunicationController.Instance.selectedSerialNumber;
                    configureRequestModel.MODE = CommunicationController.Instance.currentMode;
                    configureRequestModel.INFE = CommunicationController.Instance.currentInf;
                    configureRequestModel.TRL1 = CommunicationController.Instance.currentTimeOut1;
                    configureRequestModel.MRL2 = CommunicationController.Instance.currentModeOut2;
                    configureRequestModel.TRL2 = CommunicationController.Instance.currentTimeOut2;
                    configureRequestModel.MLED = CommunicationController.Instance.currentLedMode;
                    configureRequestModel.GCH1 = CommunicationController.Instance.currentGainCh01;
                    configureRequestModel.GCH2 = Convert.ToInt32(Nud_GCH2.Value) * 10;
                    configureRequestModel.GSPK = CommunicationController.Instance.currentGainSpeaker;

                    CommunicationController.Instance.SaveConfig(configureRequestModel);
                }
                else
                {
                    MessageBox.Show("Erro na comunicação, Reinicie a Aplicação.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void Btn_AlterarSPK_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommunicationController.Instance.State == State.KA)
                {
                    ConfigureRequestModel configureRequestModel = new ConfigureRequestModel();
                    configureRequestModel.SN = CommunicationController.Instance.selectedSerialNumber;
                    configureRequestModel.MODE = CommunicationController.Instance.currentMode;
                    configureRequestModel.INFE = CommunicationController.Instance.currentInf;
                    configureRequestModel.TRL1 = CommunicationController.Instance.currentTimeOut1;
                    configureRequestModel.MRL2 = CommunicationController.Instance.currentModeOut2;
                    configureRequestModel.TRL2 = CommunicationController.Instance.currentTimeOut2;
                    configureRequestModel.MLED = CommunicationController.Instance.currentLedMode;
                    configureRequestModel.GCH1 = CommunicationController.Instance.currentGainCh01;
                    configureRequestModel.GCH2 = CommunicationController.Instance.currentGainCh02;
                    configureRequestModel.GSPK = Convert.ToInt32(Nud_SPK.Text) * 10;

                    CommunicationController.Instance.SaveConfig(configureRequestModel);
                }
                else
                {
                    MessageBox.Show("Erro na comunicação, Reinicie a Aplicação.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                
            }
            
        }

    }
}


