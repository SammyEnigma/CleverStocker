﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CleverStocker.Client.Interfaces;
using CleverStocker.Utils;
using WeifenLuo.WinFormsUI.Docking;

namespace CleverStocker.Client.DockForms
{
    /// <summary>
    /// 停靠窗口基类
    /// </summary>
    /// <see cref="http://docs.dockpanelsuite.com/getting-started/index.html#"/>
    public abstract partial class DockFormBase : DockContent, IInitializable, IThemeAppliable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DockFormBase"/> class.
        /// </summary>
        public DockFormBase()
            : base()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets 布局持久化数据
        /// </summary>
        /// <remarks>用于在恢复布局后恢复相关数据</remarks>
        public virtual string PersistValue { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets 标题
        /// </summary>
        public override string Text
        {
            get => base.Text;

            set
            {
                base.Text = value;
                this.TabText = value;
            }
        }

        private void DockFormBase_Load(object sender, System.EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            this.ApplyTheme();
        }

        /// <summary>
        /// 应用主题
        /// </summary>
        public virtual void ApplyTheme()
        {
            if (ThemeHelper.CurrentThemeComponent == null)
            {
                return;
            }

            foreach (var toolStrip in this.Controls.OfType<ToolStrip>())
            {
                ThemeHelper.CurrentThemeComponent.ApplyTo(toolStrip);
            }

            this.BackColor = ThemeHelper.GetContainerBackcolor();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> Initialize()
        {
            yield break;
        }

        /// <summary>
        /// 窗口关闭
        /// </summary>
        /// <param name="e"></param>
        /// <remarks>坑：this.Hide() 将引用到 DockContent().Hide()，请使用：((Form)this).Hide() 或 this.Visible = false</remarks>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // 如果启用“隐藏窗口而非关闭”且用户主动请求关闭时
            if (this.HideOnClose &&
                e.CloseReason == CloseReason.UserClosing)
            {
                // 取消窗口关闭并手动隐藏窗口
                e.Cancel = true;
                this.Visible = false;
            }

            base.OnFormClosing(e);
        }

        /// <summary>
        /// 获取布局持久化标识
        /// </summary>
        /// <returns></returns>
        protected override string GetPersistString()
        {
            string persistValue = this.PersistValue;
            return $"{base.GetPersistString()}{(string.IsNullOrEmpty(persistValue) ? string.Empty : $"@{persistValue}")}";
        }
    }
}
