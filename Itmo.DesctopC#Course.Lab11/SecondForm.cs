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
    public partial class SecondForm : Form
    {
        private bool nclose = false;
        public SecondForm()
        {
            InitializeComponent();
        }

        public new void Close()
        {
            nclose = true;
            base.Close();
        }

        private void SecondForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nclose) return;
            else
            {
                e.Cancel = true;
                Hide();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
