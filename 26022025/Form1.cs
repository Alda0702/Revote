using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26022025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0;
        int dire = 1;
 

        private void pic1_Click(object sender, EventArgs e)
        {
        }

        private void btnDesplazar_Click(object sender, EventArgs e)
        {
            tmr1.Enabled = true;
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            x += 50 * dire;

            if (x >= this.Width - pic1.Width)
            {
                dire = -1;
            }
            else  if (x <= 0)
            {
                dire = 1;
            }

            pic1.Location = new Point(x, 33);


        }
    }
}
