
namespace QuanLyBenXe
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
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBếnXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTuyếnXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLịchTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.quảnLýBếnXeToolStripMenuItem,
            this.quảnLýTuyếnXeToolStripMenuItem,
            this.quảnLýXeToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLýLịchTrìnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // quảnLýBếnXeToolStripMenuItem
            // 
            this.quảnLýBếnXeToolStripMenuItem.Name = "quảnLýBếnXeToolStripMenuItem";
            this.quảnLýBếnXeToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.quảnLýBếnXeToolStripMenuItem.Text = "Quản lý bến xe";
            // 
            // quảnLýTuyếnXeToolStripMenuItem
            // 
            this.quảnLýTuyếnXeToolStripMenuItem.Name = "quảnLýTuyếnXeToolStripMenuItem";
            this.quảnLýTuyếnXeToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.quảnLýTuyếnXeToolStripMenuItem.Text = "Quản lý tuyến xe";
            // 
            // quảnLýXeToolStripMenuItem
            // 
            this.quảnLýXeToolStripMenuItem.Name = "quảnLýXeToolStripMenuItem";
            this.quảnLýXeToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.quảnLýXeToolStripMenuItem.Text = "Quản lý xe";
            this.quảnLýXeToolStripMenuItem.Click += new System.EventHandler(this.quảnLýXeToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // quảnLýLịchTrìnhToolStripMenuItem
            // 
            this.quảnLýLịchTrìnhToolStripMenuItem.Name = "quảnLýLịchTrìnhToolStripMenuItem";
            this.quảnLýLịchTrìnhToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.quảnLýLịchTrìnhToolStripMenuItem.Text = "Quản lý lịch trình";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::QuanLyBenXe.Properties.Resources.benxe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBếnXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTuyếnXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLịchTrìnhToolStripMenuItem;
    }
}

