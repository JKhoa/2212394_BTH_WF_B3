using System;

namespace BTTKForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.họTênCủaBạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmbai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmbai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmbai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họTênCủaBạnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // họTênCủaBạnToolStripMenuItem
            // 
            this.họTênCủaBạnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtmbai1,
            this.txtmbai2,
            this.txtmbai3});
            this.họTênCủaBạnToolStripMenuItem.Name = "họTênCủaBạnToolStripMenuItem";
            this.họTênCủaBạnToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.họTênCủaBạnToolStripMenuItem.Text = "Họ tên của sinh viên";
            this.họTênCủaBạnToolStripMenuItem.Click += new System.EventHandler(this.họTênCủaBạnToolStripMenuItem_Click);
            // 
            // txtmbai1
            // 
            this.txtmbai1.Image = ((System.Drawing.Image)(resources.GetObject("txtmbai1.Image")));
            this.txtmbai1.Name = "txtmbai1";
            this.txtmbai1.Size = new System.Drawing.Size(180, 22);
            this.txtmbai1.Text = "Bài 1";
            this.txtmbai1.Click += new System.EventHandler(this.txtmbai1_Click);
            // 
            // txtmbai2
            // 
            this.txtmbai2.Image = ((System.Drawing.Image)(resources.GetObject("txtmbai2.Image")));
            this.txtmbai2.Name = "txtmbai2";
            this.txtmbai2.Size = new System.Drawing.Size(180, 22);
            this.txtmbai2.Text = "Bài 2";
            this.txtmbai2.Click += new System.EventHandler(this.txtmbai2_Click);
            // 
            // txtmbai3
            // 
            this.txtmbai3.Image = ((System.Drawing.Image)(resources.GetObject("txtmbai3.Image")));
            this.txtmbai3.Name = "txtmbai3";
            this.txtmbai3.Size = new System.Drawing.Size(180, 22);
            this.txtmbai3.Text = "Bài 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void họTênCủaBạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem họTênCủaBạnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtmbai1;
        private System.Windows.Forms.ToolStripMenuItem txtmbai2;
        private System.Windows.Forms.ToolStripMenuItem txtmbai3;
    }
}

