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
        Tutorial_ImageDB[] ImageDB = new Tutorial_ImageDB[8]; // 이미지 수대로 임의수정

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
            //페이지 카운트가 1일때 버튼1번 비활성화
            if (Page_count == 1) { button1.Enabled = false; }
            pictureBox1.Image = Properties.Resources.TTI1;
            //페이지 제목
            label1.Text = "메인 화면을 알아보자!";
            //페이지 수
            label2.Text = Page_count + " / 8";
            //Form의 크기 조정 모드 설정에 따라 자동 크기조정
            this.AutoScaleMode = AutoScaleMode.Inherit;
        }

        public void Page_Image()
        {
            // 페이지에 따른 이미지 호출
            if (Page_count == 1)
            {
                pictureBox1.Image = Properties.Resources.TTI1;
                label1.Text = "메인 화면을 알아보자!"; // 카드 제목
                label2.Text = Page_count + " / 8"; // 페이지 수
            }
            if (Page_count == 2)
            {
                pictureBox1.Image = Properties.Resources.TTI2;
                label1.Text = "카드를 뽑아보자!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 3)
            {
                pictureBox1.Image = Properties.Resources.TTI3;
                label1.Text = "카드를 배치해보자!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 4)
            {
                pictureBox1.Image = Properties.Resources.TTI4;
                label1.Text = "마법 카드를 사용해보자!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 5)
            {
                pictureBox1.Image = Properties.Resources.TTI5;
                label1.Text = "카드를 버려보자!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 6)
            {
                pictureBox1.Image = Properties.Resources.TTI6;
                label1.Text = "전투에 대해 알아보자(1)!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 7)
            {
                pictureBox1.Image = Properties.Resources.TTI7;
                label1.Text = "전투에 대해 알아보자(2)!";
                label2.Text = Page_count + " / 8";
            }
            if (Page_count == 8)
            {
                pictureBox1.Image = Properties.Resources.TTI8;
                label1.Text = "게임의 최종 목표!";
                label2.Text = Page_count + " / 8";
            }


        }
        public void Button_Click()
        {
            //페이지 카운트가 1일때 버튼1 비활성화
            if (Page_count == 1) { button1.Enabled = false; }
            else { button1.Enabled = true; }
            //페이지 카운트가 8일때 버튼2 비활성화
            if (Page_count == 8) { button2.Enabled = false; }
            else { button2.Enabled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //버튼 클릭시 페이지카운트가 0과 8사이일시
            //페이지카운트 감소
            if (Page_count > 0 && Page_count <= 8) { Page_count--; }
            Button_Click();
            Page_Image(); 
            //예외처리문
            try
            {
                Page_count = 0;
            }
            catch
            {
                MessageBox.Show("오류 발생", "오류");
            }
            finally
            {
                Page_count = 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //버튼 클릭시 페이지카운트가 0과 8사이일시
            //페이지카운트 증가
            if (Page_count > 0 && Page_count <= 8) { Page_count++; }
            Button_Click();
            Page_Image();
            //예외처리문
            try
            {
                Page_count = 9;
            }
            catch
            {
                MessageBox.Show("오류 발생", "오류");
            }
            finally
            {
                Page_count = 8;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //스킵버튼 클릭시 나오는 메시지 박스
            if(MessageBox.Show("스킵 하시겠습니까?", "SKIP", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Close();
            }  
        }
        
    }
}
