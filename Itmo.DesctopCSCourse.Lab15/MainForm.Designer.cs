namespace Itmo.DesctopCSCourse.Lab15
{
    partial class MainForm
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
            this.CloseMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseMainForm
            // 
            this.CloseMainForm.Location = new System.Drawing.Point(276, 126);
            this.CloseMainForm.Name = "CloseMainForm";
            this.CloseMainForm.Size = new System.Drawing.Size(202, 95);
            this.CloseMainForm.TabIndex = 0;
            this.CloseMainForm.Text = "GREENPEACE";
            this.CloseMainForm.UseVisualStyleBackColor = true;
            this.CloseMainForm.Click += new System.EventHandler(this.CloseMainForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseMainForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseMainForm;
    }
}

