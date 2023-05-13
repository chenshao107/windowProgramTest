using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_programing_curriculum_design
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
            //初始化三个附控件
            _rootLightWaterForm = new RootLightWaterForm();
            _rootLightWaterForm.Dock = DockStyle.Fill;
            _rootMaintainForm = new RootMaintainForm();
            _rootMaintainForm.Dock = DockStyle.Fill;
            _rootOtherForm = new RootOtherForm();
            _rootOtherForm.Dock = DockStyle.Fill;
            //初始时，选中水电窗口
            panel5.Controls.Add(_rootLightWaterForm);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //让该按钮的左侧panel变蓝色，其他两个变透明
            panel2.BackColor = Color.Blue;
            panel4.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            //将水电加载到窗口panel5中
            panel5.Controls.Clear();
            panel5.Controls.Add(_rootLightWaterForm);

        }

        private void RootForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“database2DataSet.Room”中。您可以根据需要移动或移除它。
            //this.roomTableAdapter.Fill(this.database2DataSet.Room);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //让该按钮的左侧panel变蓝色，其他两个变透明
            panel2.BackColor = Color.Transparent;
            panel4.BackColor = Color.Blue;
            panel3.BackColor = Color.Transparent;
            //将报修加载到窗口panel5中
            panel5.Controls.Clear();
            panel5.Controls.Add(_rootMaintainForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //让该按钮的左侧panel变蓝色，其他两个变透明
            panel2.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel3.BackColor = Color.Blue;
            //将其他加载到窗口panel5中
            panel5.Controls.Clear();
            panel5.Controls.Add(_rootOtherForm);
        }
    }
}
