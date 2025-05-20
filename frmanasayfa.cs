using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_Car_Uygulaması
{
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }
        bool islem = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!islem)
            {
                this.Opacity += 0.010;
            }
            if(this.Opacity == 1.0)
            {
                islem = true;
            }
            if(islem == true)
            {
                this.Opacity -= 0.010;
                if (this.Opacity == 0)
                {
                    formgiris formgiris = new formgiris();
                   formgiris.Show();
                    timer1.Enabled = false;
                }
            }
            // animasyonlu griş
        }
    }
}
