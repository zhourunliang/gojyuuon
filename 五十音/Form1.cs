using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 五十音
{
    public partial class 五十音 : Form
    {
        public 五十音()
        {
            InitializeComponent();
            textBox1.Text = "あ";
            textBox3.Text = "输入下面假名的罗马音，按回车";
            radioButton1.Checked=true;
            radioButton3.Checked = true;
        }
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        string[] A = new string[50];
        string[] B = { "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "や", "ゆ", "よ", "ら", "り", "る", "れ", "ろ", "わ", "ゐ", "ゑ", "を", "ん" };
        string[] C = { "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ya", "yu", "yo", "ra", "ri", "ru", "re", "ro", "wa", "wi", "we", "wo", "n","ok" };
        string[] D = { "ア", "イ", "ウ", "エ", "オ", "カ", "キ", "ク", "ケ", "コ", "サ", "シ", "ス", "セ", "ソ", "タ", "チ", "ツ", "テ", "ト", "ナ", "ニ", "ヌ", "ネ", "ノ", "ハ", "ヒ", "フ", "ヘ", "ホ", "マ", "ミ", "ム", "メ", "モ", "ヤ", "ユ", "ヨ", "ラ", "リ", "ル", "レ", "ロ", "ワ", "ヰ", "ヱ", "ヲ", "ン"};
        int i = 0;
        int n;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (radioButton3.Checked==true)
                {
                    A[i] = textBox2.Text;
                    if (A[i] == C[i])
                    {
                        textBox3.Text = "正确";
                        if (radioButton1.Checked == true)
                        {
                            i++;
                        }
                        else if (radioButton2.Checked == true)
                        {
                            Random rd = new Random();
                            i = rd.Next(0, 48);
                        }
                        textBox1.Text = B[i];
                        textBox2.Text = "";

                    }
                    else if (C[i] == "ok")
                    {
                        MessageBox.Show(this, "太棒了，你已经完成测试", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        textBox3.Text = "你答的是" + i + "题,正确答案为" + C[i];
                    }
                }
                else if (radioButton4.Checked==true)
                {
                    A[i] = textBox2.Text;
                    if (A[i] == C[i])
                    {
                        textBox3.Text = "正确";
                        if (radioButton1.Checked == true)
                        {
                            i++;
                        }
                        else if (radioButton2.Checked == true)
                        {
                            Random rd = new Random();
                            i = rd.Next(0, 48);
                        }
                        textBox1.Text = D[i];
                        textBox2.Text = "";

                    }
                    else if (C[i] == "ok")
                    {
                        MessageBox.Show(this, "太棒了，你已经完成测试", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        textBox3.Text = "你答的是" + i + "题,正确答案为" + C[i];
                    }
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show(this, ":)", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 0;
            textBox1.Text = "あ";
            textBox3.Text = "输入下面假名的罗马音，按回车";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             RadioButton rb=(RadioButton) sender;
            if (rb.Checked)
            {
                n = i;
            }

         }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                textBox1.Text = D[i];
            }
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                textBox1.Text = B[i];
            }
        }

        
    }
}
