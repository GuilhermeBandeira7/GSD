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
    public partial class Frm_NewLogin_View : Form
    {
        public string dbUser = "sa";
        public string dbPassword = "Senha@mtw";

        public Frm_NewLogin_View()
        {
            InitializeComponent();
            this.CenterToScreen();
            Ttb_User.Select();
            Ttb_Password.TabIndex = 1;
        }


        private void Btn_Conectar_Click(object sender, EventArgs e)
        {
            string password = Ttb_Password.Text;
            string user = Ttb_User.Text;

            if (user == dbUser && password == dbPassword)
            {
                Frm_Menu frm_Menu = new Frm_Menu();
                frm_Menu.Show();
                this.Hide(); // hide login after connected
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
