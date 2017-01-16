using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string Image_BaseDirectory =  AppDomain.CurrentDomain.BaseDirectory + "images\\";
        public Image FromFile(string filepath)
        {
            return Image.FromFile(filepath);
        }

        private List<RoomConsume> _roomConsumeList = new List<RoomConsume>();

        private void Form3_Load(object sender, EventArgs e)
        {
            //ShowRoomConsumeItems();
            labelPrice.Text = "0.00";

            RoomConsume room_consume = new RoomConsume();
            room_consume.Name = "1百岁山矿泉水";
            room_consume.Price = "10.0";
            room_consume.Unit = "瓶";
            room_consume.Number = 0;
            _roomConsumeList.Add(room_consume);

            room_consume = new RoomConsume();
            room_consume.Name = "2统一方便面";
            room_consume.Price = "15.0";
            room_consume.Unit = "桶";
            room_consume.Number = 0;
            _roomConsumeList.Add(room_consume);

            room_consume = new RoomConsume();
            room_consume.Name = "3王师傅夹心饼干";
            room_consume.Price = "25.0";
            room_consume.Unit = "个";
            room_consume.Number = 0;
            _roomConsumeList.Add(room_consume);

            room_consume = new RoomConsume();
            room_consume.Name = "4可口可乐";
            room_consume.Price = "5.0";
            room_consume.Unit = "灌";
            room_consume.Number = 0;
            _roomConsumeList.Add(room_consume);

            room_consume = new RoomConsume();
            room_consume.Name = "5健脾口香糖";
            room_consume.Price = "3.0";
            room_consume.Unit = "片";
            room_consume.Number = 0;
            _roomConsumeList.Add(room_consume);

            room_consume = new RoomConsume();
            room_consume.Name = "6超薄套套";
            room_consume.Price = "30.0";
            room_consume.Unit = "2片";
            room_consume.Number = 0;
            _roomConsumeList.Add(room_consume);

            room_consume = new RoomConsume();
            room_consume.Name = "7统一方便面2";
            room_consume.Price = "15.0";
            room_consume.Unit = "桶";
            room_consume.Number = 0;
            _roomConsumeList.Add(room_consume);

            room_consume = new RoomConsume();
            room_consume.Name = "8王师傅夹心饼干2";
            room_consume.Price = "25.0";
            room_consume.Unit = "个";
            room_consume.Number = 0;
            _roomConsumeList.Add(room_consume);

            room_consume = new RoomConsume();
            room_consume.Name = "9可口可乐2";
            room_consume.Price = "5.0";
            room_consume.Unit = "灌";
            room_consume.Number = 0;
            _roomConsumeList.Add(room_consume);

            room_consume = new RoomConsume();
            room_consume.Name = "10健脾口香糖2";
            room_consume.Price = "3.0";
            room_consume.Unit = "片";
            room_consume.Number = 0;
            _roomConsumeList.Add(room_consume);

            room_consume = new RoomConsume();
            room_consume.Name = "11超薄套套2";
            room_consume.Price = "30.0";
            room_consume.Unit = "2片";
            room_consume.Number = 0;
            _roomConsumeList.Add(room_consume);

            //ShowRoomConsumeItemsData();
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void ShowRoomConsumeItems()
        {
            this.SuspendLayout();

            // 左箭头
            Panel panelLeft = new Panel();
            panelLeft.BackColor = System.Drawing.Color.Transparent;
            panelLeft.BackgroundImage = FromFile(Image_BaseDirectory + "左箭头.png");
            panelLeft.Location = new System.Drawing.Point(18, 113);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new System.Drawing.Size(12, 23);

            Panel panel0 = new Panel();
            panel0.BackColor = System.Drawing.Color.Transparent;
            panel0.Location = new System.Drawing.Point(3, 3);
            panel0.Name = "panel1";
            panel0.Size = new System.Drawing.Size(55, 252);
            // add control for panel1
            panel0.Controls.Add(panelLeft);

            // 第1个消费项目
            Panel panel1 = new Panel();
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Location = new System.Drawing.Point(64, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(170, 252);

            // first panel
            Panel panel1_1 = new Panel();
            panel1_1.BackgroundImage = FromFile(Image_BaseDirectory + "商品背景.png"); 
            panel1_1.Location = new System.Drawing.Point(12, 59);
            panel1_1.Name = "panel1_1";
            panel1_1.Size = new System.Drawing.Size(136, 92);

            // 消费项目名称
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(15, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 16);
            label1.Text = "百岁山矿泉水";

            // 消费项目的价格及单位
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(39, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 16);
            label2.Text = "10/瓶";

            panel1_1.Controls.Add(label1);
            panel1_1.Controls.Add(label2);

            // second panel
            Panel panel1_2 = new Panel();
            panel1_2.BackgroundImage = FromFile(Image_BaseDirectory + "减.png");
            panel1_2.Location = new System.Drawing.Point(15, 183);
            panel1_2.Name = "panel1_2";
            panel1_2.Size = new System.Drawing.Size(38, 38);

            // third panel
            Panel panel1_3 = new Panel();
            panel1_3.BackgroundImage = FromFile(Image_BaseDirectory + "加.png");
            panel1_3.Location = new System.Drawing.Point(113, 183);
            panel1_3.Name = "panel1_3";
            panel1_3.Size = new System.Drawing.Size(38, 38);

            // item number
            Label label3 = new Label();
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(72, 189);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(26, 27);
            label3.Text = "1";

            // add control for panel2
            panel1.Controls.Add(panel1_1);
            panel1.Controls.Add(panel1_2);
            panel1.Controls.Add(panel1_3);
            panel1.Controls.Add(label3);

            // 第2个消费项目
            // 第3个消费项目
            // 第4个消费项目
            // 第5个消费项目

            // 右箭头
            Panel panelRight = new Panel();
            panelRight.BackColor = System.Drawing.Color.Transparent;
            panelRight.BackgroundImage = FromFile(Image_BaseDirectory + "右箭头.png");
            panelRight.Location = new System.Drawing.Point(18, 113);
            panelRight.Name = "panelRight";
            panelRight.Size = new System.Drawing.Size(12, 23);

            Panel panel6 = new Panel();
            panel6.BackColor = System.Drawing.Color.Transparent;
            panel6.Location = new System.Drawing.Point(944, 3);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(55, 252);
            // add control for panel1
            panel6.Controls.Add(panelRight);

            // add control for flowLayoutPanel1
            this.flowLayoutPanel1.Controls.Add(panel0);
            this.flowLayoutPanel1.Controls.Add(panel1);
            this.flowLayoutPanel1.Controls.Add(panel6);

            this.ResumeLayout();
        }

        private async Task ShowRoomConsumeItemsData(int start, int end)
        {
            // 获取当前需要显示的消费项
            List<RoomConsume> data = GetData(start, end);
            if (data == null || data.Count == 0)
            {
                return;
            }
            flowLayoutPanel1.Controls.Clear();

            this.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();

            // 左箭头
            Panel panel0 = new Panel();
            panel0.BackColor = System.Drawing.Color.Transparent;
            panel0.Location = new System.Drawing.Point(3, 3);
            panel0.Name = "panel00";
            panel0.Size = new System.Drawing.Size(55, 252);

            if (_roomConsumeList.Count > 5 && start > 0)
            {
                Panel panelLeft = new Panel();
                panelLeft.BackColor = System.Drawing.Color.Transparent;
                panelLeft.BackgroundImage = FromFile(Image_BaseDirectory + "左箭头.png");
                panelLeft.Location = new System.Drawing.Point(18, 113);
                panelLeft.Name = "panelLeft";
                panelLeft.Size = new System.Drawing.Size(12, 23);
                panelLeft.Click += new System.EventHandler(panelLeft_Click);

                // add control
                panel0.Controls.Add(panelLeft);
                panel0.Click += new System.EventHandler(panel0_Click);
            }
            // add control for flowLayoutPanel1
            this.flowLayoutPanel1.Controls.Add(panel0);

            // 消费项目
            Panel panel = null;
            int location_x = 64;
            int index = 0;
            for (int i = 0; i < data.Count; i++)
            {
                index = start + i;
                RoomConsume roomConsume = _roomConsumeList[index];

                // 第1个消费项目
                panel = new Panel();
                panel.BackColor = System.Drawing.Color.Transparent;
                panel.Location = new System.Drawing.Point(location_x, 3);
                panel.Name = "panel" + index;
                panel.Size = new System.Drawing.Size(170, 252);

                // first panel
                Panel panel1 = new Panel();
                panel1.BackgroundImage = FromFile(Image_BaseDirectory + "商品背景.png");
                panel1.Location = new System.Drawing.Point(12, 59);
                panel1.Name = "panel1_" + index;
                panel1.Size = new System.Drawing.Size(136, 92);

                // 消费项目名称
                Label label1 = new Label();
                label1.AutoSize = false;
                label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                label1.ForeColor = System.Drawing.Color.White;
                label1.Location = new System.Drawing.Point(3, 22);
                label1.Name = "labelName_" + index;
                label1.Size = new System.Drawing.Size(130, 16);
                label1.Text = roomConsume.Name;
                label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                // 消费项目的价格及单位
                Label label2 = new Label();
                label2.AutoSize = false;
                label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                label2.ForeColor = System.Drawing.Color.White;
                label2.Location = new System.Drawing.Point(3, 55);
                label2.Name = "labelPrice_" + index;
                label2.Size = new System.Drawing.Size(130, 16);
                label2.Text = roomConsume.Price + "/" + roomConsume.Unit;
                label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                panel1.Controls.Add(label1);
                panel1.Controls.Add(label2);

                // second panel
                Panel panel2 = new Panel();
                panel2.BackgroundImage = FromFile(Image_BaseDirectory + "减.png");
                panel2.Location = new System.Drawing.Point(15, 183);
                panel2.Name = "panel2_" + index;
                panel2.Size = new System.Drawing.Size(38, 38);
                panel2.Click += new EventHandler(panelNum_Minus_Click);

                // third panel
                Panel panel3 = new Panel();
                panel3.BackgroundImage = FromFile(Image_BaseDirectory + "加.png");
                panel3.Location = new System.Drawing.Point(113, 183);
                panel3.Name = "panel3_" + index;
                panel3.Size = new System.Drawing.Size(38, 38);
                panel3.Click += new EventHandler(panelNum_Plus_Click);

                // item number
                Label label3 = new Label();
                label3.AutoSize = true;
                label3.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                label3.ForeColor = System.Drawing.Color.White;
                label3.Location = new System.Drawing.Point(72, 189);
                label3.Name = "labelNum_" + index;
                label3.Size = new System.Drawing.Size(26, 27);
                label3.Text = roomConsume.Number + "";
                label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                // add control for panel2
                panel.Controls.Add(panel1);
                panel.Controls.Add(panel2);
                panel.Controls.Add(panel3);
                panel.Controls.Add(label3);

                location_x += 176;

                this.flowLayoutPanel1.Controls.Add(panel);
            }

            location_x += 176;

            // 右箭头
            Panel panel6 = new Panel();
            panel6.BackColor = System.Drawing.Color.Transparent;
            panel6.Location = new System.Drawing.Point(location_x, 3);
            panel6.Name = "panel66";
            panel6.Size = new System.Drawing.Size(55, 252);
            if (_roomConsumeList.Count > 5 && end < _roomConsumeList.Count)
            {
                Panel panelRight = new Panel();
                panelRight.BackColor = System.Drawing.Color.Transparent;
                panelRight.BackgroundImage = FromFile(Image_BaseDirectory + "右箭头.png");
                panelRight.Location = new System.Drawing.Point(18, 113);
                panelRight.Name = "panelRight";
                panelRight.Size = new System.Drawing.Size(12, 23);
                panelRight.Click += new EventHandler(panelRight_Click);

                // add control
                panel6.Controls.Add(panelRight);
                panel6.Click += new EventHandler(panel6_Click);
            }
            this.flowLayoutPanel1.Controls.Add(panel6);

            flowLayoutPanel1.ResumeLayout();
            this.ResumeLayout();

            await Task.Delay(100);
        }

        private async void panel0_Click(object sender, EventArgs e)
        {
            await MoveDataLeft(); 
        }

        private async void panelLeft_Click(object sender, EventArgs e)
        {
            await MoveDataLeft();
        }

        private async void panel6_Click(object sender, EventArgs e)
        {
            await MoveDataRight();
        }

        private async void panelRight_Click(object sender, EventArgs e)
        {
            await MoveDataRight();
        }

        int start = 0;
        private async Task MoveDataLeft()
        {
            try
            {
                if (end == _roomConsumeList.Count)
                {
                    end = start;
                }
                else
                {
                    end = end - pageShowDataCount;
                }

                start = start - pageShowDataCount;
                if (start <= 0 )
                {
                    start = 0;
                }

                await ShowRoomConsumeItemsData(start, end);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
        }

        // 每页显示的数据条数
        int pageShowDataCount = 5;

        int end = 5;
        private async Task MoveDataRight()
        {
            try
            {
                start = start + pageShowDataCount;
                end = end + pageShowDataCount;
                if (end >= _roomConsumeList.Count)
                {
                    end = _roomConsumeList.Count;
                }

                await ShowRoomConsumeItemsData(start, end);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
            
        }

        /// <summary>
        /// 减
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelNum_Minus_Click(object sender, EventArgs e)
        {
            // panel控件的名字
            Panel panel = sender as Panel;
            string panelName = panel.Name;

            int index = Convert.ToInt32(panelName.Split('_')[1]);
            RoomConsume consume = this._roomConsumeList[index];

            // label控件的名字
            string id = "labelNum_" + index;
            Label labelRoom = (Label)this.Controls.Find(id, true)[0];
            int count = Convert.ToInt32(labelRoom.Text);
            if (count == 0)
            {
                return;
            }
            labelRoom.Text = count - 1 + "";

            consume.Number = Convert.ToInt32(labelRoom.Text);
            _roomConsumeList.Remove(consume);
            _roomConsumeList.Insert(index, consume);

            double totle_price = Convert.ToDouble(this.labelPrice.Text) - Convert.ToDouble(consume.Price);
            this.labelPrice.Text = totle_price.ToString("0.00");
        }

        /// <summary>
        /// 加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelNum_Plus_Click(object sender, EventArgs e)
        {
            // panel控件的名字
            Panel panel = sender as Panel;
            string panelName = panel.Name;

            int index = Convert.ToInt32(panelName.Split('_')[1]);
            RoomConsume consume = this._roomConsumeList[index];

            // label控件的名字
            string id = "labelNum_" + index;
            Label labelRoom = (Label)this.Controls.Find(id, true)[0];
            int count = Convert.ToInt32(labelRoom.Text);
            labelRoom.Text = count + 1 + "";

            consume.Number = Convert.ToInt32(labelRoom.Text);
            _roomConsumeList.Remove(consume);
            _roomConsumeList.Insert(index, consume);

            double totle_price = Convert.ToDouble(this.labelPrice.Text) + Convert.ToDouble(consume.Price);
            this.labelPrice.Text = totle_price.ToString("0.00");
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            await ShowRoomConsumeItemsData(0, 5);
        }

        private List<RoomConsume> GetData(int start, int end)
        {
            List<RoomConsume> data = new List<RoomConsume>();

            if (_roomConsumeList != null && _roomConsumeList.Count <= 5)
            {
                return _roomConsumeList;
            }
            else
            {
                int i = start;
                for (; i < end; i++)
                {
                    data.Add(_roomConsumeList[i]);
                }
            }
            return data;
        }
    }
}
