using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using data;

namespace windows_programing_curriculum_design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //m_dbConnection.Open();
            //string sql = "select * from highscores order by score desc";
            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //SQLiteDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //    this.textBox1.AppendText("Name: " + reader["name"] + "\tScore: " + reader["score"]+"\n");

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //设计废案
            //Console.WriteLine(e.X.ToString()+e.Y.ToString());
            //System.Diagnostics.Debug.WriteLine(e.X.ToString()+"," + e.Y.ToString());
            

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //设计废案
            MouseEventArgs ee = new MouseEventArgs(e.Button,e.Clicks
                ,e.X
                ,e.Y
                ,e.Delta);
            //this.Form1_MouseMove(this,ee);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //登录按钮，校验账号和密码
            User a =Db.verify(accountTextBox.Text,passwordTextBox.Text);
            
            if (a != null)
            {
                //隐藏登录界面
                this.Hide();
                if(a.A==0)
                {
                    //创建管理员界面
                    RootForm roomForm= new RootForm();
                    //阻塞运行窗口，直到退出
                    roomForm.ShowDialog();
                }else
                {
                    //创建学生窗口
                    StudentForm studentForm= new StudentForm(Convert.ToInt32(accountTextBox.Text));
                    //阻塞运行窗口，直到退出
                    studentForm.ShowDialog();
                    
                }
                //重新展示登录界面
                this.Show();
            }
            else
            {
                tipLinkLabel.Text="账号或者密码错误！";
            }


        }

        


        private void passwordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        protected override CreateParams CreateParams

        {

            get

            {

                CreateParams cp = base.CreateParams;

                cp.ExStyle |= 0x02000000;

                return cp;

            }
        }
    }
}
