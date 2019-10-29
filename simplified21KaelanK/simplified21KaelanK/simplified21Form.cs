using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplified21KaelanK
{
    public partial class frmSimplified21 : Form
    {
        public frmSimplified21()
        {
            InitializeComponent();

            // hide labels at beginning
            this.lblCard1.Hide();
            this.lblCard2.Hide();
            this.lblCard3.Hide();
            this.lblDealerCard1.Hide();
            this.lblDealerCard2.Hide();
            this.lblDealerCard3.Hide();
            this.btnHit.Hide();
            this.btnStay.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Show the labels after button clicked
            this.lblCard1.Show();
            this.lblCard2.Show();
            this.lblCard3.Show();
            this.lblDealerCard1.Show();
            this.lblDealerCard2.Show();
            this.lblDealerCard3.Show();
            this.btnHit.Show();
            this.btnStay.Show();
            // Hide other labels and button
            this.lblBlackjack.Hide();
            this.btnStart.Hide();
        }
    }
}
