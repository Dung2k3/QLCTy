namespace CheckInCheckOut
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listNV_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNhanVien_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dựÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listNV_ToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listNV_ToolStripMenuItem
            // 
            this.listNV_ToolStripMenuItem.Name = "listNV_ToolStripMenuItem";
            this.listNV_ToolStripMenuItem.Size = new System.Drawing.Size(191, 29);
            this.listNV_ToolStripMenuItem.Text = "Danh sách nhân viên";
            this.listNV_ToolStripMenuItem.Click += new System.EventHandler(this.listNV_ToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLNhanVien_ToolStripMenuItem,
            this.dựÁnToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // QLNhanVien_ToolStripMenuItem
            // 
            this.QLNhanVien_ToolStripMenuItem.Name = "QLNhanVien_ToolStripMenuItem";
            this.QLNhanVien_ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.QLNhanVien_ToolStripMenuItem.Text = "Nhân viên";
            this.QLNhanVien_ToolStripMenuItem.Click += new System.EventHandler(this.QLNhanVien_ToolStripMenuItem_Click);
            // 
            // dựÁnToolStripMenuItem
            // 
            this.dựÁnToolStripMenuItem.Name = "dựÁnToolStripMenuItem";
            this.dựÁnToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dựÁnToolStripMenuItem.Text = "Dự án";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listNV_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLNhanVien_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dựÁnToolStripMenuItem;
    }
}