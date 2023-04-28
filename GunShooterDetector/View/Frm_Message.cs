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
    public partial class Frm_Message : Form
    {
        public Frm_Message(string text)
        {
            InitializeComponent();
            Lbl_Message.Text = text;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
