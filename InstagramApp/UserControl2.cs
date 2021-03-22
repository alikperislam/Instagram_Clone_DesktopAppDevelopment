using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramApp
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            
            kalp.Parent = pFoto;
            kalp.BackColor = Color.Transparent;
        }

        private void begen_Click(object sender, EventArgs e)
        {
            kalp.Visible = true;
            timer1.Start();
            lblbegenme.Text = "41.498 beğenme";
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if (a == 1)
            {
                kalp.Visible = false;
            }
        }
    }
}
