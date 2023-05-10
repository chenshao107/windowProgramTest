﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace windows_programing_curriculum_design
{
    public partial class StudentForm : Form
    {
        

        public StudentForm(int roomId)
        {
            InitializeComponent();
            _roomId = roomId; 
            _studentWaterLightForm=new StudentWaterLightForm(roomId);
            _studentWaterLightForm.Dock= DockStyle.Fill;
            _maintainForm = new MaintainForm(roomId);
            panel5.Controls.Clear();
            panel5.Controls.Add( _studentWaterLightForm );
            _studentWaterLightForm.Show();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

            
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //让该按钮的左侧panel变蓝色，其他两个变透明
            panel2.BackColor = Color.Blue;
            panel4.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //让该按钮的左侧panel变蓝色，其他两个变透明
            panel2.BackColor = Color.Transparent;
            panel4.BackColor = Color.Blue;
            panel3.BackColor = Color.Transparent;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //让该按钮的左侧panel变蓝色，其他两个变透明
            panel2.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel3.BackColor = Color.Blue;
        }
    }
}
