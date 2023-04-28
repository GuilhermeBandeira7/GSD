namespace GunShooterDetector.View
{
    partial class Frm_Canal1Config
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Canal1Config));
            this.Tlp_Background = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_CalibracaoOffset = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_TempoOffset = new System.Windows.Forms.ComboBox();
            this.Lbl_TempoOffset = new System.Windows.Forms.Label();
            this.Lbl_SerialNumber = new System.Windows.Forms.Label();
            this.Cb_SerialNumber = new System.Windows.Forms.ComboBox();
            this.Cb_TempoOffset2 = new System.Windows.Forms.ComboBox();
            this.uc_Calibracao1 = new GunShooterDetector.View.Uc_Calibracao();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Tlp_CanalBackground = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Canal1Calibracao = new System.Windows.Forms.Label();
            this.Tlp_configCanal1 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_TempoMedicaoCanal1 = new System.Windows.Forms.Label();
            this.Lbl_SerialNumberCanal1 = new System.Windows.Forms.Label();
            this.Lbl_TensaoCalibCanal1 = new System.Windows.Forms.Label();
            this.Lbl_GanhoCanal1 = new System.Windows.Forms.Label();
            this.Btn_Canal1Alterar = new System.Windows.Forms.Button();
            this.Txb_SerialNumber = new System.Windows.Forms.TextBox();
            this.Nud_Ganho = new System.Windows.Forms.NumericUpDown();
            this.Nud_VCL1 = new System.Windows.Forms.NumericUpDown();
            this.Nud_TCL1 = new System.Windows.Forms.NumericUpDown();
            this.Tlp_Background.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Tlp_CanalBackground.SuspendLayout();
            this.Tlp_configCanal1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Ganho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_VCL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_TCL1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tlp_Background
            // 
            this.Tlp_Background.ColumnCount = 1;
            this.Tlp_Background.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Background.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Background.Controls.Add(this.Lbl_CalibracaoOffset, 0, 0);
            this.Tlp_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Background.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Background.Name = "Tlp_Background";
            this.Tlp_Background.RowCount = 2;
            this.Tlp_Background.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Background.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Background.Size = new System.Drawing.Size(200, 100);
            this.Tlp_Background.TabIndex = 0;
            // 
            // Lbl_CalibracaoOffset
            // 
            this.Lbl_CalibracaoOffset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_CalibracaoOffset.AutoSize = true;
            this.Lbl_CalibracaoOffset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_CalibracaoOffset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_CalibracaoOffset.Location = new System.Drawing.Point(13, 0);
            this.Lbl_CalibracaoOffset.Name = "Lbl_CalibracaoOffset";
            this.Lbl_CalibracaoOffset.Size = new System.Drawing.Size(174, 20);
            this.Lbl_CalibracaoOffset.TabIndex = 39;
            this.Lbl_CalibracaoOffset.Text = "Calibração Offset";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Cb_TempoOffset, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_TempoOffset, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_SerialNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cb_SerialNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cb_TempoOffset2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.uc_Calibracao1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Alterar, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 219);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tempo Offset 2(0 - 10.00 ms)";
            // 
            // Cb_TempoOffset
            // 
            this.Cb_TempoOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_TempoOffset.FormattingEnabled = true;
            this.Cb_TempoOffset.Location = new System.Drawing.Point(100, 62);
            this.Cb_TempoOffset.Name = "Cb_TempoOffset";
            this.Cb_TempoOffset.Size = new System.Drawing.Size(91, 23);
            this.Cb_TempoOffset.TabIndex = 9;
            // 
            // Lbl_TempoOffset
            // 
            this.Lbl_TempoOffset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_TempoOffset.AutoSize = true;
            this.Lbl_TempoOffset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TempoOffset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_TempoOffset.Location = new System.Drawing.Point(10, 49);
            this.Lbl_TempoOffset.Name = "Lbl_TempoOffset";
            this.Lbl_TempoOffset.Size = new System.Drawing.Size(77, 49);
            this.Lbl_TempoOffset.TabIndex = 8;
            this.Lbl_TempoOffset.Text = "Tempo Offset 1(0 - 10.00 ms)";
            // 
            // Lbl_SerialNumber
            // 
            this.Lbl_SerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_SerialNumber.AutoSize = true;
            this.Lbl_SerialNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_SerialNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_SerialNumber.Location = new System.Drawing.Point(6, 2);
            this.Lbl_SerialNumber.Name = "Lbl_SerialNumber";
            this.Lbl_SerialNumber.Size = new System.Drawing.Size(84, 44);
            this.Lbl_SerialNumber.TabIndex = 6;
            this.Lbl_SerialNumber.Text = "Serial Number";
            // 
            // Cb_SerialNumber
            // 
            this.Cb_SerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_SerialNumber.FormattingEnabled = true;
            this.Cb_SerialNumber.Location = new System.Drawing.Point(100, 13);
            this.Cb_SerialNumber.Name = "Cb_SerialNumber";
            this.Cb_SerialNumber.Size = new System.Drawing.Size(91, 23);
            this.Cb_SerialNumber.TabIndex = 7;
            // 
            // Cb_TempoOffset2
            // 
            this.Cb_TempoOffset2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_TempoOffset2.FormattingEnabled = true;
            this.Cb_TempoOffset2.Location = new System.Drawing.Point(100, 113);
            this.Cb_TempoOffset2.Name = "Cb_TempoOffset2";
            this.Cb_TempoOffset2.Size = new System.Drawing.Size(91, 23);
            this.Cb_TempoOffset2.TabIndex = 11;
            // 
            // uc_Calibracao1
            // 
            this.uc_Calibracao1.AutoScroll = true;
            this.uc_Calibracao1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.uc_Calibracao1.Location = new System.Drawing.Point(3, 155);
            this.uc_Calibracao1.Name = "uc_Calibracao1";
            this.uc_Calibracao1.Size = new System.Drawing.Size(8, 8);
            this.uc_Calibracao1.TabIndex = 12;
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Alterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Alterar.Location = new System.Drawing.Point(100, 161);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(91, 49);
            this.Btn_Alterar.TabIndex = 26;
            this.Btn_Alterar.Text = "Alterar ";
            this.Btn_Alterar.UseVisualStyleBackColor = true;
            // 
            // Tlp_CanalBackground
            // 
            this.Tlp_CanalBackground.ColumnCount = 1;
            this.Tlp_CanalBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_CanalBackground.Controls.Add(this.Lbl_Canal1Calibracao, 0, 0);
            this.Tlp_CanalBackground.Controls.Add(this.Tlp_configCanal1, 0, 1);
            this.Tlp_CanalBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_CanalBackground.Location = new System.Drawing.Point(0, 0);
            this.Tlp_CanalBackground.Name = "Tlp_CanalBackground";
            this.Tlp_CanalBackground.RowCount = 2;
            this.Tlp_CanalBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.26415F));
            this.Tlp_CanalBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.73585F));
            this.Tlp_CanalBackground.Size = new System.Drawing.Size(713, 353);
            this.Tlp_CanalBackground.TabIndex = 0;
            // 
            // Lbl_Canal1Calibracao
            // 
            this.Lbl_Canal1Calibracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Canal1Calibracao.AutoSize = true;
            this.Lbl_Canal1Calibracao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Canal1Calibracao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Canal1Calibracao.Location = new System.Drawing.Point(259, 10);
            this.Lbl_Canal1Calibracao.Name = "Lbl_Canal1Calibracao";
            this.Lbl_Canal1Calibracao.Size = new System.Drawing.Size(195, 23);
            this.Lbl_Canal1Calibracao.TabIndex = 40;
            this.Lbl_Canal1Calibracao.Text = "Canal 1 Calibração";
            // 
            // Tlp_configCanal1
            // 
            this.Tlp_configCanal1.ColumnCount = 2;
            this.Tlp_configCanal1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_configCanal1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_configCanal1.Controls.Add(this.Lbl_TempoMedicaoCanal1, 0, 3);
            this.Tlp_configCanal1.Controls.Add(this.Lbl_SerialNumberCanal1, 0, 0);
            this.Tlp_configCanal1.Controls.Add(this.Lbl_TensaoCalibCanal1, 0, 2);
            this.Tlp_configCanal1.Controls.Add(this.Lbl_GanhoCanal1, 0, 1);
            this.Tlp_configCanal1.Controls.Add(this.Btn_Canal1Alterar, 1, 4);
            this.Tlp_configCanal1.Controls.Add(this.Txb_SerialNumber, 1, 0);
            this.Tlp_configCanal1.Controls.Add(this.Nud_Ganho, 1, 1);
            this.Tlp_configCanal1.Controls.Add(this.Nud_VCL1, 1, 2);
            this.Tlp_configCanal1.Controls.Add(this.Nud_TCL1, 1, 3);
            this.Tlp_configCanal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_configCanal1.Location = new System.Drawing.Point(3, 46);
            this.Tlp_configCanal1.Name = "Tlp_configCanal1";
            this.Tlp_configCanal1.RowCount = 5;
            this.Tlp_configCanal1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.Tlp_configCanal1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.Tlp_configCanal1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.Tlp_configCanal1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9985F));
            this.Tlp_configCanal1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tlp_configCanal1.Size = new System.Drawing.Size(707, 304);
            this.Tlp_configCanal1.TabIndex = 41;
            // 
            // Lbl_TempoMedicaoCanal1
            // 
            this.Lbl_TempoMedicaoCanal1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_TempoMedicaoCanal1.AutoSize = true;
            this.Lbl_TempoMedicaoCanal1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TempoMedicaoCanal1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_TempoMedicaoCanal1.Location = new System.Drawing.Point(14, 199);
            this.Lbl_TempoMedicaoCanal1.Name = "Lbl_TempoMedicaoCanal1";
            this.Lbl_TempoMedicaoCanal1.Size = new System.Drawing.Size(325, 22);
            this.Lbl_TempoMedicaoCanal1.TabIndex = 11;
            this.Lbl_TempoMedicaoCanal1.Text = "Tempo De Medição (0 - 10.000 ms)";
            // 
            // Lbl_SerialNumberCanal1
            // 
            this.Lbl_SerialNumberCanal1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_SerialNumberCanal1.AutoSize = true;
            this.Lbl_SerialNumberCanal1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_SerialNumberCanal1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_SerialNumberCanal1.Location = new System.Drawing.Point(109, 19);
            this.Lbl_SerialNumberCanal1.Name = "Lbl_SerialNumberCanal1";
            this.Lbl_SerialNumberCanal1.Size = new System.Drawing.Size(135, 22);
            this.Lbl_SerialNumberCanal1.TabIndex = 7;
            this.Lbl_SerialNumberCanal1.Text = "Serial Number";
            // 
            // Lbl_TensaoCalibCanal1
            // 
            this.Lbl_TensaoCalibCanal1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_TensaoCalibCanal1.AutoSize = true;
            this.Lbl_TensaoCalibCanal1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TensaoCalibCanal1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_TensaoCalibCanal1.Location = new System.Drawing.Point(6, 139);
            this.Lbl_TensaoCalibCanal1.Name = "Lbl_TensaoCalibCanal1";
            this.Lbl_TensaoCalibCanal1.Size = new System.Drawing.Size(341, 22);
            this.Lbl_TensaoCalibCanal1.TabIndex = 10;
            this.Lbl_TensaoCalibCanal1.Text = "Tensão Caibração (0 - 3300 mVrms) ";
            // 
            // Lbl_GanhoCanal1
            // 
            this.Lbl_GanhoCanal1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_GanhoCanal1.AutoSize = true;
            this.Lbl_GanhoCanal1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_GanhoCanal1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_GanhoCanal1.Location = new System.Drawing.Point(96, 79);
            this.Lbl_GanhoCanal1.Name = "Lbl_GanhoCanal1";
            this.Lbl_GanhoCanal1.Size = new System.Drawing.Size(160, 22);
            this.Lbl_GanhoCanal1.TabIndex = 9;
            this.Lbl_GanhoCanal1.Text = "Ganho (0.1 - 10)";
            // 
            // Btn_Canal1Alterar
            // 
            this.Btn_Canal1Alterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Canal1Alterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Canal1Alterar.Location = new System.Drawing.Point(473, 247);
            this.Btn_Canal1Alterar.Name = "Btn_Canal1Alterar";
            this.Btn_Canal1Alterar.Size = new System.Drawing.Size(113, 49);
            this.Btn_Canal1Alterar.TabIndex = 27;
            this.Btn_Canal1Alterar.Text = "Alterar ";
            this.Btn_Canal1Alterar.UseVisualStyleBackColor = true;
            this.Btn_Canal1Alterar.Click += new System.EventHandler(this.Btn_Canal1Alterar_Click);
            // 
            // Txb_SerialNumber
            // 
            this.Txb_SerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_SerialNumber.Location = new System.Drawing.Point(356, 18);
            this.Txb_SerialNumber.Name = "Txb_SerialNumber";
            this.Txb_SerialNumber.Size = new System.Drawing.Size(348, 23);
            this.Txb_SerialNumber.TabIndex = 31;
            // 
            // Nud_Ganho
            // 
            this.Nud_Ganho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Nud_Ganho.Location = new System.Drawing.Point(356, 78);
            this.Nud_Ganho.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Nud_Ganho.Name = "Nud_Ganho";
            this.Nud_Ganho.Size = new System.Drawing.Size(348, 23);
            this.Nud_Ganho.TabIndex = 32;
            // 
            // Nud_VCL1
            // 
            this.Nud_VCL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Nud_VCL1.Location = new System.Drawing.Point(356, 138);
            this.Nud_VCL1.Maximum = new decimal(new int[] {
            3300,
            0,
            0,
            0});
            this.Nud_VCL1.Name = "Nud_VCL1";
            this.Nud_VCL1.Size = new System.Drawing.Size(348, 23);
            this.Nud_VCL1.TabIndex = 33;
            // 
            // Nud_TCL1
            // 
            this.Nud_TCL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Nud_TCL1.Location = new System.Drawing.Point(356, 198);
            this.Nud_TCL1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Nud_TCL1.Name = "Nud_TCL1";
            this.Nud_TCL1.Size = new System.Drawing.Size(348, 23);
            this.Nud_TCL1.TabIndex = 34;
            // 
            // Frm_Canal1Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(713, 353);
            this.Controls.Add(this.Tlp_CanalBackground);
            this.MaximizeBox = false;
            this.Name = "Frm_Canal1Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Canal1Config";
            this.Tlp_Background.ResumeLayout(false);
            this.Tlp_Background.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Tlp_CanalBackground.ResumeLayout(false);
            this.Tlp_CanalBackground.PerformLayout();
            this.Tlp_configCanal1.ResumeLayout(false);
            this.Tlp_configCanal1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Ganho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_VCL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_TCL1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel Tlp_Background;
        private Label Lbl_CalibracaoOffset;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox Cb_TempoOffset;
        private Label Lbl_TempoOffset;
        private Label Lbl_SerialNumber;
        private ComboBox Cb_SerialNumber;
        private ComboBox Cb_TempoOffset2;
        private Uc_Calibracao uc_Calibracao1;
        private Button Btn_Alterar;
        private TableLayoutPanel Tlp_CanalBackground;
        private Label Lbl_Canal1Calibracao;
        private TableLayoutPanel Tlp_configCanal1;
        private Label Lbl_SerialNumberCanal1;
        private Label Lbl_TempoMedicaoCanal1;
        private Label Lbl_TensaoCalibCanal1;
        private Label Lbl_GanhoCanal1;
        private Button Btn_Canal1Alterar;
        private TextBox Txb_SerialNumber;
        private NumericUpDown Nud_Ganho;
        private NumericUpDown Nud_VCL1;
        private NumericUpDown Nud_TCL1;
    }
}