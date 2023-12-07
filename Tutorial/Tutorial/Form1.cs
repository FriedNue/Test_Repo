using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    public partial class Form1 : Form
    {
        struct Tutorial_ImageDB
        {
            public Image Tutorial_Image;
        }
        Tutorial_ImageDB[] ImageDB = new Tutorial_ImageDB[8]; // �̹��� ����� ���Ǽ���

        public void Tuto_Iamge()
        {
            ImageDB[0].Tutorial_Image = Properties.Resources.TTI1;
            ImageDB[1].Tutorial_Image = Properties.Resources.TTI2;
            ImageDB[2].Tutorial_Image = Properties.Resources.TTI3;
            ImageDB[3].Tutorial_Image = Properties.Resources.TTI4;
            ImageDB[4].Tutorial_Image = Properties.Resources.TTI5;
            ImageDB[5].Tutorial_Image = Properties.Resources.TTI6;
            ImageDB[6].Tutorial_Image = Properties.Resources.TTI7;
            ImageDB[7].Tutorial_Image = Properties.Resources.TTI8;

        }
        public Form1()
        {
            InitializeComponent();
        }

        public int Page_count = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            //������ ī��Ʈ�� 1�϶� ��ư1�� ��Ȱ��ȭ
            if (Page_count == 1) { button1.Enabled = false; }
            pictureBox1.Image = Properties.Resources.TTI1;
            //������ ����
            label1.Text = "���� ȭ���� �˾ƺ���!";
            //������ ��
            label2.Text = Page_count + " / 8";
        }

        public void Page_Image()
        {
            // �������� ���� �̹��� ȣ��
            if (Page_count == 1)
            {
                pictureBox1.Image = Properties.Resources.TTI1;
                label1.Text = "���� ȭ���� �˾ƺ���!"; // ī�� ����
                label2.Text = Page_count + " / 8"; // ������ ��
            }
            if (Page_count == 2)
            {
                pictureBox1.Image = Properties.Resources.TTI2;
                label1.Text = "ī�带 �̾ƺ���!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 3)
            {
                pictureBox1.Image = Properties.Resources.TTI3;
                label1.Text = "ī�带 ��ġ�غ���!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 4)
            {
                pictureBox1.Image = Properties.Resources.TTI4;
                label1.Text = "���� ī�带 ����غ���!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 5)
            {
                pictureBox1.Image = Properties.Resources.TTI5;
                label1.Text = "ī�带 ��������!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 6)
            {
                pictureBox1.Image = Properties.Resources.TTI6;
                label1.Text = "������ ���� �˾ƺ���(1)!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 7)
            {
                pictureBox1.Image = Properties.Resources.TTI7;
                label1.Text = "������ ���� �˾ƺ���(2)!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 8)
            {
                pictureBox1.Image = Properties.Resources.TTI8;
                label1.Text = "������ ���� ��ǥ!";
                label2.Text = Page_count + " / 8";
            }


        }
        public void Button_Click()
        {
            //������ ī��Ʈ�� 1�϶� ��ư1 ��Ȱ��ȭ
            if (Page_count == 1) { button1.Enabled = false; }
            else { button1.Enabled = true; }
            //������ ī��Ʈ�� 8�϶� ��ư2 ��Ȱ��ȭ
            if (Page_count == 8) { button2.Enabled = false; }
            else { button2.Enabled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //��ư Ŭ���� ������ī��Ʈ�� 0�� 8�����Ͻ�
            //������ī��Ʈ ����
            if (Page_count > 0 && Page_count <= 8) { Page_count--; }
            Button_Click();
            Page_Image();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //��ư Ŭ���� ������ī��Ʈ�� 0�� 8�����Ͻ�
            //������ī��Ʈ ����
            if (Page_count > 0 && Page_count <= 8) { Page_count++; }
            Button_Click();
            Page_Image();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //��ŵ��ư Ŭ���� ������ �޽��� �ڽ�
            if(MessageBox.Show("��ŵ �Ͻðڽ��ϱ�?", "SKIP", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Close();
            }  
        }
    }
}
