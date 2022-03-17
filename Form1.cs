using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8_3
{
    public partial class Form1 : Form
    {

        string name;
        string gender;
        string header;
        string education;
        string showProfessional = "";
        string professional_1 = "";
        string professional_2 = "";
        string professional_3 = "";
        string professional_4 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 8;
            textBox1.Text = "";
            radioButton1.Checked = true;
            pictureBox1.Image = Gender.Images[0];
            pictureBox2.Image = Gender.Images[1];
            pictureBox3.Image = ImgGB.Images[1];
            pictureBox4.Image = ImgGB.Images[1];
            pictureBox5.Image = ImgGB.Images[1];
            pictureBox6.Image = ImgGB.Images[1];
            comboBox1.Items.Add("高中職");
            comboBox1.Items.Add("大學");
            comboBox1.SelectedIndex = 0;
            label5.Text = "請填寫資料後按 確定 鈕";
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text != "")
            {
                name = textBox1.Text;
                education = comboBox1.Text;
                showProfessional = professional_1 + professional_2 + professional_3 + professional_4;
                showProfessional = showProfessional.Substring(0, showProfessional.Length - 2);
                if (showProfessional != "")
                {
                    if (gender == "男")
                    {
                        header = name[0].ToString() + "先生";
                        label5.Text = header + "你的資料是：\n\n" + "姓名=" + name + "\n" + "性別=" + gender + "\n" + "學歷=" + education + "\n" + "專長=" + showProfessional;
                    }
                    else
                    {
                        header = name[0].ToString() + "小姐";
                        label5.Text = header + "妳的資料是：\n\n" + "姓名=" + name + "\n" + "性別=" + gender + "\n" + "學歷=" + education + "\n" + "專長=" + showProfessional;
                    }
                }
                else
                {
                    if (gender == "男")
                    {
                        header = name[0].ToString() + "先生";
                        label5.Text = header + "你的資料是：\n\n" + "姓名=" + name + "\n" + "性別=" + gender + "\n" + "學歷=" + education;
                    }
                    else
                    {
                        header = name[0].ToString() + "小姐";
                        label5.Text = header + "你的資料是：\n\n" + "姓名=" + name + "\n" + "性別=" + gender + "\n" + "學歷=" + education;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("請先輸入姓名", "注意", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            radioButton1.Checked = true;
            comboBox1.SelectedIndex = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            label5.Text = "請填寫資料後按 確定 鈕";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = Gender.Images[0];
                gender = "男";
            }
            else
            {
                pictureBox1.Image = Gender.Images[1];
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox2.Image = Gender.Images[2];
                gender = "女";
            }
            else
            {
                pictureBox2.Image = Gender.Images[3];
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox3.Image = ImgGB.Images[0];
                professional_1 = "C# ,";
            }
            else
            {
                pictureBox3.Image = ImgGB.Images[1];
                professional_1 = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                pictureBox4.Image = ImgGB.Images[0];
                professional_2 = "Java ,";
            }
            else
            {
                pictureBox4.Image = ImgGB.Images[1];
                professional_2 = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                pictureBox5.Image = ImgGB.Images[0];
                professional_3 = "Basic ,";
            }
            else
            {
                pictureBox5.Image = ImgGB.Images[1];
                professional_3 = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                pictureBox6.Image = ImgGB.Images[0];
                professional_4 = "PHP ,";
            }
            else
            {
                pictureBox6.Image = ImgGB.Images[1];
                professional_4 = "";
            }
        }
    }
}
