namespace GunShooterDetector.View
{
    partial class Frm_Reset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reset));
            this.Tlp_Resetbackground = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Reset = new System.Windows.Forms.Label();
            this.Tlp_configReset = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_AlarmeEvento = new System.Windows.Forms.Label();
            this.Rb_AtivaAlarme = new System.Windows.Forms.RadioButton();
            this.Rb_DesativaAlarme = new System.Windows.Forms.RadioButton();
            this.Rb_ResetAll = new System.Windows.Forms.RadioButton();
            this.Btn_AlterarOffset = new System.Windows.Forms.Button();
            this.Tlp_Resetbackground.SuspendLayout();
            this.Tlp_configReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_Resetbackground
            // 
            this.Tlp_Resetbackground.ColumnCount = 1;
            this.Tlp_Resetbackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_Resetbackground.Controls.Add(this.Lbl_Reset, 0, 0);
            this.Tlp_Resetbackground.Controls.Add(this.Tlp_configReset, 0, 1);
            this.Tlp_Resetbackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Resetbackground.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Resetbackground.Name = "Tlp_Resetbackground";
            this.Tlp_Resetbackground.RowCount = 2;
            this.Tlp_Resetbackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.19745F));
            this.Tlp_Resetbackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.80255F));
            this.Tlp_Resetbackground.Size = new System.Drawing.Size(764, 314);
            this.Tlp_Resetbackground.TabIndex = 0;
            // 
            // Lbl_Reset
            // 
            this.Lbl_Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Reset.AutoSize = true;
            this.Lbl_Reset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Reset.Location = new System.Drawing.Point(352, 15);
            this.Lbl_Reset.Name = "Lbl_Reset";
            this.Lbl_Reset.Size = new System.Drawing.Size(59, 23);
            this.Lbl_Reset.TabIndex = 8;
            this.Lbl_Reset.Text = "RESET";
            // 
            // Tlp_configReset
            // 
            this.Tlp_configReset.ColumnCount = 4;
            this.Tlp_configReset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tlp_configReset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tlp_configReset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tlp_configReset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.Tlp_configReset.Controls.Add(this.Lbl_AlarmeEvento, 0, 0);
            this.Tlp_configReset.Controls.Add(this.Rb_AtivaAlarme, 1, 0);
            this.Tlp_configReset.Controls.Add(this.Rb_DesativaAlarme, 2, 0);
            this.Tlp_configReset.Controls.Add(this.Rb_ResetAll, 3, 0);
            this.Tlp_configReset.Controls.Add(this.Btn_AlterarOffset, 2, 1);
            this.Tlp_configReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_configReset.Location = new System.Drawing.Point(3, 56);
            this.Tlp_configReset.Name = "Tlp_configReset";
            this.Tlp_configReset.RowCount = 2;
            this.Tlp_configReset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_configReset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_configReset.Size = new System.Drawing.Size(758, 255);
            this.Tlp_configReset.TabIndex = 9;
            // 
            // Lbl_AlarmeEvento
            // 
            this.Lbl_AlarmeEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_AlarmeEvento.AutoSize = true;
            this.Lbl_AlarmeEvento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AlarmeEvento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_AlarmeEvento.Location = new System.Drawing.Point(12, 40);
            this.Lbl_AlarmeEvento.Name = "Lbl_AlarmeEvento";
            this.Lbl_AlarmeEvento.Size = new System.Drawing.Size(172, 46);
            this.Lbl_AlarmeEvento.TabIndex = 9;
            this.Lbl_AlarmeEvento.Text = "Reset do Número Serial";
            // 
            // Rb_AtivaAlarme
            // 
            this.Rb_AtivaAlarme.AutoSize = true;
            this.Rb_AtivaAlarme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rb_AtivaAlarme.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rb_AtivaAlarme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rb_AtivaAlarme.Location = new System.Drawing.Point(199, 3);
            this.Rb_AtivaAlarme.Name = "Rb_AtivaAlarme";
            this.Rb_AtivaAlarme.Size = new System.Drawing.Size(190, 121);
            this.Rb_AtivaAlarme.TabIndex = 10;
            this.Rb_AtivaAlarme.TabStop = true;
            this.Rb_AtivaAlarme.Text = "Resetar e Habilitar alarme geral";
            this.Rb_AtivaAlarme.UseVisualStyleBackColor = true;
            // 
            // Rb_DesativaAlarme
            // 
            this.Rb_DesativaAlarme.AutoSize = true;
            this.Rb_DesativaAlarme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rb_DesativaAlarme.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rb_DesativaAlarme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rb_DesativaAlarme.Location = new System.Drawing.Point(395, 3);
            this.Rb_DesativaAlarme.Name = "Rb_DesativaAlarme";
            this.Rb_DesativaAlarme.Size = new System.Drawing.Size(190, 121);
            this.Rb_DesativaAlarme.TabIndex = 11;
            this.Rb_DesativaAlarme.TabStop = true;
            this.Rb_DesativaAlarme.Text = "Resetar e Desabilitar alarme geral";
            this.Rb_DesativaAlarme.UseVisualStyleBackColor = true;
            // 
            // Rb_ResetAll
            // 
            this.Rb_ResetAll.AutoSize = true;
            this.Rb_ResetAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rb_ResetAll.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rb_ResetAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rb_ResetAll.Location = new System.Drawing.Point(591, 3);
            this.Rb_ResetAll.Name = "Rb_ResetAll";
            this.Rb_ResetAll.Size = new System.Drawing.Size(164, 121);
            this.Rb_ResetAll.TabIndex = 28;
            this.Rb_ResetAll.TabStop = true;
            this.Rb_ResetAll.Text = "Full Reset";
            this.Rb_ResetAll.UseVisualStyleBackColor = true;
            // 
            // Btn_AlterarOffset
            // 
            this.Btn_AlterarOffset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_AlterarOffset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_AlterarOffset.Location = new System.Drawing.Point(395, 130);
            this.Btn_AlterarOffset.Name = "Btn_AlterarOffset";
            this.Btn_AlterarOffset.Size = new System.Drawing.Size(190, 49);
            this.Btn_AlterarOffset.TabIndex = 27;
            this.Btn_AlterarOffset.Text = "Salvar Reset";
            this.Btn_AlterarOffset.UseVisualStyleBackColor = true;
            this.Btn_AlterarOffset.Click += new System.EventHandler(this.Btn_AlterarOffset_Click);
            // 
            // Frm_Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(764, 314);
            this.Controls.Add(this.Tlp_Resetbackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSD";
            this.Tlp_Resetbackground.ResumeLayout(false);
            this.Tlp_Resetbackground.PerformLayout();
            this.Tlp_configReset.ResumeLayout(false);
            this.Tlp_configReset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel Tlp_Resetbackground;
        private Label Lbl_Reset;
        private TableLayoutPanel Tlp_configReset;
        private Label Lbl_AlarmeEvento;
        private RadioButton Rb_AtivaAlarme;
        private RadioButton Rb_DesativaAlarme;
        private Button Btn_AlterarOffset;
        private RadioButton Rb_ResetAll;
    }
}