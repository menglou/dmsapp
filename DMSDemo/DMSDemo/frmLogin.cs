using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using DMS.Common;
using DMS.ApiModel;

namespace DMSDemo
{
    partial class frmLogin : Smobiler.Core.Controls.MobileForm
    {
        public frmLogin() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void btnlogin_Press(object sender, EventArgs e)
        {
            
            //调用获取token接口
            var model = new
            {
                name = "apiuser1",
                passWord = "123456"
            };
            this.Form.ShowLoadingScreen("加载中...");
            string url = "http://10.115.177.208:9091/api/Auth/JWTToken";
            string jsonstr = Newtonsoft.Json.JsonConvert.SerializeObject(model);

            string result = HttpRequest.GetToken(url, model.name, model.passWord);

            Token resulttomodel = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(result);

            if (resulttomodel.success == true)
            {
                LoadClientData("token", resulttomodel.token);
                LoadClientData("expires_in", resulttomodel.expires_in.ToString());
                LoadClientData("logintime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                
                if (!string.IsNullOrEmpty(txtaccount.Text) && !string.IsNullOrEmpty(txtpwd.Text))
                {
                    string urls = "http://10.115.177.208:9091/api/User/getUserByNameAndPassword";
                    string param = "?userName=" + txtaccount.Text.Trim() + "&pwd=" + txtpwd.Text.Trim();
                    string res = HttpRequest.httpGet(urls, param, resulttomodel.token);
                    UserInfo resmodel = Newtonsoft.Json.JsonConvert.DeserializeObject<UserInfo>(res);
                    if (resmodel.success == true)
                    {
                        this.Form.CloseLoadingScreen();
                        if (resmodel.response != null)
                        {
                            LoadClientData("userinfo", Newtonsoft.Json.JsonConvert.SerializeObject(resmodel.response));
                            Toast(resmodel.response.user_name);
                        }
                        else
                        {
                           
                            Toast("用户名或密码错误！");

                        }

                    }
                    else
                    {
                        Toast("程序异常！");
                    }
                }
                else
                {
                    this.Form.CloseLoadingScreen();
                    //判断账号密码是否为空
                    if (string.IsNullOrEmpty(txtaccount.Text))
                    {
                       
                        Toast("账号不允许为空！");
                        
                    }
                    if (string.IsNullOrEmpty(txtpwd.Text))
                    {
                        
                        Toast("密码不允许为空！");
                    }
                }
            }
            else
            {
                Toast("程序异常！");
            }

            
        }

    }
}