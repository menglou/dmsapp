using DMS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS.ApiModel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //调用获取token接口

            //调用获取token接口
            var model = new
            {
                name = "apiuser1",
                passWord = "123456"
            };
            string url = "http://10.115.177.208:9091/api/Auth/JWTToken";
            string jsonstr = Newtonsoft.Json.JsonConvert.SerializeObject(model);

            string result = HttpRequest.GetToken(url, model.name, model.passWord);

            Token resulttomodel = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(result);

            if (resulttomodel.success == true)
            {
                //LoadClientData("token", resulttomodel.token);
                // LoadClientData("expires_in", resulttomodel.expires_in);
                //LoadClientData("logintime", DateTime.Now.ToString("yyyy-MMM-dd HH:mm:ss"));
                MessageBox.Show(resulttomodel.token);
                MessageBox.Show(resulttomodel.expires_in.ToString());
                MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                //判断账号密码是否为空
                if (string.IsNullOrEmpty(txtaccount.Text))
                {
                    MessageBox.Show("账号不允许为空！");
                }
                if (string.IsNullOrEmpty(txtpwd.Text))
                {
                    MessageBox.Show("账号不允许为空！");
                }

                if (!string.IsNullOrEmpty(txtaccount.Text) && !string.IsNullOrEmpty(txtpwd.Text))
                {
                    string urls = "http://10.115.177.208:9091/api/User/getUserByNameAndPassword";
                    string param = "?userName=" + txtaccount.Text.Trim() + "&pwd=" + txtpwd.Text.Trim();
                    string res = HttpRequest.httpGet(urls, param, resulttomodel.token);
                    UserInfo resmodel = Newtonsoft.Json.JsonConvert.DeserializeObject<UserInfo>(res);
                    
                     
                    if (resmodel.success == true)
                    {
                        if (resmodel.response != null)
                        {
                            // LoadClientData("userinfo", res);
                            MessageBox.Show(resmodel.response.user_name);
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误！");
                        }

                    }
                    else
                    {
                        MessageBox.Show("程序异常！");
                    }
                }
            }
            else
            {
                MessageBox.Show("程序异常！");
            }
        }
    }
}
