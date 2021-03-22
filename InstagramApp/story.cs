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
    public partial class story : UserControl
    {
        public story()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            frmMy f = new frmMy();
            f.WindowState = FormWindowState.Minimized;

        }
    }
}
