namespace Itmo.DesctopCSCourse.Lab15
{
    partial class SecondForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonToOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToOpen
            // 
            this.buttonToOpen.Location = new System.Drawing.Point(283, 163);
            this.buttonToOpen.Name = "buttonToOpen";
            this.buttonToOpen.Size = new System.Drawing.Size(190, 97);
            this.buttonToOpen.TabIndex = 0;
            this.buttonToOpen.Text = "buttonToOpen";
            this.buttonToOpen.UseVisualStyleBackColor = true;
            this.buttonToOpen.Click += new System.EventHandler(this.buttonToOpen_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonToOpen);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.Load += new System.EventHandler(this.SecondForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToOpen;
    }
}