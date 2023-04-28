namespace GunShooterDetector.View
{
    partial class Frm_DegubMessages
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
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.BackColor = System.Drawing.Color.Black;
            this.textBoxDebug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDebug.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBoxDebug.Location = new System.Drawing.Point(0, 0);
            this.textBoxDebug.Multiline = true;
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDebug.Size = new System.Drawing.Size(590, 346);
            this.textBoxDebug.TabIndex = 2;
            // 
            // Frm_DegubMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 346);
            this.Controls.Add(this.textBoxDebug);
            this.Name = "Frm_DegubMessages";
            this.Text = "Frm_DegubMessages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxDebug;
    }
}