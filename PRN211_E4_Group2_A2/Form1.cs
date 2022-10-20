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
    }
}