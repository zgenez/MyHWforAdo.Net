
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHomeWork : Form
    {
        public FrmHomeWork()
        {
            InitializeComponent();
        }

        //輸入數字之奇偶
        private void btn_O_E_Click(object sender, EventArgs e)
        {
            
            lblResult.Text = "";
            int number = 0;
            string num = txt_Num.Text;
            bool b = int.TryParse(num, out number);

            if (b)
            {
                int i = number % 2;
                if (i == 0)
                {
                    lblResult.Text = " 數字: " + number + ",為偶數";
                }
                else
                {
                    lblResult.Text = " 數字: " + number + ",為奇數";
                }
            }

        }

        private void btn_100_66_77_Mm_Click(object sender, EventArgs e)
        {
            
            //int b = 66;
            //int c = 77;

            int[] array = new int[] { 100,66,77};
            int Max,min;
            array.Max(); array.Min();

            Max = array.Max();
            min = array.Min();

            lblResult.Text = " 最大數字為: " + Max + "。"
                            + "\n 最小數字為:" + min + "。";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int[] nums = { 33, 4, 5, 11, 222, 34 };
            lblResult.Text = "";
            int O = 0, E = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int a = nums[i] % 2;
                if (a == 0)
                {
                    O++;
                }
                else
                {
                    E++;
                }
            }
            lblResult.Text += "int[] nums = { 33, 4, 5, 11, 222, 34 }的陣列中,"+
                              "\n奇數有 " + O + "個\n偶數有 " +E + "個";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int[] scores = { 2, 3, 46, 33, 22, 100,150, 33,55};

            //int max =  scores.Max();
            //MessageBox.Show("Max = " + max);

            //Array.Sort(scores);
            //MessageBox.Show("Max =" + scores[scores.Length - 1]);

            ////================================

            //Point[] points = new Point[3];
            //points[0].X = 3;
            //points[0].Y = 4;
            ////System.InvalidOperationException: '無法比較陣列中的兩個元素。'

            //Array.Sort(points);

            ////=================================



        }

        int MyMinScore(int[] nums)
        {
            return 10;
        }

        private void btn_99乘法表_Click(object sender, EventArgs e)
        {
            int sum;
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i == 2 && j == 1)
                    {
                        sum = i * j;
                        lblResult.Text = $"九九乘法表\n {i}x{j}={i * j}|";
                    }
                    else
                    {
                        sum = i * j;
                        lblResult.Text += $" {i}x{j}={i * j}| ";
                    }
                }
                lblResult.Text += "\n";
            }
        }


        private void button15_Click(object sender, EventArgs e)
        {
            
            lblResult.Text = "二進位尚未搞懂...";
        }

        private void button14_Click(object sender, EventArgs e)
        {
 
            string[] names = {  "Watame", "Calliope", "Botan", "Coco", "Mumie", "John Cena", "The Rock", "維麗嘉‧杜斯妥也夫斯基 AkA燒餅" };
            int LongerN = 0;
            string 最長名字 = "";
            for (int i = 0; i < names.Length; i++)

            {
                if (names[i].Length > LongerN)
                {
                    LongerN = names[i].Length;
                    最長名字 = names[i];
                }
            }

            lblResult.Text = 最長名字;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string[] names = { "Watame", "Calliope", "Botan", "Coco", "Mumie", "John Cena", "The Rock", "維麗嘉‧杜斯妥也夫斯基 AkA燒餅" };
            int Cc = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Contains('C') || names[i].Contains('c')) 
                {
                    Cc++;
                }
            }
            lblResult.Text = "names的陣列中," +
                             "\n{Watame,Calliope,Botan,Coco,Mumie,John Cena,The Rock,維麗嘉‧杜斯妥也夫斯基 AkA燒餅}" +
                             "\n含有 C 及 c 的名字有 「 " + Cc +"」 個 ";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Random Num = new Random();
            int[] 樂透號碼 = new int[6];
            lblResult.Text = " 樂透號碼 : \n ";
            for (int i = 0; i < 6; i++)
            {
                樂透號碼[i] = Num.Next(1, 53);
                for (int j = 0; j < i; j++)
                {
                    if (樂透號碼[i] == 樂透號碼[j])
                    {
                        樂透號碼[i] = Num.Next(1, 53);
                    }
                }

                
                lblResult.Text += $"{樂透號碼[i]}.";

            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblResult.Text = "結果";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
