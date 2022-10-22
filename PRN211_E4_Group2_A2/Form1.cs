using PRN211_E4_Group2_A2.Models;

namespace PRN211_E4_Group2_A2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShoppingGUI shoppingGUI = new ShoppingGUI();
            shoppingGUI.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CartGUI cartGUI = new CartGUI();
            cartGUI.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            LoginGUI loginGUI = new LoginGUI();
            loginGUI.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Settings.UserName != null && Settings.UserName != "")
                loginToolStripMenuItem.Text = $"Logout ({Settings.UserName})";
            else
                loginToolStripMenuItem.Text = "Login";

            if (Settings.Role == 1)
                albumsToolStripMenuItem.Visible = true;
            else
                albumsToolStripMenuItem.Visible = false;

            ShoppingCart shoppingCart = ShoppingCart.GetCart();
            int count = shoppingCart.GetCount();
            cartToolStripMenuItem.Text = $"Cart ({count})";
        }
    }
}