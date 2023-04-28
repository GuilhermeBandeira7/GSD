using GunShooterDetector.Models.ModelCalibracao;
using GunShooterDetector.Models.ModelConfiguracao;
using GunShooterDetector.Models.ModelReset;
using GunShooterDetector.View;
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

namespace GunShooterDetector
{
    public enum State
    {
        NC, //Not Connected
        OP, //Operating
        CNT, //Connecting
        KA, //KeepAlive
        CONFIG, //Configuration
        CALOFF,
        CAL01,
        CAL02,
    }

    public class CommunicationController
    {
        #region SINGLETON
        private static CommunicationController instance;
        private CommunicationController()
        {
        }

        public static CommunicationController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CommunicationController();
                }
                return instance;
            }
        }
        #endregion

        public State State = State.NC;
        Thread communicationThread;
        bool connected = false;
        public bool newData = false;

        public SerialPort actualSerialPort = new SerialPort();
        Dictionary<string, StatusModel> listOfStatus = new Dictionary<string, StatusModel>();

        ConfigureRequestModel configureRequestModel = new ConfigureRequestModel();
        CalibrationRequestModel calibrationRequestModel = new CalibrationRequestModel();
        CalibrationChanel1ReqModel calibrationChanel1ReqModel = new CalibrationChanel1ReqModel();
        CalibrationChanel2ReqModel calibrationChanel2ReqModel = new CalibrationChanel2ReqModel();
        FullResetModel fullResetModel = new FullResetModel();

        public string selectedSerialNumber = string.Empty;

        public delegate void Disconnect();
        Disconnect disconnect;

        private double connectTimeout = 3000;
        public double keepAliveTimeout = 1000;

        public int currentMode;
        public int currentInf;
        public int currentTimeOut1;
        public int currentModeOut2;
        public int currentTimeOut2;
        public int currentLedMode;

        public int currentGainCh01;
        public int currentGainCh02;
        public int currentGainSpeaker;

        public int currentVoltageOffset01;
        public int currentTimeoutOffset01;
        public int currentVoltageCalibration01;
        public int currentTimeoutCalibration01;
        public int currentEquivalentResistence01;

        public int currentVoltageOffset02;
        public int currentTimeoutOffset02;
        public int currentVoltageCalibration02;
        public int currentTimeoutCalibration02;
        public int currentEquivalentResistence02;

        //GCL
        public int currentGainCalibration01;
        public int currentGainCalibration02;

        public string newSerialNumberMsg;

        public string statusMessage;
        public bool waitStatusMessage = false;

        public bool tryingToConnect = true;
        public string calibrationStatus;
        public string calibChannel1Status;
        public bool waitingToCalibrate = true;

        bool run = false;
        bool portConnected = false;

        public CalibrationResponseModel responseCalibrationOffset;

        public Dictionary<DateTime, string> messageHistory = new Dictionary<DateTime, string>();

        public void Start(Frm_Menu frm_Menu)
        {
            if (State == State.NC)
            {
                run = true;
                communicationThread = new Thread(CommunicationThread);
                actualSerialPort.Open();
                portConnected = true;
                State = State.OP;
                communicationThread.Start();
                frm_Menu.EnableButtons();
            }
        }

        #region STATE_CHANGE

        public void StartConnection()
        {
            if (State == State.OP)
            {
                State = State.CNT;
            }
        }

        public void StartConfiguration()
        {
            if (State == State.KA)
            {
                State = State.CONFIG;
            }
        }

        public bool SaveConfig(ConfigureRequestModel configureRequestModel)
        {
            if (State == State.KA)
            {
                State = State.CONFIG;
                this.configureRequestModel = configureRequestModel;
                return true;
            }
            return false;
        }

        public bool CalibrateRequest(CalibrationRequestModel calibrationRequest)
        {
            if (State == State.KA)
            {
                State = State.CALOFF;
                this.calibrationRequestModel = calibrationRequest;
                return true;
            }

            return false;
        }

        public bool CalibrateChannell1Request(CalibrationChanel1ReqModel calibrationRequest)
        {
            if (State == State.KA)
            {
                State = State.CAL01;
                this.calibrationChanel1ReqModel = calibrationRequest;
                return true;
            }
            return false;
        }

        public bool CalibrateChannel2Request(CalibrationChanel2ReqModel calibrationRequest)
        {

            if (State == State.KA)
            {
                State = State.CAL02;
                this.calibrationChanel2ReqModel = calibrationRequest;
                return true;
            }

            return false;
        }

        #endregion

        private string GenerateNewSn()
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 7).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void WaitingConnection()
        {
            DateTime timeout = DateTime.Now;
            if (State == State.OP)
            {
                while (timeout.AddMilliseconds(10000) > DateTime.Now)
                {
                    try
                    {
                        if (!(actualSerialPort.IsOpen))
                        {
                            while (actualSerialPort.BytesToRead > 0)
                            {
                                CommunicationThread();
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        public void CommunicationThread() // always running and checking the current state
        {
            while (run)
            {
                if (State == State.OP) // Operating is receiving status messages all the time.
                {
                    try
                    {
                        if (actualSerialPort.BytesToRead > 0)
                        {
                            string message = actualSerialPort.ReadLine();
                            messageHistory.Add(DateTime.Now, "received - " + message);
                            StatusModel? status = JsonConvert.DeserializeObject<StatusModel>(message);

                            if (status.HEADER != null)
                            {
                                if (selectedSerialNumber != status.SN)
                                {
                                    selectedSerialNumber = status.SN;
                                    State = State.CNT; // state changed to connected
                                    waitStatusMessage = true;
                                    statusMessage = "Porta Serial configurada com sucesso!";
                                }
                            }
                        }
                        waitStatusMessage = false;
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "The port is closed.")
                        {
                            State = State.NC;
                            actualSerialPort.Close();
                            MessageBox.Show("Conexão perdida, reinicei a aplicação.", "Desconectado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            run = false;
                        }
                    }
                }
                else if (State == State.CNT) //connected state is sending a request to connect and receive a response
                {
                    try
                    {
                        ConnectRequestModel connectRequestModel = new ConnectRequestModel();
                        if (selectedSerialNumber == "SNTESTE")
                        {
                            selectedSerialNumber = GenerateNewSn();
                            newSerialNumberMsg = "Novo Numero Serial Gerado: "+ selectedSerialNumber;
                                
                        }
                        connectRequestModel.SN = selectedSerialNumber;

                        string requestToConnect = JsonConvert.SerializeObject(connectRequestModel);

                        messageHistory.Add(DateTime.Now, "send - " + requestToConnect);
                        actualSerialPort.Write(requestToConnect);
                        Thread.Sleep(250);

                        while (actualSerialPort.BytesToRead > 0)
                        {
                            string message = actualSerialPort.ReadLine();
                            messageHistory.Add(DateTime.Now, "received - " + message);
                            ConnectResponseModel? connectResponse = JsonConvert.DeserializeObject<ConnectResponseModel>(message);

                            if (connectResponse.MODE >= 0)
                            {
                                Task.Run(() => new Frm_Message("Conectado com sucesso").ShowDialog());
                                State = State.KA;
                                waitStatusMessage = true;
                                statusMessage = "Conectado!";
                                if (connectResponse.SN == selectedSerialNumber)
                                {
                                    Console.WriteLine(connectResponse);

                                    currentMode = connectResponse.MODE;
                                    currentInf = connectResponse.INFE;
                                    currentTimeOut1 = connectResponse.TRL1;
                                    currentModeOut2 = connectResponse.MRL2;
                                    currentTimeOut2 = connectResponse.TRL2;
                                    currentLedMode = connectResponse.MLED;

                                    currentGainCh01 = connectResponse.GCH1;
                                    currentGainCh02 = connectResponse.GCH2;
                                    currentGainSpeaker = connectResponse.GSPK;

                                    currentVoltageOffset01 = connectResponse.VOF1;
                                    currentTimeoutOffset01 = connectResponse.TOF1;
                                    currentVoltageCalibration01 = connectResponse.VCL1;
                                    currentTimeoutCalibration01 = connectResponse.TCL1;
                                    currentEquivalentResistence01 = connectResponse.REQ1;
                                    currentVoltageOffset02 = connectResponse.VOF2;
                                    currentTimeoutOffset02 = connectResponse.TOF2;
                                    currentVoltageCalibration02 = connectResponse.VCL2;
                                    currentTimeoutCalibration02 = connectResponse.TCL2;
                                    currentEquivalentResistence02 = connectResponse.REQ2;

                                    currentGainCalibration01 = connectResponse.GCL1;
                                    currentGainCalibration02 = connectResponse.GCL2;

                                    
                                    newData = true;
                                }
                                break;
                            }
                        }
                        tryingToConnect = false;
                        waitStatusMessage = false;
                        
                    }
                    catch
                    {

                    }

                }
                else if (State == State.KA) //keepAlive state sends and receives keepalive message (Which means the communication is alive)
                {
                    int keepAliveCounter = 0;

                    try
                    {
                        string keepAliveMessage = JsonConvert.SerializeObject(new KeepAliveModel());
                        messageHistory.Add(DateTime.Now, "send - " + keepAliveMessage);
                        actualSerialPort.Write(keepAliveMessage);
                        Thread.Sleep(100);

                        if (actualSerialPort.BytesToRead > 0)
                        {
                            string reponseMessage = actualSerialPort.ReadLine();
                            messageHistory.Add(DateTime.Now, "received - " + reponseMessage);
                            KeepAliveModel response = JsonConvert.DeserializeObject<KeepAliveModel>(reponseMessage);
                            //if (response.HEADER == "status")
                            //    State = State.CNT;
                            Console.WriteLine(response.HEADER);
                        }

                        Task.Run(() => { Thread.Sleep(5000); if (newData) newData = false; });
                    }
                    catch
                    {
                        if (!(actualSerialPort.IsOpen))
                        {
                            State = State.OP;
                            WaitingConnection();
                        }

                        keepAliveCounter++;
                        if (keepAliveCounter >= 3)
                        {
                            connected = false;
                            MessageBox.Show("Conexão perdida", "Desconectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            State = State.OP;
                        }
                    }

                    Thread.Sleep(500);

                }
                else if (State == State.CONFIG)
                {
                    string message = JsonConvert.SerializeObject(configureRequestModel);
                    messageHistory.Add(DateTime.Now, "Send - " + message);

                    actualSerialPort.Write(message);
                    Thread.Sleep(200);

                    DateTime timeout = DateTime.Now;
                    bool sucess = false;

                    while (timeout.AddMilliseconds(5000) > DateTime.Now)
                    {
                        string reponseMessage = actualSerialPort.ReadLine();
                        messageHistory.Add(DateTime.Now, "received - " + reponseMessage);

                        try
                        {
                            ConfigureResponseModel response = JsonConvert.DeserializeObject<ConfigureResponseModel>(reponseMessage);
                            if (response.MODE >= 0)
                            {
                                Task.Run(() => new Frm_Message("Configurado com sucesso").ShowDialog());
                                currentMode = response.MODE;
                                currentInf = response.INFE;
                                currentTimeOut1 = response.TRL1;
                                currentModeOut2 = response.MRL2;
                                currentTimeOut2 = response.TRL2;
                                currentLedMode = response.MLED;
                                currentGainCh01 = response.GCH1; /// 10;
                                currentGainCh02 = response.GCH2; /// 10;
                                currentGainSpeaker = response.GSPK; /// 10;
                                newData = true;
                                sucess = true;
                                break;
                            }
                        }
                        catch
                        {

                        }
                    }

                    State = State.KA;
                }
                else if (State == State.CALOFF)
                {
                    string message = JsonConvert.SerializeObject(calibrationRequestModel);

                    messageHistory.Add(DateTime.Now, "Send - " + message);

                    this.actualSerialPort.Write(message);
                    DateTime timeout = DateTime.Now;
                    bool sucess = false;

                    while (timeout.AddMilliseconds(Convert.ToDouble(Math.Max(calibrationRequestModel.TOF1, calibrationRequestModel.TOF2) * 1000) + 2000) > DateTime.Now)
                    {
                        if (actualSerialPort.BytesToRead > 0)
                        {
                            string reponseMessage = actualSerialPort.ReadLine();
                            try
                            {
                                CalibrationResponseModel response = JsonConvert.DeserializeObject<CalibrationResponseModel>(reponseMessage);

                                messageHistory.Add(DateTime.Now, "received - " + reponseMessage);

                                if (response.HEADER == "offsetCalSuccess")
                                {
                                    Task.Run(() => new Frm_Message("Offset determinado com sucesso").ShowDialog());
                                    currentVoltageOffset01 = response.VOF1;
                                    currentTimeoutOffset01 = response.TOF2;
                                    currentVoltageCalibration02 = response.VOF2;
                                    currentTimeoutOffset02 = response.TOF2;
                                    State = State.KA;
                                    break;
                                }
                                else
                                {
                                    KeepAliveModel kaResponse = JsonConvert.DeserializeObject<KeepAliveModel>(reponseMessage);
                                    if (kaResponse.HEADER == "keepalive")
                                    {
                                        string keepAliveMessage = JsonConvert.SerializeObject(new KeepAliveModel());
                                        messageHistory.Add(DateTime.Now, "send - " + keepAliveMessage);
                                        actualSerialPort.Write(keepAliveMessage);
                                        Thread.Sleep(100);
                                    }
                                }
                            }
                            catch
                            {
                                State = State.KA;
                            }
                        }
                        waitingToCalibrate = false;
                    }
                    State = State.KA;
                }
                else if (State == State.CAL01)
                {
                    //this.actualSerialPort = CommunicationController.Instance.actualSerialPort;
                    string message = JsonConvert.SerializeObject(calibrationChanel1ReqModel);

                    messageHistory.Add(DateTime.Now, "Send - " + message);

                    this.actualSerialPort.Write(message);
                    DateTime keepAliveTime = DateTime.Now;

                    while (keepAliveTime.AddMilliseconds((calibrationChanel1ReqModel.TCL1 * 1000) + 2000) > DateTime.Now)
                    {
                        if (actualSerialPort.BytesToRead > 0)
                        {
                            string reponseMessage = actualSerialPort.ReadLine();

                            try
                            {                               
                                CalibrationChanel1ResponseModel response = JsonConvert.DeserializeObject<CalibrationChanel1ResponseModel>(reponseMessage);
                                messageHistory.Add(DateTime.Now, "received - " + reponseMessage);

                                if (response.HEADER == "ch1CalSuccess")
                                {
                                    Task.Run(() => new Frm_Message("Calibração do canal 1 realizada com sucesso").ShowDialog());
                                    currentGainCalibration01 = response.GCL1;
                                    currentVoltageCalibration01 = response.VCL1;
                                    currentTimeoutCalibration01 = response.TCL1;
                                    currentEquivalentResistence01 = response.REQ1;                                    
                                    State = State.KA;
                                    break;
                                }
                                else
                                {
                                    KeepAliveModel kaResponse = JsonConvert.DeserializeObject<KeepAliveModel>(reponseMessage);
                                    if (kaResponse.HEADER == "keepalive")
                                    {
                                        string keepAliveMessage = JsonConvert.SerializeObject(new KeepAliveModel());
                                        messageHistory.Add(DateTime.Now, "send - " + keepAliveMessage);
                                        actualSerialPort.Write(keepAliveMessage);
                                        Thread.Sleep(100);
                                    }
                                }
                            }
                            catch
                            {
                                KeepAliveModel response = JsonConvert.DeserializeObject<KeepAliveModel>(reponseMessage);
                                if (response.HEADER == "keepalive")
                                {
                                    string keepAliveMessage = JsonConvert.SerializeObject(new KeepAliveModel());
                                    messageHistory.Add(DateTime.Now, "send - " + keepAliveMessage);
                                    actualSerialPort.Write(keepAliveMessage);
                                    Thread.Sleep(100);
                                }
                                //MessageBox.Show("Falha ao calibrar.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }                       
                    }
                    State = State.KA;
                }
                else if (State == State.CAL02)
                {
                    //this.actualSerialPort = CommunicationController.Instance.actualSerialPort;

                    string message = JsonConvert.SerializeObject(calibrationChanel2ReqModel);

                    messageHistory.Add(DateTime.Now, "Send - " + message);

                    actualSerialPort.Write(message);

                    DateTime keepAliveTime = DateTime.Now;

                    while (keepAliveTime.AddMilliseconds((calibrationChanel2ReqModel.TCL2 * 1000) + 2000) > DateTime.Now)
                    {
                        if (actualSerialPort.BytesToRead > 0)
                        {
                            string reponseMessage = this.actualSerialPort.ReadLine();
                            try
                            {                                
                                CalibrationChanel2ResponseModel response = JsonConvert.DeserializeObject<CalibrationChanel2ResponseModel>(reponseMessage);

                                messageHistory.Add(DateTime.Now, "Send - " + reponseMessage);

                                if (response.HEADER == "ch2CalSuccess")
                                {
                                    Task.Run(() => new Frm_Message("Calibração do canal 2 realizada com sucesso").ShowDialog());
                                    currentGainCalibration02 = response.GCL2;
                                    currentVoltageCalibration02 = response.VCL2;
                                    currentEquivalentResistence02 = response.REQ2;
                                    currentTimeoutCalibration02 = response.TCL2;
                                    State = State.KA;
                                    break;
                                }
                                else
                                {
                                    KeepAliveModel kaResponse = JsonConvert.DeserializeObject<KeepAliveModel>(reponseMessage);
                                    if (kaResponse.HEADER == "keepalive")
                                    {
                                        string keepAliveMessage = JsonConvert.SerializeObject(new KeepAliveModel());
                                        messageHistory.Add(DateTime.Now, "send - " + keepAliveMessage);
                                        actualSerialPort.Write(keepAliveMessage);
                                        Thread.Sleep(100);
                                    }
                                }
                            }
                            catch
                            {
                                State = State.KA;
                            }
                        }
                    }
                    State = State.KA;
                } 
            }
        }

        internal void Stop()
        {
            if(communicationThread != null)
            {
                if(communicationThread.IsAlive)
                {
                    run = false;
                    communicationThread.Join();
                }
            }    
        }

        public void ResetRequest(ResetRequestModel resetRequest)
        {

            string message = JsonConvert.SerializeObject(resetRequest);

            actualSerialPort.Write(message);
            DateTime keepAliveTime = DateTime.Now;

            while (keepAliveTime.AddMilliseconds(1000) > DateTime.Now)
            {
                if (actualSerialPort.BytesToRead > 0)
                {
                    string reponseMessage = actualSerialPort.ReadLine();
                    try
                    {
                        ResetResponseModel response = JsonConvert.DeserializeObject<ResetResponseModel>(reponseMessage);
                        if (response.HEADER == "resetSuccess")
                        {
                            Task.Run(() => MessageBox.Show("Reset realizado com sucesso"));
                            currentMode = response.MODE;
                            currentInf = response.INFE;
                            //MRL1
                            currentTimeOut1 = response.TRL1;
                            currentModeOut2 = response.MRL2;
                            currentTimeOut2 = response.TRL2;
                            currentLedMode = response.MLED;
                            currentGainCh01 = response.GCH1;
                            currentGainCh02 = response.GCH2;
                            currentGainSpeaker = response.GSPK;

                            MessageBox.Show("Reset realizado com sucesso, reinicie a aplicação.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        //MessageBox.Show("Falha ao calibrar.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void FullResetRequest(FullResetModel fullReset)
        {
            string message = JsonConvert.SerializeObject(fullReset);
            actualSerialPort.Write(message);
            messageHistory.Add(DateTime.Now, "Send - " + message);

            DateTime keepAliveTime = DateTime.Now;
            while (keepAliveTime.AddMilliseconds(1000) > DateTime.Now)
            {
                if(actualSerialPort.BytesToRead > 0)
                {
                    string responseMessage = actualSerialPort.ReadLine();
                    messageHistory.Add(DateTime.Now, "received - " + responseMessage);
                    try
                    {
                        FullResetResponseModel fullResetResponseModel = JsonConvert.DeserializeObject<FullResetResponseModel>(responseMessage);
                        if(fullResetResponseModel.HEADER == "fullReset")
                        {
                            MessageBox.Show("Reset Concluido com sucesso, reinicie a aplicação.", "Resetado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
