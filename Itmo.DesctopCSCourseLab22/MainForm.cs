using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Itmo.DesctopCSCourseLab22
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else MessageBox.Show("Choose elements from the list or type a new one");
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0)
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            peopleList.Items.Clear();
            FileStream fstream = new FileStream("..\\..\\XMLFile1.xml",
                FileMode.Open,FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fstream);
            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            }
            fstream.Close();

            


        }
    }
}
