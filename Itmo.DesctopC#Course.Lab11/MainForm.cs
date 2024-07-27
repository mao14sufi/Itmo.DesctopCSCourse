using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itmo.DesctopCSCourse
{
    public partial class MainForm : Form
    {
        SecondForm myF2;
        
        public MainForm()
        {
            InitializeComponent();
            myF2 = new SecondForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity =1;
        }

        private void ShowSecondForm_Click(object sender, EventArgs e)
        {
            
            myF2.StartPosition = FormStartPosition.Manual;
            myF2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            try
            {
                myF2.Show();
                myF2.Activate();
            }
            catch (ObjectDisposedException ex)
            {
                myF2 = new SecondForm();
                myF2.Text = "Again create form";
                myF2.Show();
                myF2.Activate();
            }
        }
    }
}
