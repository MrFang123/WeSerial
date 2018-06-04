namespace WeSerial
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
            this.cbx_SerialList = new System.Windows.Forms.ComboBox();
            this.txt_Serial_Received = new System.Windows.Forms.TextBox();
            this.btn_SerialConn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txt_Serial_Send = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_DeList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Conn = new System.Windows.Forms.Button();
            this.txt_RetSend = new System.Windows.Forms.TextBox();
            this.txt_RetReceived = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_SerialList
            // 
            this.cbx_SerialList.FormattingEnabled = true;
            this.cbx_SerialList.Location = new System.Drawing.Point(6, 20);
            this.cbx_SerialList.Name = "cbx_SerialList";
            this.cbx_SerialList.Size = new System.Drawing.Size(121, 20);
            this.cbx_SerialList.TabIndex = 0;
            // 
            // txt_Serial_Received
            // 
            this.txt_Serial_Received.Location = new System.Drawing.Point(6, 284);
            this.txt_Serial_Received.Multiline = true;
            this.txt_Serial_Received.Name = "txt_Serial_Received";
            this.txt_Serial_Received.Size = new System.Drawing.Size(641, 180);
            this.txt_Serial_Received.TabIndex = 1;
            // 
            // btn_SerialConn
            // 
            this.btn_SerialConn.Location = new System.Drawing.Point(260, 17);
            this.btn_SerialConn.Name = "btn_SerialConn";
            this.btn_SerialConn.Size = new System.Drawing.Size(121, 23);
            this.btn_SerialConn.TabIndex = 2;
            this.btn_SerialConn.Text = "打开串口";
            this.btn_SerialConn.UseVisualStyleBackColor = true;
            this.btn_SerialConn.Click += new System.EventHandler(this.btn_SerialConn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(133, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 21);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // txt_Serial_Send
            // 
            this.txt_Serial_Send.Location = new System.Drawing.Point(8, 100);
            this.txt_Serial_Send.Multiline = true;
            this.txt_Serial_Send.Name = "txt_Serial_Send";
            this.txt_Serial_Send.Size = new System.Drawing.Size(639, 178);
            this.txt_Serial_Send.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 498);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txt_Serial_Send);
            this.tabPage1.Controls.Add(this.txt_Serial_Received);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基础功能";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "清空";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_DeList);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.btn_Conn);
            this.tabPage2.Controls.Add(this.txt_RetSend);
            this.tabPage2.Controls.Add(this.txt_RetReceived);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "自动回复设置Hex";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_DeList
            // 
            this.btn_DeList.Location = new System.Drawing.Point(662, 441);
            this.btn_DeList.Name = "btn_DeList";
            this.btn_DeList.Size = new System.Drawing.Size(75, 23);
            this.btn_DeList.TabIndex = 6;
            this.btn_DeList.Text = "删除";
            this.btn_DeList.UseVisualStyleBackColor = true;
            this.btn_DeList.Click += new System.EventHandler(this.btn_DeList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "回复:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "收到:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(8, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(731, 400);
            this.listBox1.TabIndex = 3;
            // 
            // btn_Conn
            // 
            this.btn_Conn.Location = new System.Drawing.Point(645, 6);
            this.btn_Conn.Name = "btn_Conn";
            this.btn_Conn.Size = new System.Drawing.Size(92, 48);
            this.btn_Conn.TabIndex = 2;
            this.btn_Conn.Text = "设置";
            this.btn_Conn.UseVisualStyleBackColor = true;
            this.btn_Conn.Click += new System.EventHandler(this.btn_Conn_Click);
            // 
            // txt_RetSend
            // 
            this.txt_RetSend.Location = new System.Drawing.Point(47, 33);
            this.txt_RetSend.Name = "txt_RetSend";
            this.txt_RetSend.Size = new System.Drawing.Size(592, 21);
            this.txt_RetSend.TabIndex = 1;
            // 
            // txt_RetReceived
            // 
            this.txt_RetReceived.Location = new System.Drawing.Point(47, 6);
            this.txt_RetReceived.Name = "txt_RetReceived";
            this.txt_RetReceived.Size = new System.Drawing.Size(592, 21);
            this.txt_RetReceived.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 16);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "hex";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "文本";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(41, 16);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "hex";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 16);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.Text = "文本";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(653, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 120);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Location = new System.Drawing.Point(653, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 151);
            this.panel2.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_SerialList);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.btn_SerialConn);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 91);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "串口调试助手";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_SerialList;
        private System.Windows.Forms.TextBox txt_Serial_Received;
        private System.Windows.Forms.Button btn_SerialConn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txt_Serial_Send;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Conn;
        private System.Windows.Forms.TextBox txt_RetSend;
        private System.Windows.Forms.TextBox txt_RetReceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DeList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

