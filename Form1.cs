using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public List<int> GetPoker(int count)
        {
            List<int> result = new List<int>();
            try
            {
                //新增N筆資料
                for (int i = 1; i < count; i++)
                {
                    result.Add(i);
                }

                //模擬發牌
                for (int i = count - 3; i > 0; i--)
                {
                    int lastIndex = i + 1;                    //方便閱讀
                    int randomIndex = (new Random()).Next(i); //抽牌

                    //交換
                    int temp = result[lastIndex];
                    result[lastIndex] = result[randomIndex];
                    result[randomIndex] = temp;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            return result;
        }
        List<int> poker;
        int index = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            poker=GetPoker(52);
            string msg = "";
            for (int i = 1; i < poker.Count; i++)
            {
                msg += $"您抽到了，{poker[i]} \n";
            }
            richTextBox2.AppendText(msg);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string msg = $"您抽到了，{poker[index]} \n";
            richTextBox1.AppendText(msg);
            index++;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
