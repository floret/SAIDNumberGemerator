using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDNumberGenerator
{
    public partial class frmID : Form
    {
        public frmID()
        {
            InitializeComponent();
        }
        int[] arrID100 = new int[100];//used for storing the current  100 ID's.
        Random rand1 = new Random();
        Random rand2 = new Random();
        Random rand3 = new Random();
        Random rand4 = new Random();

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int dig1 = 0, dig2 = 0, dig3 = 0, dig7 = 0;
            string sdig2 = "", sdig3 = "";
            //creates digit 1 & 2
            while (dig1 == 0 || dig1 > 90 || dig1 < 50)
            {
                dig1 = rand1.Next(100);
            }
            //creates digit 3 & 4           
            dig2 = rand2.Next(13);
            sdig2 = dig2.ToString();
            if (dig2 < 10)
            {
                sdig2 = "0" + dig2.ToString();
            }
            //creates digit 5 & 6            
            dig3 = rand3.Next(31);
            if (dig2 == 2)//in case of february which has 28 days.
            {
                dig3 = rand3.Next(28);
            }
            sdig3 = dig3.ToString();
            if (dig3 < 10)
            {
                sdig3 = "0" + dig3.ToString();
            }
            //
            dig7 = rand4.Next(10);


            rtbOutpuut.Text = dig1.ToString() + " " + sdig2 + " " + sdig3 + " " + dig7.ToString();
        }
    }
}
