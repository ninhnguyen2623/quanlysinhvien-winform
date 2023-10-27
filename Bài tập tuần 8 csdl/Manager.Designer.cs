using System.Windows.Forms;

namespace Bài_tập_tuần_8_csdl
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.SinhVien = new System.Windows.Forms.ToolStripLabel();
            this.Khoa = new System.Windows.Forms.ToolStripLabel();
            this.MonHoc = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.XemDiem = new System.Windows.Forms.ToolStripLabel();
            this.NhapDiem = new System.Windows.Forms.ToolStripLabel();
            this.ThongKeKhoa = new System.Windows.Forms.ToolStripLabel();
            this.Thoat = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống ";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem,
            this.khoaToolStripMenuItem,
            this.mônHọcToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng ";
            this.chứcNăngToolStripMenuItem.Click += new System.EventHandler(this.chứcNăngToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.sinhViênToolStripMenuItem.Text = "Sinh Viên ";
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.khoaToolStripMenuItem.Text = "Khoa";
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.mônHọcToolStripMenuItem.Text = "Môn học";
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ Trợ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.SinhVien,
            this.Khoa,
            this.MonHoc,
            this.XemDiem,
            this.toolStripSeparator1,
            this.NhapDiem,
            this.ThongKeKhoa,
            this.Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1140, 61);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 58);
            // 
            // SinhVien
            // 
            this.SinhVien.Image = ((System.Drawing.Image)(resources.GetObject("SinhVien.Image")));
            this.SinhVien.Name = "SinhVien";
            this.SinhVien.Padding = new System.Windows.Forms.Padding(10);
            this.SinhVien.Size = new System.Drawing.Size(125, 58);
            this.SinhVien.Text = "Sinh Viên";
            this.SinhVien.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // Khoa
            // 
            this.Khoa.Image = ((System.Drawing.Image)(resources.GetObject("Khoa.Image")));
            this.Khoa.Name = "Khoa";
            this.Khoa.Padding = new System.Windows.Forms.Padding(10);
            this.Khoa.Size = new System.Drawing.Size(92, 58);
            this.Khoa.Text = "Khoa";
            this.Khoa.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // MonHoc
            // 
            this.MonHoc.Image = ((System.Drawing.Image)(resources.GetObject("MonHoc.Image")));
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.Padding = new System.Windows.Forms.Padding(10);
            this.MonHoc.Size = new System.Drawing.Size(126, 58);
            this.MonHoc.Text = "Môn Học";
            this.MonHoc.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 61);
            // 
            // XemDiem
            // 
            this.XemDiem.Image = ((System.Drawing.Image)(resources.GetObject("XemDiem.Image")));
            this.XemDiem.Name = "XemDiem";
            this.XemDiem.Padding = new System.Windows.Forms.Padding(10);
            this.XemDiem.Size = new System.Drawing.Size(135, 58);
            this.XemDiem.Text = "Xem Điểm";
            this.XemDiem.Click += new System.EventHandler(this.toolStripLabel6_Click);
            // 
            // NhapDiem
            // 
            this.NhapDiem.Image = ((System.Drawing.Image)(resources.GetObject("NhapDiem.Image")));
            this.NhapDiem.Name = "NhapDiem";
            this.NhapDiem.Padding = new System.Windows.Forms.Padding(10);
            this.NhapDiem.Size = new System.Drawing.Size(142, 58);
            this.NhapDiem.Text = "Nhập Điểm";
            this.NhapDiem.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // ThongKeKhoa
            // 
            this.ThongKeKhoa.Image = ((System.Drawing.Image)(resources.GetObject("ThongKeKhoa.Image")));
            this.ThongKeKhoa.Name = "ThongKeKhoa";
            this.ThongKeKhoa.Padding = new System.Windows.Forms.Padding(10);
            this.ThongKeKhoa.Size = new System.Drawing.Size(172, 58);
            this.ThongKeKhoa.Text = "Thống Kê Khoa";
            this.ThongKeKhoa.Click += new System.EventHandler(this.toolStripLabel7_Click);
            // 
            // Thoat
            // 
            this.Thoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Thoat.Image = ((System.Drawing.Image)(resources.GetObject("Thoat.Image")));
            this.Thoat.Name = "Thoat";
            this.Thoat.Padding = new System.Windows.Forms.Padding(10);
            this.Thoat.Size = new System.Drawing.Size(97, 58);
            this.Thoat.Text = "Thoát";
            this.Thoat.Click += new System.EventHandler(this.toolStripLabel8_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1140, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel2.Image")));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(91, 20);
            this.toolStripStatusLabel2.Text = "Ha Giang";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 89);
            this.panel1.TabIndex = 4;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Manager";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel SinhVien;
        private System.Windows.Forms.ToolStripLabel Khoa;
        private System.Windows.Forms.ToolStripLabel MonHoc;
        private System.Windows.Forms.ToolStripLabel NhapDiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel XemDiem;
        private System.Windows.Forms.ToolStripLabel ThongKeKhoa;
        private System.Windows.Forms.ToolStripLabel Thoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private Panel panel1;
    }
}

