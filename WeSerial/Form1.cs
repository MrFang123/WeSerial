using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeSerial
{
    public partial class Form1 : Form
    {
        SerialPort com = null;
        SynchronizationContext context = null;
        public Form1()
        {
            InitializeComponent();
            string[] Port = SerialPort.GetPortNames();
            for (int i = 0; i < Port.Count(); i++)
                cbx_SerialList.Items.Add(Port[i]);
            cbx_SerialList.SelectedIndex = 0;
            ArrayList date = FM1.ReadTxtToLst(System.Environment.CurrentDirectory + @"\1.FM1");
            for (int i = 0; i < date.Count; i++)
            {
                string a = date[i].ToString();
                listBox1.Items.Add( a);
            }
        }

        private void OnCmdReceived(object sender, SerialDataReceivedEventArgs e)
        {
            context.Post((o) =>
            {
                Thread.Sleep(10);
                byte[] b = new byte[com.BytesToRead];
                com.Read(b, 0, b.Count());

                for (int i = 0; i < b.Count(); i++)
                {
                    txt_Serial_Received.AppendText((b[i]).ToString("X2"));
                    txt_Serial_Received.AppendText(" ");
                    if (i == b.Count() - 1)
                        txt_Serial_Received.AppendText("\r\n\r\n");
                }
                for(int i = 0; i < listBox1.Items.Count/2; i++)
                {
                    string j = listBox1.Items[i*2].ToString();
                    j = j.Substring( 4,j.Length-4);
                    byte[] l = Cvt.HexStringToByteArray(j);
                    if (Cvt.ByteArrayEquals(l,b))
                    {
                        string k = listBox1.Items[i * 2 + 1].ToString();
                        k = k.Substring(4, k.Length-4);
                        byte[] data = Cvt.HexStringToByteArray(k);
                        com.Write(data, 0, data.Length);
                        break;
                    }
                }
            }, null);
        }

        private void btn_SerialConn_Click(object sender, EventArgs e)
        {
            if (btn_SerialConn.Text == "打开串口")
            {
                com = new SerialPort(cbx_SerialList.Text, (int)numericUpDown1.Value, Parity.None, 8, StopBits.One);
                context = SynchronizationContext.Current;
                com.DataReceived += new SerialDataReceivedEventHandler(OnCmdReceived);
                com.Open();
                btn_SerialConn.Text = "关闭串口";
            }
            else
            {
                com.Close();
                btn_SerialConn.Text = "打开串口";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] data = Cvt.HexStringToByteArray(txt_Serial_Send.Text);
            com.Write(data,0,data.Length);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Serial_Send.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_Serial_Received.Clear();
        }

        private void btn_Conn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("-->:"+txt_RetReceived.Text);
            listBox1.Items.Add("<--:"+txt_RetSend.Text);
            FM1.WriteLstToTxt(listBox1,System.Environment.CurrentDirectory + @"\1.FM1");
        }

        private void btn_DeList_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.Count-1);
            listBox1.Items.RemoveAt(listBox1.Items.Count-1);
            FM1.WriteLstToTxt(listBox1, System.Environment.CurrentDirectory + @"\1.FM1");
        }
    }
}
