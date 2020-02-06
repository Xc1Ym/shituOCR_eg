using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web;

namespace shitu_eg
{
    public partial class Form1 : Form
    {
        //private string path;

        public Form1()
        {
            InitializeComponent();
            //string path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pic;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Multiselect = false;   //是否允许多选
            openDialog.Title = "请选择图片";  //窗口title
            openDialog.Filter = "图像文件|*.jpg;*.jpeg;*.bmp;*.png";   //可选择的文件类型
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pic = openDialog.FileName;
                label1.Text = "图片路径：" + pic;  //获取文件路径
                pictureBox1.ImageLocation = openDialog.FileName;//显示图片
                //string Imagefilename;
                
            }
            /*FileStream fileStream = new FileStream(pic, FileMode.Open);
            byte[] bt = new byte[fileStream.Length];
            fileStream.Read(bt, 0, bt.Length);
            string base64 = Convert.ToBase64String(bt);
            label2.Text = base64;
            */
        }

        /*
        private static string FileToBase64String(string Imagefilename)
        {
            using (FileStream filestream = new FileStream(Imagefilename, FileMode.Open))
            {
                byte[] bt = new byte[filestream.Length];

                //调用read读取方法
                filestream.Read(bt, 0, bt.Length);
                string base64Str = Convert.ToBase64String(bt);

                return base64Str;
            }
        }
        */

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版本：0.3\n制作：玉明\n","关于",MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
