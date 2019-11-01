using System;
using Smobiler.Core;
namespace DMSDemo
{
    partial class frmLogin : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnforgetpwd = new Smobiler.Core.Controls.Button();
            this.btnlogin = new Smobiler.Core.Controls.Button();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.txtaccount = new Smobiler.Core.Controls.TextBox();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.fontIcon3 = new Smobiler.Core.Controls.FontIcon();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.fontIcon4 = new Smobiler.Core.Controls.FontIcon();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ckbox = new Smobiler.Core.Controls.CheckBox();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.txtpwd = new Smobiler.Core.Controls.TextBox();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.btnforgetpwd,
            this.btnlogin,
            this.fontIcon1,
            this.fontIcon2,
            this.txtaccount,
            this.panel2,
            this.ckbox,
            this.label5,
            this.txtpwd});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderColor = System.Drawing.Color.White;
            this.label1.BorderRadius = 5;
            this.label1.Location = new System.Drawing.Point(15, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 44);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderColor = System.Drawing.Color.White;
            this.label2.BorderRadius = 5;
            this.label2.Location = new System.Drawing.Point(15, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 44);
            // 
            // btnforgetpwd
            // 
            this.btnforgetpwd.BackColor = System.Drawing.Color.Transparent;
            this.btnforgetpwd.BorderRadius = 0;
            this.btnforgetpwd.FontSize = 20F;
            this.btnforgetpwd.Location = new System.Drawing.Point(209, 259);
            this.btnforgetpwd.Name = "btnforgetpwd";
            this.btnforgetpwd.Size = new System.Drawing.Size(76, 24);
            this.btnforgetpwd.Text = "忘记密码";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.btnlogin.FontSize = 20F;
            this.btnlogin.Location = new System.Drawing.Point(17, 295);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(270, 49);
            this.btnlogin.Text = "立即登录";
            this.btnlogin.Press += new System.EventHandler(this.btnlogin_Press);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.fontIcon1.Location = new System.Drawing.Point(29, 154);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "md-person";
            this.fontIcon1.Size = new System.Drawing.Size(25, 25);
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.fontIcon2.Location = new System.Drawing.Point(29, 207);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "ios-lock";
            this.fontIcon2.Size = new System.Drawing.Size(25, 25);
            // 
            // txtaccount
            // 
            this.txtaccount.FontSize = 16F;
            this.txtaccount.Location = new System.Drawing.Point(60, 145);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(221, 42);
            this.txtaccount.WaterMarkText = "个人账号";
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon3,
            this.label3,
            this.fontIcon4,
            this.label4});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(63, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 100);
            // 
            // fontIcon3
            // 
            this.fontIcon3.ForeColor = System.Drawing.Color.White;
            this.fontIcon3.Location = new System.Drawing.Point(40, 10);
            this.fontIcon3.Name = "fontIcon3";
            this.fontIcon3.ResourceID = "ios-call";
            this.fontIcon3.Size = new System.Drawing.Size(22, 24);
            // 
            // label3
            // 
            this.label3.FontSize = 16F;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 26);
            this.label3.Text = "客户服务热线：0510-88547895";
            // 
            // fontIcon4
            // 
            this.fontIcon4.ForeColor = System.Drawing.Color.White;
            this.fontIcon4.Location = new System.Drawing.Point(115, 46);
            this.fontIcon4.Name = "fontIcon4";
            this.fontIcon4.ResourceID = "ios-help-circle-outline";
            this.fontIcon4.Size = new System.Drawing.Size(22, 24);
            // 
            // label4
            // 
            this.label4.FontSize = 16F;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(141, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.Text = "常见问题";
            // 
            // ckbox
            // 
            this.ckbox.Location = new System.Drawing.Point(31, 259);
            this.ckbox.Name = "ckbox";
            this.ckbox.Size = new System.Drawing.Size(22, 22);
            this.ckbox.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            // 
            // label5
            // 
            this.label5.FontSize = 16F;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(57, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.Text = "记住密码";
            // 
            // txtpwd
            // 
            this.txtpwd.FontSize = 16F;
            this.txtpwd.Location = new System.Drawing.Point(60, 198);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.SecurityMode = true;
            this.txtpwd.Size = new System.Drawing.Size(221, 42);
            this.txtpwd.WaterMarkText = "密码";
            // 
            // frmLogin
            // 
            this.BackgroundImage = "login-bg";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Name = "frmLogin";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Button btnforgetpwd;
        private Smobiler.Core.Controls.Button btnlogin;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
        private Smobiler.Core.Controls.TextBox txtaccount;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.FontIcon fontIcon3;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.FontIcon fontIcon4;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.CheckBox ckbox;
        private Smobiler.Core.Controls.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Smobiler.Core.Controls.TextBox txtpwd;
    }
}