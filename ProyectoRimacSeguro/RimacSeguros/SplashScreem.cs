using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RimacSeguros
{
    public partial class SplashScreem : Form
    {
        int progress = 0;
        public SplashScreem()
        {
            InitializeComponent();
        }
        private void SplashScreem_Load(object sender, EventArgs e)
        {
            tmrTiempo.Enabled = true;
            tmrTiempo.Interval = 50;
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress >= 100)
            {
                tmrTiempo.Enabled = false;
                tmrTiempo.Stop();
                this.Close();
            }
            pgbSS.Value = progress;
        }
    }
}
