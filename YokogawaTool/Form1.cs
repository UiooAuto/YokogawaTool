using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YokogawaTool
{
    public partial class Form1 : Form
    {

        SocketUtils plc;
        Thread readThread;
        public Form1()
        {
            InitializeComponent();
            this.Text = "MemobusTool v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            CheckForIllegalCrossThreadCalls = false;
        }
        public void Show(string str)
        {
            listBox1.Items.Add(DateTime.Now.ToString("HH:mm:ss.fff") + "- " + str);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        #region 界面按钮

        private void connect_Click(object sender, EventArgs e)
        {
            if (connect.Text == "连接")
            {
                plc = new SocketUtils(tb_ip.Text, int.Parse(tb_port.Text));
                bool v = plc.Connect();
                if (!v)
                {
                    Show("连接失败");
                    return;
                }
                connect.Text = "断开";
                Show("连接");
            }
            else
            {
                plc.CloseConnect();
                connect.Text = "连接";
                Show("断开");
            }
        }

        private void btn_ReadWord_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(tb_ReadWordLength.Text, out num))
            {
                if (cb_ThreadReadOpen.Checked)
                {
                    readThread = new Thread(ReadThread1);
                    readThread.IsBackground = true;
                    readThread.Start();
                    return;
                }

                if (cb_IsNotUWord.Checked)
                {
                    Show("无效操作");return;
                    /*ReadResult<Int16[]> readResult = plc.Read16(ReadAddressOffset(tb_ReadWordAddress.Text), num);

                    if (readResult.isSuccess)
                    {
                        Show(JsonConvert.SerializeObject(readResult.result));
                    }
                    else
                    {
                        Show("读取失败");
                    }*/
                }
                else
                {
                    Show("无效操作");return;
                    /*ReadResult<UInt16[]> readResult = plc.ReadU16(tb_ReadWordAddress.Text, num);

                    if (readResult.isSuccess)
                    {
                        Show(JsonConvert.SerializeObject(readResult.result));
                    }
                    else
                    {
                        Show("读取失败");
                    }*/
                }
            }
            else
            {
                if (cb_IsNotUWord.Checked)
                {
                    Show("无效操作");return;
                    /*ReadResult<Int16> readResult = plc.Read16(ReadAddressOffset(tb_ReadWordAddress.Text));
                    if (readResult.isSuccess)
                    {
                        Show(readResult.result.ToString());
                    }
                    else
                    {
                        Show("读取失败");
                    }*/
                }
                else
                {
                    ReadResult<UInt16> readResult = plc.ReadU16(ReadAddressOffset(tb_ReadWordAddress.Text));
                    if (readResult.isSuccess)
                    {
                        Show(readResult.result.ToString());
                    }
                    else
                    {
                        Show("读取失败");
                    }
                }
            }
        }

        private void btn_WriteWord_Click(object sender, EventArgs e)
        {
            bool v;

            if (tb_WriteWordValue.Text.Contains('，'))
            {
                MessageBox.Show("请使用英文逗号分隔");
                return;
            }
            if (tb_WriteWordValue.Text.Contains(','))
            {
                Show("无效操作");return;
                /*string[] strings = tb_WriteWordValue.Text.Split(',');

                if (cb_IsNotUWord.Checked)
                {
                    Int16[] int16s = new Int16[strings.Length];
                    for (int i = 0; i < strings.Length; i++)
                    {
                        int16s[i] = Int16.Parse(strings[i]);
                    }
                    Show("开始写入");
                    v = plc.Write(tb_WriteWordAddress.Text, int16s);
                }
                else
                {
                    UInt16[] uint16s = new UInt16[strings.Length];
                    for (int i = 0; i < strings.Length; i++)
                    {
                        uint16s[i] = UInt16.Parse(strings[i]);
                    }
                    Show("开始写入");
                    v = plc.Write(tb_WriteWordAddress.Text, uint16s);
                }*/
            }
            else
            {
                if (cb_IsNotUWord.Checked)
                {
                    Show("无效操作");
                    return;
                    /*Show("开始写入");
                    v = plc.Write(tb_WriteWordAddress.Text, Int16.Parse(tb_WriteWordValue.Text));*/

                }
                else
                {
                    Show("开始写入");
                    v = plc.Write(tb_WriteWordAddress.Text, UInt16.Parse(tb_WriteWordValue.Text));
                }
            }
            if (v)
            {
                Show("写入成功");
            }
            else
            {
                Show("写入失败");
            }
        }

        private void btn_ReadDWord_Click(object sender, EventArgs e)
        {

        }

        private void btn_WriteDWord_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReadString_Click(object sender, EventArgs e)
        {

        }

        private void btn_WriteString_Click(object sender, EventArgs e)
        {

        }

        private void btn_StopThreadRead_Click(object sender, EventArgs e)
        {
            if (readThread != null)
            {
                readThread.Abort();
            }
        }

        #endregion

        private void ReadThread1()
        {
            string v = ReadAddressOffset(tb_ReadWordAddress.Text);
            while (true)
            {
                ReadResult<UInt16> readResult = plc.ReadU16(v);
                if (readResult.isSuccess)
                {
                    Show(JsonConvert.SerializeObject(readResult.result));
                }
                else
                {
                    Show("读取失败");
                }
            }
        }

        private string ReadAddressOffset(string inputAdrs)
        {
            if (inputAdrs.Contains("D") || inputAdrs.Contains("d") &&
                int.Parse(inputAdrs.Substring(1)) >= int.Parse(tb_ReadOffset.Text))
            {
                int v1 = int.Parse(inputAdrs.Substring(1)) - int.Parse(tb_ReadOffset.Text);
                return "D" + v1;
            }
            else
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UInt16 a = 1;

            string cmdString = Convert.ToString(a, 16);
            /*int length = 3;
            string recStr = "1234ffff1f2f";
            UInt16[] result = new UInt16[length];
            for (int i = 0; i < length; i++)
            {
                string v = recStr.Substring((4 * i), 4).Trim();
                result[i] = Convert.ToUInt16(v, 16);
            }
            return;*/
        }
    }
}
