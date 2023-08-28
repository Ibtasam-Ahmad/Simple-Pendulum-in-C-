namespace SimplePendulumAllCases
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simplePendulumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerCromerFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dampedPendulumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerFormToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerCromerFormToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dampedDriverPendulumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerFormToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerCromerFormToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplePendulumToolStripMenuItem,
            this.dampedPendulumToolStripMenuItem,
            this.dampedDriverPendulumToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simplePendulumToolStripMenuItem
            // 
            this.simplePendulumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eulerFormToolStripMenuItem,
            this.eulerCromerFormToolStripMenuItem});
            this.simplePendulumToolStripMenuItem.Name = "simplePendulumToolStripMenuItem";
            this.simplePendulumToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.simplePendulumToolStripMenuItem.Text = "Simple Pendulum";
            // 
            // eulerFormToolStripMenuItem
            // 
            this.eulerFormToolStripMenuItem.Name = "eulerFormToolStripMenuItem";
            this.eulerFormToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.eulerFormToolStripMenuItem.Text = "Euler Form";
            this.eulerFormToolStripMenuItem.Click += new System.EventHandler(this.eulerFormToolStripMenuItem_Click);
            // 
            // eulerCromerFormToolStripMenuItem
            // 
            this.eulerCromerFormToolStripMenuItem.Name = "eulerCromerFormToolStripMenuItem";
            this.eulerCromerFormToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.eulerCromerFormToolStripMenuItem.Text = "Euler Cromer Form";
            this.eulerCromerFormToolStripMenuItem.Click += new System.EventHandler(this.eulerCromerFormToolStripMenuItem_Click);
            // 
            // dampedPendulumToolStripMenuItem
            // 
            this.dampedPendulumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eulerFormToolStripMenuItem1,
            this.eulerCromerFormToolStripMenuItem1});
            this.dampedPendulumToolStripMenuItem.Name = "dampedPendulumToolStripMenuItem";
            this.dampedPendulumToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.dampedPendulumToolStripMenuItem.Text = "Damped Pendulum";
            this.dampedPendulumToolStripMenuItem.Click += new System.EventHandler(this.dampedPendulumToolStripMenuItem_Click);
            // 
            // eulerFormToolStripMenuItem1
            // 
            this.eulerFormToolStripMenuItem1.Name = "eulerFormToolStripMenuItem1";
            this.eulerFormToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.eulerFormToolStripMenuItem1.Text = "Euler Form";
            this.eulerFormToolStripMenuItem1.Click += new System.EventHandler(this.eulerFormToolStripMenuItem1_Click);
            // 
            // eulerCromerFormToolStripMenuItem1
            // 
            this.eulerCromerFormToolStripMenuItem1.Name = "eulerCromerFormToolStripMenuItem1";
            this.eulerCromerFormToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.eulerCromerFormToolStripMenuItem1.Text = "Euler Cromer Form";
            this.eulerCromerFormToolStripMenuItem1.Click += new System.EventHandler(this.eulerCromerFormToolStripMenuItem1_Click);
            // 
            // dampedDriverPendulumToolStripMenuItem
            // 
            this.dampedDriverPendulumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eulerFormToolStripMenuItem2,
            this.eulerCromerFormToolStripMenuItem2});
            this.dampedDriverPendulumToolStripMenuItem.Name = "dampedDriverPendulumToolStripMenuItem";
            this.dampedDriverPendulumToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.dampedDriverPendulumToolStripMenuItem.Text = "Damped Driver Pendulum";
            this.dampedDriverPendulumToolStripMenuItem.Click += new System.EventHandler(this.dampedDriverPendulumToolStripMenuItem_Click);
            // 
            // eulerFormToolStripMenuItem2
            // 
            this.eulerFormToolStripMenuItem2.Name = "eulerFormToolStripMenuItem2";
            this.eulerFormToolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.eulerFormToolStripMenuItem2.Text = "Euler Form";
            this.eulerFormToolStripMenuItem2.Click += new System.EventHandler(this.eulerFormToolStripMenuItem2_Click);
            // 
            // eulerCromerFormToolStripMenuItem2
            // 
            this.eulerCromerFormToolStripMenuItem2.Name = "eulerCromerFormToolStripMenuItem2";
            this.eulerCromerFormToolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.eulerCromerFormToolStripMenuItem2.Text = "Euler Cromer Form";
            this.eulerCromerFormToolStripMenuItem2.Click += new System.EventHandler(this.eulerCromerFormToolStripMenuItem2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "q";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simplePendulumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerCromerFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dampedPendulumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerFormToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eulerCromerFormToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dampedDriverPendulumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerFormToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eulerCromerFormToolStripMenuItem2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

