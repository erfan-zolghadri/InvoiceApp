
namespace InvoiceApp.UI
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.ثبتاطلاعاتشرکتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتفاکتورهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزراشبهتفکیکتاریخفاکتورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.DarkCyan;
            this.mnuMain.Font = new System.Drawing.Font("IRANSansX DemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتاطلاعاتشرکتToolStripMenuItem,
            this.ثبتفاکتورهاToolStripMenuItem,
            this.گزارشهاToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuMain.Size = new System.Drawing.Size(718, 28);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "mnuMain";
            // 
            // ثبتاطلاعاتشرکتToolStripMenuItem
            // 
            this.ثبتاطلاعاتشرکتToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ثبتاطلاعاتشرکتToolStripMenuItem.Name = "ثبتاطلاعاتشرکتToolStripMenuItem";
            this.ثبتاطلاعاتشرکتToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.ثبتاطلاعاتشرکتToolStripMenuItem.Text = "ثبت اطلاعات شرکت";
            this.ثبتاطلاعاتشرکتToolStripMenuItem.Click += new System.EventHandler(this.ثبتاطلاعاتشرکتToolStripMenuItem_Click);
            // 
            // ثبتفاکتورهاToolStripMenuItem
            // 
            this.ثبتفاکتورهاToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ثبتفاکتورهاToolStripMenuItem.Name = "ثبتفاکتورهاToolStripMenuItem";
            this.ثبتفاکتورهاToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.ثبتفاکتورهاToolStripMenuItem.Text = "ثبت فاکتورها";
            this.ثبتفاکتورهاToolStripMenuItem.Click += new System.EventHandler(this.ثبتفاکتورهاToolStripMenuItem_Click);
            // 
            // گزارشهاToolStripMenuItem
            // 
            this.گزارشهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزراشبهتفکیکتاریخفاکتورToolStripMenuItem});
            this.گزارشهاToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.گزارشهاToolStripMenuItem.Name = "گزارشهاToolStripMenuItem";
            this.گزارشهاToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.گزارشهاToolStripMenuItem.Text = "گزارش ها";
            // 
            // گزراشبهتفکیکتاریخفاکتورToolStripMenuItem
            // 
            this.گزراشبهتفکیکتاریخفاکتورToolStripMenuItem.Name = "گزراشبهتفکیکتاریخفاکتورToolStripMenuItem";
            this.گزراشبهتفکیکتاریخفاکتورToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.گزراشبهتفکیکتاریخفاکتورToolStripMenuItem.Text = "گزارش به تفکیک تاریخ فاکتور";
            this.گزراشبهتفکیکتاریخفاکتورToolStripMenuItem.Click += new System.EventHandler(this.گزراشبهتفکیکتاریخفاکتورToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MaximumSize = new System.Drawing.Size(734, 489);
            this.MinimumSize = new System.Drawing.Size(734, 489);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلی";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem ثبتاطلاعاتشرکتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتفاکتورهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزراشبهتفکیکتاریخفاکتورToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
    }
}