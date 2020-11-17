using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_9a713032.Properties;

namespace WP_2020_01_HW02_9a713032
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(Resources.AS);
            list.Add(Resources.AH);
            list.Add(Resources.AD);
            list.Add(Resources.AC);
            list.Add(Resources._2S);
            list.Add(Resources._2H);
            list.Add(Resources._2D);
            list.Add(Resources._2C);
            list.Add(Resources._3S);
            list.Add(Resources._3H);
            list.Add(Resources._3D);
            list.Add(Resources._3C);
            list.Add(Resources._4S);
            list.Add(Resources._4H);
            list.Add(Resources._4D);
            list.Add(Resources._4C);
            list.Add(Resources._5S);
            list.Add(Resources._5H);
            list.Add(Resources._5D);
            list.Add(Resources._5C);
            list.Add(Resources._6S);
            list.Add(Resources._6H);
            list.Add(Resources._6D);
            list.Add(Resources._6C);
            list.Add(Resources._7S);
            list.Add(Resources._7H);
            list.Add(Resources._7D);
            list.Add(Resources._7C);
            list.Add(Resources._8S);
            list.Add(Resources._8H);
            list.Add(Resources._8D);
            list.Add(Resources._8C);
            list.Add(Resources._9S);
            list.Add(Resources._9H);
            list.Add(Resources._9D);
            list.Add(Resources._9C);
            list.Add(Resources._10S);
            list.Add(Resources._10H);
            list.Add(Resources._10D);
            list.Add(Resources._10C);
            list.Add(Resources.JS);
            list.Add(Resources.JH);
            list.Add(Resources.JD);
            list.Add(Resources.JC);
            list.Add(Resources.QS);
            list.Add(Resources.QH);
            list.Add(Resources.QD);
            list.Add(Resources.QC);
            list.Add(Resources.KS);
            list.Add(Resources.KH);
            list.Add(Resources.KD);
            list.Add(Resources.KC);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Poker p = new Poker();
            List<int> poker = GetPoker(52);

            string msg = "";
            for (int i = 0; i < 1; i++)
            {
                msg += $"{poker[i] + 1 } ";

            }
            rtb.Text += msg + "\n";
            picResult.Image = list[poker[0]];
        }

        private List<int> GetPoker(int count)
        {
            List<int> result = new List<int>();
            try
            {
                //新增N筆資料
                for (int i = 0; i < count; i++)
                {
                    result.Add(i);
                }

                //模擬發牌
                for (int i = count - 2; i > 0; i--)
                {
                    int lastIndex = i + 1;                    //方便閱讀
                    int randomIndex = (new Random()).Next(i); //抽牌

                    //交換
                    int temp = result[lastIndex];
                    result[lastIndex] = result[randomIndex] ;
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
    }
}
