using GunShooterDetector.Models;
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
    public partial class Frm_Menu : Form
    {
        //Counter of the interface tabs

        int tabcounterCalib = 0;
        int tabcounterConfig = 0;
        int tabcounterReset = 0;
        int tabcounterEventos = 0;
        int tabcounterHist = 0;
        int tabcounterSerialPort = 0;

        int tabPageCounter;
        int tabPageConfig;
        int tabPageCalib;
        int tabPageSerialPort;

        SerialPort mainSerialPort = new SerialPort();


        Uc_ConfigTeste uc_Configuracoes = null;
        TabPage tbConfig = new TabPage();

        Uc_Calibracao uc_Calibracao = null;
        TabPage tbCal = new TabPage();

        Uc_Eventos uc_Eventos = null;
        TabPage tbEvent = new TabPage();

        Uc_PortaSerial uc_portaSerial = null;
        TabPage tbSerialPort = new TabPage();

        Control selectedControl = null;


        int userAcess = 0;



        public Frm_Menu()
        {
            InitializeComponent();
            Tbc_Menu.Hide();
            Btn_Calibracao.Enabled = false;
            Btn_Eventos.Enabled = false;
            Btn_Historico.Enabled = false;
            Btn_Reset.Enabled = false;
            Btn_configuracoes.Enabled = false;
       
            if(userAcess == 0)
            {
                Btn_Calibracao.Visible = true;
                Btn_Reset.Visible = true;
                Btn_Historico.Visible = true;
                Btn_Eventos.Visible = true;
                Frm_DegubMessages frm_DegubMessages = new Frm_DegubMessages();
                frm_DegubMessages.Show();
            }
            else if(userAcess == 1)
            {
                Btn_Calibracao.Visible = false;
                Btn_Reset.Visible = false;
                Btn_Historico.Visible = false;
                Btn_Eventos.Visible = false;
            }
        }

        public void EnableButtons()
        {
            Btn_Calibracao.Enabled = true;
            Btn_configuracoes.Enabled = true;
            Btn_Reset.Enabled = true;
        }

        //CLICK EVENTS

        public void Btn_configuracoes_Click(object sender, EventArgs e)
        {
            //code to control the green bar beside the buttons of the menu           
            Pnl_Pointer.Height = Btn_configuracoes.Height;
            Pnl_Pointer.Top = Btn_configuracoes.Top;

            //if statement using tabcounter variable to control the number of tabs created in the program.
            if (uc_Configuracoes == null)
            {
                uc_Configuracoes = new Uc_ConfigTeste(mainSerialPort, this);
                uc_Configuracoes.Dock = DockStyle.Fill;
            }
            if (!Tbc_Menu.TabPages.Contains(tbConfig))
            {
                tbConfig.Name = "Configurações";
                tbConfig.Text = tbConfig.Name;
                tbConfig.Controls.Add(uc_Configuracoes);
                Tbc_Menu.TabPages.Add(tbConfig);
                tbConfig.ImageIndex = 4;
                uc_Configuracoes.Size = tbConfig.Size;
                uc_Configuracoes.Show();
            }

            Tbc_Menu.SelectedTab = tbConfig;


        }

        public void Btn_Calibracao_Click(object sender, EventArgs e)
        {
            Pnl_Pointer.Height = Btn_Calibracao.Height;
            Pnl_Pointer.Top = Btn_Calibracao.Top;
            ;

            if (uc_Calibracao == null)
            {
                uc_Calibracao = new Uc_Calibracao();
                uc_Calibracao.Dock = DockStyle.Fill;
            }
            if (!Tbc_Menu.TabPages.Contains(tbCal))
            {
                tbCal.Name = "Calibração";
                tbCal.Text = tbCal.Name;
                tbCal.Controls.Add(uc_Calibracao);
                Tbc_Menu.TabPages.Add(tbCal);
                tbCal.ImageIndex = 1;
                Tbc_Menu.Show();

            }
            Tbc_Menu.SelectedTab = tbCal;
        }

        public void Btn_Reset_Click(object sender, EventArgs e)
        {
            Pnl_Pointer.Height = Btn_Reset.Height;
            Pnl_Pointer.Top = Btn_Reset.Top;

            //NOT USING USER CONTROL ANYMORE.
            //if (tabcounterReset == 0)
            //{
            //    Uc_Reset uc_Reset = new Uc_Reset();
            //    uc_Reset.Dock = DockStyle.Fill;
                
            //    TabPage tb = new TabPage();
            //    tb.Name = "Reset";
            //    tb.Text = tb.Name;
            //    tb.Controls.Add(uc_Reset);
            //    Tbc_Menu.TabPages.Add(tb);
            //    tb.ImageIndex = 3;
            //    Tbc_Menu.Show();

            //    tabcounterReset++;
            //}

            Frm_Reset reset = new Frm_Reset();
            reset.Show();
        }

        public void Btn_Eventos_Click(object sender, EventArgs e)
        {
            Pnl_Pointer.Height = Btn_Eventos.Height;
            Pnl_Pointer.Top = Btn_Eventos.Top;

            if (uc_Eventos == null)
            {
                uc_Eventos = new Uc_Eventos();
                uc_Eventos.Dock = DockStyle.Fill;
            }
            if (!Tbc_Menu.TabPages.Contains(tbEvent))
            {

                tbEvent.Name = "Eventos";
                tbEvent.Text = tbEvent.Name;
                tbEvent.Controls.Add(uc_Eventos);
                Tbc_Menu.TabPages.Add(tbEvent);
                tbEvent.ImageIndex = 0;
                Tbc_Menu.Show();
            }
;
            Tbc_Menu.SelectedTab = tbEvent;
        }

        public void Btn_Historico_Click(object sender, EventArgs e)
        {
            Pnl_Pointer.Height = Btn_Historico.Height;
            Pnl_Pointer.Top = Btn_Historico.Top;

            if (tabcounterHist == 0)
            {
                Uc_Historico uc_Historico = new Uc_Historico();
                uc_Historico.Dock = DockStyle.Fill;

                TabPage tb = new TabPage();
                tb.Name = "Histórico";
                tb.Text = tb.Name;
                tb.Controls.Add(uc_Historico);
                Tbc_Menu.TabPages.Add(tb);
                tb.ImageIndex = 2;
                Tbc_Menu.Show();

                tabcounterHist++;
            }
        }

        private void Btn_SerialPort_Click(object sender, EventArgs e)
        {
            Pnl_Pointer.Height = Btn_SerialPort.Height;
            Pnl_Pointer.Top = Btn_SerialPort.Top;

            if (uc_portaSerial == null)
            {
                uc_portaSerial = new Uc_PortaSerial(mainSerialPort, this);
                uc_portaSerial.Dock = DockStyle.Fill;

            }
            if (!Tbc_Menu.TabPages.Contains(tbSerialPort))
            {
                tbSerialPort.Name = "Porta Serial";
                tbSerialPort.Text = tbSerialPort.Name;
                tbSerialPort.Controls.Add(uc_portaSerial);
                Tbc_Menu.TabPages.Add(tbSerialPort);
                tbSerialPort.ImageIndex = 5;
                Tbc_Menu.Show();
            }

            Tbc_Menu.SelectedIndex = tabPageSerialPort;
        }

        private void Tbc_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var mousePostionX = e.X;
                var mousePostionY = e.Y;

                var contextMenu = new ContextMenuStrip();

                //CREATING ITENS OF CONTEXT MENU
                ToolStripMenuItem toolTip001 = CreateMenuItem("Deletar Aba Atual", "close");
                ToolStripMenuItem tooltip002 = CreateMenuItem("Deletar Esquerda", "left-arrow");
                ToolStripMenuItem toolTip003 = CreateMenuItem("Deletar Direita", "right-arrow");
                ToolStripMenuItem tooltip004 = CreateMenuItem("Deletar Todos", "DeleteAll");

                //ADDING ITENS TO THE CONTEXT
                contextMenu.Items.Add(toolTip001);
                contextMenu.Items.Add(tooltip002);
                contextMenu.Items.Add(toolTip003);
                contextMenu.Items.Add(tooltip004);
                contextMenu.Show(this, new Point(mousePostionX, mousePostionY));

                //CREATING CLICK EVENTS OF THE ITENS IN THE MENU 
                toolTip001.Click += new System.EventHandler(toolTip001_Click);
                tooltip002.Click += new System.EventHandler(toolTip002_Click);
                toolTip003.Click += new System.EventHandler(toolTip003_Click);
                tooltip004.Click += new System.EventHandler(toolTip004_Click);
            }
        }

        private void DeleteTabs()
        {
            if (tabcounterConfig == 1)
            {
                tabcounterConfig--;
            }
            if (tabcounterCalib == 1)
            {
                tabcounterCalib--;
            }
            if (tabcounterSerialPort == 1)
            {
                tabcounterSerialPort--;
            }
        }

        private void toolTip001_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Menu.SelectedTab == null))
            {
                DeleteTabs();
                Tbc_Menu.TabPages.Remove(Tbc_Menu.SelectedTab);

            }

        }

        private void toolTip002_Click(object sender2, EventArgs e2)
        {
            if (!(Tbc_Menu.SelectedTab == null))
            {
                int ItemSelecionado = Tbc_Menu.SelectedIndex;
                //counter = index of selected tab - 1, Until counter >= 0, Counter - 1
                for (int counter = ItemSelecionado - 1; counter >= 0; counter--)
                {
                    //deleting tab page in the  counter position. (deleting pages to the left)
                    Tbc_Menu.TabPages.Remove(Tbc_Menu.TabPages[counter]);
                }
            }
        }

        private void toolTip003_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Menu.SelectedTab == null))
            {
                int itemSelecionado = Tbc_Menu.SelectedIndex;
                //counter receive the number of tabs - 1, while counter > selected index, counter - 1
                for (int counter = Tbc_Menu.TabCount - 1; counter > itemSelecionado; counter--)
                {
                    Tbc_Menu.TabPages.Remove(Tbc_Menu.TabPages[counter]);
                }
            }
        }

        private void toolTip004_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Menu.SelectedTab == null))
            {
                int itemSelecionado = Tbc_Menu.SelectedIndex;
                for (int counter = itemSelecionado - 1; counter >= 0; counter--)
                {
                    Tbc_Menu.TabPages.Remove(Tbc_Menu.TabPages[counter]);
                }

                for (int counter = Tbc_Menu.TabCount - 1; counter >= itemSelecionado; counter--)
                {
                    Tbc_Menu.TabPages.Remove(Tbc_Menu.TabPages[counter]);
                }

                //APAGAR TUDO
                //for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i += -1)
                //{
                //    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                //}
            }
        }

        private ToolStripMenuItem CreateMenuItem(string text, string nomeImagem)
        {
            var toolStripItem = new ToolStripMenuItem();
            toolStripItem.Text = text;
            Image myImage = (Image)global::GunShooterDetector.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            toolStripItem.Image = myImage;

            return toolStripItem;
        }

        private void Btn_configuracoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var mousePostionX = e.X;
                var mousePostionY = e.Y;

                var contextMenu = new ContextMenuStrip();

                //CREATING ITENS OF CONTEXT MENU
                ToolStripMenuItem toolTip001 = CreateMenuItem("Deletar Aba Atual", "close");
                ToolStripMenuItem tooltip002 = CreateMenuItem("Deletar Esquerda", "left-arrow");
                ToolStripMenuItem toolTip003 = CreateMenuItem("Deletar Direita", "right-arrow");
                ToolStripMenuItem tooltip004 = CreateMenuItem("Deletar Todos", "DeleteAll");

                //ADDING ITENS TO THE CONTEXT
                contextMenu.Items.Add(toolTip001);
                contextMenu.Items.Add(tooltip002);
                contextMenu.Items.Add(toolTip003);
                contextMenu.Items.Add(tooltip004);
                contextMenu.Show(this, new Point(mousePostionX, mousePostionY));

                //CREATING CLICK EVENTS OF THE ITENS IN THE MENU 
                toolTip001.Click += new System.EventHandler(toolTip001_Click);
                tooltip002.Click += new System.EventHandler(toolTip002_Click);
                toolTip003.Click += new System.EventHandler(toolTip003_Click);
                tooltip004.Click += new System.EventHandler(toolTip004_Click);
            }
        }

        private void Btn_Calibracao_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var mousePostionX = e.X;
                var mousePostionY = e.Y;

                var contextMenu = new ContextMenuStrip();

                //CREATING ITENS OF CONTEXT MENU
                ToolStripMenuItem toolTip001 = CreateMenuItem("Deletar Aba Atual", "close");
                ToolStripMenuItem tooltip002 = CreateMenuItem("Deletar Esqueda", "left-arrow");
                ToolStripMenuItem toolTip003 = CreateMenuItem("Deletar Direita", "right-arrow");
                ToolStripMenuItem tooltip004 = CreateMenuItem("Deletar Todos", "DeleteAll");

                //ADDING ITENS TO THE CONTEXT
                contextMenu.Items.Add(toolTip001);
                contextMenu.Items.Add(tooltip002);
                contextMenu.Items.Add(toolTip003);
                contextMenu.Items.Add(tooltip004);
                contextMenu.Show(this, new Point(mousePostionX, mousePostionY));

                //CREATING CLICK EVENTS OF THE ITENS IN THE MENU 
                toolTip001.Click += new System.EventHandler(toolTip001_Click);
                tooltip002.Click += new System.EventHandler(toolTip002_Click);
                toolTip003.Click += new System.EventHandler(toolTip003_Click);
                tooltip004.Click += new System.EventHandler(toolTip004_Click);
            }
        }

        private void Btn_Historico_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var mousePostionX = e.X;
                var mousePostionY = e.Y;

                var contextMenu = new ContextMenuStrip();

                //CREATING ITENS OF CONTEXT MENU
                ToolStripMenuItem toolTip001 = CreateMenuItem("Deletar Aba Atual", "close");
                ToolStripMenuItem tooltip002 = CreateMenuItem("Deletar Esqueda", "left-arrow");
                ToolStripMenuItem toolTip003 = CreateMenuItem("Deletar Direita", "right-arrow");
                ToolStripMenuItem tooltip004 = CreateMenuItem("Deletar Todos", "DeleteAll");

                //ADDING ITENS TO THE CONTEXT
                contextMenu.Items.Add(toolTip001);
                contextMenu.Items.Add(tooltip002);
                contextMenu.Items.Add(toolTip003);
                contextMenu.Items.Add(tooltip004);
                contextMenu.Show(this, new Point(mousePostionX, mousePostionY));

                //CREATING CLICK EVENTS OF THE ITENS IN THE MENU 
                toolTip001.Click += new System.EventHandler(toolTip001_Click);
                tooltip002.Click += new System.EventHandler(toolTip002_Click);
                toolTip003.Click += new System.EventHandler(toolTip003_Click);
                tooltip004.Click += new System.EventHandler(toolTip004_Click);
            }
        }

        private void Frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommunicationController.Instance.Stop();
        }
    }
}

