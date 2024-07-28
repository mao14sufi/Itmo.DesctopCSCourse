﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itmo.DesktopCSCourse.MdiApplication
{
    //public delegate void MyHandler(object sender, ToolStripItemClickedEventArgs e);
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        public ParentForm()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);

        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            
            ChildForm newChild = new ChildForm();
            newChild.Text = newChild.Text + " " + ++openDocuments;
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void toolStrip1_Click(object sender, EventArgs e)
        { }
        //{
        //    switch (e.ClickedItem.Tag.ToString())
        //    {
        //        case "NewDoc":
        //            ChildForm newChild = new ChildForm();
        //            newChild.MdiParent = this;
        //            newChild.Show();
        //            newChild.Text = newChild.Text + " " + ++openDocuments;
        //            break;
        //        case "Cascade":
        //            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        //            break;
        //        case "Title":
        //            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        //            break;

        //    }    }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
                        newChild.MdiParent = this;
                        newChild.Show();
                        newChild.Text = newChild.Text + " " + ++openDocuments;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is cascade";
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is horizontal";

            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }
    }
}
