﻿namespace CleverStocker.Client
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
            this.MainTopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.StartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlueThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveLayoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TestToolItem = new System.Windows.Forms.ToolStripButton();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StateStatusItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressStatusItem = new System.Windows.Forms.ToolStripProgressBar();
            this.MainDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.MainTopMenuStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTopMenuStrip
            // 
            this.MainTopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartMenuItem,
            this.ViewMenuItem,
            this.ThemeMenuItem});
            this.MainTopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainTopMenuStrip.Name = "MainTopMenuStrip";
            this.MainTopMenuStrip.Size = new System.Drawing.Size(800, 25);
            this.MainTopMenuStrip.TabIndex = 0;
            // 
            // StartMenuItem
            // 
            this.StartMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.StartMenuItem.Image = global::CleverStocker.Client.AppResource.Home;
            this.StartMenuItem.Name = "StartMenuItem";
            this.StartMenuItem.Size = new System.Drawing.Size(60, 21);
            this.StartMenuItem.Text = "开始";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Image = global::CleverStocker.Client.AppResource.Power;
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ExitMenuItem.Text = "退出";
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.Image = global::CleverStocker.Client.AppResource.View;
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(60, 21);
            this.ViewMenuItem.Text = "视图";
            // 
            // ThemeMenuItem
            // 
            this.ThemeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LightThemeMenuItem,
            this.BlueThemeMenuItem,
            this.DarkThemeMenuItem,
            this.toolStripSeparator1,
            this.SaveLayoutMenuItem});
            this.ThemeMenuItem.Image = global::CleverStocker.Client.AppResource.Theme;
            this.ThemeMenuItem.Name = "ThemeMenuItem";
            this.ThemeMenuItem.Size = new System.Drawing.Size(60, 21);
            this.ThemeMenuItem.Text = "主题";
            // 
            // LightThemeMenuItem
            // 
            this.LightThemeMenuItem.Name = "LightThemeMenuItem";
            this.LightThemeMenuItem.Size = new System.Drawing.Size(124, 22);
            this.LightThemeMenuItem.Text = "浅色";
            this.LightThemeMenuItem.Click += new System.EventHandler(this.ThemeMenuItem_Click);
            // 
            // BlueThemeMenuItem
            // 
            this.BlueThemeMenuItem.Name = "BlueThemeMenuItem";
            this.BlueThemeMenuItem.Size = new System.Drawing.Size(124, 22);
            this.BlueThemeMenuItem.Text = "蓝色";
            this.BlueThemeMenuItem.Click += new System.EventHandler(this.ThemeMenuItem_Click);
            // 
            // DarkThemeMenuItem
            // 
            this.DarkThemeMenuItem.Name = "DarkThemeMenuItem";
            this.DarkThemeMenuItem.Size = new System.Drawing.Size(124, 22);
            this.DarkThemeMenuItem.Text = "深色";
            this.DarkThemeMenuItem.Click += new System.EventHandler(this.ThemeMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // SaveLayoutMenuItem
            // 
            this.SaveLayoutMenuItem.Name = "SaveLayoutMenuItem";
            this.SaveLayoutMenuItem.Size = new System.Drawing.Size(124, 22);
            this.SaveLayoutMenuItem.Text = "保存布局";
            this.SaveLayoutMenuItem.Click += new System.EventHandler(this.SaveLayoutMenuItem_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchToolButton,
            this.toolStripSeparator2,
            this.TestToolItem});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 25);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(800, 25);
            this.MainToolStrip.TabIndex = 2;
            // 
            // SearchToolButton
            // 
            this.SearchToolButton.Image = global::CleverStocker.Client.AppResource.Search;
            this.SearchToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchToolButton.Name = "SearchToolButton";
            this.SearchToolButton.Size = new System.Drawing.Size(52, 22);
            this.SearchToolButton.Text = "搜索";
            this.SearchToolButton.Click += new System.EventHandler(this.SearchToolButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TestToolItem
            // 
            this.TestToolItem.Image = global::CleverStocker.Client.AppResource.Research;
            this.TestToolItem.Name = "TestToolItem";
            this.TestToolItem.Size = new System.Drawing.Size(52, 22);
            this.TestToolItem.Text = "测试";
            this.TestToolItem.Click += new System.EventHandler(this.TestToolItem_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StateStatusItem,
            this.ProgressStatusItem});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.MainStatusStrip.TabIndex = 3;
            // 
            // StateStatusItem
            // 
            this.StateStatusItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StateStatusItem.Image = global::CleverStocker.Client.AppResource.Processer;
            this.StateStatusItem.Name = "StateStatusItem";
            this.StateStatusItem.Size = new System.Drawing.Size(16, 17);
            this.StateStatusItem.Text = "状态";
            this.StateStatusItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // ProgressStatusItem
            // 
            this.ProgressStatusItem.Name = "ProgressStatusItem";
            this.ProgressStatusItem.Size = new System.Drawing.Size(100, 16);
            // 
            // MainDockPanel
            // 
            this.MainDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDockPanel.DockLeftPortion = 0.2D;
            this.MainDockPanel.Location = new System.Drawing.Point(0, 50);
            this.MainDockPanel.Name = "MainDockPanel";
            this.MainDockPanel.Size = new System.Drawing.Size(800, 378);
            this.MainDockPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainDockPanel);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainTopMenuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MainTopMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainTopMenuStrip.ResumeLayout(false);
            this.MainTopMenuStrip.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainTopMenuStrip;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripMenuItem StartMenuItem;
        private System.Windows.Forms.ToolStripButton TestToolItem;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripProgressBar ProgressStatusItem;
        private System.Windows.Forms.ToolStripStatusLabel StateStatusItem;
        private WeifenLuo.WinFormsUI.Docking.DockPanel MainDockPanel;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightThemeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlueThemeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DarkThemeMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveLayoutMenuItem;
        private System.Windows.Forms.ToolStripButton SearchToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}