﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//该类是连接数据库与软件的中间层，如果想要更换数据库，只需改写该类
//目前对接的是本地SQLlite数据库
namespace data
{
    public class Db
    {
        //利用.NET4特性，实现单例模式（懒汉模式）
        private static readonly Lazy<Db> lazy = new Lazy<Db>(() => new Db());
        public static Db Instance { get { return lazy.Value; } }

        //数据库实例构造函数
        private Db() 
        {
            SQLiteConnection m_dbConnection;
            try
            {
                //throw new NotImplementedException();
                m_dbConnection = new SQLiteConnection();
                m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                m_dbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库打开异常"+"\n"+ex.Message.ToString());
                throw ex;
            }
        }

        //测试函数
        public void Nothing()
        {
            int a = 0;
            return;
        }




    }

}
