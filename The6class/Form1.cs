using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Collections.Specialized;
//using static System.Math;

namespace The6class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<int> ACE(int a)
        {
           
            List<int> list = new List<int>();
            int num = 1;
            int m = 0;
            int k = 6;
            bool stp = false;
            while (num<a)
            {
                if (num < 3)
                {
                    num++;
                }
                else
                {
                    m = k;
                    if(stp==false)
                    {
                        num = m - 1;
                    }
                    else
                    {
                        num = m + 1; 
                        k = k + 6;
                    }
                    stp = stp ^ true;
                    if(num>a)
                    {
                        break;
                    }
                }
          
           
                bool flag = true;
                if (num < 6)
                {
                    if (num != 2 && num != 3 && num != 5)
                    {
                        flag = false;
                    }
                }
                else
                {
                    int sqrt = (int)Math.Sqrt(num)+1;
                    for (int i = 0; i <=sqrt; i += 6)
                    {
                        if (i == 0)
                        {
                            if (/*num % 2 == 0 || num % 3 == 0 || */num %5==0)
                            {
                                flag = false;
                                break;
                            }
                        }
                        else if (num % (i - 1) == 0 || num % (i + 1) == 0)
                        {
                            flag = false;
                            break;
                        }

                    }
                }

                if (flag)
                { list.Add(num); }
            }
           
            return list;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label3.Text = "0";
            int a = int.Parse(this.tetnum.Text);
            List<int> jg = ACE(a);
            this.label3.Text = jg.Count().ToString();
            int ace = 0;string zf = "";
            foreach(int num in jg)
            {

                zf += num + ",";
                ace++;
                if (ace % 10 == 0 || ace == jg.Count())
                {
                    listBox1.Items.Add(zf);
                    zf = "";
                }

            }
            
        }
    }
}
