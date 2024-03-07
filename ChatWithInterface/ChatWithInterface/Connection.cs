using System;
using System.Windows.Forms;

namespace ChatWithInterface
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            using (ActiveChat frm = new ActiveChat())
            {
                frm.ShowDialog();
            }
        }

        private void txtIp_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
