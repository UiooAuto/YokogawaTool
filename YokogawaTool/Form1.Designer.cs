namespace YokogawaTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.btn_WriteString = new System.Windows.Forms.Button();
            this.btn_ReadString = new System.Windows.Forms.Button();
            this.tb_WriteString = new System.Windows.Forms.TextBox();
            this.tb_WriteStringAddress = new System.Windows.Forms.TextBox();
            this.tb_ReadStringLength = new System.Windows.Forms.TextBox();
            this.tb_ReadStringAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_WriteOffset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ReadOffset = new System.Windows.Forms.TextBox();
            this.btn_StopThreadRead = new System.Windows.Forms.Button();
            this.cb_ThreadReadOpen = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_IsNotUDWord = new System.Windows.Forms.CheckBox();
            this.cb_IsNotUWord = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_WriteDWord = new System.Windows.Forms.Button();
            this.btn_ReadDWord = new System.Windows.Forms.Button();
            this.tb_WriteDWordValue = new System.Windows.Forms.TextBox();
            this.tb_WriteDWordAddress = new System.Windows.Forms.TextBox();
            this.tb_ReadDWordLength = new System.Windows.Forms.TextBox();
            this.tb_ReadDWordAddress = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_WriteWord = new System.Windows.Forms.Button();
            this.btn_ReadWord = new System.Windows.Forms.Button();
            this.tb_WriteWordValue = new System.Windows.Forms.TextBox();
            this.tb_WriteWordAddress = new System.Windows.Forms.TextBox();
            this.tb_ReadWordLength = new System.Windows.Forms.TextBox();
            this.tb_ReadWordAddress = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(13, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(618, 1);
            this.label10.TabIndex = 127;
            this.label10.Text = "label10";
            // 
            // btn_WriteString
            // 
            this.btn_WriteString.Enabled = false;
            this.btn_WriteString.Location = new System.Drawing.Point(536, 282);
            this.btn_WriteString.Name = "btn_WriteString";
            this.btn_WriteString.Size = new System.Drawing.Size(93, 23);
            this.btn_WriteString.TabIndex = 126;
            this.btn_WriteString.Text = "写入字符串";
            this.btn_WriteString.UseVisualStyleBackColor = true;
            this.btn_WriteString.Click += new System.EventHandler(this.btn_WriteString_Click);
            // 
            // btn_ReadString
            // 
            this.btn_ReadString.Enabled = false;
            this.btn_ReadString.Location = new System.Drawing.Point(536, 244);
            this.btn_ReadString.Name = "btn_ReadString";
            this.btn_ReadString.Size = new System.Drawing.Size(93, 23);
            this.btn_ReadString.TabIndex = 125;
            this.btn_ReadString.Text = "读取字符串";
            this.btn_ReadString.UseVisualStyleBackColor = true;
            this.btn_ReadString.Click += new System.EventHandler(this.btn_ReadString_Click);
            // 
            // tb_WriteString
            // 
            this.tb_WriteString.Location = new System.Drawing.Point(136, 282);
            this.tb_WriteString.Name = "tb_WriteString";
            this.tb_WriteString.Size = new System.Drawing.Size(312, 21);
            this.tb_WriteString.TabIndex = 124;
            // 
            // tb_WriteStringAddress
            // 
            this.tb_WriteStringAddress.Location = new System.Drawing.Point(13, 282);
            this.tb_WriteStringAddress.Name = "tb_WriteStringAddress";
            this.tb_WriteStringAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_WriteStringAddress.TabIndex = 123;
            this.tb_WriteStringAddress.Text = "m100";
            // 
            // tb_ReadStringLength
            // 
            this.tb_ReadStringLength.Enabled = false;
            this.tb_ReadStringLength.Location = new System.Drawing.Point(136, 244);
            this.tb_ReadStringLength.Name = "tb_ReadStringLength";
            this.tb_ReadStringLength.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadStringLength.TabIndex = 122;
            // 
            // tb_ReadStringAddress
            // 
            this.tb_ReadStringAddress.Location = new System.Drawing.Point(13, 244);
            this.tb_ReadStringAddress.Name = "tb_ReadStringAddress";
            this.tb_ReadStringAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadStringAddress.TabIndex = 121;
            this.tb_ReadStringAddress.Text = "m0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 118;
            this.label8.Text = "读PLC地址偏移";
            // 
            // tb_WriteOffset
            // 
            this.tb_WriteOffset.Location = new System.Drawing.Point(312, 329);
            this.tb_WriteOffset.Name = "tb_WriteOffset";
            this.tb_WriteOffset.Size = new System.Drawing.Size(100, 21);
            this.tb_WriteOffset.TabIndex = 117;
            this.tb_WriteOffset.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 116;
            this.label1.Text = "读PLC地址偏移";
            // 
            // tb_ReadOffset
            // 
            this.tb_ReadOffset.Location = new System.Drawing.Point(99, 329);
            this.tb_ReadOffset.Name = "tb_ReadOffset";
            this.tb_ReadOffset.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadOffset.TabIndex = 115;
            this.tb_ReadOffset.Text = "0";
            // 
            // btn_StopThreadRead
            // 
            this.btn_StopThreadRead.Location = new System.Drawing.Point(536, 328);
            this.btn_StopThreadRead.Name = "btn_StopThreadRead";
            this.btn_StopThreadRead.Size = new System.Drawing.Size(93, 23);
            this.btn_StopThreadRead.TabIndex = 114;
            this.btn_StopThreadRead.Text = "停止线程";
            this.btn_StopThreadRead.UseVisualStyleBackColor = true;
            this.btn_StopThreadRead.Click += new System.EventHandler(this.btn_StopThreadRead_Click);
            // 
            // cb_ThreadReadOpen
            // 
            this.cb_ThreadReadOpen.AutoSize = true;
            this.cb_ThreadReadOpen.Location = new System.Drawing.Point(470, 332);
            this.cb_ThreadReadOpen.Name = "cb_ThreadReadOpen";
            this.cb_ThreadReadOpen.Size = new System.Drawing.Size(60, 16);
            this.cb_ThreadReadOpen.TabIndex = 113;
            this.cb_ThreadReadOpen.Text = "线程读";
            this.cb_ThreadReadOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_ThreadReadOpen.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(11, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(618, 1);
            this.label7.TabIndex = 112;
            this.label7.Text = "label7";
            // 
            // cb_IsNotUDWord
            // 
            this.cb_IsNotUDWord.AutoSize = true;
            this.cb_IsNotUDWord.Enabled = false;
            this.cb_IsNotUDWord.Location = new System.Drawing.Point(260, 164);
            this.cb_IsNotUDWord.Name = "cb_IsNotUDWord";
            this.cb_IsNotUDWord.Size = new System.Drawing.Size(60, 16);
            this.cb_IsNotUDWord.TabIndex = 111;
            this.cb_IsNotUDWord.Text = "有符号";
            this.cb_IsNotUDWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_IsNotUDWord.UseVisualStyleBackColor = true;
            // 
            // cb_IsNotUWord
            // 
            this.cb_IsNotUWord.AutoSize = true;
            this.cb_IsNotUWord.Enabled = false;
            this.cb_IsNotUWord.Location = new System.Drawing.Point(260, 80);
            this.cb_IsNotUWord.Name = "cb_IsNotUWord";
            this.cb_IsNotUWord.Size = new System.Drawing.Size(60, 16);
            this.cb_IsNotUWord.TabIndex = 110;
            this.cb_IsNotUWord.Text = "有符号";
            this.cb_IsNotUWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_IsNotUWord.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 107;
            this.label5.Text = "端口";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 106;
            this.label4.Text = "IP";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(618, 1);
            this.label3.TabIndex = 105;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(618, 1);
            this.label2.TabIndex = 104;
            this.label2.Text = "label2";
            // 
            // btn_WriteDWord
            // 
            this.btn_WriteDWord.Enabled = false;
            this.btn_WriteDWord.Location = new System.Drawing.Point(536, 199);
            this.btn_WriteDWord.Name = "btn_WriteDWord";
            this.btn_WriteDWord.Size = new System.Drawing.Size(93, 23);
            this.btn_WriteDWord.TabIndex = 103;
            this.btn_WriteDWord.Text = "写入DWord(32)";
            this.btn_WriteDWord.UseVisualStyleBackColor = true;
            this.btn_WriteDWord.Click += new System.EventHandler(this.btn_WriteDWord_Click);
            // 
            // btn_ReadDWord
            // 
            this.btn_ReadDWord.Enabled = false;
            this.btn_ReadDWord.Location = new System.Drawing.Point(536, 161);
            this.btn_ReadDWord.Name = "btn_ReadDWord";
            this.btn_ReadDWord.Size = new System.Drawing.Size(93, 23);
            this.btn_ReadDWord.TabIndex = 102;
            this.btn_ReadDWord.Text = "读取DWord(32)";
            this.btn_ReadDWord.UseVisualStyleBackColor = true;
            this.btn_ReadDWord.Click += new System.EventHandler(this.btn_ReadDWord_Click);
            // 
            // tb_WriteDWordValue
            // 
            this.tb_WriteDWordValue.Location = new System.Drawing.Point(136, 199);
            this.tb_WriteDWordValue.Name = "tb_WriteDWordValue";
            this.tb_WriteDWordValue.Size = new System.Drawing.Size(312, 21);
            this.tb_WriteDWordValue.TabIndex = 101;
            // 
            // tb_WriteDWordAddress
            // 
            this.tb_WriteDWordAddress.Location = new System.Drawing.Point(13, 199);
            this.tb_WriteDWordAddress.Name = "tb_WriteDWordAddress";
            this.tb_WriteDWordAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_WriteDWordAddress.TabIndex = 100;
            this.tb_WriteDWordAddress.Text = "m100";
            // 
            // tb_ReadDWordLength
            // 
            this.tb_ReadDWordLength.Enabled = false;
            this.tb_ReadDWordLength.Location = new System.Drawing.Point(136, 161);
            this.tb_ReadDWordLength.Name = "tb_ReadDWordLength";
            this.tb_ReadDWordLength.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadDWordLength.TabIndex = 99;
            // 
            // tb_ReadDWordAddress
            // 
            this.tb_ReadDWordAddress.Location = new System.Drawing.Point(13, 161);
            this.tb_ReadDWordAddress.Name = "tb_ReadDWordAddress";
            this.tb_ReadDWordAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadDWordAddress.TabIndex = 98;
            this.tb_ReadDWordAddress.Text = "m0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(13, 358);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(616, 376);
            this.listBox1.TabIndex = 97;
            // 
            // btn_WriteWord
            // 
            this.btn_WriteWord.Location = new System.Drawing.Point(536, 115);
            this.btn_WriteWord.Name = "btn_WriteWord";
            this.btn_WriteWord.Size = new System.Drawing.Size(93, 23);
            this.btn_WriteWord.TabIndex = 96;
            this.btn_WriteWord.Text = "写入Word(16)";
            this.btn_WriteWord.UseVisualStyleBackColor = true;
            this.btn_WriteWord.Click += new System.EventHandler(this.btn_WriteWord_Click);
            // 
            // btn_ReadWord
            // 
            this.btn_ReadWord.Location = new System.Drawing.Point(536, 77);
            this.btn_ReadWord.Name = "btn_ReadWord";
            this.btn_ReadWord.Size = new System.Drawing.Size(93, 23);
            this.btn_ReadWord.TabIndex = 95;
            this.btn_ReadWord.Text = "读取Word(16)";
            this.btn_ReadWord.UseVisualStyleBackColor = true;
            this.btn_ReadWord.Click += new System.EventHandler(this.btn_ReadWord_Click);
            // 
            // tb_WriteWordValue
            // 
            this.tb_WriteWordValue.Location = new System.Drawing.Point(136, 115);
            this.tb_WriteWordValue.Name = "tb_WriteWordValue";
            this.tb_WriteWordValue.Size = new System.Drawing.Size(312, 21);
            this.tb_WriteWordValue.TabIndex = 94;
            // 
            // tb_WriteWordAddress
            // 
            this.tb_WriteWordAddress.Location = new System.Drawing.Point(13, 115);
            this.tb_WriteWordAddress.Name = "tb_WriteWordAddress";
            this.tb_WriteWordAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_WriteWordAddress.TabIndex = 93;
            this.tb_WriteWordAddress.Text = "D";
            // 
            // tb_ReadWordLength
            // 
            this.tb_ReadWordLength.Location = new System.Drawing.Point(136, 77);
            this.tb_ReadWordLength.Name = "tb_ReadWordLength";
            this.tb_ReadWordLength.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadWordLength.TabIndex = 92;
            this.tb_ReadWordLength.Text = "50";
            // 
            // tb_ReadWordAddress
            // 
            this.tb_ReadWordAddress.Location = new System.Drawing.Point(13, 77);
            this.tb_ReadWordAddress.Name = "tb_ReadWordAddress";
            this.tb_ReadWordAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadWordAddress.TabIndex = 91;
            this.tb_ReadWordAddress.Text = "D1300";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(136, 27);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 21);
            this.tb_port.TabIndex = 90;
            this.tb_port.Text = "12289";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(13, 27);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(100, 21);
            this.tb_ip.TabIndex = 89;
            this.tb_ip.Text = "192.168.0.2";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(536, 25);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(93, 23);
            this.connect.TabIndex = 88;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 128;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_WriteString);
            this.Controls.Add(this.btn_ReadString);
            this.Controls.Add(this.tb_WriteString);
            this.Controls.Add(this.tb_WriteStringAddress);
            this.Controls.Add(this.tb_ReadStringLength);
            this.Controls.Add(this.tb_ReadStringAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_WriteOffset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ReadOffset);
            this.Controls.Add(this.btn_StopThreadRead);
            this.Controls.Add(this.cb_ThreadReadOpen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_IsNotUDWord);
            this.Controls.Add(this.cb_IsNotUWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_WriteDWord);
            this.Controls.Add(this.btn_ReadDWord);
            this.Controls.Add(this.tb_WriteDWordValue);
            this.Controls.Add(this.tb_WriteDWordAddress);
            this.Controls.Add(this.tb_ReadDWordLength);
            this.Controls.Add(this.tb_ReadDWordAddress);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_WriteWord);
            this.Controls.Add(this.btn_ReadWord);
            this.Controls.Add(this.tb_WriteWordValue);
            this.Controls.Add(this.tb_WriteWordAddress);
            this.Controls.Add(this.tb_ReadWordLength);
            this.Controls.Add(this.tb_ReadWordAddress);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Yokogawa Connect Tool v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_WriteString;
        private System.Windows.Forms.Button btn_ReadString;
        private System.Windows.Forms.TextBox tb_WriteString;
        private System.Windows.Forms.TextBox tb_WriteStringAddress;
        private System.Windows.Forms.TextBox tb_ReadStringLength;
        private System.Windows.Forms.TextBox tb_ReadStringAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_WriteOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ReadOffset;
        private System.Windows.Forms.Button btn_StopThreadRead;
        private System.Windows.Forms.CheckBox cb_ThreadReadOpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_IsNotUDWord;
        private System.Windows.Forms.CheckBox cb_IsNotUWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_WriteDWord;
        private System.Windows.Forms.Button btn_ReadDWord;
        private System.Windows.Forms.TextBox tb_WriteDWordValue;
        private System.Windows.Forms.TextBox tb_WriteDWordAddress;
        private System.Windows.Forms.TextBox tb_ReadDWordLength;
        private System.Windows.Forms.TextBox tb_ReadDWordAddress;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_WriteWord;
        private System.Windows.Forms.Button btn_ReadWord;
        private System.Windows.Forms.TextBox tb_WriteWordValue;
        private System.Windows.Forms.TextBox tb_WriteWordAddress;
        private System.Windows.Forms.TextBox tb_ReadWordLength;
        private System.Windows.Forms.TextBox tb_ReadWordAddress;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button button1;
    }
}

