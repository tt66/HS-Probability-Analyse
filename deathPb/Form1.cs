using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deathPb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int preDamage = 0;
        //这个文本框用于输入damage
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                preDamage = Convert.ToInt16(textBox17.Text);
            }
            catch
            {
                textBox17.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        //判断是否选取敌方英雄为目标
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox1.Visible = true;
            }
            else {
                textBox1.Visible = false;
            }
        }

        //判断是否选取敌方随从为目标
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button1.Visible = true;
                button2.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                button1.Visible = false ;
                button2.Visible = false ;
                textBox2.Visible = false ;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
        }

        //判断是否选取我方随从为目标
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button3.Visible = true;
                button4.Visible = true;
                textBox9.Visible = true;
            }
            else
            {
                button3.Visible = false;
                button4.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
            }
        }

        //判断是否选取我方英雄为目标
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox16.Visible = true;
            }
            else
            {
                textBox16.Visible = false;
            }
        }


        int emn= 1;//enemy minions number
        //为敌方增加一个随从
        private void button1_Click(object sender, EventArgs e)
        {
            if (emn < 7)
            {
                emn++;
            }

            if (emn >= 2)
            {
                textBox3.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
            }

            if (emn >= 3)
            {
                textBox4.Visible = true;
            }
            else
            {
                textBox4.Visible = false;
            }

            if (emn >= 4)
            {
                textBox5.Visible = true;
            }
            else
            {
                textBox5.Visible = false;
            }

            if (emn >= 5)
            {
                textBox6.Visible = true;
            }
            else
            {
                textBox6.Visible = false;
            }

            if (emn >= 6)
            {
                textBox7.Visible = true;
            }
            else
            {
                textBox7.Visible = false;
            }
            if (emn >= 7)
            {
                textBox8.Visible = true;
            }
            else
            {
                textBox8.Visible = false;
            }
        }
        //为敌方减少一个随从
        private void button2_Click(object sender, EventArgs e)
        {
            if (emn >= 2)
            {
                emn--;
            }

            if (emn >= 2)
            {
                textBox3.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
                textBox3.Text = "0";
                label3.Visible = false;
            }

            if (emn >= 3)
            {
                textBox4.Visible = true;
            }
            else
            {
                textBox4.Visible = false;
                textBox4.Text = "0";
                label4.Visible = false;
            }

            if (emn >= 4)
            {
                textBox5.Visible = true;
            }
            else
            {
                textBox5.Visible = false;
                textBox5.Text = "0";
                label5.Visible = false;
            }

            if (emn >= 5)
            {
                textBox6.Visible = true;
            }
            else
            {
                textBox6.Visible = false;
                textBox6.Text = "0";
                label6.Visible = false;
            }

            if (emn >= 6)
            {
                textBox7.Visible = true;
            }
            else
            {
                textBox7.Visible = false;
                textBox7.Text = "0";
                label7.Visible = false;
            }
            if (emn >= 7)
            {
                textBox8.Visible = true;
            }
            else
            {
                textBox8.Visible = false;
                textBox8.Text = "0";
                label8.Visible = false;
            }
        }

        int mmn = 1;//my minions number
        //为我方增加随从
        private void button3_Click(object sender, EventArgs e)
        {

            
                if (mmn < 7)
                {
                    mmn++;
                }

                if (mmn >= 2)
                {
                    textBox10.Visible = true;
                }
                else
                {
                    textBox10.Visible = false;
                }

                if (mmn >= 3)
                {
                    textBox11.Visible = true;
                }
                else
                {
                    textBox11.Visible = false;
                }

                if (mmn >= 4)
                {
                    textBox12.Visible = true;
                }
                else
                {
                    textBox12.Visible = false;
                }

                if (mmn >= 5)
                {
                    textBox13.Visible = true;
                }
                else
                {
                    textBox13.Visible = false;
                }

                if (mmn >= 6)
                {
                    textBox14.Visible = true;
                }
                else
                {
                    textBox14.Visible = false;
                }
                if (mmn >= 7)
                {
                    textBox15.Visible = true;
                }
                else
                {
                    textBox15.Visible = false;
                }
            
        }
        //为我方减少随从
        private void button4_Click(object sender, EventArgs e)
        {
            if (mmn >=2)
            {
                mmn--;
            }

            if (mmn >= 2)
            {
                textBox10.Visible = true;
            }
            else
            {
                textBox10.Visible = false;
                textBox10.Text = "0";
                label10.Visible = false;
            }

            if (mmn >= 3)
            {
                textBox11.Visible = true;
            }
            else
            {
                textBox11.Visible = false;
                textBox11.Text = "0";
                label11.Visible = false;
            }

            if (mmn >= 4)
            {
                textBox12.Visible = true;
            }
            else
            {
                textBox12.Visible = false;
                textBox12.Text = "0";
                label12.Visible = false;
            }

            if (mmn >= 5)
            {
                textBox13.Visible = true;
            }
            else
            {
                textBox13.Visible = false;
                textBox13.Text = "0";
                label13.Visible = false;
            }

            if (mmn >= 6)
            {
                textBox14.Visible = true;
            }
            else
            {
                textBox14.Visible = false;
                textBox14.Text = "0";
                label14.Visible = false;
            }
            if (mmn >= 7)
            {
                textBox15.Visible = true;
            }
            else
            {
                textBox15.Visible = false;
                textBox15.Text = "0";
                label15.Visible = false;
            }
        }



        //开始计算按钮
        private void button5_Click(object sender, EventArgs e)
        {
            //用于记录生命值
            

            //用于记录下面的for循环中目标的死亡次数
            int[] deathNumber = new int[16];
            for (int ed = 0; ed < 16; ed++)
            {
                deathNumber[ed] = 0;
            }

            for (int j = 0; j < 10000; j++) {

                int damage = preDamage;

                int[] ob = new int[16];

                //输入对象生命值
                if (textBox1.Visible)
                {
                    try
                    {
                        ob[0] = Convert.ToInt16(textBox1.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[0] = 30;
                }

                if (textBox2.Visible)
                {
                    try
                    {
                        ob[1] = Convert.ToInt16(textBox2.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[1] = 0;
                }

                if (textBox3.Visible)
                {
                    try
                    {
                        ob[2] = Convert.ToInt16(textBox3.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[2] = 0;
                }

                if (textBox4.Visible)
                {
                    try
                    {
                        ob[3] = Convert.ToInt16(textBox4.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[3] = 0;
                }

                if (textBox5.Visible)
                {
                    try
                    {
                        ob[4] = Convert.ToInt16(textBox5.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[4] = 0;
                }

                if (textBox6.Visible)
                {
                    try
                    {
                        ob[5] = Convert.ToInt16(textBox6.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[5] = 0;
                }

                if (textBox7.Visible)
                {
                    try
                    {
                        ob[6] = Convert.ToInt16(textBox7.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[6] = 0;
                }

                if (textBox8.Visible)
                {
                    try
                    {
                        ob[7] = Convert.ToInt16(textBox8.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[7] = 0;
                }

                if (textBox9.Visible)
                {
                    try
                    {
                        ob[8] = Convert.ToInt16(textBox9.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[8] = 0;
                }

                if (textBox10.Visible)
                {
                    try
                    {
                        ob[9] = Convert.ToInt16(textBox10.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[9] = 0;
                }

                if (textBox11.Visible)
                {
                    try
                    {
                        ob[10] = Convert.ToInt16(textBox11.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[10] = 0;
                }

                if (textBox12.Visible)
                {
                    try
                    {
                        ob[11] = Convert.ToInt16(textBox12.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[11] = 0;
                }

                if (textBox13.Visible)
                {
                    try
                    {
                        ob[12] = Convert.ToInt16(textBox13.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[12] = 0;
                }

                if (textBox14.Visible)
                {
                    try
                    {
                        ob[13] = Convert.ToInt16(textBox14.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[13] = 0;
                }

                if (textBox15.Visible)
                {
                    try
                    {
                        ob[14] = Convert.ToInt16(textBox15.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[14] = 0;
                }

                if (textBox16.Visible)
                {
                    try
                    {
                        ob[15] = Convert.ToInt16(textBox16.Text);
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的数");
                    }
                }
                else
                {
                    ob[15] = 30;
                }

                while (ob[0] >= 1 && ob[15] >= 1 && damage >= 1)
                {
                    Random ran = new Random(Guid.NewGuid().GetHashCode());
                    int result = ran.Next(16);

                    if (result == 0 && textBox1.Visible == true && ob[0] >= 1)
                    {
                        damage--;
                        ob[0]--;
                        if (ob[0] == 0)
                        {
                            damage = 0;

                        }
                    }
                    for (int qw = 1; qw <= 14; qw++)
                    {
                        if (result == qw && ob[qw] >= 1)
                        {
                            damage--;
                            ob[qw]--;
                        }
                    }

                    if (result == 15 && textBox15.Visible == true && ob[15] >= 1)
                    {
                        damage--;
                        ob[15]--;
                        if (ob[15] == 0)
                        {
                            damage = 0;

                        }
                    }
                    
                }
                for (int qs = 0; qs < 16; qs++)
                {
                    if (ob[qs] == 0)
                    {

                        deathNumber[qs]++;
                    }
                }

            }
            //把死亡次数转化为死亡概率
            double[] deathRate = new double[16];
            for (int ed = 0; ed < 16; ed++)
            {
                deathRate[ed] = deathNumber [ed]*0.0001;
            }
            if (textBox1.Visible)
            {
                label1.Visible = true;
                label1.Text = Convert.ToString(deathRate[0]);
            }
            if (textBox2.Visible)
            {
                label2.Visible = true;
                label2.Text = Convert.ToString(deathRate[1]);
            }
            if (textBox3.Visible)
            {
                label3.Visible = true;
                label3.Text = Convert.ToString(deathRate[2]);
            }
            if (textBox4.Visible)
            {
                label4.Visible = true;
                label4.Text = Convert.ToString(deathRate[3]);
            }
            if (textBox5.Visible)
            {
                label5.Visible = true;
                label5.Text = Convert.ToString(deathRate[4]);
            }
            if (textBox6.Visible)
            {
                label6.Visible = true;
                label6.Text = Convert.ToString(deathRate[5]);
            }
            if (textBox7.Visible)
            {
                label7.Visible = true;
                label7.Text = Convert.ToString(deathRate[6]);
            }
            if (textBox8.Visible)
            {
                label8.Visible = true;
                label8.Text = Convert.ToString(deathRate[7]);
            }
            if (textBox9.Visible)
            {
                label9.Visible = true;
                label9.Text = Convert.ToString(deathRate[8]);
            }
            if (textBox10.Visible)
            {
                label10.Visible = true;
                label10.Text = Convert.ToString(deathRate[9]);
            }
            if (textBox11.Visible)
            {
                label11.Visible = true;
                label11.Text = Convert.ToString(deathRate[10]);
            }
            if (textBox12.Visible)
            {
                label12.Visible = true;
                label12.Text = Convert.ToString(deathRate[11]);
            }
            if (textBox13.Visible)
            {
                label13.Visible = true;
                label13.Text = Convert.ToString(deathRate[12]);
            }
            if (textBox14.Visible)
            {
                label14.Visible = true;
                label14.Text = Convert.ToString(deathRate[13]);
            }
            if (textBox15.Visible)
            {
                label15.Visible = true;
                label15.Text = Convert.ToString(deathRate[14]);
            }
            if (textBox1.Visible)
            {
                label16.Visible = true;
                label16.Text = Convert.ToString(deathRate[15]);
            }


        }

        //下面的事件用于检查是否输入了整数
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox1.Text);
            }
            catch
            {
                textBox1.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox2.Text);
            }
            catch
            {
                textBox2.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox3.Text);
            }
            catch
            {
                textBox3.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox4.Text);
            }
            catch
            {
                textBox4.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox6.Text);
            }
            catch
            {
                textBox6.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox6.Text);
            }
            catch
            {
                textBox6.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox7.Text);
            }
            catch
            {
                textBox7.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox8.Text);
            }
            catch
            {
                textBox8.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox9.Text);
            }
            catch
            {
                textBox9.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox10.Text);
            }
            catch
            {
                textBox10.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox11.Text);
            }
            catch
            {
                textBox11.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox12.Text);
            }
            catch
            {
                textBox12.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox13.Text);
            }
            catch
            {
                textBox13.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox14.Text);
            }
            catch
            {
                textBox14.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox15.Text);
            }
            catch
            {
                textBox15.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox16.Text);
            }
            catch
            {
                textBox16.Text = "0";
                MessageBox.Show("请输入正确的数字");
            }
        }
    }
}
