using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomilostitveniPostopek
{
    public partial class Prijava : Form
    {
        MainWindow win;
        AllnOne.Ustanova tip;
        public Prijava(MainWindow win, AllnOne.Ustanova tip)
        {
            this.win = win;
            this.InitializeComponent();
            this.tip = tip;
        }

        private void buttonLoggin_Click(object sender, EventArgs e)
        {

            string username = textBoxPrijava_ime.Text;
            string password = textBoxPrijava_geslo.Text;
            Users.User user = new Users.User(username: username, password: password);
            if (user.uporabnikObstaja(tip))
            {
                user.Prijava(tip);
                win.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nepravilen uporabnik");
            }
        }
    }
}
