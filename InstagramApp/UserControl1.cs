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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        int x = 0;
        private void p1_MouseClick(object sender, MouseEventArgs e)
        {
            x++;
            if (x==1)
            {
                frmMy fr = new frmMy();
                fr.Show();
            }
            else if (x==2)
            {

            }
            else if (x==3)
            {

            }
            else
            {

            }
        }
    }
}
