﻿namespace CleverStocker.Client.DockForms
{
    partial class SelfSelectStockForm
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
            this.SelfSelectStockToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddToolButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveToolButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.SearchToolTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SelfSelectStockGridView = new System.Windows.Forms.DataGridView();
            this.StockCodeGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMarketGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockNameGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelfSelectStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelfSelectGridViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelfSelectStockToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelfSelectStockGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelfSelectStockBindingSource)).BeginInit();
            this.SelfSelectGridViewMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelfSelectStockToolStrip
            // 
            this.SelfSelectStockToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolButton,
            this.RemoveToolButton,
            this.RefreshToolButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.SearchToolTextBox});
            this.SelfSelectStockToolStrip.Location = new System.Drawing.Point(0, 0);
            this.SelfSelectStockToolStrip.Name = "SelfSelectStockToolStrip";
            this.SelfSelectStockToolStrip.Size = new System.Drawing.Size(254, 25);
            this.SelfSelectStockToolStrip.TabIndex = 0;
            // 
            // AddToolButton
            // 
            this.AddToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddToolButton.Image = global::CleverStocker.Client.AppResource.Add;
            this.AddToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToolButton.Name = "AddToolButton";
            this.AddToolButton.Size = new System.Drawing.Size(23, 22);
            this.AddToolButton.Text = "添加";
            this.AddToolButton.Click += new System.EventHandler(this.AddToolButton_Click);
            // 
            // RemoveToolButton
            // 
            this.RemoveToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveToolButton.Image = global::CleverStocker.Client.AppResource.Remove;
            this.RemoveToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveToolButton.Name = "RemoveToolButton";
            this.RemoveToolButton.Size = new System.Drawing.Size(23, 22);
            this.RemoveToolButton.Text = "删除";
            this.RemoveToolButton.Click += new System.EventHandler(this.RemoveToolButton_Click);
            // 
            // RefreshToolButton
            // 
            this.RefreshToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshToolButton.Image = global::CleverStocker.Client.AppResource.Refresh;
            this.RefreshToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshToolButton.Name = "RefreshToolButton";
            this.RefreshToolButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshToolButton.Text = "刷新";
            this.RefreshToolButton.Click += new System.EventHandler(this.RefreshToolButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = global::CleverStocker.Client.AppResource.SearchLabel;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SearchToolTextBox
            // 
            this.SearchToolTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SearchToolTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchToolTextBox.Name = "SearchToolTextBox";
            this.SearchToolTextBox.Size = new System.Drawing.Size(100, 25);
            this.SearchToolTextBox.TextChanged += new System.EventHandler(this.SearchToolTextBox_TextChanged);
            // 
            // SelfSelectStockGridView
            // 
            this.SelfSelectStockGridView.AllowUserToAddRows = false;
            this.SelfSelectStockGridView.AllowUserToDeleteRows = false;
            this.SelfSelectStockGridView.AllowUserToOrderColumns = true;
            this.SelfSelectStockGridView.AllowUserToResizeColumns = false;
            this.SelfSelectStockGridView.AllowUserToResizeRows = false;
            this.SelfSelectStockGridView.AutoGenerateColumns = false;
            this.SelfSelectStockGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelfSelectStockGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SelfSelectStockGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelfSelectStockGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SelfSelectStockGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SelfSelectStockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelfSelectStockGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockCodeGridViewColumn,
            this.StockMarketGridViewColumn,
            this.StockNameGridViewColumn});
            this.SelfSelectStockGridView.DataSource = this.SelfSelectStockBindingSource;
            this.SelfSelectStockGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelfSelectStockGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SelfSelectStockGridView.Location = new System.Drawing.Point(0, 25);
            this.SelfSelectStockGridView.MultiSelect = false;
            this.SelfSelectStockGridView.Name = "SelfSelectStockGridView";
            this.SelfSelectStockGridView.ReadOnly = true;
            this.SelfSelectStockGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SelfSelectStockGridView.RowHeadersVisible = false;
            this.SelfSelectStockGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SelfSelectStockGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SelfSelectStockGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelfSelectStockGridView.Size = new System.Drawing.Size(254, 256);
            this.SelfSelectStockGridView.TabIndex = 1;
            this.SelfSelectStockGridView.SelectionChanged += new System.EventHandler(this.SelfSelectStockGridView_SelectionChanged);
            // 
            // StockCodeGridViewColumn
            // 
            this.StockCodeGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StockCodeGridViewColumn.DataPropertyName = "Code";
            this.StockCodeGridViewColumn.HeaderText = "代码";
            this.StockCodeGridViewColumn.Name = "StockCodeGridViewColumn";
            this.StockCodeGridViewColumn.ReadOnly = true;
            // 
            // StockMarketGridViewColumn
            // 
            this.StockMarketGridViewColumn.DataPropertyName = "Market";
            this.StockMarketGridViewColumn.HeaderText = "市场";
            this.StockMarketGridViewColumn.Name = "StockMarketGridViewColumn";
            this.StockMarketGridViewColumn.ReadOnly = true;
            // 
            // StockNameGridViewColumn
            // 
            this.StockNameGridViewColumn.DataPropertyName = "Name";
            this.StockNameGridViewColumn.HeaderText = "名称";
            this.StockNameGridViewColumn.Name = "StockNameGridViewColumn";
            this.StockNameGridViewColumn.ReadOnly = true;
            // 
            // SelfSelectStockBindingSource
            // 
            this.SelfSelectStockBindingSource.DataSource = typeof(CleverStocker.Model.Stock);
            // 
            // SelfSelectGridViewMenuStrip
            // 
            this.SelfSelectGridViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenuItem,
            this.RemoveMenuItem,
            this.RefreshMenuItem});
            this.SelfSelectGridViewMenuStrip.Name = "SelfSelectGridViewMenuStrip";
            this.SelfSelectGridViewMenuStrip.Size = new System.Drawing.Size(101, 70);
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.Image = global::CleverStocker.Client.AppResource.Add;
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.Size = new System.Drawing.Size(100, 22);
            this.AddMenuItem.Text = "添加";
            this.AddMenuItem.Click += new System.EventHandler(this.AddMenuItem_Click);
            // 
            // RemoveMenuItem
            // 
            this.RemoveMenuItem.Image = global::CleverStocker.Client.AppResource.Remove;
            this.RemoveMenuItem.Name = "RemoveMenuItem";
            this.RemoveMenuItem.Size = new System.Drawing.Size(100, 22);
            this.RemoveMenuItem.Text = "移除";
            this.RemoveMenuItem.Click += new System.EventHandler(this.RemoveMenuItem_Click);
            // 
            // RefreshMenuItem
            // 
            this.RefreshMenuItem.Image = global::CleverStocker.Client.AppResource.Refresh;
            this.RefreshMenuItem.Name = "RefreshMenuItem";
            this.RefreshMenuItem.Size = new System.Drawing.Size(100, 22);
            this.RefreshMenuItem.Text = "刷新";
            this.RefreshMenuItem.Click += new System.EventHandler(this.RefreshMenuItem_Click);
            // 
            // SelfSelectStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 281);
            this.Controls.Add(this.SelfSelectStockGridView);
            this.Controls.Add(this.SelfSelectStockToolStrip);
            this.DoubleBuffered = true;
            this.Name = "SelfSelectStockForm";
            this.TabText = "自选股票";
            this.Text = "自选股票";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelfSelectStockForm_FormClosed);
            this.Load += new System.EventHandler(this.SelfSelectStockForm_Load);
            this.Shown += new System.EventHandler(this.SelfSelectStockForm_Shown);
            this.SelfSelectStockToolStrip.ResumeLayout(false);
            this.SelfSelectStockToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelfSelectStockGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelfSelectStockBindingSource)).EndInit();
            this.SelfSelectGridViewMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip SelfSelectStockToolStrip;
        private System.Windows.Forms.DataGridView SelfSelectStockGridView;
        private System.Windows.Forms.ToolStripButton RefreshToolButton;
        private System.Windows.Forms.ContextMenuStrip SelfSelectGridViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RefreshMenuItem;
        private System.Windows.Forms.ToolStripButton AddToolButton;
        private System.Windows.Forms.ToolStripButton RemoveToolButton;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveMenuItem;
        private System.Windows.Forms.BindingSource SelfSelectStockBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCodeGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMarketGridViewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockNameGridViewColumn;
        private System.Windows.Forms.ToolStripTextBox SearchToolTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}