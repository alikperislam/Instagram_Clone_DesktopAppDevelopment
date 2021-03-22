using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramApp
{
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            // hikayeler :

            u2.p1.Image = Properties.Resources.gs_pembe;
            u3.p1.Image = Properties.Resources.falcao_pembe;
            u4.p1.Image = Properties.Resources.muslera_pembe;
            u5.p1.Image = Properties.Resources.başkan_pembe;
            u6.p1.Image = Properties.Resources.kendal_pembe;
            u7.p1.Image = Properties.Resources.kylie_pembe;
            u8.p1.Image = Properties.Resources.gigi_pembe;
            
            u2.l1.Text = "galatasaray";
            u3.l1.Text = "falcao";
            u4.l1.Text = "muslera";
            u5.l1.Text = "mansuryavas";
            u6.l1.Text = "kendalljenner";
            u7.l1.Text = "kyliejenner";
            u8.l1.Text = "gigihadid";

            /////////////////
            // postlar :
            uu2.pPP.Image = Properties.Resources.kendal_pembe;
            uu2.pFoto.Image = Properties.Resources.kendall1;
            uu2.lblisim.Text = "kendalljenner";
            uu2.lblbegenme.Text = "2.178.459 beğenme";
            uu2.lblyorum.Text = "317.259 yorumun tümünü gör";
            uu2.lbldakika.Text = "1 saat önce";
            //
            uu3.pPP.Image = Properties.Resources.kendal_pembe;
            uu3.pFoto.Image = Properties.Resources.kendal2;
            uu3.lblisim.Text = "kendalljenner";
            uu3.lblbegenme.Text = "3.108.360 beğenme";
            uu3.lblyorum.Text = "186.512 yorumun tümünü gör";
            uu3.lbldakika.Text = "1 saat önce";
            //
            uu4.pPP.Image = Properties.Resources.gs_pembe;
            uu4.pFoto.Image = Properties.Resources.gs;
            uu4.lblisim.Text = "galatasaray";
            uu4.lblbegenme.Text = "530.459 beğenme";
            uu4.lblyorum.Text = "98.259 yorumun tümünü gör";
            uu4.lbldakika.Text = "2 saat önce";
            //
            uu5.pPP.Image = Properties.Resources.kylie_pembe;
            uu5.pFoto.Image = Properties.Resources.kylie;
            uu5.lblisim.Text = "kyliejenner";
            uu5.lblbegenme.Text = "5.431.216 beğenme";
            uu5.lblyorum.Text = "436.142 yorumun tümünü gör";
            uu5.lbldakika.Text = "2 saat önce";
            //
            uu6.pPP.Image = Properties.Resources.gigi_pembe;
            uu6.pFoto.Image = Properties.Resources.gigi;
            uu6.lblisim.Text = "gigihadid";
            uu6.lblbegenme.Text = "1.078.305 beğenme";
            uu6.lblyorum.Text = "97.276 yorumun tümünü gör";
            uu6.lbldakika.Text = "3 saat önce";
            //
            uu7.pPP.Image = Properties.Resources.başkan_pembe;
            uu7.pFoto.Image = Properties.Resources.mansur;
            uu7.lblisim.Text = "mansuryavas";
            uu7.lblbegenme.Text = "137.201 beğenme";
            uu7.lblyorum.Text = "18.913 yorumun tümünü gör";
            uu7.lbldakika.Text = "7 saat önce";


        }

        private void userControl12_Load(object sender, EventArgs e)
        {
            
        }

        private void u1_Click(object sender, EventArgs e)
        {
            
        }

        private void u1_Load(object sender, EventArgs e)
        {

        }

        private void u2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
