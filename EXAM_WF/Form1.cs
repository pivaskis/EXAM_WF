using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM_WF
{
    public partial class Form1 : Form
    {
        Bitmap[] pic = new Bitmap[16];//

        int nPic=0;//колиество открытых картинок

        PictureBox Name1, Name2;

        
        
        
       


        String imgTeg1, imgTeg2;
       // int imgTeg1, imgTeg2;
        
        public Form1()
        {
            InitializeComponent();
            //pictureBox1.Image = new Bitmap("mn1.bmp");
            pic[0] = new Bitmap("mn1.bmp");
            pic[1] = new Bitmap("mn2.bmp");
            pic[2] = new Bitmap("mn3.bmp");
            pic[3] = new Bitmap("mn4.bmp");
            pic[4] = new Bitmap("mn5.bmp");
            pic[5] = new Bitmap("mn6.bmp");
            pic[6] = new Bitmap("mn7.bmp");
            pic[7] = new Bitmap("mn8.bmp");
            pic[8] = new Bitmap("mn1.bmp");
            pic[9] = new Bitmap("mn2.bmp");
            pic[10] = new Bitmap("mn3.bmp");
            pic[11] = new Bitmap("mn4.bmp");
            pic[12] = new Bitmap("mn5.bmp");
            pic[13] = new Bitmap("mn6.bmp");
            pic[14] = new Bitmap("mn7.bmp");
            pic[15] = new Bitmap("mn8.bmp");
            pic[0].Tag = 1;
            pic[1].Tag = 2;
            pic[2].Tag = 3;
            pic[3].Tag = 4;
            pic[4].Tag = 5;
            pic[5].Tag = 6;
            pic[6].Tag = 7;
            pic[7].Tag = 8;
            pic[8].Tag = 1;
            pic[9].Tag = 2;
            pic[10].Tag = 3;
            pic[11].Tag = 4;
            pic[12].Tag = 5;
            pic[13].Tag = 6;
            pic[14].Tag = 7;
            pic[15].Tag = 8;


            //var r = new Random();
            //for (int i = pic.Length - 1; i > 0; i--)
            //{
            //    int j = r.Next(i);
            //    var t = pic[i];
            //    pic[i] = pic[j];
            //    pic[j] = t;
            //}

            //pictureBox1.Image = pic[0];
            //pictureBox2.Image = pic[1];
            //pictureBox3.Image = pic[2];
            //pictureBox4.Image = pic[3];
            //pictureBox5.Image = pic[4];
            //pictureBox6.Image = pic[5];
            //pictureBox7.Image = pic[6];
            //pictureBox8.Image = pic[7];
            //pictureBox9.Image = pic[8];
            //pictureBox10.Image = pic[9];
            //pictureBox11.Image = pic[10];
            //pictureBox12.Image = pic[11];
            //pictureBox13.Image = pic[12];
            //pictureBox14.Image = pic[13];
            //pictureBox15.Image = pic[14];
            //pictureBox16.Image = pic[15];
        }
        private void newGame()
        {
          

        }

        private void toolStripButton1_Click(object sender, EventArgs e)//новая игра
        {
            ////pictureBox1.
            //pic[0] = new Bitmap("mn1.bmp");
            //pic[1] = new Bitmap("mn2.bmp");
            //pic[2] = new Bitmap("mn3.bmp");
            //pic[3] = new Bitmap("mn4.bmp");
            //pic[4] = new Bitmap("mn5.bmp");
            //pic[5] = new Bitmap("mn6.bmp");
            //pic[6] = new Bitmap("mn7.bmp");
            //pic[7] = new Bitmap("mn8.bmp");
            //pic[8] = new Bitmap("mn1.bmp");
            //pic[9] = new Bitmap("mn2.bmp");
            //pic[10] = new Bitmap("mn3.bmp");
            //pic[11] = new Bitmap("mn4.bmp");
            //pic[12] = new Bitmap("mn5.bmp");
            //pic[13] = new Bitmap("mn6.bmp");
            //pic[14] = new Bitmap("mn7.bmp");
            //pic[15] = new Bitmap("mn8.bmp");

            //var r = new Random();
            //for (int i = pic.Length - 1; i > 0; i--)
            //{
            //    int j = r.Next(i);
            //    var t = pic[i];
            //    pic[i] = pic[j];
            //    pic[j] = t;
            //}
            //pictureBox1.Image = pic[0];
            //pictureBox2.Image = pic[1];
            //pictureBox3.Image = pic[2];
            //pictureBox4.Image = pic[3];
            //pictureBox5.Image = pic[4];
            //pictureBox6.Image = pic[5];
            //pictureBox7.Image = pic[6];
            //pictureBox8.Image = pic[7];
            //pictureBox9.Image = pic[8];
            //pictureBox10.Image = pic[9];
            //pictureBox11.Image = pic[10];
            //pictureBox12.Image = pic[11];
            //pictureBox13.Image = pic[12];
            //pictureBox14.Image = pic[13];
            //pictureBox15.Image = pic[14];
            //pictureBox16.Image = pic[15];
        }
        
        private void ClickPic( PictureBox pb)
        {
            if (nPic == 0)
            {
                // path1=pb;
                Name1 = pb;
                imgTeg1 = pb.Image.Tag.ToString(); 
               // MessageBox.Show(pb.Image.Tag.ToString());
               
                nPic++;
            }
            else if (nPic == 1)
            {
                Name2 = pb;
                //path2 = pb.ImageLocation.ToString();
                imgTeg2 = pb.Image.Tag.ToString();
                nPic++;
            }
            else if (nPic == 2)
            {
                if (imgTeg1 != imgTeg2)
                {
                    Name1.Image = null;
                    Name2.Image = null;
                }

                imgTeg1 = pb.Image.Tag.ToString();
                nPic = 1;
                Name1 = pb;
                
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = pic[0];
                ClickPic(pictureBox1);               
            }           
        }        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                
                pictureBox2.Image = pic[8];
                ClickPic(pictureBox2);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == null)
            {
                pictureBox3.Image = pic[2];
                ClickPic(pictureBox3);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pic[3];
            ClickPic(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = pic[4];
            ClickPic(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = pic[5];
            ClickPic(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = pic[6];
            ClickPic(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pic[7];
            ClickPic(pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = pic[8];
            ClickPic(pictureBox9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = pic[9];
            ClickPic(pictureBox10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = pic[10];
            ClickPic(pictureBox11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = pic[11];
            ClickPic(pictureBox12);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = pic[12];
            ClickPic(pictureBox13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = pic[13];
            ClickPic(pictureBox14);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = pic[14];
            ClickPic(pictureBox15);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = pic[15];
            ClickPic(pictureBox16);
        }
    }
}
