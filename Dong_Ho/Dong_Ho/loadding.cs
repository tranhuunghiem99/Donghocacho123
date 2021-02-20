using System;

using System.Windows.Forms;

namespace Dong_Ho
{
    public partial class loadding : Form
    {
        public loadding()
        {
            
            InitializeComponent();
            
        }

        private void loadding_Load(object sender, EventArgs e)
        {
            timer2.Interval = 3000;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            this.Close();
        }

       
    }
}
