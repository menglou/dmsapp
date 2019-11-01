using System;
using Smobiler.Core;
namespace DMSDemo.TabbarUseControl
{
    partial class TabbarControl : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem3 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem4 = new Smobiler.Core.Controls.ToolBarItem();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            // 
            // toolBar1
            // 
            toolBarItem1.IconID = "home";
            toolBarItem1.Name = "Home";
            toolBarItem1.SelectIconID = "home_focus";
            toolBarItem1.Text = "首页";
            toolBarItem2.IconID = "canyin";
            toolBarItem2.Name = "OrderFood";
            toolBarItem2.SelectIconID = "canyin";
            toolBarItem2.Text = "报餐";
            toolBarItem3.IconID = "liebiao";
            toolBarItem3.Name = "MyMeal";
            toolBarItem3.SelectIconID = "liebiao";
            toolBarItem3.Text = "我的菜单";
            toolBarItem4.IconID = "company";
            toolBarItem4.Name = "Mine";
            toolBarItem4.SelectIconID = "company_focus";
            toolBarItem4.Text = "我的";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2,
            toolBarItem3,
            toolBarItem4});
            this.toolBar1.Location = new System.Drawing.Point(117, 436);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            // 
            // TabbarControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.toolBar1});
            this.Name = "TabbarControl";

        }
        #endregion

        private Smobiler.Core.Controls.ToolBar toolBar1;
    }
}