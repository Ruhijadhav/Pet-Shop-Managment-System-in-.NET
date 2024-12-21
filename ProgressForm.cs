using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PET_Shop_1
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
            timer2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int StartP = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            StartP += 1;
            ProgressBar1.Value = StartP;
            lbl_percentage.Text = StartP + "%";
            if(ProgressBar1.Value == 100)
            {
                ProgressBar1.Value = 0;
                Login Obj = new Login();
                Obj.Show(); 
                this.Hide();    
                timer2.Stop();
                

            }

        }
    }
}
