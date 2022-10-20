using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_E4_Group2_A2
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();
            var username = config["User:Name"];
            var password = config["User:Password"];
            if (textBox1.Text.Equals(username) && textBox2.Text.Equals(password))
            {
                MessageBox.Show("Login successfully");
                AdminGUI adminGUI = new AdminGUI();
                adminGUI.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("That member does not existed!");
            }
        }
    }
}
