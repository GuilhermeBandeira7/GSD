namespace GunShooterDetector.View
{
    partial class Uc_PortaSerial
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tlp_BackGround = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_NovoValor = new System.Windows.Forms.Label();
            this.Tlp_ConfiguraçãoPortas = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_Handshake = new System.Windows.Forms.TextBox();
            this.Txt_StopBits = new System.Windows.Forms.TextBox();
            this.txt_DataBits = new System.Windows.Forms.TextBox();
            this.Txt_Parity = new System.Windows.Forms.TextBox();
            this.Txt_BaudRate = new System.Windows.Forms.TextBox();
            this.Lbl_Handshake = new System.Windows.Forms.Label();
            this.Lbl_NomePorta = new System.Windows.Forms.Label();
            this.Lbl_StopBits = new System.Windows.Forms.Label();
            this.Lbl_DataBits = new System.Windows.Forms.Label();
            this.Lbl_Parity = new System.Windows.Forms.Label();
            this.lbl_BaudRate = new System.Windows.Forms.Label();
            this.Cbx_NomePorta = new System.Windows.Forms.ComboBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Tbl_Mensagens = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Mensagens = new System.Windows.Forms.Label();
            this.Lbl_MsgNovoSerialNumber = new System.Windows.Forms.Label();
            this.Tlp_BackGround.SuspendLayout();
            this.Tlp_ConfiguraçãoPortas.SuspendLayout();
            this.Tbl_Mensagens.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_BackGround
            // 
            this.Tlp_BackGround.AutoSize = true;
            this.Tlp_BackGround.ColumnCount = 1;
            this.Tlp_BackGround.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_BackGround.Controls.Add(this.Lbl_NovoValor, 0, 0);
            this.Tlp_BackGround.Controls.Add(this.Tlp_ConfiguraçãoPortas, 0, 1);
            this.Tlp_BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_BackGround.Location = new System.Drawing.Point(0, 0);
            this.Tlp_BackGround.Name = "Tlp_BackGround";
            this.Tlp_BackGround.RowCount = 2;
            this.Tlp_BackGround.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_BackGround.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_BackGround.Size = new System.Drawing.Size(686, 374);
            this.Tlp_BackGround.TabIndex = 0;
            // 
            // Lbl_NovoValor
            // 
            this.Lbl_NovoValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_NovoValor.AutoSize = true;
            this.Lbl_NovoValor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_NovoValor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_NovoValor.Location = new System.Drawing.Point(195, 0);
            this.Lbl_NovoValor.Name = "Lbl_NovoValor";
            this.Lbl_NovoValor.Size = new System.Drawing.Size(296, 23);
            this.Lbl_NovoValor.TabIndex = 5;
            this.Lbl_NovoValor.Text = "CONFIGURAÇÃO PORTA SERIAL";
            // 
            // Tlp_ConfiguraçãoPortas
            // 
            this.Tlp_ConfiguraçãoPortas.ColumnCount = 2;
            this.Tlp_ConfiguraçãoPortas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.Tlp_ConfiguraçãoPortas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Txt_Handshake, 1, 5);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Txt_StopBits, 1, 4);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.txt_DataBits, 1, 3);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Txt_Parity, 1, 2);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Txt_BaudRate, 1, 1);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Lbl_Handshake, 0, 5);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Lbl_NomePorta, 0, 0);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Lbl_StopBits, 0, 4);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Lbl_DataBits, 0, 3);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Lbl_Parity, 0, 2);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.lbl_BaudRate, 0, 1);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Cbx_NomePorta, 1, 0);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Btn_Salvar, 1, 6);
            this.Tlp_ConfiguraçãoPortas.Controls.Add(this.Tbl_Mensagens, 0, 6);
            this.Tlp_ConfiguraçãoPortas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_ConfiguraçãoPortas.Location = new System.Drawing.Point(3, 26);
            this.Tlp_ConfiguraçãoPortas.Name = "Tlp_ConfiguraçãoPortas";
            this.Tlp_ConfiguraçãoPortas.RowCount = 7;
            this.Tlp_ConfiguraçãoPortas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.08881F));
            this.Tlp_ConfiguraçãoPortas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.30435F));
            this.Tlp_ConfiguraçãoPortas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.62319F));
            this.Tlp_ConfiguraçãoPortas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.Tlp_ConfiguraçãoPortas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.91304F));
            this.Tlp_ConfiguraçãoPortas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.Tlp_ConfiguraçãoPortas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.34783F));
            this.Tlp_ConfiguraçãoPortas.Size = new System.Drawing.Size(680, 345);
            this.Tlp_ConfiguraçãoPortas.TabIndex = 6;
            // 
            // Txt_Handshake
            // 
            this.Txt_Handshake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Handshake.Location = new System.Drawing.Point(353, 227);
            this.Txt_Handshake.Name = "Txt_Handshake";
            this.Txt_Handshake.Size = new System.Drawing.Size(324, 23);
            this.Txt_Handshake.TabIndex = 17;
            this.Txt_Handshake.Text = "None";
            this.Txt_Handshake.TextChanged += new System.EventHandler(this.Txt_Handshake_TextChanged);
            // 
            // Txt_StopBits
            // 
            this.Txt_StopBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_StopBits.Location = new System.Drawing.Point(353, 183);
            this.Txt_StopBits.Name = "Txt_StopBits";
            this.Txt_StopBits.Size = new System.Drawing.Size(324, 23);
            this.Txt_StopBits.TabIndex = 16;
            this.Txt_StopBits.Text = "One";
            this.Txt_StopBits.TextChanged += new System.EventHandler(this.Txt_StopBits_TextChanged);
            // 
            // txt_DataBits
            // 
            this.txt_DataBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DataBits.Location = new System.Drawing.Point(353, 139);
            this.txt_DataBits.Name = "txt_DataBits";
            this.txt_DataBits.Size = new System.Drawing.Size(324, 23);
            this.txt_DataBits.TabIndex = 15;
            this.txt_DataBits.Text = "8";
            this.txt_DataBits.TextChanged += new System.EventHandler(this.txt_DataBits_TextChanged);
            // 
            // Txt_Parity
            // 
            this.Txt_Parity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Parity.Location = new System.Drawing.Point(353, 96);
            this.Txt_Parity.Name = "Txt_Parity";
            this.Txt_Parity.Size = new System.Drawing.Size(324, 23);
            this.Txt_Parity.TabIndex = 14;
            this.Txt_Parity.Text = "None";
            this.Txt_Parity.TextChanged += new System.EventHandler(this.Txt_Parity_TextChanged);
            // 
            // Txt_BaudRate
            // 
            this.Txt_BaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_BaudRate.Location = new System.Drawing.Point(353, 53);
            this.Txt_BaudRate.Name = "Txt_BaudRate";
            this.Txt_BaudRate.Size = new System.Drawing.Size(324, 23);
            this.Txt_BaudRate.TabIndex = 13;
            this.Txt_BaudRate.Text = "38400";
            this.Txt_BaudRate.TextChanged += new System.EventHandler(this.Txt_BaudRate_TextChanged);
            // 
            // Lbl_Handshake
            // 
            this.Lbl_Handshake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Handshake.AutoSize = true;
            this.Lbl_Handshake.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Handshake.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Handshake.Location = new System.Drawing.Point(46, 228);
            this.Lbl_Handshake.Name = "Lbl_Handshake";
            this.Lbl_Handshake.Size = new System.Drawing.Size(257, 22);
            this.Lbl_Handshake.TabIndex = 11;
            this.Lbl_Handshake.Text = "Handshake (Padrão None)";
            // 
            // Lbl_NomePorta
            // 
            this.Lbl_NomePorta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_NomePorta.AutoSize = true;
            this.Lbl_NomePorta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_NomePorta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_NomePorta.Location = new System.Drawing.Point(23, 11);
            this.Lbl_NomePorta.Name = "Lbl_NomePorta";
            this.Lbl_NomePorta.Size = new System.Drawing.Size(303, 22);
            this.Lbl_NomePorta.TabIndex = 6;
            this.Lbl_NomePorta.Text = "Nome Da Porta (Padrão COM1)";
            // 
            // Lbl_StopBits
            // 
            this.Lbl_StopBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_StopBits.AutoSize = true;
            this.Lbl_StopBits.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_StopBits.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_StopBits.Location = new System.Drawing.Point(69, 184);
            this.Lbl_StopBits.Name = "Lbl_StopBits";
            this.Lbl_StopBits.Size = new System.Drawing.Size(212, 22);
            this.Lbl_StopBits.TabIndex = 7;
            this.Lbl_StopBits.Text = "StopBits (Padrão One)";
            // 
            // Lbl_DataBits
            // 
            this.Lbl_DataBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_DataBits.AutoSize = true;
            this.Lbl_DataBits.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_DataBits.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_DataBits.Location = new System.Drawing.Point(81, 140);
            this.Lbl_DataBits.Name = "Lbl_DataBits";
            this.Lbl_DataBits.Size = new System.Drawing.Size(188, 22);
            this.Lbl_DataBits.TabIndex = 8;
            this.Lbl_DataBits.Text = "DataBits (Padrão 8)";
            // 
            // Lbl_Parity
            // 
            this.Lbl_Parity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Parity.AutoSize = true;
            this.Lbl_Parity.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Parity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Parity.Location = new System.Drawing.Point(73, 96);
            this.Lbl_Parity.Name = "Lbl_Parity";
            this.Lbl_Parity.Size = new System.Drawing.Size(203, 22);
            this.Lbl_Parity.TabIndex = 9;
            this.Lbl_Parity.Text = "Parity (Padrão None)";
            // 
            // lbl_BaudRate
            // 
            this.lbl_BaudRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_BaudRate.AutoSize = true;
            this.lbl_BaudRate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_BaudRate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_BaudRate.Location = new System.Drawing.Point(55, 53);
            this.lbl_BaudRate.Name = "lbl_BaudRate";
            this.lbl_BaudRate.Size = new System.Drawing.Size(239, 22);
            this.lbl_BaudRate.TabIndex = 10;
            this.lbl_BaudRate.Text = "BaudRate (Padrão 9600)";
            // 
            // Cbx_NomePorta
            // 
            this.Cbx_NomePorta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbx_NomePorta.FormattingEnabled = true;
            this.Cbx_NomePorta.Location = new System.Drawing.Point(353, 11);
            this.Cbx_NomePorta.Name = "Cbx_NomePorta";
            this.Cbx_NomePorta.Size = new System.Drawing.Size(324, 23);
            this.Cbx_NomePorta.TabIndex = 27;
            this.Cbx_NomePorta.TextChanged += new System.EventHandler(this.Cbx_NomePorta_TextChanged);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Salvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Salvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Salvar.Location = new System.Drawing.Point(437, 271);
            this.Btn_Salvar.MaximumSize = new System.Drawing.Size(155, 61);
            this.Btn_Salvar.MinimumSize = new System.Drawing.Size(155, 61);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(155, 61);
            this.Btn_Salvar.TabIndex = 26;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Tbl_Mensagens
            // 
            this.Tbl_Mensagens.ColumnCount = 1;
            this.Tbl_Mensagens.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tbl_Mensagens.Controls.Add(this.Lbl_MsgNovoSerialNumber, 0, 1);
            this.Tbl_Mensagens.Controls.Add(this.Lbl_Mensagens, 0, 0);
            this.Tbl_Mensagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbl_Mensagens.Location = new System.Drawing.Point(3, 262);
            this.Tbl_Mensagens.Name = "Tbl_Mensagens";
            this.Tbl_Mensagens.RowCount = 2;
            this.Tbl_Mensagens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tbl_Mensagens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tbl_Mensagens.Size = new System.Drawing.Size(344, 80);
            this.Tbl_Mensagens.TabIndex = 29;
            // 
            // Lbl_Mensagens
            // 
            this.Lbl_Mensagens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Mensagens.AutoSize = true;
            this.Lbl_Mensagens.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Mensagens.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Mensagens.Location = new System.Drawing.Point(163, 8);
            this.Lbl_Mensagens.Name = "Lbl_Mensagens";
            this.Lbl_Mensagens.Size = new System.Drawing.Size(18, 23);
            this.Lbl_Mensagens.TabIndex = 28;
            this.Lbl_Mensagens.Text = "-";
            // 
            // Lbl_MsgNovoSerialNumber
            // 
            this.Lbl_MsgNovoSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_MsgNovoSerialNumber.AutoSize = true;
            this.Lbl_MsgNovoSerialNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_MsgNovoSerialNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_MsgNovoSerialNumber.Location = new System.Drawing.Point(163, 48);
            this.Lbl_MsgNovoSerialNumber.Name = "Lbl_MsgNovoSerialNumber";
            this.Lbl_MsgNovoSerialNumber.Size = new System.Drawing.Size(18, 23);
            this.Lbl_MsgNovoSerialNumber.TabIndex = 29;
            this.Lbl_MsgNovoSerialNumber.Text = "-";
            // 
            // Uc_PortaSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.Tlp_BackGround);
            this.Name = "Uc_PortaSerial";
            this.Size = new System.Drawing.Size(686, 374);
            this.Tlp_BackGround.ResumeLayout(false);
            this.Tlp_BackGround.PerformLayout();
            this.Tlp_ConfiguraçãoPortas.ResumeLayout(false);
            this.Tlp_ConfiguraçãoPortas.PerformLayout();
            this.Tbl_Mensagens.ResumeLayout(false);
            this.Tbl_Mensagens.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel Tlp_BackGround;
        private Label Lbl_NovoValor;
        private TableLayoutPanel Tlp_ConfiguraçãoPortas;
        private Label Lbl_DataBits;
        private Label Lbl_StopBits;
        private Label Lbl_NomePorta;
        private Label Lbl_Parity;
        private Label lbl_BaudRate;
        private TextBox Txt_StopBits;
        private TextBox txt_DataBits;
        private TextBox Txt_Parity;
        private TextBox Txt_BaudRate;
        private TextBox Txt_Handshake;
        private Label Lbl_Handshake;
        private ComboBox Cbx_NomePorta;
        private Button Btn_Salvar;
        private Label Lbl_Mensagens;
        private TableLayoutPanel Tbl_Mensagens;
        private Label Lbl_MsgNovoSerialNumber;
    }
}
